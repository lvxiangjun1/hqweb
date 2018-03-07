using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using Web.BaseWeb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Int32 recordcount;
            TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=0").ToString();
            footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
            QjNewShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_首页新闻列表", "NodeId=3", "startRow=0", "LastRowNum=3").ToString();
      
            //产品展示
          //  HotPicShow.InnerHtml = ContentsList.GetPicShow("2", "5", 20, "290", "242", "ID", "Desc").ToString();

        }

    }
}