<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Member_Manage_Home_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>会员中心-首页</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7"/>
    <Custom:Header ID="Header1" runat="server" />
    <link href="css/index.css" rel="Stylesheet" type="text/css"  />
</head>
<body>
    <div class="main">
        <div class="left">
            <div class="md_shortcut app_wrap">
                <div class="box_head">
                    <div class="b_d_title">快捷入口</div>
                </div>
                <ul class="app_list">
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
            <div class="md_account app_wrap">
                <div class="box_head">
                    <div class="b_d_title">我的帐户信息</div>
                </div>
            </div>
        </div>
        <div class="right">
            <div class="md_notic app_wrap">
                <div class="box_head">
                    <div class="b_d_title">最新公告</div>
                </div>
                <ul class="nt_list">
                    <li><a href="#">【有奖活动】 测财运？测人品？不如测操作！</a></li>
                    <li><a href="#">找货源，学营销，赚大钱，就来网货交易会！</a></li>
                    <li><a href="#">穿越啦~穿越啦~“甄嬛”喊你来晋升了！测测你是深宫里的宠妃还是冷妃？</a></li>
                </ul>
            </div>
        </div>
    </div>
</body>
</html>
