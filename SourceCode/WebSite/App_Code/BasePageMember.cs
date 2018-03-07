using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Web.Common;
using Web.BaseWeb;
using Web.MemberManage;
/// <summary>
/// UserPage 的摘要说明
/// </summary>

public abstract class BasePageMember : System.Web.UI.Page
{
    public string BaseUserName;
    public string BaseUserID;
    public string BaseUserPassword;
    public string BaseNickName;
 
    public BasePageMember()
    { 
        if (!CheckLogin())
        {
            System.Web.HttpContext.Current.Response.Redirect("~/memberManage/Login.aspx");
        }
    }

    private bool CheckLogin()
    {
        LoginAction la = new LoginAction();
        HttpCookie Cookie = CookiesHelper.GetCookie(SiteInfo.CookieName());
        if (Cookie == null)
        {
            return false;
        } 
        BaseUserName = Cookie.Values["UserName"];
        BaseUserPassword = Cookie.Values["Password"];
        BaseNickName = Cookie.Values["NickName"];
        BaseUserID = Cookie.Values["UserId"];
        if (la.ChkAdminExit(BaseUserName, BaseUserPassword))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
     
    public void MessageBox(String message)
    {
        ClientScript.RegisterStartupScript(GetType(), "ss", "<script language='javascript'>alert('" + message + "');</script>");
    }

    public void OpenPage(String Url)
    {
        string strJS = "<script>"
                  + " window.open('" + Url + "');";
        strJS = strJS + "</script>";
        ClientScript.RegisterStartupScript(this.GetType(), "message", strJS);
    }

    public void RunScript(String ScriptString) {
        ClientScript.RegisterStartupScript(GetType(), "aa", "<script>" + ScriptString + "</script>");
    }

    public static  bool CheckLoginLxj()
    {
        LoginAction la = new LoginAction();
        HttpCookie Cookie = CookiesHelper.GetCookie(SiteInfo.CookieName());
        if (Cookie == null)
        {
            return false;
        }
     string   BaseUserName1= Cookie.Values["UserName"];
      string  BaseUserPassword1 = Cookie.Values["Password"];
      string  BaseNickName1 = Cookie.Values["NickName"];
      string  BaseUserID1 = Cookie.Values["UserId"];
        if (la.ChkAdminExit(BaseUserName1, BaseUserPassword1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void DialogJs(string js)
    {
        ClientScript.RegisterStartupScript(GetType(), "", "<script>" + js + "</script>");
    }
}
