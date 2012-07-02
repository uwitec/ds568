<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Member_Manage_Home_index" %>
<%@ Import Namespace="Com.DianShi.BusinessRules.Community" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>会员中心-首页</title>
    <meta http-equiv="X-UA-Compatible" content="IE=EmulateIE7"/>
    <Custom:Header ID="Header1" runat="server" />
    <link href="css/index.css" rel="Stylesheet" type="text/css"  />
    <script type="text/javascript" src="js/index.js"></script>
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
                                        <img height="40" width="40" id="user-pic" alt="" src="<%=_userData.Member.Avater %>" onerror="javascript:this.src='http://i04.c.aliimg.com/images/member/da1_r13_c21.gif'"></a></div>
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
                                                    客户留言：<a href="/Member/Manage/Message/MessageCenter.aspx?tid=0"><%=DS_Message_Br.GetMsgNum(_userData.Member.ID,false,DS_Message_Br.MsgType.留言互动) %><span class="unit">条</span></a>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan="2">
                                                    系统消息：<a href="/Member/Manage/Message/MessageCenter.aspx?tid=1"><%=DS_Message_Br.GetMsgNum(_userData.Member.ID,false,DS_Message_Br.MsgType.系统消息) %><span class="unit">条</span></a>
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
                                    <li class="current">供应信息</li>
                                    <li>公司</li>
                                </ul>
                                <div class="com_wrap">
                                    <ul class="pro-list">
                                        <li>
                                            <div class="img-ctn"><a href="#"><img width="73" onload="changeImg(this,73,73)" src="http://i02.c.aliimg.com/img/ibank/2011/509/330/309033905_750275240.summ.jpg.summ.jpg" /></a></div>
                                            <div class="pro-title"><a href="#">专业生产供应地</a></div>
                                            <div class="pro-pri"><span>100.0</span>元</div>
                                        </li>
                                        <li>
                                            <div class="img-ctn"><a href="#"><img width="73" onload="changeImg(this,73,73)" src="http://i00.c.aliimg.com/img/ibank/2011/121/662/454266121_836585338.summ.jpg.summ.jpg" /></a></div>
                                            <div class="pro-title"><a href="#">专业生产供应地</a></div>
                                            <div class="pro-pri"><span>100.0</span>元</div>
                                        </li>
                                        <li>
                                            <div class="img-ctn"><a href="#"><img width="73" onload="changeImg(this,73,73)" src="http://i02.c.aliimg.com/img/ibank/2011/509/330/309033905_750275240.summ.jpg.summ.jpg" /></a></div>
                                            <div class="pro-title"><a href="#">专业生产供应地</a></div>
                                            <div class="pro-pri"><span>100.0</span>元</div>
                                        </li>
                                        <li>
                                            <div class="img-ctn"><a href="#"><img width="73" onload="changeImg(this,73,73)" src="http://i00.c.aliimg.com/img/ibank/2011/121/662/454266121_836585338.summ.jpg.summ.jpg" /></a></div>
                                            <div class="pro-title"><a href="#">专业生产供应地</a></div>
                                            <div class="pro-pri"><span>100.0</span>元</div>
                                        </li>
                                        <li>
                                            <div class="img-ctn"><a href="#"><img width="73" onload="changeImg(this,73,73)" src="http://i05.c.aliimg.com/img/ibank/2011/306/521/322125603_1408605981.search.jpg" /></a></div>
                                            <div class="pro-title"><a href="#">专业生产供应地</a></div>
                                            <div class="pro-pri"><span>100.0</span>元</div>
                                        </li>
                                        <li>
                                            <div class="img-ctn"><a href="#"><img width="73" onload="changeImg(this,73,73)" src="http://i00.c.aliimg.com/img/ibank/2012/737/882/513288737_245691504.summ.jpg.summ.jpg" /></a></div>
                                            <div class="pro-title"><a href="#">超大护颈防</a></div>
                                            <div class="pro-pri"><span>9.80</span>元</div>
                                        </li>
                                    </ul>
                                    <div class="more"><a href="#">更多&gt;&gt;</a></div>
                                </div>
                                <div class="com_wrap" style="display:none;">
                                    <ul class="com-list">
                                        <li>
                                           <div class="com-name"><a href="#">深圳点石网络科技有限公司</a><div class="com-area gray">广东深圳市</div></div>
                                           <div class="com-pro-model gray">经销批发</div>
                                        </li>
                                         <li>
                                           <div class="com-name"><a href="#">深圳点石网络科技有限公司</a><div class="com-area gray">广东深圳市</div></div>
                                           <div class="com-pro-model gray">经销批发</div>
                                        </li>
                                         <li>
                                           <div class="com-name"><a href="#">深圳点石网络科技有限公司</a><div class="com-area gray">广东深圳市</div></div>
                                           <div class="com-pro-model gray">经销批发</div>
                                        </li>
                                         <li>
                                           <div class="com-name"><a href="#">深圳点石网络科技有限公司</a><div class="com-area gray">广东深圳市</div></div>
                                           <div class="com-pro-model gray">经销批发</div>
                                        </li>
                                    </ul>
                                    <div class="more"><a href="#">更多&gt;&gt;</a></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li class="box_wrap">
                    <div class="app_wrap">
                        <div class="box_head">
                            <div class="b_d_title">常见问题</div>
                        </div>
                        <div class="content-wrap">
                            <div class="wrap368">
                                <ul class="que-list">
                                    <li>
                                        <a href="#">忘记密码怎么办？</a> 
                                    </li>
                                    <li>
                                        <a href="#">如何修改联系方式？</a> 
                                    </li> 
                                    <li>
                                        <a href="#">为什么信息审核不通过？</a> 
                                    </li>
                                    <li>
                                        <a href="#">如何对旺铺的外观进行设计？</a> 
                                    </li>
                                    <li>
                                        <a href="#">如何发布高质量的产品信息？</a> 
                                    </li>
                                </ul> 
                                <div class="more"><a href="#">查看更多&gt;&gt;</a></div>
                            </div>
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
            <div class="md_notic app_wrap">
                <div class="box_head">
                    <div class="b_d_title">客服中心</div>
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
