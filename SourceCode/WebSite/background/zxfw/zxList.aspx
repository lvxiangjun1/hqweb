<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zxList.aspx.cs" Inherits="background_zxfw_zxList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/main2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="zxList" runat="server">
    <div class="mainTop">
        <div class="mainTopTitle">
            咨询服务</div>
        <div class="mainTopRight">
            &nbsp;</div><div class="mainSearch2"> <asp:Button ID="btnAdd9" runat="server" Text="添加" OnClick="btnAdd_Click" CssClass="scbtn2" /></div> 
    </div>
    <div class="mainContant"><div  class="tableclock">
        <table width="100%" border="0" cellspacing="1" cellpadding="0" align="center">
            <tr>
                <td width="12%" align="center" class="wenziNew">
                    标题：
                </td>
                <td class="wenzi1">
                    <asp:TextBox ID="txtTITLE" runat="server" CssClass="scinput"></asp:TextBox>
                </td>
                   <td width="12%" align="center" class="wenziNew">
                    状态：
                </td>
                <td class="wenzi1"  >
                    <asp:RadioButtonList ID="rblStatus" runat="server" RepeatDirection="Horizontal" CssClass="chkListItem">
                        <asp:ListItem Value="0" Selected="True">发布</asp:ListItem>
                  
                        <asp:ListItem Value="-1">删除</asp:ListItem>
                    </asp:RadioButtonList>
                </td>    <td width="60px"  rowspan="2" class="wenzi1" align="center" > <asp:Button ID="BtnSearch" runat="server" Text="搜索" OnClick="BtnSearch_Click" CssClass="scbtn" /></td>
             
            </tr>
            <tr>
                <td width="12%" align="center" class="wenziNew">
                    问题：
                </td>
                <td class="wenzi1" colspan="3">
                    <asp:TextBox ID="txtCOPYRIGHT" runat="server" CssClass="scinput"></asp:TextBox>
                </td>
               
                
            </tr>
         
        </table></div>
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
                <asp:BoundField DataField="PUBLISHTIME" HeaderText="添加日期">
                    <ItemStyle HorizontalAlign="Center" Width="130px"/>
                </asp:BoundField>
               
               
                <asp:BoundField DataField="STATUS" HeaderText="状态">
                    <ItemStyle HorizontalAlign="Center" Width="50px" />
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
                            AlternateText="删除" OnClientClick="return confirm('确认要删除此行信息吗？')" OnClick="BtnDelete_Click" />
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
   
    </form>
</body>
</html>
