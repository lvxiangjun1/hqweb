<%@ Page Language="C#" AutoEventWireup="true" CodeFile="adminLogin.aspx.cs" Inherits="background_adminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理——宁波汉奇电子科技有限公司</title>
    <style type="text/css">
        body
        {
            background-color: #f4f4f4;
            margin-left: 0px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
        }
        .htmain
        {
            background-image: url(images/1.jpg);
            background-position: center center;
            height: 550px;
            margin-top: 80px;
        }
        .wenzi1
        {
            font-size: 14px;
            color: #1468c0;
            line-height: 30px;
            font-family: "微软雅黑";
        }
        .wenzi2
        {
            font-size: 12px;
            color: #1468c0;
            line-height: 26px;
        }
        .wenzi2 a
        {
            text-decoration: none;
            color: #1468c0;
        }
        .wenzi2 a:hover
        {
            text-decoration: underline;
        }
        .dlbk
        {
            border: 1px solid #e0e0e0;
            width: 140px;
            line-height: 22px;
        }
        .dlbk2
        {
            border: 1px solid #e0e0e0;
            width: 80px;
            line-height: 22px;
        }
        .dltable
        {
            margin: auto;
            height: 200px;
            width: 250px;
            padding-top: 220px;
            padding-left: 240px;
        }
    </style>
</head>
<body>
    <form id="adminLoginForm" runat="server">
    <div class="htmain">
        <div class="dltable">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                <tr>
                    <td class="wenzi1">
                        用户名：
                    </td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server" class="dlbk"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="wenzi1">
                        密码：
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" class="dlbk" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="wenzi1">
                        验证码：
                    </td>
                    <td>
                        <table width="100%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td>
                                    <input type="text" name="txtCheckCode" runat="server" size="5" id="txtCheckCode"
                                        class="dlbk2" />
                                </td>
                                <td>
                                    <img id="ImgBtn" alt="点击更换验证码！" onclick="return ImgBtn_onclick(this)" onmouseover="this.style.cursor='point';"
                                        src="code.aspx" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:ImageButton ID="iBtnLogin" runat="server" ImageUrl="images/1.png" Width="158"
                            Height="49" OnClick="iBtnLogin_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
<script language="JavaScript">
<!--
    function ImgBtn_onclick(id) {
        var rom = Math.random();
        id.src = "code.aspx?" + rom;
    }

//-->
</script>
</html>
