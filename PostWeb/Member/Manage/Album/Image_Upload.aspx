<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Image_Upload.aspx.cs" Inherits="Member_Manage_Album_Image_Upload" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/list.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/image_upload.js"></script>
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
<div class="abhdctn overflowAuto">
    <div class="abtips step"><b>步骤一 挑选上传图片的相册</b> 或</div><a href="javascript:;" id="addAlbum" class="alkbtn"><div class="btnL"></div><div class="btnM">新建相册</div><div class="btnR"></div></a>
</div>
<ul class="listctn overflowAuto">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <li class="ab_out" aid="<%#Eval("id") %>">
                <div class="albbg">
                    <img onload="changeImg(this,102,128)"   onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" />
                </div>
                <div class="albtitle"><%#Eval("AlbumName")%>&nbsp;<span>(<%#Eval("PictureNum")%>)</span></div>
                <div class="albtime gray"><%#((DateTime)Eval("CreateDate")).ToShortDateString()%><span><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions), Eval("Permissions"))%></span></div>
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
<div class="abhdctn overflowAuto">
    <div class="abtips step2"><b>步骤二 上传图片</b></div>
</div>
<ul class="upload_type_wrap">
    <li class="current_ut"><a  href="javascript:;">普通上传</a></li><li><a href="javascript:;">单张图片上传</a></li>
</ul>
<div class="ulbtn" >
<a href="javascript:;"  class="alkbtn"><div class="btnL"></div><div class="btnM">请选择图片<span class="ultip"> 可多选</span></div><div class="btnR"></div></a></div>
<div class="upload_detail_wrap">
   <ul class="detail_head">
       <li class="dh_1">待上传图片文件名列表</li><li class="dh_2">大小</li><li class="dh_3">操作</li>
   </ul>
   <div class="detail_body">
      <div class="bd_left">
        <div class="upimg_list"></div>
        <div class="upimg_list_info">
            <span>0</span> 张图片<span class="mgl"></span>
            <b>总大小 <span>0 B</span></b>
        </div>
      </div>
      <div class="bd_right">
        普通上传一次最多可上传<span class="red">50张</span>，单张最大 <span class="red">200 KB</span>，若图片大小超过 <span class="red">200 KB</span>，请压缩处理后再上传。<br />
        只支持JPG、GIF、BMP、PNG格式图片，请勿上传违规图片。<br />
        单个相册最多存放<span class="red">200张</span>图片。
      </div>
   </div>
</div>
<ul class="acton_wrap overflowAuto" >
    <li class="at_1"><input type="checkbox" id="imgsr" /><label for="imgsr" class="gray">添加图片水印</label><a href="#"> 设置图片水印</a></li>
    <li><a href="javascript:;" class="alkbtn dsab"><div class="btnL"></div><div class="btnM">全部删除</div><div class="btnR"></div></a></li>
    <li><a href="javascript:;" class="alkbtn dsab"><div class="btnL"></div><div class="btnM">上传图片</div><div class="btnR"></div></a></li>
    <li class="at_4 gray">别忘记上传图片的最后一步哦</li>
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

