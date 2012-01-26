<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Image_List.aspx.cs" Inherits="Member_Manage_Album_Image_List" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server"> 
<link href="css/list.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/image_list.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="alb_id" value="<%=Request.QueryString["id"] %>" />
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
                <table cellpadding=0 cellspacing=0 class="imgwrap">
                    <tr>
                        <td valign="middle">
                            <img id="imgcovert"  onload="changeImg(this,102,128)" onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" />
                        </td>
                    </tr>
                </table>
              
            </div>
            <div class="covertR">
                <div class="cvritem">相册<span class="albname"> <%#Eval("albumName") %> </span>共有 <%#Eval("PictureNum")%> 张相片<a an="<%#Eval("AlbumName")%>" pm="<%#Eval("Permissions") %>" pwd="<%#Eval("password") %>" aid="<%#Eval("id") %>"  href="javascript:;" class="edit_alb2">修改相册属性</a></div>
                <div class="cvritem"><a href="javascript:;" id="addImg" class="alkbtn"><div class="btnL"></div><div class="btnM">添加新图片</div><div class="btnR"></div></a> <a class="back" href="Album_List.aspx">返回相册列表</a></div>
                <div class="cvritem"><span class="permiss"><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions), Eval("Permissions"))%></span></div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
<div class="list_ctn">
    <div class="hode">&nbsp;</div>
    <div class="img_wrap">
        <div class="toobar">
            <input type="checkbox" id="chk_all" /><label for="chk_all">全部选择</label>
            <a class="img_del" href="javascript:;">删除</a> <a class="img_move" href="javascript:;">
                移动</a> 当前排序：<select id="order_by">
                    <option>新相片在前</option>
                    <option>新相片在后</option>
                </select>&nbsp;&nbsp;
            <a href="javascript:;" id="pre">&lt;&lt;上一页</a> <span id="ctpind">1</span>/<span
                id="pgcount"><%=ViewState["pageCount"]%></span> <a href="javascript:;" id="next">下一页&gt;&gt;</a>
            <input id="pgbox" class="txtbox" /><input type="button" id="jump" value="Go" />
        </div>
        <ul class="img_list">
            <asp:Repeater ID="Repeater4" runat="server">
                <ItemTemplate>
                    <li>
                        <div class="ctnimg">
                            <div class="img_ctn">
                                <img onload="changeImg(this,64,64)" onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                    src="/Resource/<%#Eval("ImgUrl") %>/<%#Eval("ImgName") %>" /></div>
                            <div class="imgname">
                                <input type="checkbox" imgid="<%#Eval("id") %>" id="imgchk<%#Container.ItemIndex %>" /><label for="imgchk<%#Container.ItemIndex %>"><%#Eval("imgName") %>中</label>
                            </div>
                            <a href="javascript:;"  class="setcovert">设为封面</a>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
    <div class="hode hdbt">&nbsp;</div>
</div>

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

