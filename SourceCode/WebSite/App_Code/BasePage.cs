using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Common;

/// <summary>
///BasePage 的摘要说明
/// </summary>
public abstract class BasePage : System.Web.UI.Page
{


    public String BaseUserName;

    public BasePage()
    {
        this.Load += new EventHandler(BasePage_Load);
       
    }
    void BasePage_Load(Object sender, EventArgs e)
    {
        if (Session[Names.SessionManage] == null)
        {
            Response.Redirect("~/background/adminLogin.aspx");
        }
        else
        {
            InfoStruct.LoginForm newloginForm = new InfoStruct.LoginForm();
            newloginForm = (InfoStruct.LoginForm)Session[Names.SessionManage];
            BaseUserName = newloginForm.userName;
        }
    }
    
    #region  public void RunJs(string js)
    /// <summary>
    /// 显示JS弹出框
    /// </summary>
    /// <param name="js"></param>
    public void RunJs(string js)
    {
        ClientScript.RegisterStartupScript(GetType(), "", "<script>" + js + "</script>");
    }
    #endregion

    #region  public void MessageBox(string js)
    /// <summary>
    /// 显示JS弹出框
    /// </summary>
    /// <param name="js"></param>
    public void MessageBox(string content)
    {
        ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('" + content + "');</script>");
    }
    #endregion

    public void DialogJs(string js)
    {
        ClientScript.RegisterStartupScript(GetType(), "", "<script>" + js + "</script>");
    }
}