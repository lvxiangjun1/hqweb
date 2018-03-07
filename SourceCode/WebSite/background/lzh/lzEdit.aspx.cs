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
using System.Data;
using System.Text.RegularExpressions;
public partial class Background_lzh_lzEdit : BasePage
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "43"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            txtPUBLISHTIME.Attributes.Add("onfocus", "WdatePicker({skin:'whyGreen',dateFmt:'yyyy-MM-dd HH:mm:ss'})");
            hidId.Value = Request.QueryString["id"];
            InitContent();
        }
    }
    
    private void InitContent()
    {
        try
        {
            string sql = "select * from T_NEWSBASE where id=" + hidId.Value;
            DataTable dt = PersistenceLayer.Query.ProcessSql(sql, Names.DBName);
            if (dt.Rows.Count > 0)
            {
                txtTITLE.Text = dt.Rows[0]["TITLE"].ToString();
             
                txtCOPYRIGHT.Text = dt.Rows[0]["COPYRIGHT"].ToString();
                txtAUTHOR.Text = dt.Rows[0]["AUTHOR"].ToString();
                txtContent.Value = dt.Rows[0]["CONTENT"].ToString();
                
                if (!string.IsNullOrEmpty(dt.Rows[0]["PUBLISHTIME"].ToString()))
                    txtPUBLISHTIME.Text = Convert.ToDateTime(dt.Rows[0]["PUBLISHTIME"]).ToString();
               
                string sqlImg = "select * from T_NEWSPIC where NEWSID=" + hidId.Value;
                DataTable dtImage = PersistenceLayer.Query.ProcessSql(sqlImg, Names.DBName);
                if (dt.Rows.Count > 0)
                {
                    uploadList.DataSource = dtImage;
                    uploadList.DataTextField = "PICINFO";
                    uploadList.DataValueField = "PICURL";
                    uploadList.DataBind();
                    uploadList.SelectedValue = dt.Rows[0]["DEFAULTPICURL"].ToString();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        hiduploadListText.Text += dt.Rows[0]["PICINFO"].ToString() + "&&";
                        hiduploadListValue.Text += dt.Rows[0]["PICURL"].ToString() + "&&";
                    }

                }
            }
        }
        catch { }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {

        T_NEWSBASEEntity t = new T_NEWSBASEEntity();
        t.ID = Convert.ToDecimal(Names.GetSingQuote(hidId.Value));
        t.TITLE = Names.GetSingQuote(txtTITLE.Text);
      

        t.COPYRIGHT = Names.GetSingQuote(txtCOPYRIGHT.Text);
        t.AUTHOR = Names.GetSingQuote(txtAUTHOR.Text);
        t.CONTENT = Names.GetSingQuote(txtContent.Value);

        InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
        newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
        t.UPDATEUSERNAME = newloginform.userName;

       
        if (!string.IsNullOrEmpty(txtPUBLISHTIME.Text))
            t.PUBLISHTIME = Convert.ToDateTime(txtPUBLISHTIME.Text);
        List<string> lNAME = new List<string>();
        List<string> lVALUE = new List<string>();
        try
        {
            t.DEFAULTPICURL = Request.Form["uploadList"];
            string[] uploadListValue = Regex.Split(hiduploadListValue.Text, "&&", RegexOptions.IgnoreCase);
            string[] uploadListText = Regex.Split(hiduploadListText.Text, "&&", RegexOptions.IgnoreCase);
            for (int i = 0; i < uploadListValue.Length - 1; i++)
            {
                lNAME.Add(Names.GetSingQuote(uploadListText[i]));
                lVALUE.Add(Names.GetSingQuote(uploadListValue[i]));
            }

        }
        catch { }

        if (b.EditNews(t, lNAME, lVALUE))
        {
            MessageBox("提交成功！");
            Response.Redirect("lzList.aspx");
        }
        else
        {
            MessageBox("提交失败！");
        }
    }
    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("lzList.aspx");
    }
}