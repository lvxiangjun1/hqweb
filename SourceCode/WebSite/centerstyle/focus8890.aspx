<%@ Page Language="C#" AutoEventWireup="true" CodeFile="focus8890.aspx.cs" Inherits="centerstyle_focus8890" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>金华市8890便民服务平台门户网站</title>
    <link rel="stylesheet" type="text/css" href="../css/index.css" />
    <link rel="stylesheet" type="text/css" href="../css/nei.css" />

</head>
<body>
    <form id="focus8890Form" runat="server">
    <div id="TopHtml" runat="server">
    </div>
    <div class="jhmainnei">
        <div class="jhneiLeft">
            <div class="neititle">
                中心风采</div>
            <div class="neititle2">
                <ul id="centerstyleleftShow" runat="server">
                </ul>
            </div>
            <div class="rdph">
                <h1>
                    中心事迹</h1>
                <ul id="hotnewShow" runat="server">
                </ul>
            </div>
        </div>
        <div class="jhneiRight">
            <div class="jhneiRighttitle">
                您现在的位置：金华市8890便民服务平台 >> 中心风采 >> 聚焦8890</div>
            <div class="jhneiRightmain">
                <ul id="NewsShow" runat="server">
                </ul>
                <div class="jhzhuanye">
                    <webdiyer:aspnetpager id="MyAspNetPager" cssclass="paginator" currentpagebuttonclass="cpb"
                        runat="server" alwaysshow="True" firstpagetext="首页" lastpagetext="尾页" nextpagetext="下一页"
                        pagesize="20" prevpagetext="上一页" showinputbox="Auto" onpagechanged="MyAspNetPager_PageChanged"
                        submitbuttontext="确定" textbeforeinputbox="第" textafterinputbox="页" inputboxclass="shuru11"
                        submitbuttonclass="queding" submitbuttonstyle="" numericbuttoncount="5" custominfotextalign="Right">
                    </webdiyer:aspnetpager>
                </div>
            </div>
        </div>
    </div>
    <div id="footor" runat="server">
    </div>
    </form>
</body>
</html>
