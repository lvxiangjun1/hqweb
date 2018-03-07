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

public partial class background_ADManage_ADSel : BasePage
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
            string sql = "select * from T_ADVERTISMENT where ID=" + id;
            DataTable DT = Query.ProcessSql(sql, Names.DBName);
            string strR = "";
            string strA = "";
            if (DT.Rows.Count > 0)
            {
                strR = "";
                strA = DT.Rows[0]["WEBURL"].ToString();
                if (string.IsNullOrEmpty(strA))
                {
                    strA = "javascript:void(0)";
                }

                strR += "<a href=\"" + strA + "\" target=\"_blank\" title=\"" + DT.Rows[0]["INTRODUCE"].ToString() + "\" ><img src=\"" + BaseClass.VirtualPath1() + DT.Rows[0]["PICURL"].ToString() + "\" width=\"" + DT.Rows[0]["PICWIDTH"].ToString() + "\" height=\"" + DT.Rows[0]["PICHEIGHT"].ToString() + "\" border=\"0\"></a>";
                string spath = Server.MapPath("~") + "\\UploadFiles\\ADJS\\Rel\\";
                if (!Directory.Exists(spath))
                {
                    Directory.CreateDirectory(spath);
                }
                strR += "<div  title=\"关闭飘浮窗\" onclick=\"document.getElementById(\\'ad_" + DT.Rows[0]["ID"] + "\\').style.display=\\'none\\'\" style=\"color: #FC0000;font-size: 24px;line-height: 16px;font-weight: 400;position: absolute;right: 2px;text-align: center;cursor: pointer;margin: 0;padding: 0;background: rgb(253, 212, 48);border-radius: 3px;margin-top: -18px;\">×</div>";
                StreamWriter sr = File.CreateText(spath + "ad_" + DT.Rows[0]["ID"] + ".js");
                if (DT.Rows[0]["ADVTYPE"].ToString() == "2")
                {
                    sr.WriteLine("var browser" + DT.Rows[0]["ID"] + "={ie6:function(){return((window.XMLHttpRequest==undefined)&&(ActiveXObject!=undefined))},getWindow:function(){var myHeight=0;var myWidth=0;if(typeof(window.innerWidth)=='number'){myHeight=window.innerHeight;myWidth=window.innerWidth}else if(document.documentElement){myHeight=document.documentElement.clientHeight;myWidth=document.documentElement.clientWidth}else if(document.body){myHeight=document.body.clientHeight;myWidth=document.body.clientWidth}return{'height':myHeight,'width':myWidth}},getScroll:function(){var myHeight=0;var myWidth=0;if(typeof(window.pageYOffset)=='number'){myHeight=window.pageYOffset;myWidth=window.pageXOffset}else if(document.documentElement){myHeight=document.documentElement.scrollTop;myWidth=document.documentElement.scrollLeft}else if(document.body){myHeight=document.body.scrollTop;myWidth=document.body.scrollLeft}return{'height':myHeight,'width':myWidth}},getDocWidth:function(D){if(!D)var D=document;return Math.max(Math.max(D.body.scrollWidth,D.documentElement.scrollWidth),Math.max(D.body.offsetWidth,D.documentElement.offsetWidth),Math.max(D.body.clientWidth,D.documentElement.clientWidth))},getDocHeight:function(D){if(!D)var D=document;return Math.max(Math.max(D.body.scrollHeight,D.documentElement.scrollHeight),Math.max(D.body.offsetHeight,D.documentElement.offsetHeight),Math.max(D.body.clientHeight,D.documentElement.clientHeight))}};var dom" + DT.Rows[0]["ID"] + "={ID:function(id){var type=typeof(id);if(type=='object')return id;if(type=='string')return document.getElementById(id);return null},insertHtml:function(html){var frag=document.createDocumentFragment();var div=document.createElement(\"div\");div.innerHTML=html;for(var i=0,ii=div.childNodes.length;i<ii;i++){frag.appendChild(div.childNodes[0])}document.body.insertBefore(frag,document.body.firstChild)}};var myEvent={add:function(element,type,handler){var ele=dom" + DT.Rows[0]["ID"] + ".ID(element);if(!ele)return;if(ele.addEventListener)ele.addEventListener(type,handler,false);else if(ele.attachEvent)ele.attachEvent(\"on\"+type,handler);else ele[\"on\"+type]=handler},remove:function(element,type,handler){var ele=dom" + DT.Rows[0]["ID"] + ".ID(element);if(!ele)return;if(ele.removeEventListener)ele.removeEventListener(type,handler,false);else if(ele.detachEvent)ele.detachEvent(\"on\"+type,handler);else ele[\"on\"+type]=null}};var position" + DT.Rows[0]["ID"] + "={rightCenter:function(id){var id=dom" + DT.Rows[0]["ID"] + ".ID(id);var ie6=browser" + DT.Rows[0]["ID"] + ".ie6();var win=browser" + DT.Rows[0]["ID"] + ".getWindow();var ele={'height':id.clientHeight,'width':id.clientWidth};if(ie6){var scrollBar=browser" + DT.Rows[0]["ID"] + ".getScroll()}else{var scrollBar={'height':0,'width':0};id.style.position='fixed'}ele.top=" + DT.Rows[0]["TOPPIX"] + ";id.style.top=ele.top+'px';id.style.right='3px'},floatRightCenter:function(id){position" + DT.Rows[0]["ID"] + ".rightCenter(id);var fun=function(){position" + DT.Rows[0]["ID"] + ".rightCenter(id)};if(browser" + DT.Rows[0]["ID"] + ".ie6()){myEvent.add(window,'scroll',fun);myEvent.add(window,'resize',fun)}else{myEvent.add(window,'resize',fun)}},leftCenter:function(id){var id=dom" + DT.Rows[0]["ID"] + ".ID(id);var ie6=browser" + DT.Rows[0]["ID"] + ".ie6();var win=browser" + DT.Rows[0]["ID"] + ".getWindow();var ele={'height':id.clientHeight,'width':id.clientWidth};if(ie6){var scrollBar=browser" + DT.Rows[0]["ID"] + ".getScroll()}else{var scrollBar={'height':0,'width':0};id.style.position='fixed'}ele.top=parseInt((win.height-ele.height)/2+scrollBar.height);id.style.top=ele.top+'px';id.style.left='3px'},floatLeftCenter:function(id){position" + DT.Rows[0]["ID"] + ".leftCenter(id);var fun=function(){position" + DT.Rows[0]["ID"] + ".leftCenter(id)};if(browser" + DT.Rows[0]["ID"] + ".ie6()){myEvent.add(window,'scroll',fun);myEvent.add(window,'resize',fun)}else{myEvent.add(window,'resize',fun)}}};");

                    sr.WriteLine("function ad_" + DT.Rows[0]["ID"] + "(){var html;html = '<div id=\"ad_" + DT.Rows[0]["ID"] + "\" style=\"z-index: 9999; width:" + DT.Rows[0]["PICWIDTH"] + "px; position: fixed; " + (DT.Rows[0]["POSITION"].ToString() == "1" ? "left" : "right") + ": 5px;text-align:right;\">" + strR + "</div>'; dom" + DT.Rows[0]["ID"] + ".insertHtml(html);position" + DT.Rows[0]["ID"] + ".floatRightCenter('ad_" + DT.Rows[0]["ID"] + "');}");

                    sr.WriteLine("myEvent.add(window,'load',ad_" + DT.Rows[0]["ID"] + ");");
                }
                else
                {
                    strR = "var html;html = \'<div id=\"ad_" + DT.Rows[0]["ID"] + "\" style=\"z-index: 9999; width:" + DT.Rows[0]["PICWIDTH"] + "px; position: fixed; " + (DT.Rows[0]["POSITION"].ToString() == "1" ? "left" : "right") + ": 5px;text-align:right;\">" + strR + "</div><script type=\"text/javascript\">var ggRoll" + DT.Rows[0]["ID"] + "={roll:document.getElementById(\"ad_" + DT.Rows[0]["ID"] + "\"),speed: 20, statusX: 1, statusY: 1, x: 100, y: " + DT.Rows[0]["ID"] + ", winW: document.documentElement.clientWidth - document.getElementById(\"ad_" + DT.Rows[0]["ID"] + "\").offsetWidth, winH: document.documentElement.clientHeight - document.getElementById(\"ad_" + DT.Rows[0]["ID"] + "\").offsetHeight, Go: function () { this.roll.style.left = this.x + \"px\"; this.roll.style.top = this.y + \"px\"; this.x = this.x + (this.statusX ? -1 : 1); if (this.x < 0) { this.statusX = 0 } if (this.x > this.winW) { this.statusX = 1 } this.y = this.y + (this.statusY ? -1 : 1); if (this.y < 0) { this.statusY = 0 } if (this.y > this.winH) { this.statusY = 1 } } }; var interval" + DT.Rows[0]["ID"] + " = setInterval(\"ggRoll" + DT.Rows[0]["ID"] + ".Go()\", ggRoll" + DT.Rows[0]["ID"] + ".speed); ggRoll" + DT.Rows[0]["ID"] + ".roll.onmouseover = function () { clearInterval(interval" + DT.Rows[0]["ID"] + ") }; ggRoll" + DT.Rows[0]["ID"] + ".roll.onmouseout = function () { interval" + DT.Rows[0]["ID"] + " = setInterval(\"ggRoll" + DT.Rows[0]["ID"] + ".Go()\", ggRoll" + DT.Rows[0]["ID"] + ".speed)};</script>\';document.write(html);";

                    sr.WriteLine(strR);
                }
                sr.Close();
                mainContent.InnerHtml = "<script  type=\"text/javascript\" src='" + BaseClass.VirtualPath1() + "/UploadFiles/ADJS/Rel/ad_" + DT.Rows[0]["ID"] + ".js'></script>";
            }
            else
            {
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


}