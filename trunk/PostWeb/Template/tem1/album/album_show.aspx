<%@ Page Language="C#" AutoEventWireup="true" CodeFile="album_show.aspx.cs" Inherits="Template_tem1_album_album_show" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>图片展示</title>
    <meta name="description" content="方伟泽，深圳市福田区华强北路经济大厦D22，主要经营插卡音箱;电话线;电话转接头;电话配件;，86-0755- 82796991，如需购买插卡音箱;电话线;电话转接头;电话配件;，请联系我们方伟泽，一流的质量有竞争力的价格是您的不二选择!" />
    <meta name="keywords" content="方伟泽，插卡音箱;电话线;电话转接头;电话配件;" />
    <Custom:Header ID="Header1" runat="server" />
    <script type="text/javascript" src="js/gallery.js"></script>
    <link rel="stylesheet" type="text/css" href="css/gallery.css" />
    <script type="text/javascript" src="js/album_show.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="AlbumBodyBg">
	<div class="head">
    	<div class="HeadLeft">&nbsp;苏得冠</div>
        <div class="HeadRight" >
        	<div class="HRR1">
            	
            </div>
            <div class="HRR2">
            	<ul>
                	<li class="HRR2Li1"><a href="#">收藏本公司</a></li>
                    <li class="HRR2Li2"><a href="#">设为首页</a></li>
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
                        	<li><a href="#">热销产品</a></li>
                            <li class="Selected"><a href="#">我的相册</a></li>
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
                                    <a href="#" class="PrevAlbum">上本相册</a>相册名称：<span>我的相册</span><a href="#" class="NextAlbum">下本相册</a>
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
