<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="news_list.aspx.cs" Inherits="Member_Manage_News_news_list" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="Css/news_list.css" rel="stylesheet" type="text/css" />
 <script type="text/javascript" src="/js/pager/pagination.js"></script>
<link href="/js/pager/pagination.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/news_list.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">管理动态</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="scctn">信息标题：<input name="keyword" class="txtbox keyword" />&nbsp;<input id="btnSearch" type="button" value="查询" /></div>
<input type="hidden" id="rc" value="<%=ViewState["rc"] %>" />
<table cellpadding=0 cellspacing=0 class="tblist">
    <tr><th >标题</th><th>排序</th><th>更新时间</th><th>操作</th></tr>
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <tr><td><%#Eval("title") %></td><td>--</td><td><%#Eval("updatedate") %></td><td>
                <div class="cmctn_1" ind="<%#Container.ItemIndex %>"><a href="edit.aspx?id=<%#Eval("id") %>"  class="lkedit">修改</a> / <a href="javascript:viod();"  class="lkdel" nid="<%#Eval("id") %>">删除</a></div>
            </td></tr>      
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr class="altr"><td><%#Eval("title") %></td><td>--</td><td><%#Eval("updatedate") %></td><td>
                <div class="cmctn_1" ind="<%#Container.ItemIndex %>"><a href="edit.aspx?id=<%#Eval("id") %>"  class="lkedit">修改</a> / <a href="javascript:viod();"  class="lkdel" nid="<%#Eval("id") %>">删除</a></div>
            </td></tr>   
        </AlternatingItemTemplate>
    </asp:Repeater>
</table>
<div class="pagerwrap"></div>
</asp:Content>

