<%@ Page Title="" Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="CtfPost.aspx.cs" Inherits="Member_Manage_ComInfo_CtfPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="Stylesheet" type="text/css" href="Css/ctfpost.css" />
 
<script type="text/javascript" src="/js/ajaxupload.js"></script>
<script type="text/javascript" src="js/CtfPost.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">填写证书信息</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="Remind">
   <div class="red"> 重要提醒：</div> 
   1、上传证书可以提高企业信用级别，赢得买家信赖！请认真填写、仔细填写。 <br />
   2、为了顺利通过审核，请如实填写证书上的相关信息。
</div>
<form class="mstForm">
<ul class="ctList">
    <li><span class="sp_filed">选择证书类别：<label class="star">*</label></span><div class="floatL">
        <select>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <option><%#Container.DataItem %></option>
                </ItemTemplate>
            </asp:Repeater>
        </select>
    </div></li>
    <li><span class="sp_filed">证书名称：<label class="star">*</label></span><div class="floatL">
        <input name="ctfname" class="txtbox input-bg" />
    </div></li>
    <li><span class="sp_filed">生效时间：<label class="star">*</label></span><div class="floatL">
        <input class="txtbox input-bg date" name="startdate"  onfocus="calendar()"  />
    </div></li>
    <li><span class="sp_filed">截止时间：<label class="star">&nbsp;</label></span><div class="floatL">
        <input class="txtbox input-bg date" name="enddate"  onfocus="calendar()" />
        <div class="remark gray">如果证书上有，必须填写。</div>
    </div></li><li><span class="sp_filed">证书编号：<label class="star">&nbsp;</label></span><div class="floatL">
        <input class="txtbox input-bg"  />
    </div></li>
    <li><span class="sp_filed">发证机构：<label class="star">*</label></span><div class="floatL">
        <input class="txtbox input-bg" name="issag"  />
    </div></li>
    <li><span class="sp_filed">发证机构电话：<label class="star">&nbsp;</label></span><div class="floatL">
        <input class="txtbox input-bg" name="issphone"  />
    </div></li>
    <li><span class="sp_filed">发证机构网址：<label class="star">&nbsp;</label></span><div class="floatL">
        <input class="txtbox input-bg" name="isswebsite" style="width:300px;" />
    </div></li>
    <li><span class="sp_filed">上传证书：<label class="star">*</label></span><div class="floatL">
        <input type="file" class="txtbox input-bg" name="ctfimg" id="ctfimg"  />
        <div class="remark gray">证书图片格式必须为<span class="red"> <b>jpg</b> </span>或<span class="red"> <b>gif</b> </span>,图片大小不超过<span class="red"> <b>1M</b> </span>(1024KB)</div>
    </div></li>
    <li><span class="sp_filed">证书介绍：<label class="star">&nbsp;</label></span><div class="floatL">
        <textarea class="input-bg ctf-detail" name="ctfprofile"></textarea>
    </div></li>
    <li><span class="sp_filed">&nbsp;</span><a class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">提交审核</span><span class="cb_r">&nbsp;</span></a></li>
</ul>
</form>
</asp:Content>

