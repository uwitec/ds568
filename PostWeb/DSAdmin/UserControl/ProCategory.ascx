<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProCategory.ascx.cs" Inherits="DSAdmin_UserControl_ProCategory" %>
 <asp:DropDownList ID="DropDownList1" Visible="false" AutoPostBack="true" DataTextField="CategoryName" DataValueField="ID" runat="server">
</asp:DropDownList>
<asp:DropDownList ID="DropDownList2" AutoPostBack="true" Visible="false" DataTextField="CategoryName" DataValueField="ID" runat="server">
<asp:ListItem Value="0">--二级类--</asp:ListItem>
</asp:DropDownList>
<asp:DropDownList ID="DropDownList3" DataTextField="CategoryName" Visible="false" DataValueField="ID"  runat="server">
<asp:ListItem Value="0">--三级类--</asp:ListItem>
</asp:DropDownList>