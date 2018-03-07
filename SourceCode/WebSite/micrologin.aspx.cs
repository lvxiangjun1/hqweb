using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;
using Web.MemberManage;
using System.Data;
using Web.BaseWeb;
public partial class micrologin : System.Web.UI.Page
{
    LoginAction la = new LoginAction();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CheckLogin();

        }
    }
    private void CheckLogin()
    {
        LoginAction la = new LoginAction();
        HttpCookie Cookie = CookiesHelper.GetCookie(SiteInfo.CookieName());
        if (Cookie == null)
        {
            pnlCookie.Visible = false;
            pnlLogin.Visible = true;
        }
        else
        {
            string BaseUserName = Cookie.Values["UserName"];
            string BaseUserPassword = Cookie.Values["Password"];
            string NickName = Cookie.Values["NickName"];
            if (la.ChkAdminExit(BaseUserName, BaseUserPassword))
            {
                lbNICK_NAME.Text = NickName;
                pnlCookie.Visible = true;
                pnlLogin.Visible = false;
            }
            else
            {
                pnlCookie.Visible = false;
                pnlLogin.Visible = true;
            }
        }
    }
    protected void ibLogin_Click(object sender, ImageClickEventArgs e)
    {
        string name = txtUSERNAME.Text;
        string password = txtPassword.Text;
        if ("".Equals(name))
        {

            return;
        }
        if ("".Equals(password))
        {

            return;
        }
        string UserName = name;
        string ConfirmPassword = Names.EncryptPassword(password);
        if (la.ChkAdminExit(UserName, ConfirmPassword))
        {
            DataTable DT = la.GetAdminInfo(UserName);
            if (DT.Rows.Count == 0)
            {
                MessageBox("该用户不存在！");
                return;
            }
            else if (DT.Rows[0]["NB_ZT"].ToString() == "0")
            {
                MessageBox("该用户已无效！");
                return;
            }
            else
            {



                HttpCookie Cookie = CookiesHelper.GetCookie(SiteInfo.CookieName());
                if (Cookie == null)
                {
                    Cookie = new HttpCookie(SiteInfo.CookieName());
                    Cookie.Values.Add("UserId", DT.Rows[0]["NB_ID"].ToString());
                    Cookie.Values.Add("UserName", DT.Rows[0]["VAR_ZH"].ToString());
                    Cookie.Values.Add("Password", DT.Rows[0]["VAR_MM"].ToString());
                    Cookie.Values.Add("NickName", DT.Rows[0]["VAR_NICK_NAME"].ToString());
                    //设置Cookie过期时间
                    Cookie.Expires = DateTime.Now.AddDays(1);
                    CookiesHelper.AddCookie(Cookie);
                }
                if (Cookie.Values.Count <= 0)
                {
                    Cookie = new HttpCookie(SiteInfo.CookieName());
                    Cookie.Values.Add("UserId", DT.Rows[0]["NB_ID"].ToString());
                    Cookie.Values.Add("UserName", DT.Rows[0]["VAR_ZH"].ToString());
                    Cookie.Values.Add("Password", DT.Rows[0]["VAR_MM"].ToString());
                    Cookie.Values.Add("NickName", DT.Rows[0]["VAR_NICK_NAME"].ToString());
                    //设置Cookie过期时间
                    Cookie.Expires = DateTime.Now.AddDays(1);
                    CookiesHelper.AddCookie(Cookie);
                }
                else if ((!Cookie.Values["UserName"].Equals(DT.Rows[0]["VAR_ZH"].ToString())) || (!Cookie.Values["Password"].Equals(DT.Rows[0]["VAR_MM"].ToString())))
                {
                    CookiesHelper.SetCookie(SiteInfo.CookieName(), "UserId", DT.Rows[0]["NB_ID"].ToString());
                    CookiesHelper.SetCookie(SiteInfo.CookieName(), "UserName", DT.Rows[0]["VAR_ZH"].ToString());
                    CookiesHelper.SetCookie(SiteInfo.CookieName(), "Password", DT.Rows[0]["VAR_MM"].ToString());
                    CookiesHelper.SetCookie(SiteInfo.CookieName(), "NickName", DT.Rows[0]["VAR_NICK_NAME"].ToString());
                }
                lbNICK_NAME.Text = DT.Rows[0]["VAR_NICK_NAME"].ToString();

                pnlCookie.Visible = true;
                pnlLogin.Visible = false;
                return;


            }
        }
        else {
            MessageBox("用户名或密码错误！");
            return;
        }
    }
    protected void lbtnExit_Click(object sender, EventArgs e)
    {
        HttpCookie Cookie = CookiesHelper.GetCookie(SiteInfo.CookieName());
        if (Cookie != null)
        {
            Cookie = new HttpCookie(SiteInfo.CookieName());
            Cookie.Values.Add("UserId", "");
            Cookie.Values.Add("UserName", "");
            Cookie.Values.Add("Password", "");
            Cookie.Values.Add("NickName", "");
            //设置Cookie过期时间
            Cookie.Expires = DateTime.Now.AddDays(-1);
            CookiesHelper.AddCookie(Cookie);

        }
        pnlCookie.Visible = false;
        pnlLogin.Visible = true;
    
    }
    public void MessageBox(String Str)
    {
        String scriptString = @"<script language=JavaScript>";
        scriptString += @"alert('" + Str + "');";
        scriptString += @"history.go(-1);";
        scriptString += @"<";
        scriptString += @"/";
        scriptString += @"script>";
        if (!Page.IsStartupScriptRegistered("Startup"))
            Page.RegisterStartupScript("Startup", scriptString);
    }
}