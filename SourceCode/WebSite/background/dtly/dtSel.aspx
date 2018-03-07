<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dtSel.aspx.cs" Inherits="Background_NewsManage_newsSel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../../xheditor/jquery/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor-1.2.2.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor_lang/zh-cn.js"></script>
     <link href="../css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="newsAddForm" runat="server">
 <div class="titleMd" >
    <div class="titleM2" >
    
       <asp:Label ID="lbTITLE" runat="server" ></asp:Label>
     
     
    </div>
       
   
       <div class="titleB">来源：<asp:Label ID="txtCOPYRIGHT" runat="server"></asp:Label>&nbsp; 作者：<asp:Label ID="txtAUTHOR" runat="server"></asp:Label>&nbsp; 更新日期：<asp:Label ID="lbPUBLISHTIME" runat="server"></asp:Label>
    <asp:HiddenField ID="hidId" runat="server" /> </div>
<div class="titleW">
      <asp:Label ID="lbCONTENT" runat="server"></asp:Label>
    </div>
        
   
    </form>
</body>
</html>
