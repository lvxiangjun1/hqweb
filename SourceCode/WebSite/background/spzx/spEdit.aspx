<%@ Page Language="C#" AutoEventWireup="true" CodeFile="spEdit.aspx.cs" Inherits="Background_spzx_spEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../xheditor/jquery/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor-1.2.2.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor_lang/zh-cn.js"></script>
    <script type="text/javascript" src="../../My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript">
        function insertUpload(arrMsg) {

        }
        function Check() {

            if (spAddForm.txtTITLE.value == "") {
                alert("标题不能为空！！");
                tsAddForm.txtTITLE.focus();
                return false;
            }
            if (spAddForm.txtPUBLISHTIME.value == "") {
                alert("更新日期不能为空！！");
                tsAddForm.txtPUBLISHTIME.focus();
                return false;
            }
            return confirm("确定提交？");
        }
    </script>
</head>
<body>
    <form id="spAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            修改视频中心</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenzi1">
                    标题：
                </td>
                <td class="wenzi1">
                    <asp:DropDownList ID="ddlTITLESIZE" runat="server" Width="80">
                        <asp:ListItem Selected="True" Value="18">字体大小</asp:ListItem>
                        <asp:ListItem Value="10">极小</asp:ListItem>
                        <asp:ListItem Value="12">特小</asp:ListItem>
                        <asp:ListItem Value="16">小</asp:ListItem>
                        <asp:ListItem Value="18">中</asp:ListItem>
                        <asp:ListItem Value="24">大</asp:ListItem>
                        <asp:ListItem Value="32">特大</asp:ListItem>
                        <asp:ListItem Value="48">极大</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlTITLEFONT" runat="server" Width="80">
                        <asp:ListItem Selected="True" Value="SimSun">字体</asp:ListItem>
                        <asp:ListItem Value="SimSun">宋体</asp:ListItem>
                        <asp:ListItem Value="FangSong_GB2312">仿宋体</asp:ListItem>
                        <asp:ListItem Value="SimHei">黑体</asp:ListItem>
                        <asp:ListItem Value="KaiTi_GB2312">楷体</asp:ListItem>
                        <asp:ListItem Value="Microsoft YaHei">微软雅黑</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlTITLECOLOR" runat="server" Width="80">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtTITLE" runat="server" Width="280"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    副标题：
                </td>
                <td class="wenzi1">
                    <asp:DropDownList ID="ddlSUBTITLESIZE" runat="server" Width="80">
                        <asp:ListItem Selected="True" Value="18">字体大小</asp:ListItem>
                        <asp:ListItem Value="10">极小</asp:ListItem>
                        <asp:ListItem Value="12">特小</asp:ListItem>
                        <asp:ListItem Value="16">小</asp:ListItem>
                        <asp:ListItem Value="18">中</asp:ListItem>
                        <asp:ListItem Value="24">大</asp:ListItem>
                        <asp:ListItem Value="32">特大</asp:ListItem>
                        <asp:ListItem Value="48">极大</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlSUBTITLEFONT" runat="server" Width="80">
                        <asp:ListItem Selected="True" Value="SimSun">字体</asp:ListItem>
                        <asp:ListItem Value="SimSun">宋体</asp:ListItem>
                        <asp:ListItem Value="FangSong_GB2312">仿宋体</asp:ListItem>
                        <asp:ListItem Value="SimHei">黑体</asp:ListItem>
                        <asp:ListItem Value="KaiTi_GB2312">楷体</asp:ListItem>
                        <asp:ListItem Value="Microsoft YaHei">微软雅黑</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlSUBTITLECOLOR" runat="server" Width="80">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtSUBTITLE" runat="server" Width="280"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    来源：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtCOPYRIGHT" runat="server" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    作者：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtAUTHOR" runat="server" Width="200"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    更新日期：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtPUBLISHTIME" runat="server" Width="200"></asp:TextBox>
                </td>
            </tr>
           
            <tr>
                <td align="center" class="wenziNew">
                    内容：
                </td>
                <td class="wenzi1">
                    <textarea id="txtContent" class="xheditor {tools:'full',skin:'o2007silver',hoverExecDelay:-1,upBtnText:'上传',upMultiple:5,upImgUrl:'../../xheditor/upload.aspx',upImgExt:'jpg,jpeg,gif,png',onUpload:insertUpload}"
                        rows="20" runat="server" style="width: 100%"></textarea>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="wenzi1" align="center" style="padding-top: 5px; padding-bottom: 5px;">
                    <asp:HiddenField ID="hidId" runat="server" />
                    <asp:Button ID="btnOK" runat="server" Text="提交" OnClick="btnOK_Click" CssClass="scbtn"
                        OnClientClick="return Check()" />
                    <asp:Button ID="btnCalcel" runat="server" Text="取消" OnClick="btnCalcel_Click" CssClass="scbtn" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
