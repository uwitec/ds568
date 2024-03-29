﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="album_show.aspx.cs" Inherits="Template_tem1_album_album_show" %>
<%@ OutputCache Duration="1800" VaryByParam="album_id" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片展示</title>
    <meta name="description" content="" />
    <meta name="keywords" content="" />
    <Custom:Header ID="Header1" runat="server" />
    <script type="text/javascript" src="js/gallery.js"></script>
    <link rel="stylesheet" type="text/css" href="css/gallery.css" />
    <script type="text/javascript" src="js/album_show.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <input type="hidden" id="albumid" value="<%=Request.QueryString["album_id"] %>" />
    <div class="AlbumBodyBg">
	<div class="head">
    	<div class="HeadLeft">&nbsp;<%=_vMember.CompanyName%></div>
        <div class="HeadRight" >
        	<div class="HRR1">
            	
            </div>
            <div class="HRR2">
            	<ul>
                	<li class="HRR2Li1"><a href="javascript:AddFavorite(location.href,'<%=ViewState["comName"]%>')">收藏本公司</a></li>
                    <li class="HRR2Li2"><a onclick="this.homepage.style.behavior='url(#default#homepage)';this.homepage.sethomepage('http://www.netbei.com');" href="javascript:;">设为首页</a></li>
                    <li class="HRR2Li3"><a target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=416351551&Site=www.apsw8.com&Menu=yes">
                                            <img src="http://wpa.qq.com/pa?p=1:416351551:4" alt='online' style='font-family: Arial'>给我留言</a></li>
                </ul>
            </div>
        </div>
    </div>
    
    <div class="Content" style="float:left;" >
         <!--========内容中间部分开始=================-->
         	<div class="ContentMiddle">
            	<!--==========左边开始==================-->
                <div class="ContentLeft">
                	<div class="SelectOrder">
                     	<ul>
                             <asp:Repeater ID="Repeater2" runat="server">
                                <ItemTemplate>
                                    <li aid="<%#Eval("id") %>"><a href="album_show.aspx?album_id=<%#Eval("id") %>&member_id=<%#Request.QueryString["member_id"] %>"><%#Eval("albumname") %></a></li>
                                </ItemTemplate>
                             </asp:Repeater>
                        </ul>
                    </div>
                </div>
                <!--==========左边结束==================-->
               
            	<!--========展示区开始=================-->
            	   <div id="gallery" class="ad-gallery">
                   	<div class="ad-gallery-left">
                          <div class="ad-image-wrapper">
                          </div>
                          <div   class="ad-controls">
                          </div>
                          <div class="ad-controls2" >
                          		<div class="ad-controls2Content">
                                    <div  class="ad-contentR1">
                                    	<a href="#" class="ad-pre"></a>
                                        <a href="#" title="自动播放" class="ad-paly"></a>
                                        <a href="#" class="ad-next2"></a>
                                    </div>
                                	<div  class="ad-contentR2">
                                    <a href="#" class="PrevAlbum">上本相册</a>相册名称：<span style="width:64px;overflow:hidden;height:16px;"><%=ViewState["albumName"] %></span><a href="#" class="NextAlbum">下本相册</a>
                                    </div>
                                </div>
                          </div>
                      </div>
                      <div class="ad-nav">
                        <div class="ad-thumbs">
                          <ul class="ad-thumb-list" >
                              <asp:Repeater ID="Repeater1" runat="server">
                                  <ItemTemplate>
                                      <li><a href="/resource/<%#Eval("ImgUrl") %>/<%#Eval("ImgName") %>">
                                          <img onload="changeImg(this,62,62)" src="/resource/<%#Eval("ImgUrl") %>/<%#Eval("ImgName") %>"
                                              title="<%#Eval("imgtitle") %>" longdesc="/resource/<%#Eval("ImgUrl") %>/<%#Eval("ImgName") %>" alt="<%#Eval("ImgDescript") %>"
                                              class="image0">
                                      </a></li>
                                  </ItemTemplate>
                              </asp:Repeater>
                          </ul>
                        </div>
                      </div>
                      
                    </div>
                    <!--========展示区结束=================-->
            </div>
         <!--========内容中间部分结束=================-->
    </div>
     <!--==============内容部分结束===============-->
     
</div>
    </form>
</body>
</html>
