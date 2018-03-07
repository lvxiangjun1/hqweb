<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADAdd.aspx.cs" Inherits="background_ADManage_ADAdd" validateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../xheditor/jquery/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor-1.2.2.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor_lang/zh-cn.js"></script>
    <script type="text/javascript" src="../../My97DatePicker/WdatePicker.js"></script>
    <title>飘窗添加/修改</title>
    <script type="text/javascript">
        function checkcontrols() {
            var controlstxtTitle = document.getElementById("txtTitle");
            if (controlstxtTitle.value == null || controlstxtTitle.value.replace(/\s/g,'') == "") {
                alert("请输入名称！");
                controlstxtTitle.focus();
                return false;
            }
            var controlstxtWidth = document.getElementById("txtWidth");
            var re = /^[0-9]*]*$/;
            if (!re.test(controlstxtWidth.value)) {
                alert("飘窗宽度应为正整数！");
                controlstxtWidth.focus();
                return false;
            }
            var controlstxtHeight = document.getElementById("txtHeight");
            var re = /^[0-9]*]*$/;
            if (!re.test(controlstxtHeight.value)) {
                alert("飘窗高度应为正整数！");
                controlstxtHeight.focus();
                return false;
            }  
            return true;
        }
        function ChangePhotoView() {
            var re = /^[0-9]*]*$/;
            var w;
            var h;
            var controlstxtWidth = document.getElementById("txtWidth");
            w = controlstxtWidth.value;
            if (!re.test(w)) {
                alert("飘窗宽度应为正整数！");
                controlstxtWidth.focus();
                return false;
            }
            var controlstxtHeight = document.getElementById("txtHeight");
            h = controlstxtHeight.value;
            if (!re.test(h)) {
                alert("飘窗高度应为正整数！");
                controlstxtHeight.focus();
                return false;
            }
            var pView = document.getElementById("PhotoView");
            $("#PhotoView").width(w);
            $("#PhotoView").height(h);
        }
    </script>
</head>
<body>
    <form id="ADAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            添加广告飘窗</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
        <div class="mainContent">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
                <tr>
                    <td align="center" class="wenziNew"  >
                        标题：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtTITLE" runat="server" Width="500px" MaxLength="100"></asp:TextBox>&nbsp;<font
                            color="red">*</font>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        说明：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox id="txtINTRODUCE" runat="server" Width="500px" MaxLength="500" Height="80" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        飘窗图片：
                    </td>
                    <td class="wenzi1">
                        <asp:Image ID="PhotoView" runat="server" />
                        <br />
                        <asp:TextBox ID="txtPicPath" runat="server"  Width="200px" ></asp:TextBox>
                        <br />
                        <asp:FileUpload ID="uploadDefaultPic" runat="server" Width="200px" />
                    &nbsp;<asp:Button ID="btnUpload" runat="server" onclick="btnUpload_Click" 
                            Text="上 传" /> <label style="color:Green;">支持格式：gif、jpg、bmp、png</label>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        链接路径：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtWEBURL" runat="server" Width="400px" MaxLength="500">http://</asp:TextBox>&nbsp;&nbsp;<label style="color:Green;">如果不使用链接，请清空文本框</label>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        飘窗宽：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtPICWIDTH" runat="server" Width="100px" MaxLength="8" onblur="ChangePhotoView()">200</asp:TextBox>&nbsp;像素&nbsp;<label style="color:Green;">请输入正整数值</label>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        飘窗高：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtPICHEIGHT" runat="server" Width="100px" MaxLength="8" onblur="ChangePhotoView()">130</asp:TextBox>&nbsp;像素&nbsp;<label style="color:Green;">请输入正整数值</label>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        广告风格：
                    </td>
                    <td class="wenzi1">
                    <asp:DropDownList ID="ddlADVTYPE" runat="server">
                        <asp:ListItem Value="1" Selected="True">飘动</asp:ListItem>
                        <asp:ListItem Value="2">侧边</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        侧边位置：
                    </td>
                    <td class="wenzi1">
                        <asp:DropDownList ID="ddlPOSITION" runat="server">
                        <asp:ListItem Value="1" Selected="True">左边</asp:ListItem>
                        <asp:ListItem Value="2">右边</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="wenziNew"  >
                        离顶部多少：
                    </td>
                    <td class="wenzi1">
                        <asp:TextBox ID="txtTOPPIX" runat="server" Width="100px" MaxLength="8" >200</asp:TextBox>&nbsp;像素&nbsp;<label style="color:Green;">请输入正整数值</label>
                    </td>
                </tr>
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
