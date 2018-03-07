<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProSel.aspx.cs" Inherits="background_product_ProSel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript" src="../../xheditor/jquery/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor-1.2.2.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor_lang/zh-cn.js"></script>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="spAddForm" runat="server">
    <div class="titleMd">
          <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenzi1">
                    标题：
                </td>
                <td class="wenzi1">
                    <asp:label ID="txtTITLE" runat="server" ></asp:label>
                     <asp:HiddenField ID="hidId" runat="server" />
                        <asp:HiddenField ID="lbReqHuID" runat="server" />
                </td>
               
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    品牌：
                </td>
                <td class="wenzi1">
                    <asp:label ID="txtSUBTITLE" runat="server"  ></asp:label>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenzi1">
                    产品类型：
                </td>
                <td class="wenzi1">
                  <asp:label ID="ddlTITLECOLOR" runat="server"  ></asp:label> 
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    产品状态：
                </td>
                <td class="wenzi1">
                   <asp:label ID="txtProstatus" runat="server" ></asp:label>   </td>
            </tr>
              <tr>
                <td align="center" class="wenziNew">
                    产品介绍：
                </td>
                <td class="wenzi1">
                <asp:label ID="txtINTRODUCE" runat="server" ></asp:label>
                   </td>
            </tr>
            
               <tr bgcolor="#ffffff">
                <td class="tableCo">
                    产品图片：
                </td>
                <td align="left" height="60px" colspan="3">
                    <asp:ListBox ID="ImageShow" runat="server" Width="200px"  
                       ></asp:ListBox>
                    <asp:Image ID="ImageShow1" runat="server" Width="188px" Height="39px" /> 
                </td>
            </tr>
        
            
        </table>
    </div>
    </form>
</body>
</html>
