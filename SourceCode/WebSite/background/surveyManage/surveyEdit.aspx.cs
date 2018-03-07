using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Web.Common;
//

public partial class background_surveyManage_surveyCreate : BasePage
{


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SurveyInfoBind();
        }
    }

    private void SurveyInfoBind()
    {
        string ID = Request.QueryString["ID"];
        int i = 0;
        if (int.TryParse(ID, out i))
        {
            txtID.Text = ID;
            string strSql = "SELECT * FROM T_SURVEY WHERE ID = " + txtID.Text;
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                txtName.Text = DT.Rows[0]["TITLE"].ToString();
                dropIsPublish.SelectedValue = DT.Rows[0]["ISPUBLISH"].ToString();
            }
        }
        else
        {
            Response.Redirect("../main.aspx");
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if ("".Equals(txtName.Text.Trim()))
        {
            MessageBox("问卷名称不能为空！");
            return;
        }
        string strSql = "UPDATE T_SURVEY SET TITLE = '" + Names.GetSingQuote(txtName.Text.Trim())
            + "',ISPUBLISH = " + dropIsPublish.SelectedValue + " WHERE ID = " + txtID.Text.Trim();
        PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
        Response.Redirect("surveyList.aspx");
    }
}
