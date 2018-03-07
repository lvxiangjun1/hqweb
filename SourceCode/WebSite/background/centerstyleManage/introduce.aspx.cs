using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Web.BusinessEntity;
using Web.Common;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;
using Web.News;
public partial class Background_centerstyleManage_introduce : BasePage
{
    Base b = new Base();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "57"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            string strSql = "SELECT * FROM T_WEBINFO WHERE ID = 1";
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                txtTITLE.Text = DT.Rows[0]["TITLE"].ToString();
                txtContent.Value = DT.Rows[0]["CONTENT"].ToString();
            }
            else
            {
                strSql = "INSERT INTO T_WEBINFO (ID,TITLE,CONTENT) VALUES (1,'','')";
                PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        string strcnn = ConfigurationManager.AppSettings["strcnn"];
        OracleConnection mycon = new OracleConnection(strcnn);
        mycon.Open();
        string strSql = "UPDATE T_WEBINFO SET TITLE = '" + Names.GetSingQuote(txtTITLE.Text.Trim()) + "',CONTENT = :content WHERE ID = 1";
        OracleCommand mycmd = new OracleCommand(strSql);
        mycmd.Connection = mycon;
        OracleParameter pa1 = new OracleParameter(":content", OracleDbType.Long);
        pa1.Value = Names.GetSingQuote(txtContent.Value);
        mycmd.Parameters.Add(pa1);
        mycmd.ExecuteNonQuery();
        mycon.Close();

    }

}