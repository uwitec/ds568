<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Image_List.aspx.cs" Inherits="Member_Manage_Album_Image_List" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/list.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/imglist.js"></script>
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
    <div class="abtips"><a href="Album_List.aspx">所有相册</a> > <span class="albname"><%=ViewState["albname"] %></span></div>
</div>
<div class="covertwrap">
    <asp:Repeater ID="Repeater3" runat="server">
        <ItemTemplate>
            <div class="covertL">
                <div>
                    <img onload="changeImg(this,102,128)" onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" /></div>
            </div>
            <div class="covertR">
                <div class="cvritem">相册<span class="albname"> <%#Eval("albumName") %> </span>共有 <%#Eval("PictureNum")%> 张相片<a href="javascript:;" class="edit_alb2">修改相册属性</a></div>
                <div class="cvritem"><a href="javascript:;" id="addImg" class="alkbtn"><div class="btnL"></div><div class="btnM">添加新图片</div><div class="btnR"></div></a> <a class="back" href="Album_List.aspx">返回相册列表</a></div>
                <div class="cvritem"><span class="permiss"><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions), Eval("Permissions"))%></span></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="hode"></div>
<ul class="listctn overflowAuto" style="display:none;">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <li class="ab_out">
                <div class="albbg">
                    <img onload="changeImg(this,102,128)"   onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" />
                    <span>
                        <a class="edit_alb" an="<%#Eval("AlbumName")%>" pm="<%#Eval("Permissions") %>" pwd="<%#Eval("password") %>" aid="<%#Eval("id") %>" href="javascript:;">编辑</a><a class="del_alb" an="<%#Eval("AlbumName")%>" aid="<%#Eval("id") %>" href="javascript:;">删除</a>
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
        <div class="itemL">相册名称：</div><div class="itemR"><input maxlength="20" class="txtbox albumName" /></div>
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
        <div class="itemL">访问密码：</div><div class="itemR"><input maxlength="20" class="txtbox pmpsd" /></div>
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

