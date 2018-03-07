using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.Common;

public partial class background_adminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void iBtnLogin_Click(object sender, ImageClickEventArgs e)
    {
        if ("".Equals(this.txtUsername.Text))
        {
            NewMessage("请先输入用户名！");
            return;
        }
        if ("".Equals(this.txtPassword.Text))
        {
            NewMessage("请先输入密码！");
            return;
        }
        if (!CheckCode())
            return;
        String UserName = this.txtUsername.Text;
        String ConfirmPassword = Names.EncryptPassword(this.txtPassword.Text);
        if (UserLogin(UserName, ConfirmPassword))
        {
            InfoStruct.LoginForm LoginForm = new InfoStruct.LoginForm();
            LoginForm.userName = UserName;
            LoginForm.passWord = ConfirmPassword;
            Session[Names.SessionManage] = LoginForm;
            string strSql = "UPDATE T_WEBMANAGE SET LASTLOGINTIME = SYSDATE,LASTLOGINIP = '" + GetClientIP() + "' WHERE USERNAME = '" + UserName + "'";
            PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
            Response.Redirect("Default.aspx");
        }
        else
        {
            ClientScript.RegisterStartupScript(GetType(), "error_script", "<script>alert('用户名或者密码错误。');</script>");
        }
    }

    /// <summary>
    ///得到客户端ip地址
    /// </summary>
    public static string GetClientIP()
    {
        if (HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
        {
            return HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
        }
        else
        {
            return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
        }
    }

    private bool UserLogin(String UserName, String Password)
    {
        String Strsql = "SELECT COUNT(*) FROM T_WEBMANAGE WHERE USERNAME = '" + UserName + "' AND PASSWORD = '" + Password + "' AND STATUS = 0";
        try
        {
            DataTable DT = PersistenceLayer.Query.ProcessSql(Strsql, Names.DBName);
            if (int.Parse(DT.Rows[0][0].ToString()) <= 0)
                return false;
            else
                return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    private void NewMessage(String Message)
    {
        ClientScript.RegisterStartupScript(GetType(), "error_script", "<script>alert('" + Message + "');</script>");
    }

    private bool CheckCode()
    {
        bool bRet = false;
        if (Request.Cookies["CheckCode"] == null)
        {
            ClientScript.RegisterStartupScript(GetType(), "error_script", "<script>alert('您的浏览器设置已被禁用 Cookies，您必须设置浏览器允许使用 Cookies 选项后才能使用本系统。');document.all.UserName.value=''; document.all.Password.value=''; document.all.txtCheckCode.value='';</script>");
            return bRet;

        }
        if (String.Compare(Request.Cookies["CheckCode"].Value, this.txtCheckCode.Value, true) != 0)
        {
            ClientScript.RegisterStartupScript(GetType(), "error_script", "<script>alert('验证码错误，请输入正确的验证码。');document.all.txtCheckCode.value='';</script>");
        }
        else
        {
            bRet = true;
        }
        return bRet;
    }
}