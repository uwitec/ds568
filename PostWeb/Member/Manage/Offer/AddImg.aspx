﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddImg.aspx.cs" EnableViewState="true" Inherits="Member_Manage_Offer_AddImg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>上传产品图片</title>
    <Custom:Header runat="server" ID="Header1" />
    <link href="<%=Common.Constant.WebConfig("Resource") %>/Css/Pager.css" rel="stylesheet" type="text/css" />
    <link href="Css/AddImg.css" rel="stylesheet" type="text/css" />
    <link rel="Stylesheet" href="/js/uploadify/uploadify.css" />
    <script type="text/javascript" src="/js/uploadify/swfobject.js"></script>
    <script type="text/javascript" src="/js/uploadify/jquery.uploadify.v2.1.4.min.js"></script>
    <script type="text/javascript" src="js/addimg.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <input type="hidden" value="<%=Request.QueryString["ind"] %>" id="hdind" />
  <ul class="headmn"><li class="tag">&nbsp;</li><li class="selmemo">选择您要添加图片的来源</li>
    <li class="split">&nbsp;</li>
    <li class="menu1"><div ind="1">图片管家</div></li>
    <li class="split">&nbsp;</li>
    <li class="menu2"><div ind="2">我的电脑</div></li>
  </ul>
  <div class="ctn" >
        <div class="ctnshow1">
            <div class="selctn gray"><asp:DropDownList ID="selAlbum" AutoPostBack="true" DataTextField="AlbumName" DataValueField="ID" runat="server">
                </asp:DropDownList> 请从您的图片管家中点击选择图片</div>
            <ul class="imgList">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <li ><img onload="changeImg(this,61,61)"   src="/Resource/<%#Eval("imgUrl") %>/<%#Eval("imgName") %>" /></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
            <!--=========分页开始========-->
            <div class="overflowAuto ppctn">
            <webdiyer:AspNetPager CssClass="pages"  AlwaysShowFirstLastPageNumber="true" HorizontalAlign="Center"  ShowDisabledButtons="false" PageSize="16"  ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager4" NumericButtonCount="7" runat="server" 
                FirstPageText="首页" LastPageText="尾页" TextBeforePageIndexBox="共100页 第"  TextAfterPageIndexBox="页 "  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"   PrevPageText="上一页">
            </webdiyer:AspNetPager></div>
        <!--=========分页结束========-->
        </div>
        <div class="ctnshow2">
            <div class="selctn gray">如果您不希望上传的图片在相册中公开展示，建议将图片上传到不公开相册中</div>
            <div class="item">
                <div class="itemL">选择相册：</div>
                <div >
                    <select name="selAlbum2" id="selAlbum2" runat="server" datatextfield="AlbumName" datavaluefield="id"></select>&nbsp;<a href="#" class="crtAlb">创建新相册</a>
                    <div id="cactn" style="display:none">
                        <div class="marginT20"></div>
                        <div class="abItem"><div class="abItemL">相册名称： </div><div class="abItemR"><input type="text" class="alname"  name="albumName" /></div></div>
                        <div class="abItem"><div class="abItemL">访问权限： </div><div class="abItemR"><input id="album-type-public"  disabled name="album-type1" 
                                    type="radio" value="V1" /><label for="album-type-public">公开</label>
                                <input id="album-type-secret"  disabled name="album-type2" 
                                    type="radio" value="V1" /><label for="album-type-secret">密码访问</label>
                                <input id="album-type-private" checked="checked" disabled name="album-type" 
                                    type="radio" value="V1" /><label for="album-type-private">不公开</label>
                                </div>
                       </div>
                       <div class="abItem cal">正在提交数据，请稍后</div>
                       <div class="abItem common"><a href="#" class="addAlbum">创建</a><a href="javascript:;" class="cancelAlbum wBox_close">取消</a></div>
                    </div>
               </div> 
            </div>
            <div class="item">
                <div class="itemL">添加图片：</div>
                <div class="itemR"><input readonly type="text" id="tb0" /><div><input type="file" name="uploadify" id="uploadify0" /></div><a href="#" id="clear0">&nbsp;清除</a></div>
            </div>
            <div class="item">
                <div class="itemL">&nbsp;</div>
                <div class="itemR"><div class="fileQueue" id="fileQueue" ></div></div>
            </div>
            <div class="divsub"><input disabled type="button" /></div>
        </div>
  </div>
    </form>
</body>
</html>
