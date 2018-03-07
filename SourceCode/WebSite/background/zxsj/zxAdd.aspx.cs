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
using System.Text.RegularExpressions;
public partial class Background_zxsj_zxAdd : BasePage
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "9"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            txtPUBLISHTIME.Attributes.Add("onfocus", "WdatePicker({skin:'whyGreen',dateFmt:'yyyy-MM-dd HH:mm:ss'})");
            txtPUBLISHTIME.Text = DateTime.Now.ToString();
          
        }
    }
    
    protected void btnAdd_Click(object sender, EventArgs e)
    {
       
                T_NEWSBASEEntity t = new T_NEWSBASEEntity();
                t.NODEID = 61;
                t.TITLE = Names.GetSingQuote(txtTITLE.Text);

                t.CONTENT = Names.GetSingQuote(txtContent.Value);
                InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
                newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
                t.USERNAME = newloginform.userName;
                t.STATUS = 0;

                if (!string.IsNullOrEmpty(txtPUBLISHTIME.Text))
                    t.PUBLISHTIME = Convert.ToDateTime(txtPUBLISHTIME.Text);
                List<string> lNAME = new List<string>();
                List<string> lVALUE = new List<string>();
                try
                {
                    t.DEFAULTPICURL = Request.Form["uploadList"];


                }
                catch { }
                if (b.AddNews(t, lNAME, lVALUE))
                {
                    MessageBox("提交成功！");
                    Response.Redirect("zxList.aspx");
                }
                else
                {
                    MessageBox("提交失败！");
                }
       
    }
    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("zxList.aspx");
    }
}