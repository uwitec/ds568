<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true"  CodeFile="List.aspx.cs" Inherits="Member_Manage_Offer_List" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="Stylesheet" type="text/css" href="Css/List.css" />
<script type="text/javascript" src="Js/List.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="showType" value="<%=Request.QueryString["show_type"] %>" />
<input type="hidden" name="action" id="action" />
<ul class="hmenu">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
             <li state="<%#(byte)Container.DataItem %>">
                 <div class="mLeft lunsl"></div>
                 <div class="mMiddle munsl"><a href="?show_type=<%#(byte)Container.DataItem %>"><%#Container.DataItem %><span>(<%#GetProCount((byte)Container.DataItem)%>)</span></a></div>
                 <div class="mRight runsl"></div>
            </li>
        </ItemTemplate>
    </asp:Repeater>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="scctn">信息标题：<input name="keyword" class="txtbox keyword" />&nbsp;<input id="btnSearch" type="button" value="查询" /></div>
<table cellpadding=0 cellspacing=0 class="tblist">
    <tr><th colspan=2>图片</th><th>标题</th><th>价格</th><th>自定义分类</th><th>到期时间</th><th>操作</th></tr>
    <tr><td colspan=7 class="actbar"><input type="checkbox" id="chkAll" /><label for="chkAll">全选</label> 将选中信息 <input type="button" value="加入自定义分类" id="btncat" class="btnbar" /> <input type="button" value="批量重发" id="btnReSend" class="btnbar" /> <input type="button" value="转为过期" id="btnExpri" class="btnbar" /> <asp:Button ID="btnDel" runat="server" Text="永久删除" CssClass="btnbar btnDel" /></td></tr>
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <tr><td class="tdcb"><input type="checkbox" name="chb_pro" /></td><td><img src="<%#Eval("Img1") %>" onload="changeImg(this,80,80)" /></td><td><%#Eval("title") %></td><td>价格</td><td><%#Eval("shopcatid") %></td><td><%#((DateTime)Eval("ExpiredDate")).ToString("yyyy-MM-dd")%></td><td><a href="#">修改</a> / <a href="#">重发</a></td></tr>        
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr class="altr"><td class="tdcb"><input type="checkbox" name="chb_pro" /></td><td><img src="<%#Eval("Img1") %>" onload="changeImg(this,80,80)" /></td><td><%#Eval("title") %></td><td>价格</td><td><%#Eval("shopcatid") %></td><td><%#((DateTime)Eval("ExpiredDate")).ToString("yyyy-MM-dd")%></td><td><a href="#">修改</a> / <a href="#">重发</a></td></tr>        
        </AlternatingItemTemplate>
    </asp:Repeater>
</table>
  <webdiyer:AspNetPager CssClass="pages"  AlwaysShowFirstLastPageNumber="true"  ShowDisabledButtons="false" ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager1" NumericButtonCount="7" runat="server" 
        FirstPageText="首页" LastPageText="尾页" TextBeforePageIndexBox="共100页 第"  TextAfterPageIndexBox="页 "  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"  ShowPageIndexBox="Always" PrevPageText="上一页">
    </webdiyer:AspNetPager>
</asp:Content>

