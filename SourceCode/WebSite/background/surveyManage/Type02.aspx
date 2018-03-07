<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Type02.aspx.cs" Inherits="background_surveyManage_Type02" %>

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
            //编辑选项
            $("#btnEdit").click(function () {
                if ($("#txtContent").val() == "") {
                    alert("请填写选项内容！");
                    $("#txtContent").focus();
                    return false;
                }
            });
            //添加选项
            $("#btnAdd").click(function () {
                if ($("#txtAddContent").val() == "") {
                    alert("请填写选项内容！");
                    $("#txtAddContent").focus();
                    return false;
                }
            });


        });
    </script>
</head>
<body>
    <form id="Type02Form" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            多选题</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew" colspan="2">
                    多选题
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
                <td align="center" class="wenziNew">
                    选项：
                </td>
                <td class="wenzi1">
                    <asp:CheckBoxList ID="chkList" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="chkList_SelectedIndexChanged"
                        AutoPostBack="True">
                        <asp:ListItem>A 选项</asp:ListItem>
                        <asp:ListItem>B 选项</asp:ListItem>
                        <asp:ListItem>C 选项</asp:ListItem>
                        <asp:ListItem>D 选项</asp:ListItem>
                    </asp:CheckBoxList>
                    <asp:TextBox ID="txtContent" runat="server"></asp:TextBox>
                    <asp:LinkButton ID="btnEdit" runat="server" OnClick="btnEdit_Click" CssClass="by5"><img src="../images/t/12.gif"> 编辑</asp:LinkButton>
                    <asp:LinkButton ID="btnUp" runat="server" OnClick="btnUp_Click" CssClass="by5"><img src="../images/t/10.gif"> 上移</asp:LinkButton>
                    <asp:LinkButton ID="btnDown" runat="server" OnClick="btnDown_Click" CssClass="by5"><img src="../images/t/09.gif"> 下移</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    选项内容：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtAddContent" runat="server" Width="350"></asp:TextBox>
                    <asp:Button ID="btnAdd" runat="server" Text="添加一项" OnClick="btnAdd_Click" CssClass="buttom44" />
                    <asp:Button ID="btnRemove" runat="server" Text="移除选中项" OnClick="btnRemove_Click"
                        CssClass="buttom44" />
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew" colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="完 成" OnClick="btnSubmit_Click" CssClass="scbtn" />
                    &nbsp;
                    <asp:Button ID="btnClose" runat="server" Text="关 闭" OnClick="btnClose_Click" CssClass="scbtn" />
                    <asp:Label ID="lbReqId" runat="server" Visible="false"></asp:Label>
                    <asp:Label ID="lbSurId" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
