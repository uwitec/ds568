﻿<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Album_List.aspx.cs" Inherits="Member_Manage_Album_Album_List" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/list.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/list.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">相册管理</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="abhdctn overflowAuto">
    <div class="abtips">共有 6 本相册，您可以</div><a href="javascript:;" class="alkbtn"><div class="btnL"></div><div class="btnM">新建相册</div><div class="btnR"></div></a>
    <div class="odctn">当前排序：<select id="order">
            <option>新相册在前</option>
            <option> 新相册在后</option>
            <option>最近上传的在前</option>
            <option>最近上传的在后</option>   
        </select></div>
    <div class="pgctn">
        <a href="javascript:;" id="pre">&lt;&lt;上一页</a> <span id="ctpind">1</span>/<span id="pgcount">3</span> <a href="javascript:;" id="next">下一页&gt;&gt;</a> <input id="pgbox" class="txtbox" /><input type="button" value="Go" />
    </div>
</div>
<ul class="listctn overflowAuto">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <li class="ab_out">
                <div class="albbg">
                    <img onload="changImg(this,102,128)"   onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" />
                </div>
                <div class="albtitle"><%#Eval("AlbumName")%>&nbsp;<span>(<%#Eval("PictureNum")%>)</span></div>
                <div class="albtime"><%#((DateTime)Eval("CreateDate")).ToShortDateString()%><span><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions), Eval("Permissions"))%></span></div>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
</asp:Content>

