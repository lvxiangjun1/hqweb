<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_left.aspx.cs" Inherits="Background_admin_left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Tree CSS -->
    <link rel="StyleSheet" href="Css/dtree.css" type="text/css" />
    <!-- Tree JS-->
    <script type="text/javascript" src="JS/dtree.js"></script>
    <script type="text/javascript" src="JS/jquery-1.4.1.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#imgLoading").hide();
        });
    </script>
    <style type="text/css">
        body
        {
            margin-left: 4px;
            margin-top: 0px;
            margin-right: 0px;
            margin-bottom: 0px;
            background-color: #F4F4F4;
            background-image: url(images/xitong_22.jpg);
            background-repeat: repeat-y;
            text-decoration: none;
        }
        .bgLeft
        {
        }
        .ydleft
        {
            height: 34px;
            margin-left: 1px;
        }
        .ydleft1
        {
            background-image: url(images/bgzxb.jpg);
            background-repeat: no-repeat;
            font-family: "微软雅黑";
            font-size: 14px;
            color: #333;
            height: 34px;
        }
        .mainMenuLan01
        {
            float: left;
            background-image: url(images/bgzxb.jpg);
            height: 30px;
            cursor: hand;
            width: 163px;
            font-family: "微软雅黑";
            font-size: 14px;
            color: #333;
            padding-top: 4px;
        }
        .mainMenuLan01 a
        {
            font-family: "微软雅黑";
            font-size: 14px;
            color: #333;
            text-decoration: none;
        }
        .mainMenuLan01 a:hover
        {
            color: #92ad1b;
        }
        .mainMenuLan01:hover
        {
            width: 208px;
            height: 43px;
            padding-top: 4px;
            background-color: #000;
        }
        #PARENT
        {
        }
        #PARENT ul
        {
            margin: 0px;
            padding: 0px;
        }
        #nav
        {
            list-style-type: none;
            text-align: left;
            width: 209px;
            margin: 0px;
            padding: 0px;
        }
        
        #nav a
        {
            width: 200px;
            display: block;
            padding-left: 60px;
        }
        #nav li
        {
            float: left;
            background-image: url(images/bgzxb.jpg);
            height: 37px;
            cursor: hand;
            width: 208px;
            font-family: "微软雅黑";
            font-size: 14px;
            color: #333;
            margin: 0px;
            padding: 0px;
            background-repeat: no-repeat;
            line-height: 36px;
        }
        #nav li img
        {
            margin: 0px;
            vertical-align: middle;
            vertical-align: middle;
            padding: 0px;
        }
        #nav li a:hover
        {
            color: #FFF;
            font-weight: normal;
            background-color: #80b329;
        }
        #nav a:link
        {
            color: #333333;
            text-decoration: none;
            font-size: 14px;
        }
        #nav a:visited
        {
            font-size: 14px;
            color: #333333;
            text-decoration: none;
        }
        #nav a:hover
        {
            background-color: #80b329;
            width: 208px;
            height: 37px;
        }
        
        #nav li ul
        {
            margin: 0px;
            padding: 0px;
        }
        #nav li ul li
        {
            border-bottom: #FFF 1px solid;
            background: #EBEBEB;
            height: 36px;
        }
        #nav li ul a
        {
            padding-left: 63px;
        }
        
        #nav li ul a:link
        {
            color: #333333;
            text-decoration: none;
            text-indent: 15px;
        }
        #nav li ul a:visited
        {
            text-indent: 15px;
            color: #666;
            text-decoration: none;
        }
        #nav li ul a:hover
        {
            color: #FFF;
            font-weight: bold;
        }
        
        #nav li:hover ul
        {
            margin: 0px;
            padding: 0px;
        }
        #nav li.sfhover ul
        {
            margin: 0px;
            padding: 0px;
        }
        #content
        {
            clear: left;
        }
        #nav ul.collapsed
        {
            display: none;
        }
        
        .anniu
        {
            background-color: #FFF;
            height: 30px;
            border-bottom-width: 1px;
            border-bottom-style: solid;
            border-bottom-color: #d0e0f0;
        }
        .anniuLeft
        {
            float: left;
            font-family: "微软雅黑";
            font-size: 12px;
            line-height: 28px;
            text-align: center;
            border-right-width: 1px;
            border-right-style: solid;
            border-right-color: #d0e0f0;
            height: 30px;
            width: 100px;
        }
        .anniuLeft a
        {
            text-decoration: none;
            color: #333;
        }
        .anniuLeft a:hover
        {
            color: #999;
        }
        .anniuRight
        {
            float: left;
            font-family: "微软雅黑";
            font-size: 12px;
            line-height: 28px;
            text-align: center;
            height: 30px;
            width: 100px;
        }
        .anniuRight a
        {
            text-decoration: none;
            color: #333;
        }
        .anniuRight a:hover
        {
            color: #999;
        }
    </style>
</head>
<body>
    <form id="adminleftForm" runat="server">
    <div class="leftTitle">
        <img src="images/xitong_13.jpg" width="209" alt="" /></div>
    <div class="anniu">
        <div class="anniuLeft">
            <a href="javascript: d.openAll();">打开所有栏目</a></div>
        <div class="anniuRight">
            <a href="javascript: d.closeAll();">关闭所有栏目</a></div>
    </div>
    <asp:Literal ID="ltlTree" runat="server"></asp:Literal>
    </form>
</body>
</html>
