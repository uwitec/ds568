<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true"  CodeFile="List.aspx.cs" Inherits="Member_Manage_Offer_List" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="Stylesheet" type="text/css" href="Css/List.css" />
<script type="text/javascript" src="Js/List.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="showType" value="<%=Request["show_type"] %>" />
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
<div class="proctn">
    <table cellpadding=0 cellspacing=0 class="tblist">
        <tr><th colspan=2>图片</th><th>标题</th><th>价格</th><th>自定义分类</th><th>到期时间</th><th>操作</th></tr>
        <tr><td colspan=7 class="actbar"><input type="checkbox" id="chkAll" /><label for="chkAll">全选</label> 将选中信息 <input type="button" value="加入自定义分类" id="btncat" class="btnbar" /> <input type="button" value="批量重发" id="btnReSend" class="btnbar" /> <input type="button" value="转为过期" id="btnExpri" class="btnbar" /> <input type="button" value="永久删除" id="btnDel" class="btnbar" /></td></tr>
        <asp:Repeater ID="Repeater2" runat="server">
            <ItemTemplate>
                <tr><td class="tdcb"><input type="checkbox" value="<%#Eval("id") %>" name="chb_pro" /></td><td><img src="<%#Eval("Img1") %>" onload="changeImg(this,80,80)" /></td><td><%#Eval("title") %></td><td>---</td><td><%#Eval("categoryname") %></td><td><%#((DateTime)Eval("ExpiredDate")).ToString("yyyy-MM-dd")%></td><td><a href="post.aspx?id=<%#Eval("id") %>">修改</a> / <a href="#">重发</a></td></tr>        
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr class="altr"><td class="tdcb"><input type="checkbox" value="<%#Eval("id") %>" name="chb_pro" /></td><td><img src="<%#Eval("Img1") %>" onload="changeImg(this,80,80)" /></td><td><%#Eval("title") %></td><td>---</td><td><%#Eval("categoryname")%></td><td><%#((DateTime)Eval("ExpiredDate")).ToString("yyyy-MM-dd")%></td><td><a href="post.aspx?id=<%#Eval("id") %>">修改</a> / <a href="#">重发</a></td></tr>        
            </AlternatingItemTemplate>
        </asp:Repeater>
    </table>
</div>
</asp:Content>

