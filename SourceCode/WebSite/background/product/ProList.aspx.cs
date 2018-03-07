using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersistenceLayer;
using Web.Common;
using System.Data;
using Web.News;
using Web.LxjOnlineMarket;
using Web.BaseWeb;
public partial class background_product_ProList : BasePage
{
    Base b = new Base();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "5"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            DdlDataBind();
            GridViewDataBind();
        }
    }

    private void DdlDataBind()
    {
        this.TxtCARCOLOR.DataSource = RentalHouse.GetSTONETYPE("ST_PROTYPE");
        this.TxtCARCOLOR.DataTextField = "VVALUE";
        this.TxtCARCOLOR.DataValueField = "CODE";
        this.TxtCARCOLOR.DataBind(); 
        this.TxtCARCOLOR.Items.Insert(0, new ListItem("全部", "null"));
    }

    private void GridViewDataBind()
    {
        MyAspNetPager.PageSize = 18;
        Int32 recordcount;
        string sql = "SELECT * FROM T_PRODUCT WHERE 1=1 ";
        if (!"".Equals(txtTITLE.Text.Trim()))
        {
            sql = sql + " AND   PRONAME  LIKE '%'" + txtTITLE.Text.Trim() + "%'";
        }
        if (!string.Equals(this.TxtCARCOLOR.SelectedValue, "null"))
        {
            sql = sql + " AND   PROTYPE  ='" + TxtCARCOLOR.SelectedValue + "'";
        }
        if (!string.Equals(this.rblStatus.SelectedValue, "null"))
        {
            sql = sql + " AND   STATUS  =" + rblStatus.SelectedValue;
        }
        sql = sql + " ORDER BY ID ASC";

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
                e.Row.Cells[7].Text = "发布";
            else if ("-1".Equals(drv.Row["STATUS"].ToString()))
            {
                e.Row.Cells[7].Text = "删除";
            }
            else
                e.Row.Cells[7].Text = "待审核";

            Label lbTitle = (Label)e.Row.FindControl("lbTitle");
            lbTitle.Text = Web.LxjOnlineMarket.RentalHouse.GetST_PROTYPE(lbTitle.Text);

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
        Response.Redirect("ProAdd.aspx");
    }

    protected void LinkBtnEdit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();
        Response.Redirect("ProEdit.aspx?id=" + id);
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
        RunJs("window.open('ProSel.aspx?id=" + id + "')");
    }
}