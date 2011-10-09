<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ToolBar.ascx.cs" Inherits="DSAdmin_UserControl_ToolBar" %>
<link href="/DSAdmin/UserControl/Css/ToolBar.css" rel="stylesheet" type="text/css" />
<div class="toolbarctn">
    <ul runat="server" id="TbCtn"></ul>
    <div class="paperctn"><webdiyer:AspNetPager NumericButtonCount="6" AlwaysShow="true" PageSize="16"  PageIndexBoxStyle="border:solid 1px #7fa153;line-height:16px; background-color:Transparent" SubmitButtonStyle="background-color:Transparent;margin-left:3px;border:solid 1px #7fa153;width:30px;line-height:12px;height:20px;"  runat="server" ID="paper"></webdiyer:AspNetPager></div>
</div>