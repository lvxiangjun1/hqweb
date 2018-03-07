<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gmSel.aspx.cs" Inherits="Background_wlsp_wlSel" %>

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
    <form id="wlAddForm" runat="server">
   <div class="titleMd" >
    <div class="titleM2" >
    
       <asp:Label ID="lbTITLE" runat="server" ></asp:Label>
     
     
     
   </div>
       
    <div  class="titleN">
 <asp:Label ID="lbSUBTITLE" runat="server"></asp:Label>
   </div>
      
   
    <div class="titleB">更新日期：<asp:Label ID="lbPUBLISHTIME" runat="server"></asp:Label>
      点击数：<asp:Label ID="lbHITS" runat="server"></asp:Label>
    <asp:HiddenField ID="hidId" runat="server" /> </div>
 <div class="titleW">
      <asp:Label ID="lbCONTENT" runat="server"></asp:Label>
    </div>
        
   
    </form>
</body>
</html>
