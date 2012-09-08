<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Password.aspx.cs" Inherits="Member_Manage_Account_Password" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Css/password.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/password.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li class="mn-wrap-crt">
        <div class="mLeft"></div>
        <div class="mMiddle">修改密码</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<form id="form1" runat="server" class="mstForm">
<ul class="ctList">
    <li><span>旧密码：<label class="star">*</label></span><input type="password" class="txtbox"   id="pwd" name="pwd" maxlength="20" /></li>
    <li><span>新密码：<label class="star">*</label></span><input type="password" class="txtbox"  id="npwd" name="npwd" maxlength="20" /></li>
    <li><span>确认密码：<label class="star">*</label></span><input type="password" class="txtbox"  id="npwd2" name="npwd2" maxlength="20" /></li>
    
    <li><span>&nbsp;</span><asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="保存" /></li>
</ul>
</form>
</asp:Content>

