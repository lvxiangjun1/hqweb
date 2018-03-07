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
public partial class background_adminManage_adminList : BasePage
{
    Base b=new Base();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "1"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            GridViewAdminDataBind();
        }
    }

    private void GridViewAdminDataBind()
    {
        MyAspNetPager.PageSize = 18;
        Int32 recordcount;
        string sql = "SELECT * FROM T_WEBMANAGE WHERE STATUS=" + this.rblStatus.SelectedValue;
        if (!string.IsNullOrEmpty(txtUserName.Text))
            sql += " AND USERNAME LIKE '%" + txtUserName.Text + "%'";
        if (!string.IsNullOrEmpty(txtTrueName.Text))
            sql += " AND TRUENAME LIKE '%" + txtTrueName.Text + "%'";
        sql += " ORDER BY ID DESC";

        DataTable DT = Pages.GetPage(sql, MyAspNetPager.CurrentPageIndex, MyAspNetPager.PageSize, out recordcount);
        GridViewAdmin.DataSource = DT;
        GridViewAdmin.DataBind();
        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
        this.lblRecordCount.Text = recordcount.ToString();
        this.lblPageSize.Text = MyAspNetPager.CurrentPageIndex.ToString();
    }

    protected void GridViewAdmin_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;
            if ("0".Equals(drv.Row["STATUS"].ToString()))
                e.Row.Cells[6].Text = "正常";
            else
                e.Row.Cells[6].Text = "锁定";
        }
    }

    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        GridViewAdminDataBind();
    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        this.MyAspNetPager.CurrentPageIndex = 0;
        GridViewAdminDataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminAdd.aspx");
    }

    protected void GridViewAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Transaction T = new Transaction();
        string strSql = "DELETE FROM T_WEBMANAGE WHERE ID = " + GridViewAdmin.Rows[e.RowIndex].Cells[0].Text;
        T.AddSqlString(strSql, Names.DBName);
        string rolesql = "DELETE FROM T_WEBMANAGEROLE WHERE USERNAME = '" + GridViewAdmin.Rows[e.RowIndex].Cells[1].Text + "'";
        T.AddSqlString(rolesql, Names.DBName);
        T.Process();
        GridViewAdminDataBind();
    }
    protected void GridViewAdmin_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("adminEdit.aspx?ID=" + GridViewAdmin.Rows[e.NewEditIndex].Cells[0].Text);
    }
}