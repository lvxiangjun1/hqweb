<%@ Page Language="C#" AutoEventWireup="true" CodeFile="beststaffDetail.aspx.cs"
    Inherits="centerstyle_beststaffDetail" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>金华市8890便民服务平台门户网站</title>
    <link rel="stylesheet" type="text/css" href="../css/index.css" />
    <link rel="stylesheet" type="text/css" href="../css/nei.css" />

</head>
<body>
    <form id="beststaffDetailForm" runat="server">
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
                您现在的位置：金华市8890便民服务平台 >> 中心风采 >> 优秀员工</div>
            <div class="jhneiRightmain2">
                <div class="wenzi7" id="newstitle" runat="server">
                </div>
                <div class="wenzi8" id="inserttime" runat="server">
                </div>
                <div class="yxygpic" align="center">
                    <asp:Image ID="imgPicUrl" runat="server" Width="525px" Height="761px" />
                </div>
                <div class="qianm" align="center" id="subtitle" runat="server">
                </div>
            </div>
        </div>
        <div id="footor" runat="server">
        </div>
    </form>
</body>
</html>
