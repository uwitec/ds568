<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Member_Manage_Account_Contact" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Css/Contact.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/Contact.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">联系信息</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<ul class="ctList">
    <li><span>电子邮箱：<label class="star">*</label></span><input type="text" class="txtbox" id="email" name="email" maxlength="100" /></li>
    <li><span>联系人：<label class="star">*</label></span><input type="text" class="txtbox" id="trueName" name="trueName" maxlength="20" /></li>
    <li><span>性别：<label class="star">*</label></span><input class="mType" name="sex" id="sex1" value="先生"  type="radio" checked /><label for="sex1">先生</label>
                        <input class="mType"  name="sex" id="sex2" value="女士" type="radio" /><label for="sex2">女士</label></li>
    <li><span>部门职位：<label class="star">*</label></span><input type="text" class="txtbox" id="department" name="department" maxlength="20" /></li>
    <li><span>电话：<label class="star">*</label></span><input class="txtbox phone-qh"  maxlength=4 name="phoneqh" id="phoneqh" type="text" />-<input class="txtbox phone-hm" maxlength=9   name="phonehm" id="phonehm" type="text" />-<input class="txtbox phone-fj" maxlength=4  name="phonefj" id="phonefj" type="text" /></li>
    <li><span>手机：&nbsp;</span><input class="txtbox mobile" name="mobile" id="mobile" type="text" /></li>
    <li><span>传真：&nbsp;</span><input class="txtbox fax-qh" name="faxqh" maxlength=4   id="faxqh" type="text" />-<input class="txtbox fax-hm" name="faxhm" maxlength=9   id="faxhm" type="text" />-<input class="txtbox fax-fj" name="faxfj" maxlength=4 id="faxfj"  type="text" /></li>
    <li><span>公司网址：&nbsp;</span><input type="text" id="webSite" class="txtbox" name="webSite" maxlength="200" /></li>
    <li><span></span><asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="保存" /></li>
</ul>
</asp:Content>

