using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using System.Data;
using Web.Common;
using Web.BusinessEntity;

public partial class centerstyle_processDetail : System.Web.UI.Page
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
                newstitle.InnerHtml = FM.TITLE;
                imgPicUrl.ImageUrl = FM.DEFAULTPICURL;
            }
        }
    }

}