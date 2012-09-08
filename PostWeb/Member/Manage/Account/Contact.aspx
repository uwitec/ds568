<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Member_Manage_Account_Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Css/Contact.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/Contact.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li class="mn-wrap-crt">
        <div class="mLeft"></div>
        <div class="mMiddle">联系信息</div>
        <div class="mRight"></div>
    </li>
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">个人头像</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<form id="form1">
<ul class="ctList">
    <li><span>电子邮箱：<label class="star">*</label></span><input type="text" class="txtbox" value="<%=_userData.vMember.Email %>" id="email" name="email" maxlength="100" /></li>
    <li><span>联系人：<label class="star">*</label></span><input type="text" class="txtbox" value="<%=_userData.vMember.TrueName %>" id="trueName" name="trueName" maxlength="20" /></li>
    <li><span>性别：<label class="star">*</label></span><input class="mType" name="sex" id="sex1" <%=string.IsNullOrEmpty(_userData.vMember.Gender) ? "" : (_userData.vMember.Gender.ToString().Equals("先生") ? "checked" : "")%> value="先生"  type="radio" /><label for="sex1">先生</label>
                        <input class="mType"  name="sex" id="sex2" <%=string.IsNullOrEmpty(_userData.vMember.Gender) ? "" : (_userData.vMember.Gender.ToString().Equals("女士") ? "checked" : "")%> value="女士" type="radio" /><label for="sex2">女士</label></li>
    <li><span>部门职位：<label class="star">*</label></span><input type="text" class="txtbox" value="<%=_userData.vMember.Position %>" id="position" name="position" maxlength="20" /></li>
    <li><span>电话：<label class="star">*</label></span><input class="txtbox phone-qh" value="<%=phoneqh %>" maxlength=4 name="phoneqh"   type="text" />-<input class="txtbox phone-hm" value="<%=phonehm %>" maxlength=9   name="phonehm" id="Text2" type="text" />-<input class="txtbox phone-fj" value="<%=phonefj %>" maxlength=4  name="phonefj" id="Text3" type="text" /></li>
    <li><span>QQ：<label class="star">*</label></span><input type="text"  class="txtbox qq" value="<%=_userData.vMember.QQ %>" maxlength=15 name="qq"/></li>
    <li><span>手机：&nbsp;</span><input class="txtbox mobile" name="mobile" value="<%=_userData.vMember.Mobile %>" id="mobile" type="text" /></li>
    <li><span>传真：&nbsp;</span><input class="txtbox fax-qh" name="faxqh" maxlength=4 value="<%=faxqh %>"  type="text" />-<input class="txtbox fax-hm" value="<%=faxhm %>" name="faxhm" maxlength=9   id="faxhm" type="text" />-<input class="txtbox fax-fj" value="<%=faxfj %>" name="faxfj" maxlength=4 id="faxfj"  type="text" /></li>
    <li><span>公司网址：&nbsp;</span><input type="text" id="webSite" value="<%=_userData.vMember.HomePage %>" class="txtbox" name="webSite" maxlength="200" /></li>
    <li><span>&nbsp;</span><input class="subBtn" type="button" value="保存" /><label id="subload" class="loading2 loadLeft">数据提交中…</label></li>
</ul>
</form>
<div class="atater">
    <div class="a_left">
        <div class="atater_img">
            <img  src="<%=string.IsNullOrEmpty(_userData.Member.Avater)?"#":_userData.Member.Avater %>" onerror="javascript:noAvater(this)" alt="个人头像" width="100" height="100" />
            <script type="text/javascript">
                function noAvater(obj) {
                    obj.src = 'http://i04.c.aliimg.com/images/member/da1_r13_c21.gif';
                    $(".up_tips_h span").text("您目前还没有头像，");
                    $(".up_tips_h a").text("点此上传");
                }
            </script>
        </div>
        <div class="a_tips">您当前的头像</div>
    </div>
    <div class="a_right">
        <div class="up_tips_h"><span>不满意自己的头像，请 </span><a id="lk_up"  href="javascript:;">点此修改</a></div>
        <div class="up_tips_m">上传图片要求：</div>
        <div class="up_tips_b">请使用真实头像，展示风格支持JPG, JPEG, GIF, PNG风格，支持512KB以内的图片。</div>
    </div>
</div>
</asp:Content>