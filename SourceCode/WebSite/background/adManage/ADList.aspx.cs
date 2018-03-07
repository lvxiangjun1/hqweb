using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PersistenceLayer;
using Web.Common;
using System.Data;
using Web.News;
using System.IO;
using Web.BaseWeb;

public partial class background_ADManage_ADList : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Base b = new Base();
        if (!Page.IsPostBack)
        {
            if (!b.IsNewsQX(BaseUserName, "77"))
            {
                Response.Redirect("../NoQx.aspx");
            }
            GridViewDataBind();
            //AD_DIV.InnerHtml = BaseAD.getADList();
        }
    }
    private void GridViewDataBind()
    {
        MyAspNetPager.PageSize = 18;
        Int32 recordcount;
        string sql = "SELECT * FROM T_ADVERTISMENT WHERE ISDELETE='N' ";
        if (!string.IsNullOrEmpty(txtTITLE.Text))
            sql += " AND TITLE LIKE '%" + txtTITLE.Text + "%'";
        if (ddlADVTYPE.SelectedValue != "00")
            sql += " AND ADVTYPE LIKE '%" + ddlADVTYPE.SelectedValue + "%'";
        if (ddlPOSITION.SelectedValue != "00")
            sql += " AND POSITION LIKE '%" + ddlPOSITION.SelectedValue + "%'";
        sql += " ORDER BY ID DESC";

        DataTable DT = Pages.GetPage(sql, MyAspNetPager.CurrentPageIndex, MyAspNetPager.PageSize, out recordcount);
        GridViewNews.DataSource = DT;
        GridViewNews.DataBind();

        this.MyAspNetPager.RecordCount = recordcount;
        MyAspNetPager.TextBeforeInputBox = "共" + this.MyAspNetPager.RecordCount + "条  转到第";
        MyAspNetPager.TextAfterInputBox = "页";
        this.lblRecordCount.Text = recordcount.ToString();
        this.lblPageSize.Text = MyAspNetPager.CurrentPageIndex.ToString();
    }
    protected void GridViewNews_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;
            if ("1".Equals(drv.Row["ADVTYPE"].ToString()))
                e.Row.Cells[4].Text = "飘动";
            else
                e.Row.Cells[4].Text = "侧边";
            if ("1".Equals(drv.Row["POSITION"].ToString()))
                e.Row.Cells[5].Text = "左边";
            else
                e.Row.Cells[5].Text = "右边";

        }
    }
    protected void MyAspNetPager_PageChanged(object sender, EventArgs e)
    {
        GridViewDataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("ADAdd.aspx");
    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        this.MyAspNetPager.CurrentPageIndex = 0;
        GridViewDataBind();
    }
    protected void LinkBtnEdit_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();
        Response.Redirect("ADEdit.aspx?ID=" + id);
    }
    protected void BtnDelete_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();

        if (BaseAD.DelAD(id,BaseUserName))
        {
            MessageBox("删除成功！");
        }
        else {
            MessageBox("删除失败！");
        }

        GridViewDataBind();
    }
    protected void LinkBtnSel_Click(object sender, ImageClickEventArgs e)
    {
        GridViewRow rows = (GridViewRow)((Control)sender).Parent.Parent;
        string id = GridViewNews.DataKeys[rows.RowIndex].Values["ID"].ToString();
        RunJs("window.open('ADSel.aspx?ID=" + id + "')");
    }

    protected void btnCreateJS_Click(object sender, EventArgs e)
    {
        try
        {
            string sql = "SELECT * FROM T_ADVERTISMENT WHERE ISDELETE='N'";
            DataTable DT = Query.ProcessSql(sql, Names.DBName);
            string strR = "";
            string strA = "";
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                strR = "";
                strA = DT.Rows[i]["WEBURL"].ToString();
                if (string.IsNullOrEmpty(strA))
                {
                    strA = "javascript:void(0)";
                }

                strR += "<a href=\"" + strA + "\" target=\"_blank\" title=\"" + DT.Rows[i]["INTRODUCE"].ToString() + "\" ><img src=\"" + BaseClass.VirtualPath1() + DT.Rows[i]["PICURL"].ToString() + "\" width=\"" + DT.Rows[i]["PICWIDTH"].ToString() + "\" height=\"" + DT.Rows[i]["PICHEIGHT"].ToString() + "\" border=\"0\"></a>";
                string spath = Server.MapPath("~") + "\\UploadFiles\\ADJS\\";
                if (!Directory.Exists(spath))
                {
                    Directory.CreateDirectory(spath);
                }
                strR += "<div  title=\"关闭飘浮窗\" onclick=\"document.getElementById(\\'ad_" + DT.Rows[i]["ID"] + "\\').style.display=\\'none\\'\" style=\"color: #FC0000;font-size: 24px;line-height: 16px;font-weight: 400;position: absolute;right: 2px;text-align: center;cursor: pointer;margin: 0;padding: 0;background: rgb(253, 212, 48);border-radius: 3px;margin-top: -18px;\">×</div>";
                StreamWriter sr = File.CreateText(spath + "ad_" + DT.Rows[i]["ID"] + ".js");
                if (DT.Rows[i]["ADVTYPE"].ToString() == "2")
                {
                    sr.WriteLine("var browser" + DT.Rows[i]["ID"] + "={ie6:function(){return((window.XMLHttpRequest==undefined)&&(ActiveXObject!=undefined))},getWindow:function(){var myHeight=0;var myWidth=0;if(typeof(window.innerWidth)=='number'){myHeight=window.innerHeight;myWidth=window.innerWidth}else if(document.documentElement){myHeight=document.documentElement.clientHeight;myWidth=document.documentElement.clientWidth}else if(document.body){myHeight=document.body.clientHeight;myWidth=document.body.clientWidth}return{'height':myHeight,'width':myWidth}},getScroll:function(){var myHeight=0;var myWidth=0;if(typeof(window.pageYOffset)=='number'){myHeight=window.pageYOffset;myWidth=window.pageXOffset}else if(document.documentElement){myHeight=document.documentElement.scrollTop;myWidth=document.documentElement.scrollLeft}else if(document.body){myHeight=document.body.scrollTop;myWidth=document.body.scrollLeft}return{'height':myHeight,'width':myWidth}},getDocWidth:function(D){if(!D)var D=document;return Math.max(Math.max(D.body.scrollWidth,D.documentElement.scrollWidth),Math.max(D.body.offsetWidth,D.documentElement.offsetWidth),Math.max(D.body.clientWidth,D.documentElement.clientWidth))},getDocHeight:function(D){if(!D)var D=document;return Math.max(Math.max(D.body.scrollHeight,D.documentElement.scrollHeight),Math.max(D.body.offsetHeight,D.documentElement.offsetHeight),Math.max(D.body.clientHeight,D.documentElement.clientHeight))}};var dom" + DT.Rows[i]["ID"] + "={ID:function(id){var type=typeof(id);if(type=='object')return id;if(type=='string')return document.getElementById(id);return null},insertHtml:function(html){var frag=document.createDocumentFragment();var div=document.createElement(\"div\");div.innerHTML=html;for(var i=0,ii=div.childNodes.length;i<ii;i++){frag.appendChild(div.childNodes[i])}document.body.insertBefore(frag,document.body.firstChild)}};var myEvent={add:function(element,type,handler){var ele=dom" + DT.Rows[i]["ID"] + ".ID(element);if(!ele)return;if(ele.addEventListener)ele.addEventListener(type,handler,false);else if(ele.attachEvent)ele.attachEvent(\"on\"+type,handler);else ele[\"on\"+type]=handler},remove:function(element,type,handler){var ele=dom" + DT.Rows[i]["ID"] + ".ID(element);if(!ele)return;if(ele.removeEventListener)ele.removeEventListener(type,handler,false);else if(ele.detachEvent)ele.detachEvent(\"on\"+type,handler);else ele[\"on\"+type]=null}};var position" + DT.Rows[i]["ID"] + "={rightCenter:function(id){var id=dom" + DT.Rows[i]["ID"] + ".ID(id);var ie6=browser" + DT.Rows[i]["ID"] + ".ie6();var win=browser" + DT.Rows[i]["ID"] + ".getWindow();var ele={'height':id.clientHeight,'width':id.clientWidth};if(ie6){var scrollBar=browser" + DT.Rows[i]["ID"] + ".getScroll()}else{var scrollBar={'height':0,'width':0};id.style.position='fixed'}ele.top=" + DT.Rows[i]["TOPPIX"] + ";id.style.top=ele.top+'px';id.style.right='3px'},floatRightCenter:function(id){position" + DT.Rows[i]["ID"] + ".rightCenter(id);var fun=function(){position" + DT.Rows[i]["ID"] + ".rightCenter(id)};if(browser" + DT.Rows[i]["ID"] + ".ie6()){myEvent.add(window,'scroll',fun);myEvent.add(window,'resize',fun)}else{myEvent.add(window,'resize',fun)}},leftCenter:function(id){var id=dom" + DT.Rows[i]["ID"] + ".ID(id);var ie6=browser" + DT.Rows[i]["ID"] + ".ie6();var win=browser" + DT.Rows[i]["ID"] + ".getWindow();var ele={'height':id.clientHeight,'width':id.clientWidth};if(ie6){var scrollBar=browser" + DT.Rows[i]["ID"] + ".getScroll()}else{var scrollBar={'height':0,'width':0};id.style.position='fixed'}ele.top=parseInt((win.height-ele.height)/2+scrollBar.height);id.style.top=ele.top+'px';id.style.left='3px'},floatLeftCenter:function(id){position" + DT.Rows[i]["ID"] + ".leftCenter(id);var fun=function(){position" + DT.Rows[i]["ID"] + ".leftCenter(id)};if(browser" + DT.Rows[i]["ID"] + ".ie6()){myEvent.add(window,'scroll',fun);myEvent.add(window,'resize',fun)}else{myEvent.add(window,'resize',fun)}}};");

                    sr.WriteLine("function ad_" + DT.Rows[i]["ID"] + "(){var html;html = '<div id=\"ad_" + DT.Rows[i]["ID"] + "\" style=\"z-index: 9999; width:" + DT.Rows[i]["PICWIDTH"] + "px; position: fixed; " + (DT.Rows[i]["POSITION"].ToString() == "1" ? "left" : "right") + ": 5px;text-align:right;\">" + strR + "</div>'; dom" + DT.Rows[i]["ID"] + ".insertHtml(html);position" + DT.Rows[i]["ID"] + ".floatRightCenter('ad_" + DT.Rows[i]["ID"] + "');}");

                    sr.WriteLine("myEvent.add(window,'load',ad_" + DT.Rows[i]["ID"] + ");");
                }
                else
                {
                    strR = "var html;html = \'<div id=\"ad_" + DT.Rows[i]["ID"] + "\" style=\"z-index: 9999; width:" + DT.Rows[i]["PICWIDTH"] + "px; position: fixed; " + (DT.Rows[i]["POSITION"].ToString() == "1" ? "left" : "right") + ": 5px;text-align:right;\">" + strR + "</div><script type=\"text/javascript\">var ggRoll" + DT.Rows[i]["ID"] + "={roll:document.getElementById(\"ad_" + DT.Rows[i]["ID"] + "\"),speed: 20, statusX: 1, statusY: 1, x: 100, y: " + DT.Rows[i]["ID"] + ", winW: document.documentElement.clientWidth - document.getElementById(\"ad_" + DT.Rows[i]["ID"] + "\").offsetWidth, winH: document.documentElement.clientHeight - document.getElementById(\"ad_" + DT.Rows[i]["ID"] + "\").offsetHeight, Go: function () { this.roll.style.left = this.x + \"px\"; this.roll.style.top = this.y + \"px\"; this.x = this.x + (this.statusX ? -1 : 1); if (this.x < 0) { this.statusX = 0 } if (this.x > this.winW) { this.statusX = 1 } this.y = this.y + (this.statusY ? -1 : 1); if (this.y < 0) { this.statusY = 0 } if (this.y > this.winH) { this.statusY = 1 } } }; var interval" + DT.Rows[i]["ID"] + " = setInterval(\"ggRoll" + DT.Rows[i]["ID"] + ".Go()\", ggRoll" + DT.Rows[i]["ID"] + ".speed); ggRoll" + DT.Rows[i]["ID"] + ".roll.onmouseover = function () { clearInterval(interval" + DT.Rows[i]["ID"] + ") }; ggRoll" + DT.Rows[i]["ID"] + ".roll.onmouseout = function () { interval" + DT.Rows[i]["ID"] + " = setInterval(\"ggRoll" + DT.Rows[i]["ID"] + ".Go()\", ggRoll" + DT.Rows[i]["ID"] + ".speed)};</script>\';document.write(html);";
                    
                    sr.WriteLine(strR);
                }
                sr.Close();
            }


            MessageBox("飘窗代码生成成功！");
        }
        catch { MessageBox("飘窗代码生成失败(>_<)！"); }
    }

    public string getSubstr(string s, int length)
    {
        byte[] bytes = System.Text.Encoding.Unicode.GetBytes(s);
        int n = 0;
        int i = 0;
        for (; i < bytes.GetLength(0) && n < length; i++)
        {
            if (i % 2 == 0)
            {
                n++;
            }
            else
            {
                if (bytes[i] > 0)
                {
                    n++;
                }
            }
        }
        if (i % 2 == 1)
        {
            if (bytes[i] > 0)
                i = i - 1;
            else
                i = i + 1;
        }
        return System.Text.Encoding.Unicode.GetString(bytes, 0, i);
    }
}