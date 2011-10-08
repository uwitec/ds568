<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ToolBar.ascx.cs" Inherits="DSAdmin_UserControl_ToolBar" %>
<link href="/DSAdmin/UserControl/Css/ToolBar.css" rel="stylesheet" type="text/css" />
<ul runat="server" id="TbCtn" class="toolbarctn">
  <li><webdiyer:AspNetPager runat="server" ID="paper"></webdiyer:AspNetPager></li>
</ul>