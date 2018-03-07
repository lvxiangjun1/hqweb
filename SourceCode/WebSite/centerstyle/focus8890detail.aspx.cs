using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using Web.BusinessEntity;

public partial class centerstyle_focus8890detail : System.Web.UI.Page
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
        string ID = Request.QueryString["ID"];
        int i = 0;
        if (int.TryParse(ID, out i))
        {
            T_NEWSBASEEntity FM = new T_NEWSBASEEntity();
            FM.ID = int.Parse(ID);
            FM.Retrieve();
            if (FM.IsPersistent)
            {
                newstitle.InnerHtml = "<font color='" + FM.TITLECOLOR + "' size='" + FM.TITLESIZE + "' face='" + FM.TITLEFONT + "'>" + FM.TITLE + "</font>";
                if (!"".Equals(FM.SUBTITLE))
                {
                    newstitle.InnerHtml = newstitle.InnerHtml + "<BR>";
                    newstitle.InnerHtml = newstitle.InnerHtml + "<font color='" + FM.SUBTITLECOLOR + "' size='" + FM.SUBTITLESIZE + "' face='" + FM.SUBTITLEFONT + "'>" + FM.SUBTITLE + "</font>";
                }
                //newsinfo.InnerHtml = "发布时间：" + FM.PUBLISHTIME.ToString() + " 文章来源：" + FM.COPYRIGHT + " 作者：" + FM.AUTHOR + " 点击数： " + FM.HITS.ToString();
                newscontent.InnerHtml = FM.CONTENT;
                FM.HITS = FM.HITS + 1;
                FM.Save();
            }
        }
    }
}