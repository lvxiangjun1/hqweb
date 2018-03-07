<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newsAdd.aspx.cs" Inherits="Background_NewsManage_newsAdd" %>

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
            console.log(arrMsg)
            var i, msg;
            for (i = 0; i < arrMsg.length; i++) {
                msg = arrMsg[i];
                $("#uploadList").append('<option value="' + msg.url + '">' + msg.localname + '</option>');
                $("#hiduploadListValue").val($("#hiduploadListValue").val() + msg.url + "&&");
                $("#hiduploadListText").val($("#hiduploadListText").val() + msg.localname + "&&");
            }
        }
        function Check() {

            if (newsAddForm.txtTITLE.value == "") {
                alert("标题不能为空！！");
                newsAddForm.txtTITLE.focus();
                return false;
            }
            if (newsAddForm.txtPUBLISHTIME.value == "") {
                alert("更新日期不能为空！！");
                newsAddForm.txtPUBLISHTIME.focus();
                return false;
            }
            return confirm("确定提交？"); //OnClientClick=" return Check()"
        }
    </script>
</head>
<body>
    <form id="newsAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            添加中心动态</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew">
                    标题：
                </td>
                <td class="wenzi1"  >
                    
                     <asp:DropDownList ID="ddlTITLESIZE" runat="server" Width="80">
                        <asp:ListItem Value="18" Selected="True">字体大小</asp:ListItem>
                        <asp:ListItem Value="10">极小</asp:ListItem>
                        <asp:ListItem Value="12">特小</asp:ListItem>
                        <asp:ListItem Value="16">小</asp:ListItem>
                        <asp:ListItem Value="18">中</asp:ListItem>
                        <asp:ListItem Value="24">大</asp:ListItem>
                        <asp:ListItem Value="32">特大</asp:ListItem>
                        <asp:ListItem Value="48">极大</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlTITLEFONT" runat="server" Width="80">
                       <asp:ListItem Value="SimSun" Selected="True">字体</asp:ListItem>
                        <asp:ListItem Value="SimSun" >宋体</asp:ListItem>
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
                <td align="center" class="wenziNew">
                    副标题：
                </td>
                <td class="wenzi1"  >
                    
                     <asp:DropDownList ID="ddlSUBTITLESIZE" runat="server" Width="80">
                       <asp:ListItem Value="18" Selected="True">字体大小</asp:ListItem>
                        <asp:ListItem Value="10">极小</asp:ListItem>
                        <asp:ListItem Value="12">特小</asp:ListItem>
                        <asp:ListItem Value="16">小</asp:ListItem>
                        <asp:ListItem Value="18" >中</asp:ListItem>
                        <asp:ListItem Value="24">大</asp:ListItem>
                        <asp:ListItem Value="32">特大</asp:ListItem>
                        <asp:ListItem Value="48">极大</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlSUBTITLEFONT" runat="server" Width="80">
                       <asp:ListItem Value="SimSun" Selected="True">字体</asp:ListItem>
                        <asp:ListItem Value="SimSun" >宋体</asp:ListItem>
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
                <td align="center" class="wenziNew">
                    来源：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtCOPYRIGHT" runat="server"></asp:TextBox>
                </td>   </tr>
            <tr>
                <td align="center" class="wenziNew">
                    作者：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtAUTHOR" runat="server"></asp:TextBox>
                </td>   </tr>
            <tr>
                <td align="center" class="wenziNew">
                    更新日期：
                </td>
                <td class="wenzi1"  >
                    <asp:TextBox ID="txtPUBLISHTIME" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td align="center" class="wenziNew">
                    内容：
                </td>
                <td colspan="2" class="wenzi1">
                    <textarea id="txtContent" class="xheditor {tools:'full',skin:'o2007silver',hoverExecDelay:-1,upBtnText:'上传',upMultiple:5,upImgUrl:'../../xheditor/upload.aspx',upImgExt:'jpg,jpeg,gif,png',onUpload:insertUpload}"
                        rows="20" runat="server" style="width: 100%"></textarea>
                </td>
            </tr>
             <tr>
                <td align="center" class="wenziNew">
                    设置首页图片：
                </td>
                <td class="wenzi1"  >
                    <asp:DropDownList ID="uploadList" runat="server">
                        <asp:ListItem Value="">不显示首页图片</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="hiduploadListText" runat="server" Style="display: none"></asp:TextBox>
                    <asp:TextBox ID="hiduploadListValue" runat="server" Style="display: none"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    是否首页显示：
                </td>
                <td class="wenzi1"  >
                    <asp:DropDownList ID="ddlISSPECIAL" runat="server">
                        <asp:ListItem Value="Y">是</asp:ListItem>
                        <asp:ListItem Value="N" Selected="True">否</asp:ListItem>
                    </asp:DropDownList>
                </td></tr>
               
            <tr>
                <td class="wenzi1" colspan="2" align="center" style="padding-top: 5px; padding-bottom: 5px;">
                    <asp:Button ID="btnAdd" runat="server" Text="提交" OnClick="btnAdd_Click" CssClass="scbtn" OnClientClick=" return Check()"/>
                    <asp:Button ID="btnCalcel" runat="server" Text="取消" OnClick="btnCalcel_Click" CssClass="scbtn" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
