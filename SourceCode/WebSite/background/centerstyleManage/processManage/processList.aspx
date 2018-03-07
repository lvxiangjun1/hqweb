﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="processList.aspx.cs" Inherits="background_centerstyleManage_processManage_processList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="processListForm" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            两周年历程</div>
        <div class="mainTopRight">
            &nbsp;</div>
        <div class="mainSearch2">
            <asp:Button ID="btnAdd8" runat="server" Text="添加" OnClick="btnAdd_Click" CssClass="scbtn2" /></div>
    </div>
    <div class="mainContant">
        <asp:GridView ID="GridViewDoctor" CssClass="tableclock2" CellSpacing="1" runat="server"
            AutoGenerateColumns="False" GridLines="None" DataKeyNames="ID" OnRowDataBound="GridViewDoctor_RowDataBound"
            OnRowDeleting="GridViewDoctor_RowDeleting" OnRowEditing="GridViewDoctor_RowEditing"
            Width="100%">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="编号">
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="TITLE" HeaderText="标题">
                    <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="HITS" HeaderText="排序">
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="USERNAME" HeaderText="添加用户">
                    <ItemStyle HorizontalAlign="Center" Width="80px" />
                </asp:BoundField>
                <asp:BoundField DataField="INSERTTIME" HeaderText="添加时间">
                    <ItemStyle HorizontalAlign="Center" Width="120px" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="修改" ShowHeader="False">
                    <ItemStyle ForeColor="Red" HorizontalAlign="Center" Width="40px" />
                    <ItemTemplate>
                        <asp:ImageButton ID="LinkBtnEdit" runat="server" CausesValidation="False" CommandName="Edit"
                            ImageUrl="../../images/xiugai.gif" AlternateText="修改" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="操作" ShowHeader="False">
                    <ItemStyle ForeColor="Red" HorizontalAlign="Center" Width="40px" />
                    <ItemTemplate>
                        <asp:ImageButton ID="BtnDelete" runat="server" CausesValidation="False" CommandName="Delete"
                            ImageUrl="../../images/zhuxiao.gif" AlternateText="删除" OnClientClick="return confirm('确认要删除此行信息吗？')" />
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
        <div class="tianjia">
            <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" CssClass="scbtn2" /></div>
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
            <ul class="paginList">
                <webdiyer:AspNetPager ID="MyAspNetPager" CssClass="paginItem" CurrentPageButtonClass="cpb"
                    runat="server" AlwaysShow="True" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页"
                    PageSize="10" PrevPageText="上一页" ShowInputBox="Auto" OnPageChanged="MyAspNetPager_PageChanged"
                    SubmitButtonText="确定" TextBeforeInputBox="第" TextAfterInputBox="页" InputBoxClass="shuru11"
                    SubmitButtonClass="queding" SubmitButtonStyle="" NumericButtonCount="5" CustomInfoTextAlign="Right">
                </webdiyer:AspNetPager>
            </ul>
        </div>
    </form>
</body>
</html>
