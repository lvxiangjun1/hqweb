using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Web.BusinessEntity;
using Web.News;
using Web.Common;
using System.Data;
using Web.BaseWeb;
public partial class background_product_ProSel : System.Web.UI.Page
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hidId.Value = Request.QueryString["id"];

            InitContent();
        }
    }
    private void InitContent()
    {
        try
        {
           
            T_PRODUCTEntity Rehouse = new T_PRODUCTEntity();
            Rehouse.ID = Convert.ToDecimal(hidId.Value);
            Rehouse.Retrieve();
            lbReqHuID.Value = Rehouse.PROID;
            txtSUBTITLE.Text = Rehouse.BAND;
            ddlTITLECOLOR.Text = Web.LxjOnlineMarket.RentalHouse.GetST_PROTYPE(Rehouse.PROTYPE); 
            txtProstatus.Text = Rehouse.PROSTATUS.ToString();
            txtTITLE.Text = Rehouse.PRONAME;
            txtINTRODUCE.Text = Rehouse.INTRODUCE.ToString();
           
            string PicSql = "select * from T_PRODUCTPIC where PROID='" + lbReqHuID.Value + "'";
            DataTable PicDt = PersistenceLayer.Query.ProcessSql(PicSql, Names.DBName);
            if (PicDt.Rows.Count > 0)
            {
                for (int i = 0; i < PicDt.Rows.Count; i++)
                {
                    ImageShow.Items.Add(PicDt.Rows[i]["PICURL"].ToString());
                }
                ImageShow.Items[0].Selected = true;
                ImageShow1.ImageUrl = SiteInfo.VirtualPath() + "\\uploadfile\\PictureSite\\" + ImageShow.SelectedItem.Text;
            } 
        }
        catch { }
    }
}