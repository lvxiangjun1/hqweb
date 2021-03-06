﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersistenceLayer;
using Web.Common;
using System.Data;
using Web.News;
public partial class background_zxsj_zxList : BasePage
{
    Base b = new Base();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "9"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            GridViewDataBind();
        }
    }

    private void GridViewDataBind()
    {
        MyAspNetPager.PageSize = 18;
        Int32 recordcount;
        string sql = "SELECT * FROM T_NEWSBASE WHERE NODEID=61 and STATUS=" + this.rblStatus.SelectedValue;
        if (!string.IsNullOrEmpty(txtTITLE.Text))
            sql += " AND TITLE LIKE '%" + txtTITLE.Text + "%'";
    
       

        DataTable DT = Pages.GetPage(sql, MyAspNetPager.CurrentPageIndex, MyAspNetPager.PageSize, out recordcount);
        GridViewNews.DataSource = DT;
        GridViewNews.DataBind();

        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
        this.lblRecordCount.Text = recordcount.ToString();
        this.lblPageSize.Text = MyAspNetPager.CurrentPageIndex.ToString();
    }

    protected void GridViewNews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;
           
            if ("0".Equals(drv.Row["STATUS"].ToString()))
                e.Row.Cells[4].Text = "发布";
            else if ("-1".Equals(drv.Row["STATUS"].ToString()))
            {
                e.Row.Cells[4].Text = "删除";
            }
            else
                e.Row.Cells[4].Text = "待审核";
           
        }
    }

    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        GridViewDataBind();
    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        this.MyAspNetPager.CurrentPageIndex = 0;
        GridViewDataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("zxAdd.aspx");
    }




    protected void LinkBtnEdit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();
        Response.Redirect("zxEdit.aspx?id=" + id);
    }
    protected void BtnDelete_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();
        b.DelNews(id);

        GridViewDataBind();
    }
    protected void LinkBtnSel_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();
        RunJs("window.open('zxSel.aspx?id=" + id + "')");
    }
    protected void rblStatus_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}