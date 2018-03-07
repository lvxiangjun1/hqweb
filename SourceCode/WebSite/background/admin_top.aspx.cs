using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

public partial class background_admin_top : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            dateshow.InnerHtml = "今天是" + DateTime.Now.ToString("yyyy年MM月dd天HH时mm分") + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
            InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
            if (Session[Names.SessionManage] != null)
            {
                newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
                usernameshow.InnerHtml = "欢迎您！" + newloginform.userName;
            }
        }
    }
}