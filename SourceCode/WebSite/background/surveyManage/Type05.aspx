<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Type05.aspx.cs" Inherits="background_surveyManage_Type05" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>问卷管理-添加问题</title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.4.1.js"></script>
    <script type="text/javascript" src="../ArtDialog/artDialog.js?skin=blue"></script>
    <script type="text/javascript" src="../ArtDialog/plugins/iframeTools.js"></script>
    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            //提交问题
            $("#btnSubmit").click(function () {
                if ($("#txtTitle").val() == "") {
                    alert("请填写问题内容！");
                    $("#txtTitle").focus();
                    return false;
                }
            });


        });
    </script>
</head>
<body>
    <form id="Type05Form" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            单行文本框</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew" colspan="2">
                    单行文本框
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    问题内容：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtTitle" runat="server" Width="425px" Height="48px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew" colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="完 成" CssClass="scbtn" />
                    &nbsp;
                    <asp:Button ID="btnClose" runat="server" OnClick="btnClose_Click" Text="关 闭" CssClass="scbtn" />
                    <asp:Label ID="lbReqId" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="lbSurId" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
