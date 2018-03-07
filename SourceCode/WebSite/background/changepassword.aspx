<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="background_changepassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="changepasswordForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            修改密码</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew">
                    原密码：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtoldPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    新密码：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtnewPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    确认密码：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtcomPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="wenzi1" colspan="2" align="center">
                    <asp:Button ID="btnSave" runat="server" Text="确认修改" OnClick="btnSave_Click" CssClass="scbtn" Width="80px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
