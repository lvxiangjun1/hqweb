using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using PersistenceLayer;
using Web.Common;
using Web.BaseWeb;

/// <summary>
///BaseAD 的摘要说明
/// </summary>
public class BaseAD : System.Web.UI.Page
{
	public BaseAD()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
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
    //获取飘窗调用列表
    public static string getADList(){
        string sql = "SELECT * FROM T_ADVERTISMENT WHERE ISDELETE='N'";
        DataTable DT = Query.ProcessSql(sql, Names.DBName);
        string str= "";
        for (int i = 0; i < DT.Rows.Count; i++)
        {

            str += "<script  type=\"text/javascript\" src='" + BaseClass.VirtualPath1() + "/UploadFiles/ADJS/ad_" + DT.Rows[i]["ID"] + ".js'></script>";

        }
        return str;
    }
    //根据ID删除飘窗
    public static bool DelAD(string id,string username)
    {
        try
        {
            string sql = "update  T_ADVERTISMENT  set ISDELETE='Y',DELETETIME= sysdate,DELETENAME='" + username + "' WHERE ID = " + id + "";
            Query.ProcessSql(sql, Names.DBName);
            return true;
        }
        catch { return false; }
    }
}