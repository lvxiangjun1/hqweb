using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.BaseWeb;
using Web.BusinessEntity;
using Web.Common;
using Web.LxjOnlineMarket;

public partial class productManage_productDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            Int32 recordcount;
            TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=1").ToString();
            footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
            helponlineleftShow.InnerHtml = BaseClass.ShowListLabelNoPageIn("Label=WEB_产品类型列表", "ServiceCode=001").ToString();
             
             NewsInfoBind();
        }
    }

    private void NewsInfoBind()
    {
        string ID = Request.QueryString["ID"];
        int i = 0;
        if (int.TryParse(ID, out i))
        {
            T_PRODUCTEntity FM = new T_PRODUCTEntity();
            FM.ID = int.Parse(ID);
            FM.Retrieve();
            if (FM.IsPersistent)
            {
                newstitle.InnerHtml = "<span style='color: #000000';font-size:18px;font-family:SimSun'>" + FM.PRONAME + "</span>";
                
                nodename.InnerText = FM.PRONAME;
                newsinfo.InnerHtml =  " 发布人：" + FM.MEMBERID + " 发布时间： " + FM.INSERTTIME.ToString() + " 点击率： " + FM.HITS.ToString();
                newsinfo1.InnerHtml = "产品品牌：" + FM.BAND.ToString() + "<br />" + " 产品类型：" + RentalHouse.GetST_PROTYPE(FM.PROTYPE) + "<br />";
                
                newscontent.InnerHtml = FM.INTRODUCE;
                FM.HITS = FM.HITS + 1;
                FM.Save();
            }

            string PicSql = "select * from T_PRODUCTPIC where PROID='" + FM.PROID + "'";
            DataTable PicDt = PersistenceLayer.Query.ProcessSql(PicSql, Names.DBName);
            if (PicDt.Rows.Count > 0)
            {
                for (int j = 0; j < PicDt.Rows.Count; j++)
                {
                    newsimage.InnerHtml += "<image src='" + SiteInfo.VirtualPath() + "\\uploadfile\\PictureSite\\" + PicDt.Rows[j]["PICURL"].ToString() + "' />";
               
                }
              }
        }
    }
}