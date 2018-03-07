<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminEdit.aspx.cs" Inherits="background_adminManage_adminAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="adminAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            修改管理员</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <div class="tableclock">
            <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center">
                <tr>
                    <td width="12%" align="center" class="wenziNew">
                        用户名：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                        <asp:TextBox ID="txtUserName" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew">
                        密码：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:TextBox ID="txtVisPassword" runat="server" Visible="false"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew">
                        姓名：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtTrueName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew">
                        联系方式：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew">
                        所属部门：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew">
                        栏目管理：
                    </td>
                    <td class="wenzi1">
                        <asp:TreeView ID="trNode" runat="server" CssClass="tyu7" ShowCheckBoxes="Leaf">
                        </asp:TreeView>
                    </td>
                </tr>
                <tr>
                    <td class="wenzi1" colspan="2" align="center" style="padding-top: 5px; padding-bottom: 5px;">
                        <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" CssClass="scbtn" />
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
