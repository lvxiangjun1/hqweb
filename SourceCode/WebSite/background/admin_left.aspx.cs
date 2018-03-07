using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using PersistenceLayer;
using Web.Common;

public partial class Background_admin_left : BasePage
{

    StringBuilder appendTree = new StringBuilder();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //拼javascript
            appendTree.Append("<script type=\"text/javascript\">")
                .Append("d = new dTree('d');")
                .Append("d.add(0,-1,'网站管理');");

            CreateTree(0);

            appendTree.Append("document.write(d);")
                .Append("d.closeAll();")
                .Append("</script>");

            ltlTree.Text = appendTree.ToString();

            //ClientScript.RegisterStartupScript(this.GetType(),"key",appendTree.ToString());
        }

    }

    /// <summary>
    /// 递归添加树节点
    /// </summary>
    /// <param name="MenuParentID"></param>
    private void CreateTree(Int32 MenuParentID)
    {
        IList<TreeMenu> list = GetMenuByParentID(MenuParentID);
        for (Int32 i = 0; i < list.Count; i++)
        {
            appendTree.Append(String.Format("d.add({0},{1},'{2}','{3}','{2}','mainFrame');",
                list[i].ID, MenuParentID, list[i].MenuName, list[i].MenuClickURL));
            CreateTree(list[i].ID);
        }
    }

    private IList<TreeMenu> GetMenuByParentID(int MenuParentID)
    {
        string sqls="SELECT * FROM T_NEWSNODE T1,T_WEBMANAGEROLE T2 WHERE T1.ID = T2.NODEID AND T2.USERNAME = '" + BaseUserName + "' AND STATUS = 0 AND PARENTID = " + MenuParentID + " ORDER BY T1.ID ASC";
        DataTable dt = PersistenceLayer.Query.ProcessSql(sqls, Names.DBName);
        IList<TreeMenu> menu = new List<TreeMenu>();
        if (dt.Rows.Count > 0)
        {



            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    menu.Add(new TreeMenu()
                    {
                        ID = Int32.Parse(dr["ID"].ToString()),
                        ParentMenuID = Int32.Parse(dr["PARENTID"].ToString()),
                        MenuName = dr["NODENAME"].ToString(),
                        MenuClickURL = dr["WEBURL"].ToString()
                    });
                }
            }
        }

        return menu;

    }

    protected override void OnPreInit(EventArgs e)
    {
        base.OnPreInit(e);
        //显示正在加载数据的提示
        Response.Write("<img src=\"Images/Loading/loading01.gif\" id=\"imgLoading\" alt=\"数据加载中\" />");
    }


}