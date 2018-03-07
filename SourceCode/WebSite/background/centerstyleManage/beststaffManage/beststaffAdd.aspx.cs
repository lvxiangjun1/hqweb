using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.Common;
using Web.BusinessEntity;
using PersistenceLayer;
using System.IO;
using Web.News;
public partial class background_centerstyleManage_beststaffManage_beststaffAdd : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Base b = new Base();
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "62"))
            {
                Response.Redirect("../../NoQx.aspx");
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        T_NEWSBASEEntity FM = new T_NEWSBASEEntity();
        FM.ID = Sequence.GetNextValue("SEQ_T_NEWSBASE");
        FM.NODEID = 62;
        FM.TITLE = txtTitle.Text;
        FM.SUBTITLE = txtSubTitle.Text;
        FM.DEFAULTPICURL = imgPicUrl.ImageUrl;
        FM.PUBLISHTIME = DateTime.Now;
        FM.USERNAME = BaseUserName;
        FM.INSERTTIME = DateTime.Now;
        FM.HITS = 0;
        FM.Save();
        Response.Redirect("beststaffList.aspx");
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
            string SavePath = Server.MapPath("~\\uploadfile\\img_beststaff"); //+ "/uploadfile/img_doctor"; ;//图片保存到文件夹下
            string attach_subdir = "day_" + DateTime.Now.ToString("yyMMdd");
            string attach_dir = SavePath + "/" + attach_subdir + "/";
            // 生成随机文件名
            Random random = new Random(DateTime.Now.Millisecond);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmss") + random.Next(10000) + extension;
            string target = attach_dir + filename;
            string filedir = System.Web.HttpContext.Current.Request.ApplicationPath + @"\uploadfile\img_beststaff\" + attach_subdir;
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
            string checkdir = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + @"uploadfile\img_beststaff\" + attach_subdir;
            checkdir = checkdir + "\\" + filename;
            if (!Names.IsImage(checkdir))
            {
                File.Delete(checkdir);
                MessageBox("请上传正确的图片文件！");
            }

            imgPicUrl.Visible = true;
            imgPicUrl.ImageUrl = filedir + "\\" + filename;//界面显示图片
        }
        else
        {
            MessageBox("请选择正确的图片文件！");
        }

    }
}