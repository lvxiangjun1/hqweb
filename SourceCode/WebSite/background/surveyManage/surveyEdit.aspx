<%@ Page Language="C#" AutoEventWireup="true" CodeFile="surveyEdit.aspx.cs" Inherits="background_surveyManage_surveyCreate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>问卷管理--创建问卷</title>
    <meta http-equiv="X-UA-Compatible" content="IE=7" />
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.4.1.js"></script>
    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#btnSave").click(function () {
                if ($("#txtName").val() == "") {
                    alert("请填写问卷名！");
                    $("#txtName").focus();
                    return false;
                }
            });

        });
    </script>
</head>
<body>
    <form id="surveyCreateForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            编辑调查问卷</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew">
                    问卷名称：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtID" runat="server" Visible="false"></asp:TextBox>
                    <asp:TextBox ID="txtName" runat="server" Width="415px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    是否发布：
                </td>
                <td class="wenzi1">
                    <asp:DropDownList ID="dropIsPublish" runat="server" Width="120px">
                        <asp:ListItem Value="0">未发布</asp:ListItem>
                        <asp:ListItem Value="1">已发布</asp:ListItem>
                    </asp:DropDownList>
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
