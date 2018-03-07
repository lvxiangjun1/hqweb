<%@ Page Language="C#" AutoEventWireup="true" CodeFile="process.aspx.cs" Inherits="centerstyle_process" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>金华市8890便民服务平台门户网站</title>
    <link rel="stylesheet" type="text/css" href="../css/index.css" />
    <link rel="stylesheet" type="text/css" href="../css/nei.css" />

</head>
<body>
    <form id="processForm" runat="server">
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
                您现在的位置：金华市8890便民服务平台 >> 中心风采 >> 二周年历程</div>
            <div class="jhneiRightmain2">
                <div class="wlsp">
                    <div class="qyjstitle">
                        二周年历程</div>
                    <div id="beststaffShow" runat="server">
                    </div>
                    <div class="jhzhuanye">
                        <webdiyer:AspNetPager ID="MyAspNetPager" CssClass="paginator" CurrentPageButtonClass="cpb"
                            runat="server" AlwaysShow="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                            PageSize="20" PrevPageText="上一页" ShowInputBox="Auto" OnPageChanged="MyAspNetPager_PageChanged"
                            SubmitButtonText="确定" TextBeforeInputBox="第" TextAfterInputBox="页" InputBoxClass="shuru11"
                            SubmitButtonClass="queding" SubmitButtonStyle="" NumericButtonCount="5" CustomInfoTextAlign="Right">
                        </webdiyer:AspNetPager>
                    </div>
                </div>
            </div>
        </div>
        <div id="footor" runat="server">
        </div>
    </form>
</body>
</html>
