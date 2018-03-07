<%@ Page Language="C#" AutoEventWireup="true" CodeFile="beststaffEdit.aspx.cs" Inherits="background_centerstyleManage_beststaffManage_beststaffEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="beststaffEditForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            编辑优秀员工</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew">
                    姓名：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    格言：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtSubTitle" runat="server" Width="480"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    照片：
                </td>
                <td class="wenzi1">
                    <asp:FileUpload ID="FileUploadPicUrl" runat="server" Width="240" />
                    <asp:Button ID="btnUpload" runat="server" Text="上传照片" OnClick="btnUpload_Click" /><br />
                    <asp:Image ID="imgPicUrl" runat="server" Width="360" Height="480" />
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew" colspan="3">
                    <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" CssClass="scbtn" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
