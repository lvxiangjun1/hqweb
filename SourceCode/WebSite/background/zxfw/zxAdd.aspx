﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zxAdd.aspx.cs" Inherits="Background_zxfw_zxAdd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../xheditor/jquery/jquery-1.4.4.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor-1.2.2.min.js"></script>
    <script type="text/javascript" src="../../xheditor/xheditor_lang/zh-cn.js"></script>
    <script type="text/javascript" src="../../My97DatePicker/WdatePicker.js"></script>
    <script type="text/javascript">
        function insertUpload(arrMsg) {
            console.log(arrMsg)
            var i, msg;
            for (i = 0; i < arrMsg.length; i++) {
                msg = arrMsg[i];
                $("#uploadList").append('<option value="' + msg.url + '">' + msg.localname + '</option>');
                $("#hiduploadListValue").val($("#hiduploadListValue").val() + msg.url + "&&");
                $("#hiduploadListText").val($("#hiduploadListText").val() + msg.localname + "&&");
            }
        }
        function Check() {

            if (zxAddForm.txtTITLE.value == "") {
                alert("标题不能为空！！");
                zxAddForm.txtTITLE.focus();
                return false;
            }
            if (zxAddForm.txtPUBLISHTIME.value == "") {
                alert("更新日期不能为空！！");
                zxAddForm.txtPUBLISHTIME.focus();
                return false;
            }
            return confirm("确定提交？"); //OnClientClick=" return Check()"
        }
    </script>
</head>
<body>
    <form id="zxAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            添加咨询服务</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew">
                    问题：
                </td>
                <td class="wenzi1"  >
                    
                    <asp:TextBox ID="txtTITLE" runat="server" Width="380"></asp:TextBox>
                </td>
              
               
               
               
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    更新日期：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtPUBLISHTIME" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td align="center" class="wenziNew">
                    内容：
                </td>
                <td class="wenzi1">
                    <textarea id="txtContent" class="xheditor {tools:'full',skin:'o2007silver',hoverExecDelay:-1,upBtnText:'上传',upMultiple:5,upImgUrl:'../../xheditor/upload.aspx',upImgExt:'jpg,jpeg,gif,png',onUpload:insertUpload}"
                        rows="20" runat="server" style="width: 100%"></textarea>
                </td>
            </tr>
               
            <tr>
                <td class="wenzi1" colspan="2" align="center" 
                    style="padding-top: 5px; padding-bottom: 5px;">
                    <asp:Button ID="btnAdd" runat="server" Text="提交" OnClick="btnAdd_Click" CssClass="scbtn" OnClientClick=" return Check()"/>
                    <asp:Button ID="btnCalcel" runat="server" Text="取消" OnClick="btnCalcel_Click" CssClass="scbtn" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
