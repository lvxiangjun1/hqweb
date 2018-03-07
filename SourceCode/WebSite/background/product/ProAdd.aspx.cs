using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Web.BusinessEntity;
using PersistenceLayer;
using Web.Common;
using Action_Log4Net;
using Web.LxjOnlineMarket;
using Web.BaseWeb;
public partial class background_product_ProAdd : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
            //产品类型
            this.ddlTITLECOLOR.DataSource = RentalHouse.GetSTONETYPE("ST_PROTYPE");
            this.ddlTITLECOLOR.DataTextField = "VVALUE";
            this.ddlTITLECOLOR.DataValueField = "CODE";
            this.ddlTITLECOLOR.DataBind();
            lbReqId.Value = UtFunction.GetInnerSnByType("SZ");
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            Transaction t = new Transaction();
            T_PRODUCTEntity Rehouse = new T_PRODUCTEntity();
            Rehouse.ID = Sequence.GetNextValue("SEQ_T_PRODUCT");
            Rehouse.PROID = lbReqId.Value;
            Rehouse.BAND = txtSUBTITLE.Text.Trim();
            Rehouse.PROTYPE = ddlTITLECOLOR.SelectedValue;
           
            Rehouse.INTRODUCE = txtINTRODUCE.Text.Trim();
            Rehouse.PRONAME = txtTITLE.Text.Trim();
            Rehouse.PROSTATUS = txtProstatus.Text.Trim(); 
            Rehouse.STATUS =0;
            Rehouse.MEMBERID = BaseUserName;
            Rehouse.INSERTTIME = DateTime.Now;
            t.AddSaveObject(Rehouse);
            if (t.Process())
            {
                Response.Redirect("ProList.aspx", false);
            }
            else
            {
                Response.Redirect("ShowCarResult.aspx?id=2", false);
                //  btnEdit.Enabled = true;
            }
        }
        catch (Exception ex)
        {
            SysLog.Error("onmarket_SECCARAdd.aspx.BtnAdd_Click:" + ex.Message);
            //  Response.Redirect("ShowResult.aspx?ID=2", false);
        }
    }

    public void MessageBox(String Str)
    {
        String scriptString = @"<script language=JavaScript>";
        scriptString += @"alert('" + Str + "');";
        scriptString += @"history.go(-1);";
        scriptString += @"<";
        scriptString += @"/";
        scriptString += @"script>";
        if (!Page.IsStartupScriptRegistered("Startup"))
            Page.RegisterStartupScript("Startup", scriptString);
    }

    protected void BtnUpload_Click(object sender, EventArgs e)
    {
        Random AA = new Random();
        string fullname = FileUpload.FileName.ToString();
        string fn = DateTime.Now.ToString("yyyyMMddHHmmss") + AA.Next(10000000);
        string typ2 = fullname.Substring(fullname.LastIndexOf(".") + 1);
        if (typ2 == "gif" || typ2 == "jpg" || typ2 == "bmp" || typ2 == "png")
        {
            FileUpload.SaveAs(Server.MapPath("~") + "\\uploadfile\\PictureSite\\" + fn + "." + typ2);
            string webFilePath = Server.MapPath("~") + "\\uploadfile\\PictureSite\\" + fn + "." + typ2;
            string webFilePath_s = Server.MapPath("~") + "\\uploadfile\\PictureSite\\SamllPicture\\" + fn + "." + typ2;
            string webFilePath_h = Server.MapPath("~") + "\\uploadfile\\PictureSite\\BigPicture\\" + fn + "." + typ2;

            MakeThumbnail(webFilePath, webFilePath_s, 35, 35, "Cut");
            MakeThumbnail(webFilePath, webFilePath_h, 620, 378, "Cut");
            //txtPicUrl.Text = fn + "." + typ2;
            ImageShow.Items.Add(fn + "." + typ2);
            //int hj=1;
            //ImageShow.Items[hj].Selected = true;
            ImageShow1.ImageUrl = SiteInfo.VirtualPath() + "\\uploadfile\\PictureSite\\" + fn + "." + typ2;

           T_PRODUCTPICEntity MT = new T_PRODUCTPICEntity();
            MT.ID = Sequence.GetNextValue("SEQ_T_PRODUCTPIC");
            MT.PROID= lbReqId.Value;
            //MT.SUBTITLE = txtPicUrl.Text;
            MT.PICURL = fn + "." + typ2;
            MT.ISTOP = Convert.ToDecimal(RadioFM.SelectedValue);
            MT.Save();
            BtnDelete.Visible = true;
        }
        else
        {

        }
    }

    public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
    {
        System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
        int towidth = width;
        int toheight = height;
        int x = 0;
        int y = 0;
        int ow = originalImage.Width;
        int oh = originalImage.Height;
        switch (mode)
        {
            case "HW"://指定高宽缩放（可能变形）                
                break;
            case "W"://指定宽，高按比例                    
                toheight = originalImage.Height * width / originalImage.Width;
                break;
            case "H"://指定高，宽按比例
                towidth = originalImage.Width * height / originalImage.Height;
                break;
            case "Cut"://指定高宽裁减（不变形）                
                if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                {
                    oh = originalImage.Height;
                    ow = originalImage.Height * towidth / toheight;
                    y = 0;
                    x = (originalImage.Width - ow) / 2;
                }
                else
                {
                    ow = originalImage.Width;
                    oh = originalImage.Width * height / towidth;
                    x = 0;
                    y = (originalImage.Height - oh) / 2;
                }
                break;
            default:
                break;
        }
        //新建一个bmp图片
        System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
        //新建一个画板
        System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
        //设置高质量插值法
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
        //设置高质量,低速度呈现平滑程度
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //清空画布并以透明背景色填充
        g.Clear(System.Drawing.Color.Transparent);
        //在指定位置并且按指定大小绘制原图片的指定部分
        g.DrawImage(originalImage, new System.Drawing.Rectangle(0, 0, towidth, toheight),
new System.Drawing.Rectangle(x, y, ow, oh),
System.Drawing.GraphicsUnit.Pixel);
        try
        {
            //以jpg格式保存缩略图
            bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        catch (System.Exception e)
        {
            throw e;
        }
        finally
        {
            originalImage.Dispose();
            bitmap.Dispose();
            g.Dispose();
        }
    }

    protected void ImageShow_SelectedIndexChanged(object sender, EventArgs e)
    {
        ImageShow1.ImageUrl = SiteInfo.VirtualPath() + "\\uploadfile\\PictureSite\\" + ImageShow.SelectedItem.Text;
        BtnDelete.Visible = true;
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "delete from T_PRODUCTPIC where PICURL='" + ImageShow.SelectedItem.Text + "'";
            int i = PersistenceLayer.Query.ProcessSqlNonQuery(sql, Names.DBName);
            if (i > 0)
            {
                ImageShow.Items.Remove(ImageShow.SelectedItem.Text);
                BtnDelete.Visible = false;
                ImageShow1.ImageUrl = "";
            }
            else
            {
                MessageBox("未找到图片");
            }
        }
        catch (Exception ex)
        {
            SysLog.Error("onmarket_SECCARAdd.aspx.BtnDelete_Click" + ex);
        }
    }

    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProList.aspx");
    }
}