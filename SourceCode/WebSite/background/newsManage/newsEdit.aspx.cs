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
public partial class Background_NewsManage_newsEdit : BasePage
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (!b.IsNewsQX(BaseUserName, "3"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            txtPUBLISHTIME.Attributes.Add("onfocus", "WdatePicker({skin:'whyGreen',dateFmt:'yyyy-MM-dd HH:mm:ss'})");
            InitDDL();
            InitDDL1();
            hidId.Value = Request.QueryString["id"];
            if (!UtFunction.IsNum(hidId.Value))
            {
                Response.Redirect("../Error.aspx");
            }
            InitContent();
        }
    }
    #region 初始化颜色控件
    private void InitDDL()
    {
        ArrayList ds = GetData();

        foreach (MyData data in ds)
        {
            ListItem item = new ListItem(data.Text, data.Value);
            item.Attributes.Add("style", "color:" + data.Color);
            ddlTITLECOLOR.Items.Add(item);

        }
    }
    public ArrayList GetData()
    {
        System.Collections.ArrayList data = new System.Collections.ArrayList();
        data.Add(new MyData("颜色", "#000000", "#000000"));
        data.Add(new MyData("黑色", "#000000", "#000000"));
        data.Add(new MyData("蓝色", "#3333FF", "#3333FF"));
        data.Add(new MyData("红色", "#FF0000", "#FF0000"));
        data.Add(new MyData("橘色", "#FFCC33", "#FFCC33"));
        data.Add(new MyData("黄色", "#FFFF00", "#FFFF00"));
        data.Add(new MyData("青色", "#CCFFFF", "#CCFFFF"));
        data.Add(new MyData("绿色", "#33CC00", "#33CC00"));
        return data;
    }
    public class MyData
    {
        string _Text;
        string _Value;
        string _Color;

        public string Text { get { return _Text; } }
        public string Value { get { return _Value; } }
        public string Color { get { return _Color; } }

        public MyData(string text, string value, string color)
        {
            _Text = text;
            _Value = value;
            _Color = color;

        }
    }

    private void InitDDL1()
    {
        ArrayList ds1 = GetData1();

        foreach (MyData data1 in ds1)
        {
            ListItem item = new ListItem(data1.Text, data1.Value);
            item.Attributes.Add("style", "color:" + data1.Color);
            ddlSUBTITLECOLOR.Items.Add(item);

        }
    }
    public ArrayList GetData1()
    {
        System.Collections.ArrayList data = new System.Collections.ArrayList();
        data.Add(new MyData("颜色", "#000000", "#000000"));
        data.Add(new MyData("黑色", "#000000", "#000000"));
        data.Add(new MyData("蓝色", "#3333FF", "#3333FF"));
        data.Add(new MyData("红色", "#FF0000", "#FF0000"));
        data.Add(new MyData("橘色", "#FFCC33", "#FFCC33"));
        data.Add(new MyData("黄色", "#FFFF00", "#FFFF00"));
        data.Add(new MyData("青色", "#CCFFFF", "#CCFFFF"));
        data.Add(new MyData("绿色", "#33CC00", "#33CC00"));
        return data;
    }
    public class MyData1
    {
        string _Text;
        string _Value;
        string _Color;

        public string Text { get { return _Text; } }
        public string Value { get { return _Value; } }
        public string Color { get { return _Color; } }

        public MyData1(string text, string value, string color)
        {
            _Text = text;
            _Value = value;
            _Color = color;

        }
    }
    #endregion
    private void InitContent()
    {
        try
        {
            string sql = "select * from T_NEWSBASE where id=" + hidId.Value;
            DataTable dt = PersistenceLayer.Query.ProcessSql(sql, Names.DBName);
            if (dt.Rows.Count > 0)
            {
                txtTITLE.Text = dt.Rows[0]["TITLE"].ToString();
                ddlTITLEFONT.SelectedValue = dt.Rows[0]["TITLEFONT"].ToString();
                ddlTITLECOLOR.SelectedValue = dt.Rows[0]["TITLECOLOR"].ToString();
                ddlTITLESIZE.SelectedValue = dt.Rows[0]["TITLESIZE"].ToString();
                txtSUBTITLE.Text = dt.Rows[0]["SUBTITLE"].ToString();
                ddlSUBTITLEFONT.SelectedValue = dt.Rows[0]["SUBTITLEFONT"].ToString();
                ddlSUBTITLECOLOR.SelectedValue = dt.Rows[0]["SUBTITLECOLOR"].ToString();
                ddlSUBTITLESIZE.SelectedValue = dt.Rows[0]["SUBTITLESIZE"].ToString();
                txtCOPYRIGHT.Text = dt.Rows[0]["COPYRIGHT"].ToString();
                txtAUTHOR.Text = dt.Rows[0]["AUTHOR"].ToString();
                txtContent.Value = dt.Rows[0]["CONTENT"].ToString();
                ddlISSPECIAL.SelectedValue = dt.Rows[0]["ISSPECIAL"].ToString();
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

                    for (int i = 0; i < dtImage.Rows.Count; i++)
                    {
                        hiduploadListText.Text += dtImage.Rows[0]["PICINFO"].ToString() + "&&";
                        hiduploadListValue.Text += dtImage.Rows[0]["PICURL"].ToString() + "&&";
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
        t.TITLEFONT = Names.GetSingQuote(ddlTITLEFONT.SelectedValue);
        t.TITLECOLOR = Names.GetSingQuote(ddlTITLECOLOR.SelectedValue);
        t.TITLESIZE = Convert.ToDecimal(Names.GetSingQuote(ddlTITLESIZE.SelectedValue));

        t.SUBTITLE = Names.GetSingQuote(txtSUBTITLE.Text);
        t.SUBTITLEFONT = Names.GetSingQuote(ddlSUBTITLEFONT.SelectedValue);
        t.SUBTITLECOLOR = Names.GetSingQuote(ddlSUBTITLECOLOR.SelectedValue);
        t.SUBTITLESIZE = Convert.ToDecimal(Names.GetSingQuote(ddlSUBTITLESIZE.SelectedValue));

        t.COPYRIGHT = Names.GetSingQuote(txtCOPYRIGHT.Text);
        t.AUTHOR = Names.GetSingQuote(txtAUTHOR.Text);
        t.CONTENT = Names.GetSingQuote(txtContent.Value);

        InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
        newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
        t.UPDATEUSERNAME = newloginform.userName;

    
        t.ISSPECIAL = Names.GetSingQuote(ddlISSPECIAL.SelectedValue);
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
            Response.Redirect("NewsList.aspx");
        }
        else
        {
            MessageBox("提交失败！");
        }
    }
    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewsList.aspx");
    }
}