<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="Member_Manage_Offer_List" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script type="text/javascript" src="Js/List.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="showType" value="<%=Request.QueryString["show_type"] %>" />
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
</asp:Content>

