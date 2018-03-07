using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using Web.Common;

public partial class news_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 recordcount;
        TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=1").ToString();
        footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
        newsleftShow.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_新闻左侧页面").ToString();
        hotnewShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_热点排行新闻列表", "NodeId=3", "startRow=0", "LastRowNum=10").ToString();
        
        NewsBind(); 
        string ID = Request.QueryString["NODEID"];
        if ("".Equals(ID) || ID == null)
            ID = "3";
        int i = 0;
        if (int.TryParse(ID, out i))
        {
            nodename.InnerText = WebFunction.GetNodeName(ID);
        }
    }

    private void NewsBind()
    {
        string ID = Request.QueryString["NODEID"];
        if ("".Equals(ID) || ID == null)
            ID = "3";
        int i = 0;
        if (int.TryParse(ID, out i))
        {
            Int32 recordcount = 0;
            Int32 startRow = (this.MyAspNetPager.CurrentPageIndex - 1) * this.MyAspNetPager.PageSize + 1;
            Int32 LastRowNum = startRow + this.MyAspNetPager.PageSize - 1;
            NewsShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_中心新闻一列式列表", "NodeId=" + ID, "startRow=" + startRow, "LastRowNum=" + LastRowNum).ToString();
            this.MyAspNetPager.RecordCount = recordcount;
            MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
            MyAspNetPager.TextAfterInputBox = "页";
        }
    }

    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        NewsBind();
    }
}