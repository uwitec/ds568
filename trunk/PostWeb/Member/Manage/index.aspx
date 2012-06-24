<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Member_Login_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>点石-商务中心</title>
    <link href="Css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/lib.js"></script>
    <script type="text/javascript" src="js/index.js"></script>
</head>
<body>
<div class="topbar_wrap" >
    <div class="ct_wrap">
        <ul class="ct_ul">
            <li class="ds_logo">&nbsp;</li>
            <li class="menu"><a href="/Member/Manage/home/index.aspx"><div class="ml">&nbsp;</div><div class="mm">首页</div><div class="mr">&nbsp;</div></a></li>
            <li class="menu"><a href="Offer/Post.aspx"><div class="ml">&nbsp;</div><div class="mm">销售</div><div class="mr">&nbsp;</div></a></li>
            <li class="menu"><a href="#"><div class="ml">&nbsp;</div><div class="mm">采购</div><div class="mr">&nbsp;</div></a></li>
            <li class="menu mnhv"><a class="nolk" href="javascript:void(0)"><div class="ml">&nbsp;</div><div class="mm"><span>我的应用</span></div><div class="mr">&nbsp;</div></a></li>
            <li class="sch_ctn"><div class="sch_wrap"><a class="sch_prj" onfocus="this.blur();" href="javascript:void(0);">产品</a><div><input type="text" dv="搜索…" name="kw" /></div><a class="sch_btn" href="javascript:void(0);">&nbsp;</a></div></li>
            <li class="menu"><a  href="Message/MessageCenter.aspx"><div class="ml">&nbsp;</div><div class="mm"><span class="msg">消息</span><span class="msgc"><span class="mc_block"><%=msgCount%></span></span></div><div class="mr">&nbsp;</div></a></li>
            <li class="welcome"><%=_userData.Member.UserID%> <a href="/member/signout/SignOut.aspx">[退出]</a></li>
            <li class="homepage"><a href="/home/index.aspx" target="_blank">点石网首页</a></li>
        </ul>
        <div class="app_wrap">
            <div class="app_sub_wrap">
                <div class="fix_tag">&nbsp;</div>
                <div class="fix_bg">&nbsp;</div>
                <div class="fix_ctn">
                    <ul>
                        <li>
                            <a href="offer/list.aspx">
                                <div class="md_wrap">
                                    <div class="model_ico offer">&nbsp;</div>
                                    <div class="model_name">供应管理</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                <div class="md_wrap">
                                    <div class="model_ico purchase">&nbsp;</div>
                                    <div class="model_name">采购管理</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="Album/Album_List.aspx">
                                <div class="md_wrap">
                                    <div class="model_ico imagemanager">&nbsp;</div>
                                    <div class="model_name">相册管理</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="News/news_list.aspx">
                                <div class="md_wrap">
                                    <div class="model_ico idinfo">&nbsp;</div>
                                    <div class="model_name">公司动态</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="ComInfo/BaseInfo.aspx">
                                <div class="md_wrap">
                                    <div class="model_ico privateseller">&nbsp;</div>
                                    <div class="model_name">公司资料</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="Transaction/seller_order_list.aspx">
                                <div class="md_wrap">
                                    <div class="model_ico salemana">&nbsp;</div>
                                    <div class="model_name">交易管理</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                <div class="md_wrap">
                                    <div class="model_ico winporter">&nbsp;</div>
                                    <div class="model_name">装修商铺</div>
                                </div>
                            </a>
                        </li>
                        <li>
                            <a href="Account/Contact.aspx">
                                <div class="md_wrap">
                                    <div class="model_ico account">&nbsp;</div>
                                    <div class="model_name">帐号管理</div>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
            </div> 
        </div>
    </div>
</div>
<iframe  src="home/index.aspx" framespacing="0"   frameborder="0"  border="0"   width="100%"   name="conFrame" id="mainFrame" />
</body>
</html>
