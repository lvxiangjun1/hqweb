using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using Web.BusinessEntity;
using Web.Common;

public partial class generalweb_detail : System.Web.UI.Page
{
    public string nodename;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 recordcount;
        TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=1").ToString();
        footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
        //newsleftShow.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_新闻左侧页面").ToString();
        //hotnewShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_热点排行新闻列表", "NodeId=2", "startRow=0", "LastRowNum=10").ToString();
        NewsInfoBind();
    }

    private void NewsInfoBind()
    {
        string ID = Request.QueryString["ID"];
        int i = 0;
        if (int.TryParse(ID, out i))
        {
            T_NEWSBASEEntity FM = new T_NEWSBASEEntity();
            FM.ID = int.Parse(ID);
            FM.Retrieve();
            if (FM.IsPersistent)
            {
                newstitle.InnerHtml = "<span style='color:" + FM.TITLECOLOR + ";font-size:" + FM.TITLESIZE + "px;font-family:" + FM.TITLEFONT + "'>" + FM.TITLE + "</span>";
                if (!"".Equals(FM.SUBTITLE))
                {
                    newstitle.InnerHtml = newstitle.InnerHtml + "<BR>";
                    newstitle.InnerHtml = newstitle.InnerHtml + "<span style='color:" + FM.SUBTITLECOLOR + ";font-size:" + FM.SUBTITLESIZE + "px;font-family:" + FM.SUBTITLEFONT + "'>" + FM.SUBTITLE + "</span>";
                }
                nodename = WebFunction.GetNodeName(FM.NODEID.ToString());
                newsinfo.InnerHtml = "发布时间：" + FM.PUBLISHTIME.ToString() + " 文章来源：" + FM.COPYRIGHT + " 作者：" + FM.AUTHOR + " 点击数： " + FM.HITS.ToString();
                newscontent.InnerHtml = FM.CONTENT;
                FM.HITS = FM.HITS + 1;
                FM.Save();
            }
        }
    }
}