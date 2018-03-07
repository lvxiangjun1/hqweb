using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//
using Web.BusinessEntity;
using Web.Survey;
using Web.Common;
using PersistenceLayer;

public partial class background_surveyManage_Type03 : BasePage 
{
    #region 全局变量
    CreateAction createAction = new CreateAction();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbReqId.Text = Request.Params["ID"];//试题ID
            lbSurId.Text = Request.Params["SURID"];//试卷ID
            if (!string.IsNullOrEmpty(lbReqId.Text))
            {
                string strSql = "SELECT * FROM T_SURVEYQUESTION WHERE ID=" + lbReqId.Text;
                DataTable dt = Query.ProcessSql(strSql, Names.DBName);
                if (dt.Rows.Count > 0)
                {
                    txtTitle.Text = dt.Rows[0]["TITLE"].ToString();//题目
                    lbIsText.Text = dt.Rows[0]["ISTEXT"].ToString();//文本框标志
                    chkList.Items.Clear();
                    string strAnswer = dt.Rows[0]["ANSWER"].ToString();//选项
                    string[] strAnswerList = strAnswer.Split('¤');
                    for (int i = 0; i < strAnswerList.Length; i++)
                    {
                        chkList.Items.Add(new ListItem(strAnswerList[i], strAnswerList[i]));
                    }

                }
            }
            lbShowText.Text = createAction.showText(lbIsText.Text);

        }
    }
    /// <summary>
    /// 完成
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            string strSql = "";
            string strAnswer = "";
            int intDir;

            for (int i = 0; i < chkList.Items.Count; i++)
            {
                if (i == 0)
                {
                    strAnswer += chkList.Items[i].Text;
                }
                else
                {
                    strAnswer += "¤" + chkList.Items[i].Text;
                }

            }
            if (chkList.RepeatDirection == RepeatDirection.Horizontal)
            {
                intDir = 0;
            }
            else
            {
                intDir = 1;
            }
            if (!string.IsNullOrEmpty(lbReqId.Text))
            {
                strSql = "UPDATE T_SURVEYQUESTION SET TITLE='" + txtTitle.Text + "',ANSWER='" + strAnswer + "',ISTEXT='" + lbIsText.Text + "' WHERE ID=" + lbReqId.Text;
            }
            else
            {
                int intIndex = int.Parse(createAction.getMaxIndex(lbSurId.Text));
                intIndex += 1;
                strSql = "INSERT INTO T_SURVEYQUESTION (ID,SURVEYID,QUESTIONID,TYPE,TITLE,ANSWER,ISTEXT) ";
                strSql += " VALUES(SEQ_T_SURVEYQUESTION.NEXTVAL," + lbSurId.Text + "," + intIndex + ",'03','" + txtTitle.Text + "','" + strAnswer + "','" + lbIsText.Text + "')";
            }
            Query.ProcessSql(strSql, Names.DBName);
        }
        catch
        {

        }
        const string strJs = "parent.document.getElementById('lbRefresh').click();art.dialog.close();";
        RunJs(strJs);
    }

    /// <summary>
    /// 关闭
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnClose_Click(object sender, EventArgs e)
    {
        const string strJs = "art.dialog.close();";
        RunJs(strJs);
    }
    /// <summary>
    /// 编辑
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            chkList.SelectedItem.Text = txtContent.Text;
            chkList.SelectedItem.Value = txtContent.Text;
            txtContent.Text = "";
        }
    }
    /// <summary>
    /// 上移
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnUp_Click(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            if (chkList.SelectedIndex - 1 >= 0)
            {
                int index = chkList.SelectedIndex;
                ListItem l1 = chkList.SelectedItem;//选择项
                ListItem l2 = chkList.Items[index - 1];
                chkList.Items.Remove(l1);
                chkList.Items.Remove(l2);
                chkList.Items.Insert(index - 1, l1);
                chkList.Items.Insert(index, l2);
                lbIsText.Text = createAction.setText(lbIsText.Text, index, -1);
                lbShowText.Text = createAction.showText(lbIsText.Text);
            }
        }

    }
    /// <summary>
    /// 下移
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnDown_Click(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            if (chkList.SelectedIndex + 1 <= chkList.Items.Count - 1)
            {
                int index = chkList.SelectedIndex;
                ListItem l1 = chkList.SelectedItem;//选择项
                chkList.Items.Remove(l1);
                chkList.Items.Insert(index + 1, l1);
                lbIsText.Text = createAction.setText(lbIsText.Text, index, 1);
                lbShowText.Text = createAction.showText(lbIsText.Text);
            }
        }
    }

    /// <summary>
    /// 添加一项
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        chkList.Items.Add(new ListItem(txtAddContent.Text, txtAddContent.Text));
        chkList.DataBind();
        txtAddContent.Text = "";
        lbIsText.Text = createAction.addTextNum(lbIsText.Text);
        lbShowText.Text = createAction.showText(lbIsText.Text);
    }
    /// <summary>
    /// 移除一项
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            lbIsText.Text = createAction.removeTextNum(lbIsText.Text, chkList.SelectedIndex);
            lbShowText.Text = createAction.showText(lbIsText.Text);
            chkList.Items.RemoveAt(chkList.SelectedIndex);
            

        }
    }
   

    protected void chkList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            txtContent.Text = chkList.SelectedValue;
        }
    }

    /// <summary>
    /// 设置文本框
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSetText_Click(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            lbIsText.Text = createAction.setText(lbIsText.Text, chkList.SelectedIndex, "Y");
            lbShowText.Text = createAction.showText(lbIsText.Text);
        }
    }
    
    /// <summary>
    /// 取消文本框
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnConcelText_Click(object sender, EventArgs e)
    {
        if (chkList.SelectedIndex >= 0)
        {
            lbIsText.Text = createAction.setText(lbIsText.Text, chkList.SelectedIndex, "N");
            lbShowText.Text = createAction.showText(lbIsText.Text);
        }
    }
}
