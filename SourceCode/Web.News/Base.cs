using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.BusinessEntity;
using PersistenceLayer;
using System.Data;
using Oracle.DataAccess;
using Web.Common;
using Oracle.DataAccess.Client;
namespace Web.News
{

    public class Base
    {
        string strcnn = System.Configuration.ConfigurationSettings.AppSettings["strcnn"];

        public bool AddNews(T_NEWSBASEEntity t, List<string> lNAME, List<string> lVALUE)
        {
            try
            {
                string newsId = Sequence.GetNextValue("SEQ_T_NEWSBASE").ToString();
                OracleConnection mycon = new OracleConnection(strcnn);
                mycon.Open();
                string strUpdate = "insert into T_NEWSBASE(ID,NODEID,TITLE,TITLEFONT,TITLECOLOR,TITLESIZE,SUBTITLE,SUBTITLEFONT,SUBTITLECOLOR,SUBTITLESIZE,COPYRIGHT,AUTHOR,CONTENT,DEFAULTPICURL,USERNAME,INSERTTIME,STATUS,ISSPECIAL,PUBLISHTIME,HITS) values(" + newsId + "," + t.NODEID + ",'" + t.TITLE + "','" + t.TITLEFONT + "','" + t.TITLECOLOR + "'," + t.TITLESIZE + ",'" + t.SUBTITLE + "','" + t.SUBTITLEFONT + "','" + t.SUBTITLECOLOR + "'," + t.SUBTITLESIZE + ",'" + t.COPYRIGHT + "','" + t.AUTHOR + "',:content,'" + t.DEFAULTPICURL + "','" + t.USERNAME + "',sysdate,'" + t.STATUS + "','" + t.ISSPECIAL + "',to_date('" + t.PUBLISHTIME + "','yyyy-MM-dd HH24:MI:SS'),0)";
                OracleCommand mycmd = new OracleCommand(strUpdate);
                mycmd.Connection = mycon;
                OracleParameter pa1 = new OracleParameter(":content", OracleDbType.Long);
                pa1.Value = t.CONTENT;
                mycmd.Parameters.Add(pa1);
                mycmd.ExecuteNonQuery();
                mycon.Close();


                Transaction T = new Transaction();

                string sql = "";
                for (int i = 0; i < lNAME.Count; i++)
                {
                    sql = "insert into T_NEWSPIC(ID,NEWSID,PICINFO,PICURL,STATUS) values (" + Sequence.GetNextValue("SEQ_T_NEWSPIC") + "," + newsId + ",'" + lNAME[i] + "','" + lVALUE[i] + "',1)";
                    T.AddSqlString(sql, Names.DBName);
                }
                T.Process();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditNews(T_NEWSBASEEntity t, List<string> lNAME, List<string> lVALUE)
        {
            try
            {

                OracleConnection mycon = new OracleConnection(strcnn);
                mycon.Open();
                string strUpdate = "update T_NEWSBASE set TITLE='" + t.TITLE + "',TITLEFONT='" + t.TITLEFONT + "',TITLECOLOR='" + t.TITLECOLOR + "',TITLESIZE=" + t.TITLESIZE + ",SUBTITLE='" + t.SUBTITLE + "',SUBTITLEFONT='" + t.SUBTITLEFONT + "',SUBTITLECOLOR='" + t.SUBTITLECOLOR + "',SUBTITLESIZE=" + t.SUBTITLESIZE + ",COPYRIGHT='" + t.COPYRIGHT + "',AUTHOR='" + t.AUTHOR + "',CONTENT=:content,DEFAULTPICURL='" + t.DEFAULTPICURL + "',UPDATEUSERNAME='" + t.UPDATEUSERNAME + "',UPDATETIME=sysdate,PUBLISHTIME=to_date('" + t.PUBLISHTIME + "','yyyy-MM-dd HH24:MI:SS'),ISSPECIAL='" + t.ISSPECIAL + "' where id=" + t.ID;
                OracleCommand mycmd = new OracleCommand(strUpdate);
                mycmd.Connection = mycon;
                OracleParameter pa1 = new OracleParameter(":content", OracleDbType.Long);
                pa1.Value = t.CONTENT;
                mycmd.Parameters.Add(pa1);
                mycmd.ExecuteNonQuery();
                mycon.Close();

                Transaction T = new Transaction();
                string sql = "";
                for (int i = 0; i < lNAME.Count; i++)
                {

                    if (Query.ProcessSql("select count(*) from T_NEWSPIC where PICURL='" + lVALUE[i] + "' and NEWSID=" + t.ID, Names.DBName).Rows[0][0].ToString() == "0")
                    {
                        sql = "insert into T_NEWSPIC(ID,NEWSID,PICINFO,PICURL,STATUS) values (" + Sequence.GetNextValue("SEQ_T_NEWSPIC") + "," + t.ID + ",'" + lNAME[i] + "','" + lVALUE[i] + "',1)";
                        T.AddSqlString(sql, Names.DBName);
                    }
                }
                T.Process();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DelNews(string id)
        {
            try
            {
                string sql = "select STATUS from T_NEWSBASE  WHERE ID = " + id + "";
                DataTable DT = Query.ProcessSql(sql,Names.DBName);
                if (DT.Rows[0][0].ToString() == "-1")
                {
                    sql = "delete  T_NEWSBASE  WHERE ID = " + id + "";
                    Query.ProcessSql(sql, Names.DBName);
                }
                else
                {
                     sql = "update  T_NEWSBASE  set STATUS=-1 WHERE ID = " + id + "";
                    Query.ProcessSql(sql, Names.DBName);
                }
                return true;
            }
            catch { return false; }
        }
        //判断是否拥有权限
        public bool IsNewsQX(string username, string nodeid)
        {
            try
            {
                string sql = " SELECT count(*) FROM T_NEWSNODE T1,T_WEBMANAGEROLE T2 WHERE T1.ID = T2.NODEID AND T2.USERNAME = '" + username + "' and  T2.NODEID =" + nodeid + " AND t1. STATUS = 0";
                DataTable dt = Query.ProcessSql(sql, Names.DBName);
                if (dt.Rows[0][0].ToString() == "0")
                    return false;
                else
                    return true;
            }
            catch
            {
                return false; 
            }
        }
    }
}
