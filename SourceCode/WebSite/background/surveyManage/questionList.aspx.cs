using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
//
using PersistenceLayer;
using Web.BusinessEntity;
using Web.Survey;
using Web.Common;

public partial class background_surveyManage_questionList : BasePage 
{
    #region 全局变量
    CreateAction createAction = new CreateAction();
    #endregion

    /// <summary>
    /// 获取试卷信息
    /// </summary>
    /// <param name="id"></param>
    private void GetPaperMsg(string id)
    {
        try
        {
            string strSql = "SELECT * FROM T_SURVEY WHERE ID = " + id;
            DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
            if (DT.Rows.Count > 0)
            {
                txtName.Text = DT.Rows[0]["TITLE"].ToString();
                dropIsPublish.SelectedValue = DT.Rows[0]["ISPUBLISH"].ToString();
            }
        }
        catch
        {
            MessageBox("加载试卷信息错误！");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbReqId.Text = Request.Params["ID"];
            if (!string.IsNullOrEmpty(lbReqId.Text))
            {
                GetPaperMsg(lbReqId.Text);
                dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
                dlQuestList.DataBind();
                ibtnType01.Attributes.Add("onClick", "javascript:art.dialog.open('Type01.aspx?SURID=" + lbReqId.Text + "',{id:'Type01',title:'添加列表单选题',width:'700px',height:'400px'});return false;");
                ibtnType02.Attributes.Add("onClick", "javascript:art.dialog.open('Type02.aspx?SURID=" + lbReqId.Text + "',{id:'Type02',title:'添加多选题',width:'700px',height:'400px'});return false;");
                ibtnType03.Attributes.Add("onClick", "javascript:art.dialog.open('Type03.aspx?SURID=" + lbReqId.Text + "',{id:'Type03',title:'添加组合单选题',width:'700px',height:'400px'});return false;");
                ibtnType04.Attributes.Add("onClick", "javascript:art.dialog.open('Type04.aspx?SURID=" + lbReqId.Text + "',{id:'Type04',title:'添加组合多选题',width:'700px',height:'400px'});return false;");
                ibtnType05.Attributes.Add("onClick", "javascript:art.dialog.open('Type05.aspx?SURID=" + lbReqId.Text + "',{id:'Type05',title:'添加单行文本框题',width:'700px',height:'400px'});return false;");
                ibtnType06.Attributes.Add("onClick", "javascript:art.dialog.open('Type06.aspx?SURID=" + lbReqId.Text + "',{id:'Type06',title:'添加多行文本框题',width:'700px',height:'400px'});return false;");
                ibtnType07.Attributes.Add("onClick", "javascript:art.dialog.open('Type07.aspx?SURID=" + lbReqId.Text + "',{id:'Type07',title:'添加信息题题',width:'700px',height:'400px'});return false;");
            }
            else
            {
                MessageBox("未获取到试卷信息，无法创建试题！");
            }
        }
    }

    /// <summary>
    /// 修改试卷信息
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        try
        {
            T_SURVEYEntity ety = new T_SURVEYEntity();
            ety.ID = int.Parse(lbReqId.Text);
            ety.Retrieve();
            ety.ISPUBLISH = int.Parse(dropIsPublish.SelectedValue);
            if (ety.Save() == 1)
            {
                MessageBox("修改成功！");
            }
            else
            {
                MessageBox("修改失败！");
            }
        }
        catch
        {
            MessageBox("修改失败！");
        }
    }

    /// <summary>
    /// 刷新
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void lbRefresh_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(lbReqId.Text))
        {
            GetPaperMsg(lbReqId.Text);
            dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
            dlQuestList.DataBind();
        }
        else
        {
            MessageBox("未获取到试卷信息，无法创建试题！");
        }
    }

    /// <summary>
    /// 关闭
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClose_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(GetType(), "close", "<script>window.close();</script>");
    }

    #region 试题添加按钮事件
    /// <summary>
    /// 单选
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType01_Click(object sender, EventArgs e)
    {
        OpenPage("Type01.aspx?SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 多选
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType02_Click(object sender, EventArgs e)
    {
        OpenPage("Type02.aspx?SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 组合单选
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType03_Click(object sender, EventArgs e)
    {
        OpenPage("Type03.aspx?SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 组合多选
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType04_Click(object sender, EventArgs e)
    {
        OpenPage("Type04.aspx?SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 单行文本
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType05_Click(object sender, EventArgs e)
    {
        OpenPage("Type05.aspx?SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 多行文本
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType06_Click(object sender, EventArgs e)
    {
        OpenPage("Type06.aspx?SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 信息题
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnType07_Click(object sender, EventArgs e)
    {
        OpenPage("Type07.aspx?SURID=" + lbReqId.Text);
    }
    #endregion

    #region 页面处理按钮事件
    /// <summary>
    /// 编辑按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnEdit_Click(object sender, EventArgs e)
    {
        DataListItem item = (DataListItem)((Control)sender).Parent;
        string id = dlQuestList.DataKeys[item.ItemIndex].ToString();
        string type = createAction.GetTypeById(int.Parse(id));
        OpenPage("Type" + type + ".aspx?ID=" + id + "&SURID=" + lbReqId.Text);
    }

    /// <summary>
    /// 删除按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnDel_Click(object sender, EventArgs e)
    {
        DataListItem item = (DataListItem)((Control)sender).Parent;
        string id = dlQuestList.DataKeys[item.ItemIndex].ToString();
        if (createAction.DeleteQuestion(int.Parse(id)))
        {
            MessageBox("删除成功！");
            //刷新
            if (!string.IsNullOrEmpty(lbReqId.Text))
            {
                GetPaperMsg(lbReqId.Text);
                dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
                dlQuestList.DataBind();
            }
        }
        else
        {
            MessageBox("删除失败！");
        }
    }

    /// <summary>
    /// 上移按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnUp_Click(object sender, EventArgs e)
    {
        DataListItem item = (DataListItem)((Control)sender).Parent;
        string id = dlQuestList.DataKeys[item.ItemIndex].ToString();
        createAction.SetQuestionIdUp(int.Parse(id));
        if (!string.IsNullOrEmpty(lbReqId.Text))
        {
            GetPaperMsg(lbReqId.Text);
            dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
            dlQuestList.DataBind();
        }
    }

    /// <summary>
    /// 下移按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnDown_Click(object sender, EventArgs e)
    {
        DataListItem item = (DataListItem)((Control)sender).Parent;
        string id = dlQuestList.DataKeys[item.ItemIndex].ToString();
        createAction.SetQuestionIdDown(int.Parse(id));
        if (!string.IsNullOrEmpty(lbReqId.Text))
        {
            GetPaperMsg(lbReqId.Text);
            dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
            dlQuestList.DataBind();
        }
    }

    /// <summary>
    /// 最前按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnFirst_Click(object sender, EventArgs e)
    {
        DataListItem item = (DataListItem)((Control)sender).Parent;
        string id = dlQuestList.DataKeys[item.ItemIndex].ToString();
        createAction.SetQuestionIdFirst(int.Parse(id));
        if (!string.IsNullOrEmpty(lbReqId.Text))
        {
            GetPaperMsg(lbReqId.Text);
            dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
            dlQuestList.DataBind();
        }
    }

    /// <summary>
    /// 最后按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void ibtnLast_Click(object sender, EventArgs e)
    {
        DataListItem item = (DataListItem)((Control)sender).Parent;
        string id = dlQuestList.DataKeys[item.ItemIndex].ToString();
        createAction.SetQuestionIdLast(int.Parse(id));
        if (!string.IsNullOrEmpty(lbReqId.Text))
        {
            GetPaperMsg(lbReqId.Text);
            dlQuestList.DataSource = createAction.GetQuestionData(int.Parse(lbReqId.Text));
            dlQuestList.DataBind();
        }
    }
    #endregion

    public void OpenPage(String Url)
    {
        string strJS = "<script>"
                  + " window.open('" + Url + "');";
        strJS = strJS + "</script>";
        ClientScript.RegisterStartupScript(this.GetType(), "key1", strJS);
    }




}
