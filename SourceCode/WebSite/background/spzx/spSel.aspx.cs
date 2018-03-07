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
public partial class Background_spzx_spSel : System.Web.UI.Page
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hidId.Value = Request.QueryString["id"];

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
                lbTITLE.Text = dt.Rows[0]["TITLE"].ToString();
             
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