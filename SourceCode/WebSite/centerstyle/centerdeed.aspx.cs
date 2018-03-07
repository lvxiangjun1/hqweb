using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using System.Data;
using Web.Common;

public partial class centerstyle_centerdeed : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 recordcount;
        TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=8").ToString();
        footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
        centerstyleleftShow.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_中心风采左侧页面").ToString();
        hotnewShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_中心风采左侧列表", "NodeId=61", "startRow=0", "LastRowNum=10").ToString();
        NewsInfoBind();
    }

    private void NewsInfoBind()
    {
        Int32 recordcount = 0;
        Int32 startRow = (this.MyAspNetPager.CurrentPageIndex - 1) * this.MyAspNetPager.PageSize + 1;
        Int32 LastRowNum = startRow + this.MyAspNetPager.PageSize - 1;
        NewsShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_中心事迹一列式列表", "NodeId=61", "startRow=" + startRow, "LastRowNum=" + LastRowNum).ToString();
        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
    }

    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        NewsInfoBind();
    }
}