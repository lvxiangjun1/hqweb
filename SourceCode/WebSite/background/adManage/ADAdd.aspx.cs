using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersistenceLayer;
using System.Data;
using System.IO;
using Web.News;
using Web.BusinessEntity;
using Web.Common;
using Web.BaseWeb;

public partial class background_ADManage_ADAdd : BasePage
{

    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "77"))
            {
                Response.Redirect("../NoQx.aspx");
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try{
        string TITLE = Names.GetSingQuote(txtTITLE.Text);
        string INTRODUCE = Names.GetSingQuote(txtINTRODUCE.Text);
        string PICURL = Names.GetSingQuote(txtPicPath.Text);
        decimal PICWIDTH = Convert.ToDecimal(Names.GetSingQuote(txtPICWIDTH.Text));
        decimal PICHEIGHT = Convert.ToDecimal(Names.GetSingQuote(txtPICHEIGHT.Text));
        string WEBURL = Names.GetSingQuote(txtWEBURL.Text);
        InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
        newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
        string USERNAME = newloginform.userName;
        decimal ADVTYPE = Convert.ToDecimal(Names.GetSingQuote(ddlADVTYPE.SelectedValue));
        decimal POSITION = Convert.ToDecimal(Names.GetSingQuote(ddlPOSITION.SelectedValue));
        decimal TOPPIX = Convert.ToDecimal(Names.GetSingQuote(txtTOPPIX.Text));
        string sql = "insert into T_ADVERTISMENT(ID,TITLE,INTRODUCE,PICURL,PICWIDTH,PICHEIGHT,WEBURL,USERNAME,INSERTTIME,ISDELETE,DELETETIME,DELETENAME,ADVTYPE,POSITION,TOPPIX) values(" + Sequence.GetNextValue("SEQ_T_ADVERTISMENT").ToString() + ",'" + TITLE + "','" + INTRODUCE + "','" + PICURL + "'," + PICWIDTH + "," + PICHEIGHT + ",'" + WEBURL + "','" + USERNAME + "',sysdate,'N','',''," + ADVTYPE + ", " + POSITION + "," + TOPPIX + ")";
        if (Query.ProcessSqlNonQuery(sql, Names.DBName) > 0)
        {
            MessageBox("提交成功！");
            Response.Redirect("ADList.aspx");
        }
        else {
            MessageBox("提交失败！");
        }
        }catch{
            MessageBox("提交失败！");
        }

    }
    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ADList.aspx");
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        Random AA = new Random();
        string fullname = uploadDefaultPic.FileName.ToString();
        string fn = DateTime.Now.ToString("yyyyMMddHHmmss") + AA.Next(10000000);
        string typ2 = fullname.Substring(fullname.LastIndexOf(".") + 1);
        if (typ2 == "gif" || typ2 == "jpg" || typ2 == "bmp" || typ2 == "png")
        {
            string spath = Server.MapPath("~") + "\\UploadFiles\\ADPhoto\\";
            if (!Directory.Exists(spath))
            {
                Directory.CreateDirectory(spath);
            }
            uploadDefaultPic.SaveAs(spath + fn + "." + typ2);
            txtPicPath.Text = "/UploadFiles/ADPhoto/" + fn + "." + typ2;
            PhotoView.ImageUrl = "../../UploadFiles/ADPhoto/" + fn + "." + typ2;
        }
        else
        {
            MessageBox("请确认图片格式为“jpg、gif、png”之一");
        }
    }

}