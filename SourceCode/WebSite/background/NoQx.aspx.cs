using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

public partial class background_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session[Names.SessionManage] == null)
            {
                Response.Redirect("adminLogin.aspx");
            }
            //else
            //{
            //    InfoStruct.LoginForm newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
            //    Session[Names.SessionManage] = newloginform;
            //}
        }
    }
}