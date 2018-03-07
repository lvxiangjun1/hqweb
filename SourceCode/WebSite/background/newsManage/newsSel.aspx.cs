using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Web.BusinessEntity;
using Web.News;
using Web.Common;
using System.Data;
public partial class Background_NewsManage_newsSel : System.Web.UI.Page
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hidId.Value = Request.QueryString["id"];
            if (!UtFunction.IsNum(hidId.Value))
            {
                Response.Redirect("../Error.aspx");
            }
            InitContent();
        }
    }
    private void InitContent()
    {
        try
        {
            string sql = "select * from T_NEWSBASE where id=" + hidId.Value;
            DataTable dt = PersistenceLayer.Query.ProcessSql(sql, Names.DBName);
            if (dt.Rows.Count > 0)
            {
                lbTITLE.Text = "<span style='font-family:" + dt.Rows[0]["TITLEFONT"].ToString() + ";font-size:" + dt.Rows[0]["TITLESIZE"].ToString() + "px;color:" + dt.Rows[0]["TITLECOLOR"].ToString() + ";'>" + dt.Rows[0]["TITLE"].ToString() + "</span>";
                lbSUBTITLE.Text = "<span style='font-family:" + dt.Rows[0]["SUBTITLEFONT"].ToString() + ";font-size:" + dt.Rows[0]["SUBTITLESIZE"].ToString() + "px;color:" + dt.Rows[0]["SUBTITLECOLOR"].ToString() + ";'>" + dt.Rows[0]["SUBTITLE"].ToString() + "</span>";
                lbCONTENT.Text = dt.Rows[0]["CONTENT"].ToString();
                txtCOPYRIGHT.Text = dt.Rows[0]["COPYRIGHT"].ToString();
                txtAUTHOR.Text = dt.Rows[0]["AUTHOR"].ToString();
                lbPUBLISHTIME.Text = Convert.ToDateTime(dt.Rows[0]["PUBLISHTIME"]).ToShortDateString();
                lbHITS.Text = dt.Rows[0]["HITS"].ToString();
            }
        }
        catch { }
    }

}