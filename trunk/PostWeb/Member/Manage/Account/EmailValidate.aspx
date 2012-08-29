<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="EmailValidate.aspx.cs" Inherits="Member_Manage_Account_EmailValidate" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Css/EmailValidate.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/EmailValidate.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">邮箱验证</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<form id="form1" runat="server" class="mstForm">
<ul class="ctList">
    <li><span>电子邮箱：<label class="red">*</label></span><input type="hidden" runat="server" class="cemail" value="" id="cemail" name="cemail" /><input type="text" class="txtbox email" value="<%=ViewState["Email"] %>" id="email" name="email" maxlength="100" /></li>
    <li><span>&nbsp;</span><label class="msg"></label><a href="javascript:;" class="sendCC">发送验证码</a></li>
    <li><span>验证码：<label class="red">*</label></span><input type="text" class="txtbox gray" value="请输入6位验证码" id="valiCode" name="valiCode" maxlength="20" /></li>
    <li><span>&nbsp;</span><asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="确定" /></li>
</ul>
</form>
<div class="validSuccess">
    <div class="sicon floatL"></div>
    <div class="sccon floatL"><b>您的电子邮箱 <%=cemail.Value %>  已验证！</b><br />
        您可以 <a href="emailvalidate.aspx?action=modify">更换邮箱</a> 或 <a href="emailvalidate.aspx?action=cancle">取消验证</a> 
    </div>
</div>
<div class="cancelValidate">
    <div class="sicon floatL"></div>
    <div class="sccon floatL">
    <b>取消验证成功！</b><br />
    <a href="emailvalidate.aspx">重新验证邮箱</a>
    </div>
</div>
</asp:Content>

