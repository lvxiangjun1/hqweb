<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProAdd.aspx.cs" Inherits="background_product_ProAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
            
            return confirm("确定提交？"); //OnClientClick=" return Check()" 
        }
    </script>
</head>
<body>
    <form id="spAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            添加产品</div>
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
                    <asp:TextBox ID="txtTITLE" runat="server" Width="280"></asp:TextBox>
                     <asp:HiddenField ID="lbReqId" runat="server" />
                </td>
               
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    品牌：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtSUBTITLE" runat="server" Width="280"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    产品类型：
                </td>
                <td class="wenzi1">
                    <asp:DropDownList ID="ddlTITLECOLOR" runat="server" Width="80">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    产品状态：
                </td>
                <td class="wenzi1">
                   <asp:TextBox ID="txtProstatus" runat="server" Width="280"></asp:TextBox>   </td>
            </tr>
              <tr>
                <td align="center" class="wenziNew">
                    产品介绍：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtINTRODUCE" runat="server" Width="300px" TextMode="MultiLine"
                        Height="100px"></asp:TextBox><span style="color: red; font-size: 12px;">*</span>
                </td>
            </tr>
            <tr bgcolor="#ffffff">
                <td class="tableCo">
                    上传产品图片：
                </td>
                <td align="left" height="60px" colspan="3">
                    <asp:ListBox ID="ImageShow" runat="server" Width="200px" OnSelectedIndexChanged="ImageShow_SelectedIndexChanged"
                        AutoPostBack="true"></asp:ListBox>
                    <asp:Image ID="ImageShow1" runat="server" Width="188px" Height="39px" /><asp:Button
                        ID="BtnDelete" runat="server" Text="删除" Visible="false" OnClick="BtnDelete_Click"
                        CssClass="button2" />
                </td>
            </tr>
            <tr bgcolor="#ffffff">
                <td class="tableCo">
                    图片路径：
                </td>
                <td align="left" height="60px" colspan="3">
                    <asp:FileUpload ID="FileUpload" runat="server" />
                    <asp:Button ID="BtnUpload" runat="server" Text="上传" Width="73px" CssClass="button2"
                        OnClick="BtnUpload_Click" />
                    <br />
                </td>
            </tr>
            <tr bgcolor="#ffffff">
                <td class="tableCo">
                    是否封面：
                </td>
                <td align="left" height="60px" colspan="3" class="dywenzi1c">
                    <asp:RadioButtonList ID="RadioFM" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1">是</asp:ListItem>
                        <asp:ListItem Value="0" Selected="True">否</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="wenzi1" colspan="2" align="center" style="padding-top: 5px; padding-bottom: 5px;">
                    <asp:Button ID="btnAdd" runat="server" Text="提交" OnClick="btnAdd_Click" CssClass="scbtn"
                        OnClientClick=" return Check()" />
                    <asp:Button ID="btnCalcel" runat="server" Text="取消" OnClick="btnCalcel_Click" CssClass="scbtn" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
