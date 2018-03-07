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

        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if("".Equals(txtName.Text.Trim()))
        {
            MessageBox("问卷名称不能为空！");
            return;
        }
        string strSql = "INSERT INTO T_SURVEY (ID,TITLE,USERNAME,INSERTTIME,ISPUBLISH) VALUES (SEQ_T_SURVEY.NEXTVAL,'" + Names.GetSingQuote(txtName.Text.Trim())
            + "','" + BaseUserName + "',SYSDATE," + dropIsPublish.SelectedValue + ")";
        PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
        Response.Redirect("surveyList.aspx");
    }
}
