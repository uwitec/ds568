﻿<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Image_Detail.aspx.cs" Inherits="Member_Manage_Album_Image_Detail" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
<link href="css/list.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/Image_Detail.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="img_id" value="<%=Request.QueryString["img_id"] %>" />
<input type="hidden" id="FrontCover" value="<%=ViewState["FrontCover"] %>" />
<ul class="hmenu">
    <li class="mn-wrap-crt">
        <div class="mLeft"></div>
        <div class="mMiddle">相册管理</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="abhdctn overflowAuto">
    <div class="abtips"><a href="Album_List.aspx">所有相册</a> > <a href="Image_List.aspx?id=<%=ViewState["albid"] %>" class="albname"><%=ViewState["albname"] %></a> > <span id="crtimgname"><%=ViewState["imgtitle"] %></span></div>
</div>
<div class="conWrap">
    <div class="dt_left">
        <div class="picwrap">
            <span class="sp1">
               <img onload="changeImg(this,450,600)" onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'" src="<%=ViewState["imgurl"] %>" />
            </span>
        </div>
        <div class="actionctn"><span class="hascv">已设为相册封面</span><a href="javascript:;">设为相册封面</a><a href="javascript:;">移动</a><a href="javascript:;">删除</a><a href="javascript:;">设为相册封面</a><a href="javascript:;">复制图片地址</a></div>
        <div class="saveInfo">
            <div class="shado">编辑图片标题与描述成功！</div>
        </div>
        <div class="infoctn">
            <div>图片标题：<span class="remark">（1-30个中文字或英文字母）</span></div>
            <div><input class="imgtitle" maxlength="30" /></div>
            <div class="desctn">图片描述：<span class="remark">（0-2000个中文字、英文字母、数字或符号）</span></div>
            <div><textarea  class="imgdes"></textarea></div>
        </div>
        <div class="subctn"><a href="javascript:;" id="save" class="alkbtn dsab"><div class="btnL"></div><div class="btnM">确定</div><div class="btnR"></div></a></div>
    </div>
    <div class="dt_right">
        <div class="npctn">
            <div class="hdtitle"><div class="fwimg"></div><b><%=ViewState["albname"] %></b> 中的其他相片：</div>
            <div class="subwrap">
                <ul>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <li imgid=<%#Eval("id") %> >
                                <div class="thctn"><img onload="changeImg(this,64,64)" src="/Resource/<%#Eval("ImgUrl") %>/<%#Eval("ImgName") %>" /></div>
                                <div class="tlctn"><%#Eval("imgtitle") %></div>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <div class="corect">&nbsp;</div>
            </div>
            <div class="overflowAuto">
                <a href="javascript:;" class="preImg">上一张</a><a href="javascript:;" class="nextImg">下一张</a>
            </div>
        </div>
    </div>
</div>
</asp:Content>

