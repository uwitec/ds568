<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Album_List.aspx.cs" Inherits="Member_Manage_Album_Album_List" Title="Untitled Page" %>

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
    <div class="abtips">共有 6 本相册，您可以</div><a href="javascript:;" id="addAlbum" class="alkbtn"><div class="btnL"></div><div class="btnM">新建相册</div><div class="btnR"></div></a>
    <div class="odctn">当前排序：<select id="order">
            <option>新相册在前</option>
            <option> 新相册在后</option>
            <option>最近上传的在前</option>
            <option>最近上传的在后</option>   
        </select></div>
    <div class="pgctn">
        <a href="javascript:;" id="pre">&lt;&lt;上一页</a> <span id="ctpind">1</span>/<span id="pgcount"><%=ViewState["pageCount"]%></span> <a href="javascript:;" id="next">下一页&gt;&gt;</a> <input id="pgbox" class="txtbox" /><input type="button" value="Go" />
    </div>
</div>
<ul class="listctn overflowAuto">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <li class="ab_out">
                <div class="albbg">
                    <img onload="changeImg(this,102,128)"   onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" />
                    <span>
                        <a class="edit_alb" href="javascript:;">编辑</a><a class="del_alb" an="<%#Eval("AlbumName")%>" aid="<%#Eval("id") %>" href="javascript:;">删除</a>
                    </span>
                </div>
                <div class="albtitle"><%#Eval("AlbumName")%>&nbsp;<span>(<%#Eval("PictureNum")%>)</span></div>
                <div class="albtime gray"><%#((DateTime)Eval("CreateDate")).ToShortDateString()%><span><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions), Eval("Permissions"))%></span></div>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
<div class="wbctn">
    <div class="wbwrap">
    <div class="item">
        <div class="itemL">相册名称：</div><div class="itemR"><input class="txtbox albumName" /></div>
    </div>
    <div class="item">
        <div class="itemL">访问权限：</div><div class="itemR">
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <input type="radio"  value="<%#(byte)Container.DataItem %>" id="pm<%#Container.ItemIndex %>" name="pm"/><label for="pm<%#Container.ItemIndex %>"><%#Container.DataItem %></label>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <div class="item psw">
        <div class="itemL">访问密码：</div><div class="itemR"><input class="txtbox pmpsd" /></div>
    </div>
    <div class="item">
       <div class="btnctn">
          <a href="javascript:;" class="alkbtn btnsub"><div class="btnL"></div><div class="btnM">确定</div><div class="btnR"></div></a>
          <a href="javascript:;" class="alkbtn wBox_close"><div class="btnL"></div><div class="btnM">取消</div><div class="btnR"></div></a>
       </div>
    </div>
    </div>
</div>
</asp:Content>

