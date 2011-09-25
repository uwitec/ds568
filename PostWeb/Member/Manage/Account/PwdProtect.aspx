<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="PwdProtect.aspx.cs" Inherits="Member_Manage_Account_PwdProtect" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Css/PwdProtect.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/PwdProtect.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">密保问题管理</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<ul class="ctList">
    <li><span>密保问题：<label class="star">*</label></span>
        <select  id="confirm_question" class="safeQuestion"	name="passsafe_question">
			<option value="" selected>-------请您选择------</option>
			<option value="您母亲的姓名是？">您母亲的姓名是？</option>
			<option value="您父亲的姓名是？">您父亲的姓名是？</option>
			<option value="您配偶的姓名是？">您配偶的姓名是？</option>
			<option value="我母亲的生日？">我母亲的生日？</option>
			<option value="我最喜欢的颜色？">我最喜欢的颜色？</option>
			<option value="我最欣赏的一位名人？">我最欣赏的一位名人？</option>
			<option value="7">其他</option>
		</select>
    </li>
    <li class="ctnOq"><span>输入其他问题：<label class="star">*</label></span><input type="text" class="txtbox"  id="otherQuestion" name="otherQuestion" maxlength="50" /></li>
    <li><span>密保答案：<label class="star">*</label></span><input type="text" class="txtbox"  id="answer" name="answer" maxlength="20" /></li>
    <li><span>确认密保答案：<label class="star">*</label></span><input type="text" class="txtbox"  id="answer2" name="answer2" maxlength="20" /></li>
    
    <li><span>&nbsp;</span><asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="保存" /></li>
</ul>
<div class="validSuccess">
    <div class="sicon floatL"></div>
    <div class="sccon floatL"><b>您的密保问题已设置！</b><br />
        您可以 <a href="javascript:;" id="chgquestion">修改密保问题</a> 
    </div>
</div>
<div id="popwindow" class="popwindow" >
    <div class="info">修改密保问题前需先完成安全验证</div>
    <ul>
        <li><span>密码保护问题：</span><input type="text" class="txtbox popquestion" readonly value="<%=ViewState["question"] %>"  maxlength="50" /></li>
        <li><span>密码保护答案：</span><input type="text" class="txtbox"  id="answer3" name="answer3" maxlength="50" /></li>
        <li><span>&nbsp;</span><input type="button" value="确定" id="popsub" class="subBtn" /></li>
    </ul>
</div>
</asp:Content>

