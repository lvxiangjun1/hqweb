﻿using System;
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
using System.IO;
public partial class Background_spzx_spAdd : BasePage
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "4"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            txtPUBLISHTIME.Attributes.Add("onfocus", "WdatePicker({skin:'whyGreen',dateFmt:'yyyy-MM-dd HH:mm:ss'})");
            txtPUBLISHTIME.Text = DateTime.Now.ToString();
            InitDDL();
        }
    }
    #region 初始化颜色控件
    private void InitDDL()
    {
        ArrayList ds = GetData();
        ArrayList ds1 = GetData1();
        foreach (MyData data in ds)
        {
            ListItem item = new ListItem(data.Text, data.Value);
            item.Attributes.Add("style", "color:" + data.Color);
            ddlTITLECOLOR.Items.Add(item);

        }
        foreach (MyData data in ds1)
        {
            ListItem item = new ListItem(data.Text, data.Value);
            item.Attributes.Add("style", "color:" + data.Color);
            ddlSUBTITLECOLOR.Items.Add(item);

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
    #endregion
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        T_NEWSBASEEntity t = new T_NEWSBASEEntity();
        t.NODEID = 4;
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
        t.USERNAME = newloginform.userName;
        t.STATUS = 0;
       
        if (!string.IsNullOrEmpty(txtPUBLISHTIME.Text))
            t.PUBLISHTIME = Convert.ToDateTime(txtPUBLISHTIME.Text);
        List<string> lNAME = new List<string>();
        List<string> lVALUE = new List<string>();
      
        if (b.AddNews(t, lNAME, lVALUE))
        {
            MessageBox("提交成功！");
            Response.Redirect("spList.aspx");
        }
        else
        {
            MessageBox("提交失败！");
        }


    }
    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("spList.aspx");
    }
  
}
