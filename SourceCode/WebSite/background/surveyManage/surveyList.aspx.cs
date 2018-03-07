using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.Common;
using Web.News;

public partial class background_surveyManage_surveyList : BasePage
{

    Base b = new Base();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "6"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            SurveyDataBind();
        }
    }

    private void SurveyDataBind()
    {
        MyAspNetPager.PageSize = 18;
        Int32 recordcount;
        string sql = "SELECT * FROM T_SURVEY WHERE 1 = 1";
        if (!string.IsNullOrEmpty(txtTitle.Text))
            sql += " AND TITLE LIKE '%" + txtTitle.Text + "%'";
        if (!string.IsNullOrEmpty(ddlIspublish.SelectedValue))
            sql += " AND ISPUBLISH = " + ddlIspublish.SelectedValue;
        sql += " ORDER BY ID DESC";

        DataTable DT = Pages.GetPage(sql, MyAspNetPager.CurrentPageIndex, MyAspNetPager.PageSize, out recordcount);
        GridViewSurvey.DataSource = DT;
        GridViewSurvey.DataBind();
        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
        this.lblRecordCount.Text = recordcount.ToString();
        this.lblPageSize.Text = MyAspNetPager.CurrentPageIndex.ToString();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("surveyCreate.aspx");
    }

    protected void GridViewSurvey_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;

            LinkButton btnUpdate = (LinkButton)e.Row.FindControl("LinkBtnUpdate");

            if ("0".Equals(drv.Row["ISPUBLISH"].ToString()))
            {
                e.Row.Cells[4].Text = "未发布";
                btnUpdate.Enabled = true;
            }
            else
            {
                e.Row.Cells[4].Text = "已发布";
                btnUpdate.Enabled = false;
            }
        }
    }
    protected void GridViewSurvey_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string strSql = "DELETE FROM T_SURVEY WHERE ID = " + GridViewSurvey.Rows[e.RowIndex].Cells[0].Text;
        PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
        strSql = "DELETE FROM T_SURVEYQUESTION WHERE SURVEYID = " + GridViewSurvey.Rows[e.RowIndex].Cells[0].Text;
        PersistenceLayer.Query.ProcessSqlNonQuery(strSql, Names.DBName);
        SurveyDataBind();
    }
    protected void GridViewSurvey_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("surveyEdit.aspx?ID=" + GridViewSurvey.Rows[e.NewEditIndex].Cells[0].Text);
    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        SurveyDataBind();
    }
    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        SurveyDataBind();
    }
    protected void GridViewSurvey_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Response.Redirect("questionList.aspx?ID=" + GridViewSurvey.Rows[e.RowIndex].Cells[0].Text);
    }
}