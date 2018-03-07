<%@ Page Language="C#" AutoEventWireup="true" CodeFile="questionList.aspx.cs" Inherits="background_surveyManage_questionList" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>问卷管理-问卷列表</title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/jquery-1.4.1.js"></script>
    <script type="text/javascript" src="../ArtDialog/artDialog.js?skin=blue"></script>
    <script type="text/javascript" src="../ArtDialog/plugins/iframeTools.js"></script>
    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#btnEdit").click(function () {
                if ($("#txtName").val() == "") {
                    alert("请填写问卷名！");
                    $("#txtName").focus();
                    return false;
                }
            });

        });
    </script>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
.topLogo{
	background-image: url(../images/jia_02.gif);
	background-repeat: repeat;
	height: 37px;
	
}.yangshi ul{
.yangshi ul{float: left; width:240px;
list-style:none;margin-left:8px;}
}
.yangshi li{
	float: left;
	background-image: url(../images/jia_12.gif);
	background-repeat: no-repeat;
	margin-right:4px;
	margin-left:4px;
	font-size: 12px;
	color: #000000;
	height: 31px;
	width: 107px;
	margin-top: 3px;
	list-style-position: inside;
	list-style-type: none;
	padding: 0px;
	margin-bottom: 0px;
	padding-top: 8px;
	list-style:none;text-indent: 6px;
	
}
.yangshi li a{
 
	background-repeat: no-repeat;
	color: #000000;
	text-decoration: none;
	font-weight: bold;	
}
.yangshi li a:hover{	font-weight: bold;	
 
	background-repeat: no-repeat;
	color: #666666;
	text-decoration: underline;	 
	
}
.yangshi li img{
	margin-right: 4px;	 
}
body,td,th {
	font-size: 12px;
}
 .dis {
 DISPLAY: block
}
.undis {
 DISPLAY: none
}
#cntR {
 WIDTH: 250px; 	 
}
#NewsTop {
 CLEAR: both; MARGIN-BOTTOM: 4px
}
#NewsTop P {
 FLOAT: left; LINE-HEIGHT: 21px
}
#NewsTop P.topTit {
	float: left;
	 
}
#NewsTop P.topC0 {
	float: left;
	 
	margin-right:2px;
	margin-left:2px;
	font-size: 12px;
	color: #000000;
	height: 31px;
	width: 107px;
	margin-top: 3px;
	list-style-position: inside;
	list-style-type: none;
	padding: 0px;
	margin-bottom: 0px;
 
	list-style:none; 
}
#NewsTop P.topC1 {
	float: left;
	 
	margin-right:2px;
	margin-left:2px;
	font-size: 12px;
	color: #000000;
	height: 31px;
	width: 107px;
	margin-top: 3px;
	list-style-position: inside;
	list-style-type: none;
	padding: 0px;
	margin-bottom: 0px;
 
	list-style:none; 
}
#NewsTop #NewsTop_tit {	margin-left: 10px;
	HEIGHT: 21px;
	border-bottom-width: 0px;
	border-bottom-style: solid;
	border-bottom-color: #c2130e;
}
#NewsTop #NewsTop_cnt {
	height: 130px;
	width: 220px;
	border: 1px solid #cccccc;
	background-color: #ffffff;
	margin-top: 5px;
	margin-left: 12px; float:left;
}
#NewsTop #NewsTop_cnt A {
 COLOR: #666; TEXT-DECORATION: none
}
#NewsTop #NewsTop_cnt A:hover {
 COLOR: #c2130e; TEXT-DECORATION: underline
}
.span22{

}
.red{
	font-size: 12px;
	font-weight: normal;
	color: #FF0000;
}
.yangshi2{
	font-size: 12px;
	font-weight: bold;
	color: #0067CE;
}
.yangshi{font-size: 14px;
	font-weight: bold;
	color: #333333;}
.yangshi3{font-size: 13px;
	font-weight: bold;
	color: #666666;}
.buttom44{
BORDER-RIGHT: #7b9ebd 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7b9ebd 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 12px; FILTER: progid:DXImageTransform.Microsoft.Gradient(GradientType=0, StartColorStr=#ffffff, EndColorStr=#cecfde); BORDER-LEFT: #7b9ebd 1px solid; CURSOR: hand; COLOR: black; PADDING-TOP: 2px; BORDER-BOTTOM: #7b9ebd 1px solid

}.rrt12{border: 1px solid #dbdbdb; margin-top:5px;	}
.rrt1{
	width: 100%;
	margin-top: 0px;
	margin-left: 0px;
 
	background-image: url(../images/xitong_15nnm.jpg);
	background-repeat: repeat-x;
	height:28px; line-height:28px; 
	font-size: 14px;
	font-weight: bold;
	color: #FFFFFF;font-family: "微软雅黑";
 
	text-indent:5px;
}
.rrt2{width:100%;
	margin-top: 0px;
	margin-left: 0px;
	border: 0px solid #dbdbdb;	  
}
.rrt3{
	width:100%;  
	border: 2px solid #EFF9FF;padding:0px;
	
}.rrt4{
	width:100%; margin-left:0px; margin-right:0px;
 
	
}
.boxWen{border: 2px solid #EFF9FF; 
	 
	width: 100%;padding: 0px;
 
}

.change{
	 
	width: 100%;padding: 0px;
	border: 2px solid #FFCD99; 
 } 
img{
	margin:0;
	border: 0px;
}
.by5{font-size: 12px;
	color: #999999;
	text-decoration: none;
	height: 30px;
	width: 60px;
	 
	text-align: center; padding-top:2px;
} 
.co1{float:left;
	background-image: url(../images/t/01.gif);
 background-position: 2px;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center;
}
.co2{ float:left;
	background-image: url(../images/t/01.gif);
 background-position: 2px;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
	text-align: center;
}
 .co3{float:left;
	background-image: url(../images/t/02.gif);
 background-position: 14px;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center;
}
.co4{ float:left;	 
	background-image: url(../images/t/02.gif);
 background-position: 14px;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
	text-align: center;
}
 .co5{float:left;
	background-image: url(../images/t/03.gif);
	 background-position: 6px;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center;
}
.co6{ float:left;
	background-image: url(../images/t/03.gif);
 background-position: 6px;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
	text-align: center;
} .co7{float:left;
	background-image: url(../images/t/04.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center;
}
.co8{ float:left;
	background-image: url(../images/t/04.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
	text-align: center;
} .co9{
	float:left;
	background-image: url(../images/t/05.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center;
 
}
.co10{ float:left; 
	background-image: url(../images/t/05.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
text-align: center;
} .co11{float:left;
	background-image: url(../images/t/06.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center;
}
.co12{ float:left;
	background-image: url(../images/t/06.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
	text-align: center;
}
.co13{float:left;
	background-image: url(../images/t/077.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #99CCFF;
	border: 1px solid #00CCFF;
	text-align: center; background-position: 4px;
}
.co14{ float:left; 
	background-image: url(../images/t/077.gif);
	background-position: left;
	background-repeat: no-repeat;
	height: 31px;
	width: 107px;
	background-color: #FFCD99;
	border: 1px solid #F8B607;
	text-align: center;
}
#dlQuestList{ width:100%;}
#dlQuestList td{ padding:5px 8px 5px 5px; line-height:24px;}
-->
   </style>
</head>
<body>
    <form id="questionListForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            编辑问卷问题</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td valign="top">
                    <div id="divPaper" class="tableclock">
                        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center">
                            <tr>
                                <td width="12%" align="center" class="wenziNew">
                                    问卷名称：
                                </td>
                                <td class="wenzi1">
                                    <asp:TextBox ID="txtName" runat="server" Width="280px"></asp:TextBox>
                                </td>
                                <td width="12%" align="center" class="wenziNew">
                                    是否发布：
                                    <td class="wenzi1">
                                        <asp:DropDownList ID="dropIsPublish" runat="server">
                                            <asp:ListItem Value="N">否</asp:ListItem>
                                            <asp:ListItem Value="Y">是</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="wenzi1" width="180px">
                                        <asp:Button ID="btnEdit" runat="server" Text="修 改" OnClick="btnEdit_Click" CssClass="scbtn" />
                                        <asp:Button ID="lbRefresh" runat="server" Text="刷 新" OnClick="lbRefresh_Click" CssClass="scbtn" />
                                        <asp:Button ID="btnClose" runat="server" Text="关 闭" CssClass="scbtn" OnClick="btnClose_Click" />
                                        <asp:Label ID="lbReqId" runat="server" Visible="false"></asp:Label>
                                    </td>
                            </tr>
                        </table>
                    </div>
                    <div class="rrt12">
                        <div class="rrt1">
                            问题列表</div>
                        <div class="rrt2">
                            <asp:DataList ID="dlQuestList" runat="server" DataKeyField="ID">
                                <ItemTemplate>
                                    <div class="rrt3" onmouseover="this.className='change'" onmouseout="this.className='boxWen'">
                                        <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lbDetail" runat="server" Text='<%# Bind("DETAIL") %>'></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="right">
                                                   <asp:LinkButton ID="ibtnEdit" runat="server" OnClick="ibtnEdit_Click" CssClass="by5"><img src="../images/t/12.gif"> 编辑</asp:LinkButton> 
                                                    <asp:LinkButton ID="ibtnDel" runat="server" OnClick="ibtnDel_Click" CssClass="by5"
                                                        OnClientClick="return confirm('您确定要删除此题目吗？')"><img src="../images/t/11.gif"> 删除</asp:LinkButton>
                                                    <asp:LinkButton ID="ibtnUp" runat="server" OnClick="ibtnUp_Click" CssClass="by5"><img src="../images/t/10.gif"> 上移</asp:LinkButton>
                                                    <asp:LinkButton ID="ibtnDown" runat="server" OnClick="ibtnDown_Click" CssClass="by5"><img src="../images/t/09.gif"> 下移</asp:LinkButton>
                                                    <asp:LinkButton ID="ibtnFirst" runat="server" OnClick="ibtnFirst_Click" CssClass="by5"><img src="../images/t/08.gif"> 最前</asp:LinkButton>
                                                    <asp:LinkButton ID="ibtnLast" runat="server" OnClick="ibtnLast_Click" CssClass="by5"><img src="../images/t/07.gif"> 最后</asp:LinkButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </td>
                <td valign="top">
                    <div id="divMenu" style="z-index: 1024; right: 5px; clear: right; float: right; text-align: left;
                        width: 250px;">
                        <table width="187" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>
                                    <img src="../images/jia_07.gif" width="250">
                                </td>
                            </tr>
                            <tr>
                                <td height="115" valign="top" background="../images/jia_09.gif">
                                    <div id="cntR">
                                        <div id="NewsTop">
                                            <div id="NewsTop_tit">
                                                <p class="topTit">
                                                </p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType01" runat="server" OnClick="ibtnType01_Click" onmouseover="this.className='co2'"
                                                        onmouseout="this.className='co1'" Text="列表单选题" CssClass="co2" />
                                                </p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType02" runat="server" OnClick="ibtnType02_Click" onmouseover="this.className='co4'"
                                                        onmouseout="this.className='co3'" Text="多选题" CssClass="co3" />
                                                </p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType03" runat="server" OnClick="ibtnType03_Click" onmouseover="this.className='co6'"
                                                        onmouseout="this.className='co5'" Text="组合单选" CssClass="co5" /></p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType04" runat="server" OnClick="ibtnType04_Click" onmouseover="this.className='co8'"
                                                        onmouseout="this.className='co7'" Text=" &nbsp;&nbsp;组合多选" CssClass="co7" />
                                                </p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType05" runat="server" OnClick="ibtnType05_Click" onmouseover="this.className='co10'"
                                                        onmouseout="this.className='co9'" Text=" &nbsp;&nbsp;&nbsp;&nbsp;单行文本框" CssClass="co9" /></p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType06" runat="server" OnClick="ibtnType06_Click" onmouseover="this.className='co12'"
                                                        onmouseout="this.className='co11'" Text="多行文本框" CssClass="co11" /></p>
                                                <p class="topC0">
                                                    <asp:Button ID="ibtnType07" runat="server" OnClick="ibtnType07_Click" onmouseover="this.className='co14'"
                                                        onmouseout="this.className='co13'" Text="信息题" CssClass="co13" /></p>
                                            </div>
                                            <div id="NewsTop_cnt">
                                                <span title="Don't delete me"></span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                列表单选题(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                您工作压力的程度？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <label>
                                                                    <input type="radio" name="radiobutton" value="radiobutton" />
                                                                    压力不大</label>
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                适度压力
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                压力很大
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                极度压力
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                多选题(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                您对新浪什么内容比较感兴趣？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <label>
                                                                    <input name="" type="checkbox" value="">
                                                                    文化娱乐</label>
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                财经新闻
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                社会话题
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                论坛博客
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                体育新闻
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                影视电视
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                组合单选题(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                您是通过什么知道我们公司的？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <label>
                                                                    <input type="radio" name="radiobutton" value="radiobutton" />
                                                                    搜索引擎</label>
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                媒体介绍
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                朋友推荐
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                其他页面链接
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3" colspan="2">
                                                                <input type="radio" name="radiobutton" value="radiobutton" />
                                                                其他
                                                                <input name="" type="text">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                组合多选题(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                您对新浪什么内容比较感兴趣？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <label>
                                                                    <input name="" type="checkbox" value="">
                                                                    文化娱乐</label>
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                财经新闻
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                社会话题
                                                            </td>
                                                            <td class="yangshi3">
                                                                <input name="" type="checkbox" value="">
                                                                论坛博客
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3" colspan="2">
                                                                <input name="" type="checkbox" value="">
                                                                其他
                                                                <input name="" type="text">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                单行文本框(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                您的姓名？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3" colspan="2">
                                                                <input type="text" size="26">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                多行文本框(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                非常感谢您参与此次调查，请留下您的宝贵意见？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3" colspan="2">
                                                                <textarea cols="23" rows="3"></textarea>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span><span>
                                                    <table width="100%" border="0">
                                                        <tr>
                                                            <td height="24" colspan="2" align="center" bgcolor="#EFF9FF" class="yangshi2">
                                                                信息题(样式)
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="24" colspan="2" class="yangshi">
                                                                非常感谢您参与此次调查，请留下您的宝贵意见？
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td class="yangshi3" colspan="2">
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </span>
                                            </div>
                                            <script type="text/javascript" language="javascript">
                                                var Tags = document.getElementById('NewsTop_tit').getElementsByTagName('p');
                                                var TagsCnt = document.getElementById('NewsTop_cnt').getElementsByTagName('span');
                                                var len = Tags.length;
                                                var flag = 1; //修改默认值
                                                for (i = 1; i < len; i++) {
                                                    Tags[i].value = i;
                                                    Tags[i].onmouseover = function () { changeNav(this.value) };
                                                    TagsCnt[i].className = 'undis';
                                                }
                                                Tags[flag].className = 'topC1';
                                                TagsCnt[flag].className = 'dis';
                                                function changeNav(v) {
                                                    Tags[flag].className = 'topC0';
                                                    TagsCnt[flag].className = 'undis';
                                                    flag = v;
                                                    Tags[v].className = 'topC1';
                                                    TagsCnt[v].className = 'dis';
                                                }
                                            </script>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <img src="../images/jia_15.gif">
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript" language="javascript">
        var bNetscape4plus = (navigator.appName == "Netscape" && navigator.appVersion.substring(0, 1) >= "4");
        var bExplorer4plus = (navigator.appName == "Microsoft Internet Explorer" && navigator.appVersion.substring(0, 1) >= "4");
        function CheckUIElements() {
            var yMenuFrom, yMenuTo, yButtonFrom, yButtonTo, yOffset, timeoutNextCheck;

            if (bNetscape4plus) {
                yMenuFrom = document["divMenu"].top;
                yMenuTo = top.pageYOffset + 295;
            }
            else if (bExplorer4plus) {
                yMenuFrom = parseInt(divMenu.style.top, 10);
                yMenuTo = document.body.scrollTop + 65; //距页面顶部的距离
            }

            timeoutNextCheck = 500;

            if (Math.abs(yButtonFrom - (yMenuTo + 152)) < 6 && yButtonTo < yButtonFrom) {
                setTimeout("CheckUIElements()", timeoutNextCheck);
                return;
            }

            if (yButtonFrom != yButtonTo) {
                yOffset = Math.ceil(Math.abs(yButtonTo - yButtonFrom) / 10);
                if (yButtonTo < yButtonFrom)
                    yOffset = -yOffset;

                if (bNetscape4plus)
                    document["divLinkButton"].top += yOffset;
                else if (bExplorer4plus)
                    divLinkButton.style.top = parseInt(divLinkButton.style.top, 10) + yOffset;

                timeoutNextCheck = 10;
            }
            if (yMenuFrom != yMenuTo) {
                yOffset = Math.ceil(Math.abs(yMenuTo - yMenuFrom) / 20);
                if (yMenuTo < yMenuFrom)
                    yOffset = -yOffset;

                if (bNetscape4plus)
                    document["divMenu"].top += yOffset;
                else if (bExplorer4plus)
                    divMenu.style.top = parseInt(divMenu.style.top, 10) + yOffset;

                timeoutNextCheck = 10;
            }

            setTimeout("CheckUIElements()", timeoutNextCheck);
        }

        function OnLoad() {
            var y;
            if (top.frames.length)
                if (bNetscape4plus) {
                    document["divMenu"].top = top.pageYOffset + 135;
                    document["divMenu"].visibility = "visible";
                }
                else if (bExplorer4plus) {
                    divMenu.style.top = document.body.scrollTop + 235;
                    divMenu.style.visibility = "visible";
                }
            CheckUIElements();
            return true;
        }
        OnLoad();
    </script>
    </form>
</body>
</html>
