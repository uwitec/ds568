<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Make_Order.aspx.cs" Inherits="Order_Make_Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" rev="stylesheet" href="css/order.css" type="text/css"  />
<script type="text/javascript" src="js/make_order.js"></script>
<style type="text/css">
    .sthead{background-position:0 -200px;}
    .step1{background-position:-313px -25px;}
    .step2{background-position:-310px -50px;}
</style>   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="order_wrap">
     <ul class="navwrap">
        <li class="sthead">&nbsp;</li>
        <li class="step1">1.选择货品</li>
        <li class="step2 curent">2.确认订单信息</li>
        <li class="step3">3.选择付款方式并付款</li>
        <li class="step4">4.确认收货</li>
        <li class="step5">5.完成</li>
    </ul>
    <div class="m_tl_bar margin_16"><span class="b_block">&nbsp;</span><span class="b_tl">收货地址确认</span></div>
    <div class="address_list crt_ads" id="ads_lt_1">
        <div class="a_l_chk"><input type="radio" ind="1" checked name="a_l_chk" id="a_l_chk_1" /><label for="a_l_chk_1">苏得冠 广东省 深圳市 福田区 华强北 </label></div>
    </div>
    <div class="address_list" id="ads_lt_2">
        <div class="a_l_chk"><div class="chk_body_left"><input type="radio" ind="2" name="a_l_chk" id="a_l_chk_other" /><label for="a_l_chk_other">使用其他地址</label></div><div class="chk_body_right"><span class="star">*</span>为必填项</div></div>
        <div class="ads_det_item">
            <div class="itemL"><span class="star">*</span>地址：</div>
            <div class="itemR"><select name="province"></select> 省 <select name="city"></select> 市 <select name="town"></select> 区</div>
        </div>
        <div class="ads_det_item">
            <div class="itemL"><span class="star">*</span>邮政编码：</div>
            <div class="itemR"><input class="zipcode" name="zipcode" /></div>
        </div>
        <div class="ads_det_item">
            <div class="itemL"><span class="star">*</span>街道地址：</div>
            <div class="itemR"><input class="street" name="street" /></div>
        </div>
        <div class="ads_det_item">
            <div class="itemL"><span class="star">*</span>收货人姓名：</div>
            <div class="itemR"><input class="username" name="username" /></div>
        </div>
        <div class="ads_det_item">
            <div class="itemL">电话：</div>
            <div class="itemR"><input class="phone" name="phone" />&nbsp;&nbsp;&nbsp;手机：<input class="mobile" name="mobile" /></div>
        </div>
    </div>
    <div class="m_tl_bar margin_16"><span class="b_block">&nbsp;</span><span class="b_tl">订购信息确认</span></div>
    <div class="com_info">卖家：<a href="http://shop14.ds568.net" target="_blank">杭州康盾生物科技有限公司</a> <a class="qq" href="http://wpa.qq.com/msgrd?v=3&uin=416351551&site=qq&menu=yes"><img onload="if(this.width>16) $(this).next().text('和我联系');" src="http://wpa.qq.com/pa?p=2:416351551:4" alt="和我联系" /><span>给我留言</span></a></div>
</div>
</asp:Content>

