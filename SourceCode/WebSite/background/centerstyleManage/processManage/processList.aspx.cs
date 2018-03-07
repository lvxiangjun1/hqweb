using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersistenceLayer;
using Web.Common;
using System.Data;
using System.Drawing;
using Web.News;
public partial class background_centerstyleManage_processManage_processList : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Base b = new Base();
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "64"))
            {
                Response.Redirect("../../NoQx.aspx");
            }
            GridViewDoctorDataBind();
        }
    }

    private void GridViewDoctorDataBind()
    {
        MyAspNetPager.PageSize = 18;
        Int32 recordcount;
        string sql = "SELECT * FROM T_NEWSBASE WHERE NODEID = 64 ORDER BY ID DESC";
        DataTable DT = Pages.GetPage(sql, MyAspNetPager.CurrentPageIndex, MyAspNetPager.PageSize, out recordcount);
        GridViewDoctor.DataSource = DT;
        GridViewDoctor.DataBind();
        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
        this.lblRecordCount.Text = recordcount.ToString();
        this.lblPageSize.Text = MyAspNetPager.CurrentPageIndex.ToString();
    }

    protected void GridViewDoctor_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;

        }
    }

    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        GridViewDoctorDataBind();
    }

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        this.MyAspNetPager.CurrentPageIndex = 0;
        GridViewDoctorDataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("processAdd.aspx");
    }

    protected void GridViewDoctor_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string strSql = "DELETE FROM T_NEWSBASE WHERE ID = " + GridViewDoctor.Rows[e.RowIndex].Cells[0].Text;
        PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
        GridViewDoctorDataBind();
    }
    protected void GridViewDoctor_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("processEdit.aspx?ID=" + GridViewDoctor.Rows[e.NewEditIndex].Cells[0].Text);
    }
}