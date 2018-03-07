<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_top.aspx.cs" Inherits="background_admin_top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/top.css" />
    <style type="text/css">
        .dh img
        {
            azimuth: expression(
this.pngSet?this.pngSet=true:(this.nodeName == "IMG" && this.src.toLowerCase().indexOf('.png')>-1?(this.runtimeStyle.backgroundImage = "none",
this.runtimeStyle.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(src='" + this.src + "', sizingMethod='image')",
this.src = "transparent.gif"):(this.origBg = this.origBg? this.origBg :this.currentStyle.backgroundImage.toString().replace('url("','').replace('")',''),
this.runtimeStyle.filter = "progid:DXImageTransform.Microsoft.AlphaImageLoader(src='" + this.origBg + "', sizingMethod='crop')",
this.runtimeStyle.backgroundImage = "none")),this.pngSet=true);
        }
    </style>
</head>
<body>
    <form id="admintopForm" runat="server">
    <div class="Topbg">
        <div class="TopTitle">
        </div>
        <div class="TopRight">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td>
                        <a href="main.aspx" target="mainFrame"><img src="images/index_05.png" width="87" height="24" /></a>
                    </td>
                    <td>
                        <a href="changepassword.aspx" target="mainFrame"><img src="images/index_06.jpg" width="90" height="24" /></a>
                    </td>
                    <td>
                        <a href="adminLogin.aspx" target="_parent"> <img src="images/index_07.png" width="87" height="24" border="0" /></a>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    <div class="wz">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
            <tr>
                <td align="left">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="2%">
                                <img src="images/b3.png" width="25" height="20" />
                            </td>
                            <td width="98%" class="wenzi1" id="usernameshow" runat="server">
                            </td>
                        </tr>
                    </table>
                </td>
                <td align="right">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="66%" class="wenzi" align="right" id="dateshow" runat="server">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
