using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.Common;
using Web.BusinessEntity;
using PersistenceLayer;
using Web.News;
public partial class background_adminManage_adminAdd : BasePage
{
    Base b = new Base();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "1"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            NodeBind();
            trNode.ExpandAll();
        }
    }

    #region  绑定栏目

    /// <summary>
    /// 绑定组织体系数据
    /// </summary>
    private void NodeBind()
    {
        TreeNode Node = new TreeNode();
        Node.Text = "网站栏目";
        Node.Value = "0";
        //Node.ImageUrl = "../../images/all_001666.jpg";
        Node.Target = "_parent";
        trNode.Nodes.Add(Node);
        Node.Expanded = false;
        AddTree("0", Node);
    }

    /// <summary>
    /// 递归添加树的节点
    /// </summary>
    /// <param name="pCode">父节点代码</param>
    /// <param name="pNode">父节点对象</param>
    public void AddTree(string pCode, TreeNode pNode)
    {
        DataTable dt = PersistenceLayer.Query.ProcessSql("SELECT * FROM T_NEWSNODE WHERE STATUS = 0 AND PARENTID = " + pNode.Value, Names.DBName);
        if (dt != null)
        {
            DataView dvTree = new DataView(dt);
            if (dvTree.Count > 0)
            {
                foreach (DataRowView row in dvTree)
                {
                    TreeNode Node = new TreeNode();
                    Node.Text = row["NODENAME"].ToString();
                    Node.Value = row["ID"].ToString();
                    //Node.ImageUrl = "../../images/all_0013456.jpg";
                    Node.Target = "_parent";
                    pNode.ChildNodes.Add(Node);
                    Node.Expanded = false;
                    //递归 
                    AddTree(Node.Value, Node);
                }
            }
        }
    }

    #endregion
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (ishasuser())
        {
            MessageBox("该用户名已经存在，请重新输入！");
            return;
        }
        if (!StringOperate.IsCheckEngNumUnderLine(txtUserName.Text.Trim()))
        {
            MessageBox("用户名需由字母、数字或下划线组成，请重新输入！");
            return;
        }
        T_WEBMANAGEEntity FM = new T_WEBMANAGEEntity();
        FM.ID = Sequence.GetNextValue("SEQ_T_WEBMANAGE");
        FM.USERNAME = txtUserName.Text.Trim();
        FM.PASSWORD = Names.EncryptPassword(txtPassword.Text.Trim());
        FM.TRUENAME = txtTrueName.Text.Trim();
        FM.TELEPHONE = txtTelephone.Text.Trim();
        FM.DEPT = txtDept.Text.Trim();
        FM.CREATETIME = DateTime.Now;
        FM.STATUS = 0;
        FM.Save();
        foreach (TreeNode n in trNode.Nodes)
        {
            if (n.Checked)
            {
                T_WEBMANAGEROLEEntity MT = new T_WEBMANAGEROLEEntity();
                MT.ID = Sequence.GetNextValue("SEQ_T_WEBMANAGEROLE");
                MT.USERNAME = FM.USERNAME;
                MT.NODEID = int.Parse(n.Value);
                MT.Save();
                GetParentID(FM.USERNAME, MT.NODEID.ToString());
            }
            DiGui(n, FM.USERNAME);
        }
        Response.Redirect("adminList.aspx");
    }

    private bool ishasuser()
    {
        string strSql = "SELECT ID FROM T_WEBMANAGE WHERE USERNAME = '" + txtUserName.Text.Trim() + "'";
        DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
        if (DT.Rows.Count > 0)
            return true;
        else
            return false;
    }

    private bool ishasrole(string nodeid)
    {
        string strSql = "SELECT ID FROM T_WEBMANAGEROLE WHERE USERNAME = '" + txtUserName.Text.Trim() + "' AND NODEID = " + nodeid;
        DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
        if (DT.Rows.Count > 0)
            return true;
        else
            return false;
    }


    private void GetParentID(string username, string nodeid)
    {
        string strSql = "SELECT PARENTID FROM T_NEWSNODE WHERE ID = " + nodeid;
        DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
        if (DT.Rows.Count > 0)
        {
            if (!ishasrole(DT.Rows[0][0].ToString()))
            {
                T_WEBMANAGEROLEEntity MT2 = new T_WEBMANAGEROLEEntity();
                MT2.ID = Sequence.GetNextValue("SEQ_T_WEBMANAGEROLE");
                MT2.USERNAME = username;
                MT2.NODEID = int.Parse(DT.Rows[0][0].ToString());
                MT2.Save();
            }
            GetParentID(username, DT.Rows[0][0].ToString());

        }
    }


    private void DiGui(TreeNode tn, string userName)
    {
        foreach (TreeNode tnSub in tn.ChildNodes)
        {
            if (tnSub.Checked)
            {
                T_WEBMANAGEROLEEntity MT = new T_WEBMANAGEROLEEntity();
                MT.ID = Sequence.GetNextValue("SEQ_T_WEBMANAGEROLE");
                MT.USERNAME = userName;
                MT.NODEID = int.Parse(tnSub.Value);
                MT.Save();
                GetParentID(userName, MT.NODEID.ToString());
            }
            DiGui(tnSub, userName);
        }
    }
}