<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detail.aspx.cs" Inherits="generalweb_detail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>金华市8890便民服务平台门户网站</title>
    <link rel="stylesheet" type="text/css" href="../css/index.css" />
    <link rel="stylesheet" type="text/css" href="../css/nei.css" />

</head>
<body>
    <form id="newsdetailForm" runat="server">
    <div id="TopHtml" runat="server">
    </div>
<div class="jhmainnei2">
   

  <div class="jhneiRighttitle2">您现在的位置：金华市8890便民服务平台 >> <%=nodename%></div>
  <div class="jhneiRightmain3">
      <div class="jhneiRightmain">
                <div class="wenzi7" id="newstitle" runat="server">
                </div>
                <div class="wenzi8c" id="newsinfo" runat="server">
                </div>
                <div class="wenzi9" id="newscontent" runat="server">
                </div>
    </div>
  </div>
   
   
   
</div>
   
    <div id="footor" runat="server">
    </div>
    </form>
    <script type="text/javascript" src="../js/jquery-1.4a2.min.js"></script>
    <script type="text/javascript" src="../js/jQuery.autoIMG.js"></script>
<script type="text/javascript">
    $('#newscontent').autoIMG();
</script>
</body>
</html>
