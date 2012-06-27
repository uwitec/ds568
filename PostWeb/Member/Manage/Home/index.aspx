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
                <div class="content-wrap">
                <ul class="app_list">
                    <li>
                        <a href="/member/manage/offer/list.aspx">
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
                        <a href="/member/manage/Album/Album_List.aspx">
                            <div class="md_wrap">
                                <div class="model_ico imagemanager">&nbsp;</div>
                                <div class="model_name">相册管理</div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/member/manage/News/news_list.aspx">
                            <div class="md_wrap">
                                <div class="model_ico idinfo">&nbsp;</div>
                                <div class="model_name">公司动态</div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/member/manage/ComInfo/BaseInfo.aspx">
                            <div class="md_wrap">
                                <div class="model_ico privateseller">&nbsp;</div>
                                <div class="model_name">公司资料</div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/member/manage/Transaction/seller_order_list.aspx">
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
                        <a href="/member/manage/Account/Contact.aspx">
                            <div class="md_wrap">
                                <div class="model_ico account">&nbsp;</div>
                                <div class="model_name">帐号管理</div>
                            </div>
                        </a>
                    </li>
                </ul>
                </div>
            </div>
            <div class="md_account app_wrap">
                <div class="box_head">
                    <div class="b_d_title">我的帐户信息</div>
                </div>
	    		<div class="content-wrap">
                    <div class="cel0">
                        <div  class="row">
                            <div class="member-info">
                                <div class="user-pic-grid">
                                    <a title="" target="_blank" href="http://profile.china.alibaba.com/user/alwdeguan.htm">
                                        <img height="40" width="40" id="user-pic" alt="" src="<%=_userData.Member.Avater %>"></a></div>
                                <h3>
                                    <a title="<%=_userData.vMember.CompanyName %>" target="_blank" href="http://shop<%=_userData.Member.ID %>.ds568.net"
                                        class="company-link"><%=_userData.vMember.CompanyName %></a><a title="您还未进行任何认证,通过认证让买家更放心!"  href="javascript:;"
                                            class="not-auth site-link">公司未认证</a></h3>
                                <div class="sub-info-wrap">
                                    <div class="sub-info"><span class="member-level">点石网普通会员</span></div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="iserver">
                                <div class="t-box">
                                    <a  href="/member/Manage/account/contact.aspx">完善<br>
                                        信息</a></div>
                                <div class="iserver-grid border-lf">
                                    <table style="width: 300px;">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <a  href="/member/Manage/account/contact.aspx">完善帐户信息</a>
                                                </td>
                                                <td>
                                                    <a  href="/member/Manage/account/MobileValidate.aspx">手机验证设置</a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <a title="" target="_blank" href="/member/Manage/account/Password.aspx">
                                                        修改密码</a>
                                                </td>
                                                <td>
                                                    <a title="" target="_blank" href="/member/Manage/account/PwdProtect.aspx">
                                                        密保问题管理</a>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
	    			
                    <div class="cel1">
                        <div id="row-4" class="row">
                            <div id="icommunity" class="icommunity">
                                <div class="t-box">
                                    <a title="" target="_blank" href="http://work.china.alibaba.com/channel/sns.htm">我的<br>
                                        社区</a></div>
                                <div class="default-grid border-lf">
                                    <table style="width: 300px;">
                                        <tbody>
                                            <tr>
                                                <td colspan="2">
                                                    客户留言：<a title="" target="_blank" href="http://work.china.alibaba.com/app/SNSMessageFriend.htm">0<span
                                                        class="unit">条</span></a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    系统消息：<a title="" target="_blank" href="http://work.china.alibaba.com/app/SNSMessageSys.htm">0<span
                                                        class="unit">条</span></a>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
	    		</div>
            </div>
            <ul class="middle_wrap">
                <li class="box_wrap odd">
                    <div class="app_wrap">
                        <div class="box_head">
                            <div class="b_d_title">
                                为您推荐</div>
                        </div>
                        <div class="content-wrap">
                            <div class="wrap368">
                                <ul class="box-mn">
                                    <li>供应信息</li>
                                    <li>公司</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </li>
                <li class="box_wrap">
                    <div class="app_wrap">
                        <div class="box_head">
                            <div class="b_d_title">
                                最新收藏</div>
                        </div>
                        <div class="content-wrap">
                        gdew
                        </div>
                    </div>
                </li>
            </ul>
        </div>
        <div class="right">
            <div class="md_notic app_wrap">
                <div class="box_head">
                    <div class="b_d_title">最新公告</div>
                </div>
                <div class="content-wrap">
                    <ul class="nt_list">
                        <li><a href="#">【有奖活动】 测财运？测人品？不如测操作！</a></li>
                        <li><a href="#">找货源，学营销，赚大钱，就来网货交易会！</a></li>
                        <li><a href="#">穿越啦~穿越啦~“甄嬛”喊你来晋升了！测测你是深宫里的宠妃还是冷妃？</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
