<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="background_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理-宁波汉奇电子科技有限公司门户网站</title>
</head>
<frameset rows="124,*" cols="*" frameborder="no" border="0" framespacing="0">
  <frame src="admin_top.aspx" name="topFrame" scrolling="No" noresize="noresize" id="topFrame" title="topFrame" />
  
  <frameset rows="*" cols="209,11,*" framespacing="0" id="allFrame" frameborder="no" border="0">
    <frame src="admin_left.aspx" name="leftFrame" scrolling="No" noresize="noresize" id="leftFrame" title="leftFrame" />
        <frame src='List_frame_Bar.html' name='List_frame_Bar' scrolling='no'/>
    <frame src="main.aspx" name="mainFrame" id="mainFrame" title="mainFrame" />
  </frameset>
</frameset>
<noframes>
    <body>
        <form id="DefaultForm" runat="server">
        <div>
        </div>
        </form>
    </body>
</noframes>
</html>
