﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Web.BusinessEntity;
using Web.News;
using Web.Common;
using System.Text.RegularExpressions;
using System.IO;
public partial class Background_wlsp_wlAdd : BasePage
{
    Base b = new Base();
    bool result = false;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "13"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            txtPUBLISHTIME.Attributes.Add("onfocus", "WdatePicker({skin:'whyGreen',dateFmt:'yyyy-MM-dd HH:mm:ss'})");
            txtPUBLISHTIME.Text = DateTime.Now.ToString();
            
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {

        T_NEWSBASEEntity t = new T_NEWSBASEEntity();
        t.NODEID = 13;
        t.TITLE = Names.GetSingQuote(txtTITLE.Text);
        t.SUBTITLE = txtSUBTITLE.Text;
        t.CONTENT = Names.GetSingQuote(txtContent.Value);
        InfoStruct.LoginForm newloginform = new InfoStruct.LoginForm();
        newloginform = (InfoStruct.LoginForm)Session[Names.SessionManage];
        t.USERNAME = newloginform.userName;
        t.STATUS = 0;

        if (!string.IsNullOrEmpty(txtPUBLISHTIME.Text))
            t.PUBLISHTIME = Convert.ToDateTime(txtPUBLISHTIME.Text);
        List<string> lNAME = new List<string>();
        List<string> lVALUE = new List<string>();
        t.DEFAULTPICURL = txtDefaultPicUrl.Text.Trim();
        if (b.AddNews(t, lNAME, lVALUE))
        {
            MessageBox("提交成功！");
            Response.Redirect("wlList.aspx");
        }
        else
        {
            MessageBox("提交失败！");
        }

    }
    protected void btnCalcel_Click(object sender, EventArgs e)
    {
        Response.Redirect("wlList.aspx");
    }


    private void CreateFolder(string FolderPath)
    {
        if (!System.IO.Directory.Exists(FolderPath)) System.IO.Directory.CreateDirectory(FolderPath);
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {

        string FullName = FileUploadPicUrl.PostedFile.FileName;//获取图片物理地址
        FileInfo fi = new FileInfo(FullName);
        string name = fi.Name;//获取图片名称
        string extension = fi.Extension.ToLower();//获取图片类型
        if (extension == ".jpg" || extension == ".gif" || extension == ".bmp" || extension == ".png")
        {
            string SavePath = Server.MapPath("~\\uploadfile\\img_netclass"); //+ "/uploadfile/img_doctor"; ;//图片保存到文件夹下
            string attach_subdir = "day_" + DateTime.Now.ToString("yyMMdd");
            string attach_dir = SavePath + "/" + attach_subdir + "/";
            // 生成随机文件名
            Random random = new Random(DateTime.Now.Millisecond);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmss") + random.Next(10000) + extension;
            string target = attach_dir + filename;
            string filedir = System.Web.HttpContext.Current.Request.ApplicationPath + @"\uploadfile\img_netclass\" + attach_subdir;
            try
            {
                CreateFolder(attach_dir);

                FileUploadPicUrl.PostedFile.SaveAs(target);//保存路径
            }
            catch (Exception ex)
            {
                MessageBox(ex.Message);
                return;
            }
            string checkdir = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + @"uploadfile\img_netclass\" + attach_subdir;
            checkdir = checkdir + "\\" + filename;
            if (!Names.IsImage(checkdir))
            {
                File.Delete(checkdir);
                MessageBox("请上传正确的图片文件！");
            }

            txtDefaultPicUrl.Text = @"\uploadfile\img_netclass\" + attach_subdir + "\\" + filename;//界面显示图片
        }
        else
        {
            MessageBox("请选择正确的图片文件！");
        }
    }
}