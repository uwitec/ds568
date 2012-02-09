<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Edit_Image.aspx.cs" Inherits="Member_Manage_Album_Edit_Image" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/list.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">上传图片</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="saveInfo vsb">
    <ul>
        <li class="info_1">您本次上传图片结果： 成功<span class="red"><%=Request.QueryString["fc"] %></span>张 。</li>
        <li>1. 请为上传成功的图片编辑标题并添加描述。点击保存后，您所编辑的内容会被保存。</li>
        <li>2. 您可使用“向下复制”功能，对具有相同特性的图片进行描述。</li>
        <li>3. 若您上传失败，请检查文件类型是否符合要求并尝试重新上传。</li>
    </ul>
</div>
<div class="abhdctn overflowAuto">
    <div class="abtips step3"><b>步骤三 添加标题与内容</b></div>
</div>
</asp:Content>

