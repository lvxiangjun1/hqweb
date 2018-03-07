<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ADList.aspx.cs" Inherits="background_ADManage_ADList" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function onclicksel() {
            var chkobj = document.getElementById("BoxIdAll");
            if (chkobj.checked == true) {
                selAll();
            }
            else {
                removeAll();
            }
        }
        function selAll() {
            var selobj = document.getElementsByName("BoxId");
            for (var i = 0; i < selobj.length; i++) {
                if (!selobj[i].disabled) {
                    selobj[i].checked = true;
                }
            }
        }
        function removeAll() {
            var selobj = document.getElementsByName("BoxId");
            for (var i = 0; i < selobj.length; i++) {
                selobj[i].checked = false;
            }
        }
        function batchAudit(id) {
            var AuditVal = "";
            var bid = document.getElementsByName("BoxId");
            for (var i = 0; i < bid.length; i++) {
                if (bid[i].checked == true) {
                    AuditVal = AuditVal + bid[i].value + ",";
                }
            }
            if (AuditVal.length <= 0) {
                alert("请先选择要操作的项");
                return false;
            }
            else {
                if (id == "batchDel") {
                    if (confirm("您确认要删除吗？")) {
                        document.getElementById("hdfWPBH").value = AuditVal;
                        return true;
                    }
                    return false;
                }
            }
        }
        function affirmDel() {
            if (confirm("您确认要删除此信息吗？")) {
                return true;
            }
            return false;
        }
        function ShowADPreview(picurl, w, h, e) {
            var str = "";
            str = "<img src='" + picurl + "' width='" + w + "px' height='" + h + "px' border='0'/>";
            document.getElementById("hdDiv").innerHTML = str;
            $("#hdDiv").css("top", e.clientY);
            $("#hdDiv").css("left", e.clientX);
            $("#hdDiv").css("display","block");
        }
        function HideADPreview() {
            $("#hdDiv").css("display","none");
        }
    </script>
    <style type="text/css">
        .hidOver{overflow:hidden;}
        .hdDiv{position:fixed;display:none;}
    </style>
</head>
<body>
    <form id="ADListForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            网站飘窗</div> 
        <div class="mainTopRight">
            &nbsp;</div> <div class="mainSearch2"> <asp:Button ID="btnCreateJS" runat="server" Text="生成飘窗" OnClick="btnCreateJS_Click" CssClass="scbtn2" /> <asp:Button ID="btnAdd3" runat="server" Text="添加" OnClick="btnAdd_Click" CssClass="scbtn2" /></div>
    </div>   
    <div class="mainContant">
    <div  class="tableclock">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center">
            <tr>
                <td width="12%" align="center" class="wenziNew">
                    标题：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtTITLE" runat="server" CssClass="scinput"></asp:TextBox>
                </td>
                <td width="12%" align="center" class="wenziNew">
                    风格：
                </td>
                <td class="wenzi1">
                    <asp:DropDownList ID="ddlADVTYPE" runat="server">
                        <asp:ListItem Value="00">全部</asp:ListItem>
                        <asp:ListItem Value="1">飘动</asp:ListItem>
                        <asp:ListItem Value="2">侧边</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td width="12%" align="center" class="wenziNew">
                    侧边位置：
                </td>
                <td class="wenzi1" >
                    <asp:DropDownList ID="ddlPOSITION" runat="server">
                        <asp:ListItem Value="00">全部</asp:ListItem>
                        <asp:ListItem Value="1">左边</asp:ListItem>
                        <asp:ListItem Value="2">右边</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td width="60px"  rowspan="2" class="wenzi1" align="center" > <asp:Button ID="BtnSearch" runat="server" Text="搜索" OnClick="BtnSearch_Click" CssClass="scbtn" /></td>
            </tr>
         
        </table>
        </div>
        <asp:GridView ID="GridViewNews" CssClass="tableclock2" CellSpacing="1" runat="server"
            AutoGenerateColumns="False" GridLines="None" DataKeyNames="ID" OnRowDataBound="GridViewNews_RowDataBound"
            Width="100%">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="编号">
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="TITLE" HeaderText="标题">
                    <ItemStyle HorizontalAlign="left" />
                </asp:BoundField>
                <asp:BoundField DataField="USERNAME" HeaderText="添加人">
                    <ItemStyle HorizontalAlign="Center" Width="80px"/>
                </asp:BoundField>
                <asp:BoundField DataField="INSERTTIME" HeaderText="添加日期">
                    <ItemStyle HorizontalAlign="Center" Width="130px"/>
                </asp:BoundField>
                 <asp:BoundField DataField="ADVTYPE" HeaderText="添加日期">
                    <ItemStyle HorizontalAlign="Center" Width="130px"/>
                </asp:BoundField>
                 <asp:BoundField DataField="POSITION" HeaderText="添加日期">
                    <ItemStyle HorizontalAlign="Center" Width="130px"/>
                </asp:BoundField>
                <asp:TemplateField HeaderText="修改" ShowHeader="False">
                    <ItemStyle ForeColor="Red" HorizontalAlign="Center" Width="40px"/>
                    <ItemTemplate>
                        <asp:ImageButton ID="LinkBtnEdit" runat="server" ImageUrl="../images/xiugai.gif"
                            AlternateText="修改" OnClick="LinkBtnEdit_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="预览" ShowHeader="False">
                    <ItemStyle ForeColor="Red" HorizontalAlign="Center" Width="40px"/>
                    <ItemTemplate>
                        <asp:ImageButton ID="LinkBtnSel" runat="server" ImageUrl="../images/xiangxi.gif" AlternateText="预览"
                            OnClick="LinkBtnSel_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="删除" ShowHeader="False">
                    <ItemStyle ForeColor="Red" HorizontalAlign="Center" Width="40px"/>
                    <ItemTemplate>
                        <asp:ImageButton ID="BtnDelete" runat="server" CausesValidation="False" ImageUrl="../images/zhuxiao.gif"
                            AlternateText="删除" OnClientClick="return confirm('确认要删除此飘窗吗？')" OnClick="BtnDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle CssClass="aboutB1" />
            <HeaderStyle CssClass="aboutA1" BorderWidth="0px" />
            <PagerSettings Visible="False" />
            <EmptyDataTemplate>
                <table width="100%">
                    <tr align="center" class="aboutA1">
                        <td>
                            当前没有符合条件的数据！
                        </td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <AlternatingRowStyle CssClass="aboutC1" />
        </asp:GridView>
    </div>
    <div class="zhuanye000">
       <div class="tianjia"> <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" CssClass="scbtn2" /></div>
        <div class="pagin">
        <div class="message">
            <div class="Black">
                共&nbsp;</div>
            <div class="blue">
                <asp:Label ID="lblRecordCount" runat="server" Text=""></asp:Label></div>
            <div class="Black">
                &nbsp;条记录，当前显示第&nbsp;</div>
            <div class="blue">
                <asp:Label ID="lblPageSize" runat="server" Text=""></asp:Label></div>
            <div class="Black">
                &nbsp;页</div>
        </div>
        
       <div class="paginList">
            <webdiyer:AspNetPager ID="MyAspNetPager" CssClass="paginItem" CurrentPageButtonClass="cpb"
                runat="server" AlwaysShow="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                PageSize="10" PrevPageText="上一页" ShowInputBox="Auto" OnPageChanged="MyAspNetPager_PageChanged"
                SubmitButtonText="确定" TextBeforeInputBox="第" TextAfterInputBox="页" InputBoxClass="shuru11"
                SubmitButtonClass="queding" SubmitButtonStyle="" NumericButtonCount="5" CustomInfoTextAlign="Right">
            </webdiyer:AspNetPager>
        </div>
    </div>
    
    </div>
   <div runat="server" id="AD_DIV"></div>
   
    </form>
    <div id="hdDiv" class="hdDiv"></div>
</body>
</html>
