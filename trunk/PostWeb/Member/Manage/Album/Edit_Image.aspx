<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Edit_Image.aspx.cs" Inherits="Member_Manage_Album_Edit_Image" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/list.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/image_edit.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="albumid" value="<%=Request.QueryString["albumid"] %>" />
<ul class="hmenu">
    <li class="mn-wrap-crt">
        <div class="mLeft"></div>
        <div class="mMiddle">上传图片</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="saveInfo vsb">
    <div class="shado2">
        <ul>
            <li class="info_1">您本次上传图片结果： 成功<span class="red"><%=Request.QueryString["fc"] %></span>张 。</li>
            <li>1. 请为上传成功的图片编辑标题并添加描述。点击保存后，您所编辑的内容会被保存。</li>
            <li>2. 您可使用“向下复制”功能，对具有相同特性的图片进行描述。</li>
            <li>3. 若您上传失败，请检查文件类型是否符合要求并尝试重新上传。</li>
        </ul>
    </div>
</div>
<div class="abhdctn overflowAuto">
    <div class="abtips step3"><b>步骤三 添加标题与内容</b></div>
</div>
<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <div class="edit_row_wrap" imgid="<%#Eval("id") %>">
            <div class="row_left">
                <div class="picwrap">
                    <span class="sp1">
                       <img onload="changeImg(this,150,150)" onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'" src="/Resource/<%#Eval("ImgUrl") %>/<%#Eval("ImgName") %>" />
                    </span>
                </div>
                <div class="fcwrap"><input type="radio" name="fontcover" id="fontcover<%#Container.ItemIndex %>" /><label for="fontcover<%#Container.ItemIndex %>">设为封面</label></div>
            </div>
            <div class="row_right">
                <div class="r_wrap">
                    <div class="fdtitle">图片标题：</div>
                    <div class="fdcontent"><input class="txtbox" maxlength="30" value="<%#Eval("ImgTitle") %>" type="text" /></div>
                </div>
                <div class="r_wrap">
                    <div class="fdtitle">图片内容：</div>
                    <div class="fdcontent"><textarea class="txtbox"></textarea></div>
                </div>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>
<div class="btnwrap">
<a href="javascript:;" id="saveimg" class="alkbtn"><div class="btnL"></div><div class="btnM">保存设定</div><div class="btnR"></div></a>
</div>
</asp:Content>

