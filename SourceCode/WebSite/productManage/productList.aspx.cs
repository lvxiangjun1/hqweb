using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.BaseWeb;
using Web.Common;
using Web.LxjOnlineMarket;

public partial class productManage_productList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {

                Int32 recordcount;
                TopHtml.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站顶部", "curr=6").ToString();
                footor.InnerHtml = BaseClass.ShowStaticLabel("Label=WEB_网站底部").ToString();
                helponlineleftShow.InnerHtml = BaseClass.ShowListLabelNoPageIn("Label=WEB_产品类型列表", "ServiceCode=001").ToString();
             

                if (Request.QueryString["PROID"] != null)
                {

                    string strCategoryID = Request.QueryString["PROID"].Trim();
                    if (strCategoryID != "" && !SQLToolAction.SQLValidateCheck(strCategoryID) && SQLToolAction.IsNum(strCategoryID))
                    {
                        hidproid.Value = strCategoryID;
                        lbName.InnerText = RentalHouse.GetST_PROTYPE(hidproid.Value);
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script type='text/JavaScript'>alert('传入参数异常！');history.back(-1);</script>");
                    }
                }
                else
                {
                    lbName.InnerText = "全部类型";
                }
                HelpOnlineBind();
            }
            catch (Exception EX)
            {

                throw;
            }
        }
    }

    private void HelpOnlineBind()
    {

        Int32 recordcount = 0;
        Int32 startRow = (this.MyAspNetPager.CurrentPageIndex - 1) * this.MyAspNetPager.PageSize + 1;
        Int32 LastRowNum = startRow + this.MyAspNetPager.PageSize - 1;
        if (hidproid.Value != "")
        {
            helponlineShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_产品中心一列式列表", "PROID=" + hidproid.Value, "startRow=" + startRow, "LastRowNum=" + LastRowNum).ToString();
        }
        else
        {
            helponlineShow.InnerHtml = BaseClass.ShowListLabel(out recordcount, "Label=WEB_产品中心所有一列式列表", "startRow=" + startRow, "LastRowNum=" + LastRowNum).ToString();

        }
        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
    }

    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        HelpOnlineBind();
    }




}