using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

public partial class background_changepassword : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
        if (Session[Names.SessionManage] != null)
        {
            newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
            string oldpwd = Names.EncryptPassword(txtoldPassword.Text.Trim());
            if (!oldpwd.Equals(newloginform.passWord))
            {
                MessageBox("请输入正确的原始密码！");
                return;
            }
            if (!txtnewPassword.Text.Trim().Equals(txtcomPassword.Text.Trim()))
            {
                MessageBox("确认密码和新密码请保持一致！");
                return;
            }
            string strSql = "UPDATE T_WEBMANAGE SET PASSWORD = '" + Names.EncryptPassword(txtnewPassword.Text.Trim()) + "' WHERE USERNAME = '" + newloginform.userName + "'";
            PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
            Session[Names.SessionManage] = null;
            MessageBox("密码修改成功，请重新登录！");
            Response.Write("<script type='text/javascript'>javascript:parent.location.href='adminLogin.aspx';</script>");
          
        }
    }
}