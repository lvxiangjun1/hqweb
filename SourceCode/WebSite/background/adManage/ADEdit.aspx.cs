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

public partial class background_ADManage_ADEdit : BasePage
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
            string id = Names.GetSingQuote(Request.QueryString["ID"].ToString());
            bindInfo(int.Parse(id));
        }
    }

    protected void bindInfo(int id)
    {
        try
        {
            string sql = "select * from T_ADVERTISMENT where ID="+id;
            DataTable dt = Query.ProcessSql(sql,Names.DBName);
            if (dt.Rows.Count > 0)
            {
                string TITLE = Names.GetSingQuote(txtTITLE.Text);
                txtTITLE.Text = dt.Rows[0]["TITLE"].ToString();
                txtINTRODUCE.Text = dt.Rows[0]["INTRODUCE"].ToString();
                txtPicPath.Text = dt.Rows[0]["PICURL"].ToString();
                PhotoView.ImageUrl = "../.." + dt.Rows[0]["PICURL"].ToString();
                txtPICWIDTH.Text = dt.Rows[0]["PICWIDTH"].ToString();
                txtPICHEIGHT.Text = dt.Rows[0]["PICHEIGHT"].ToString();
                txtWEBURL.Text = dt.Rows[0]["WEBURL"].ToString();
                ddlADVTYPE.SelectedValue = dt.Rows[0]["ADVTYPE"].ToString();
                ddlPOSITION.SelectedValue = dt.Rows[0]["POSITION"].ToString();
                txtTOPPIX.Text = dt.Rows[0]["TOPPIX"].ToString();
                hdID.Value = id.ToString();
                
            }
            else {
                MessageBox("获取数据失败！");
                Response.Redirect("ADList.aspx");
            }
        }
        catch
        {
            MessageBox("获取数据失败！");
            Response.Redirect("ADList.aspx");
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
        string sql = "update T_ADVERTISMENT set  TITLE='" + TITLE + "',INTRODUCE='" + INTRODUCE + "',PICURL='" + PICURL + "',PICWIDTH=" + PICWIDTH + ",PICHEIGHT=" + PICHEIGHT + ",WEBURL='" + WEBURL + "',USERNAME='" + USERNAME + "',ADVTYPE=" + ADVTYPE + ",POSITION=" + POSITION + ",TOPPIX=" + TOPPIX + " where ID =" + hdID.Value;
        if (Query.ProcessSqlNonQuery(sql, Names.DBName) > 0)
        {
            MessageBox("修改成功！");
            Response.Redirect("ADList.aspx");
        }
        else {
            MessageBox("修改失败！");
        }
        }catch{
            MessageBox("修改失败！");
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