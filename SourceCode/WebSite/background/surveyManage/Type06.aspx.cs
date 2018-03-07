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

public partial class background_surveyManage_Type06 : BasePage 
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
                }
            }

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

            if (!string.IsNullOrEmpty(lbReqId.Text))
            {
                strSql = "UPDATE T_SURVEYQUESTION SET TITLE='" + txtTitle.Text + "'  WHERE ID=" + lbReqId.Text;
            }
            else
            {
                int intIndex = int.Parse(createAction.getMaxIndex(lbSurId.Text));
                intIndex += 1;
                strSql = "INSERT INTO T_SURVEYQUESTION(ID,SURVEYID,QUESTIONID,TYPE,TITLE,ANSWER,ISTEXT) ";
                strSql += " VALUES(SEQ_T_SURVEYQUESTION.NEXTVAL," + lbSurId.Text + "," + intIndex + ",'06','" + txtTitle.Text + "','0','N')";
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
}
