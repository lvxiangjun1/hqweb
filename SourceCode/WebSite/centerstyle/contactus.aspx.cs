using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using System.Data;
using Web.Common;

public partial class centerstyle_contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 recordcount;
        TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=8").ToString();
        footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
       // centerstyleleftShow.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_中心风采左侧页面").ToString();
      //  hotnewShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_热点排行新闻列表", "NodeId=9", "startRow=0", "LastRowNum=10").ToString();
        NewsInfoBind();
    }

    private void NewsInfoBind()
    {
        string ID = Request.QueryString["ID"];
        string strSql = "SELECT * FROM T_WEBINFO WHERE ID = 8";
        DataTable DT = PersistenceLayer.Query.ProcessSql(strSql, Names.DBName);
        if (DT.Rows.Count > 0)
        {
            newstitle.InnerHtml = DT.Rows[0]["TITLE"].ToString();
            newscontent.InnerHtml = DT.Rows[0]["CONTENT"].ToString();
        }
    }
}