<%@ Page Language="C#" AutoEventWireup="true" CodeFile="micrologin.aspx.cs" Inherits="micrologin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .topMainMenu2Search
        {
            float: right;
            width: 400px;
            margin-right: 5px;
            padding-top: 3px;
        }
        .topMainMenu2Search a
        {
            font-size: 12px;
            font-weight: normal;
            color: #FF9900;
            text-decoration: none;
        }
        .inpuTop2
        {
            width: 95px;
            height: 16px;
            padding-left: 5px;
            border: 1px solid #CCC;
            color: #999;
            float:left;
            margin-left: 5px;
        }
    </style>
</head>
<body>
    <form id="microloginForm" runat="server">
    <div class="topMainMenu2Search">
        <asp:Panel ID="pnlLogin" runat="server">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td width="25">
                        <img src="images/INDEX2_19.png" width="20" height="23" />
                    </td>
                    <td width="220">
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td> <asp:TextBox ID="txtUSERNAME" class="inpuTop2" runat="server" onFocus="if(this.value=='用户名'){this.value='';}this.select();">用户名</asp:TextBox></td>
    <td><asp:TextBox ID="txtPassword" class="inpuTop2" runat="server" onFocus="if(this.value=='密码'){this.value='';}this.select();"
                            TextMode="Password">密码</asp:TextBox></td>
  </tr>
</table>
                       
                        
                    </td>
                    <td width="63">
                        <asp:ImageButton ID="ibLogin" runat="server" src="images/INDEX_03.jpg" Width="60"
                            Height="23" OnClick="ibLogin_Click" />
                    </td>
                    <td width="70">
                        <a href="memberManage/Register.aspx" target="_search">个人注册</a>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Panel ID="pnlCookie" runat="server">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td width="160" align="right">
                        <img alt="" src="images/title_05.png" width="32" height="24" />
                    </td>
                    <td align="left" style="font-size: 12px;">
                        您好！<asp:Label ID="lbNICK_NAME" runat="server" Text=""></asp:Label>
                        &nbsp;<a href="memberManage/User/Default.aspx" target="_search">个人中心</a>
                        <asp:LinkButton ID="lbtnExit" OnClientClick="return confirm('退出登录？')" runat="server"
                            OnClick="lbtnExit_Click">退出登录</asp:LinkButton>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
