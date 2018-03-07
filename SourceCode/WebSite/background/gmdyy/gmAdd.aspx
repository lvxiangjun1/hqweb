<%@ Page Language="C#" AutoEventWireup="true" CodeFile="gmAdd.aspx.cs" Inherits="Background_wlsp_wlAdd" %>

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
        function Check() {

            if (wlAddForm.txtTITLE.value == "") {
                alert("标题不能为空！！");
                wlAddForm.txtTITLE.focus();
                return false;
            }
            if (wlAddForm.txtPUBLISHTIME.value == "") {
                alert("更新日期不能为空！！");
                wlAddForm.txtPUBLISHTIME.focus();
                return false;
            }
            return confirm("确定提交？"); //OnClientClick=" return Check()"
        }
    </script>
</head>
<body>
    <form id="wlAddForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            添加光明电影院</div>
        <div class="mainTopRight">
            &nbsp;</div>
    </div>
    <div class="mainContant">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center" class="tableclock">
            <tr>
                <td align="center" class="wenziNew">
                    标题：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtTITLE" runat="server" Width="480px"></asp:TextBox>
                </td>
            </tr>
              <tr>
                <td align="center" class="wenziNew">
                    简单介绍：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtSUBTITLE" runat="server" Width="480px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    更新日期：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtPUBLISHTIME" runat="server" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    首页图片：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtDefaultPicUrl" runat="server" ReadOnly="true" Width="300px"></asp:TextBox>&nbsp;&nbsp;<asp:FileUpload
                        ID="FileUploadPicUrl" runat="server" />
                    <asp:Button ID="btnUpload" runat="server" Text="上传" OnClick="btnUpload_Click" />
                </td>
            </tr>
            <tr>
                <td align="center" class="wenziNew">
                    内容：
                </td>
                <td colspan="2" class="wenzi1">
                    <textarea id="txtContent" class="xheditor {tools:'full',skin:'o2007silver',hoverExecDelay:-1,layerShadow:1,upBtnText:'上传',html5Upload:false,upMultiple:5,upLinkUrl:'../../xheditor/upload.aspx',upLinkExt:'zip,rar,txt,7z,doc,docx,xls,xlsx',upImgUrl:'../../xheditor/upload.aspx',upImgExt:'jpg,jpeg,gif,png',upFlashUrl:'../../xheditor/upload.aspx',upFlashExt:'swf',upMediaUrl:'../../xheditor/upload.aspx',upMediaExt:'wmv,avi,wma,mp3,mid'}"
                        rows="30" runat="server" style="width: 98%"></textarea>
                </td>
            </tr>
            <tr>
                <td class="wenzi1" colspan="4" align="center" style="padding-top: 5px; padding-bottom: 5px;">
                    <asp:Button ID="btnAdd" runat="server" Text="提交" OnClick="btnAdd_Click" CssClass="scbtn"
                        OnClientClick=" return Check()" />
                    <asp:Button ID="btnCalcel" runat="server" Text="取消" OnClick="btnCalcel_Click" CssClass="scbtn" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
