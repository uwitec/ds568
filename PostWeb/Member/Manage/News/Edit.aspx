<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Member_Manage_News_Edit" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script type="text/javascript" src="/KindEditor/kindeditor-min.js"></script>
<script type="text/javascript" src="/KindEditor/lang/zh_CN.js"></script>
<script type="text/javascript" src="js/edit.js"></script>
<link href="Css/Add.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" value="<%=Request.QueryString["id"] %>" id="nid" />
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">修改动态</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div>
    <div class="item">
        <div class="iLeft floatL">
            动态标题：</div>
        <div class="iRight floatL">
            <input name="news_title" maxlength="150" value="<%=ViewState["title"] %>" class="txtbox" />
        </div>
    </div>
     <div class="item">
        <div class="iLeft floatL">
            动态内容：</div>
        <div class="iRight floatL">
            <textarea id="content" name="content"><%=ViewState["content"] %></textarea>
        </div>
    </div>
     <div class="item">
        <div class="iLeft floatL">
            &nbsp;</div>
        <div class="iRight floatL">
            <span class="loading2">数据提交中…</span><input type="button" id="save" value="保存" />
        </div>
    </div>
</div>
</asp:Content>

