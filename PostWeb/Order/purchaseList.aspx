<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="purchaseList.aspx.cs" Inherits="Order_Purchase_purchaseList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" rev="stylesheet" href="css/order.css" type="text/css"  />    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="order_wrap">
    <div class="pur_logo">我的进货单</div>
    <ul class="navwrap">
        <li class="sthead">&nbsp;</li>
        <li class="step1 curent">1.选择货品</li>
        <li class="step2">2.确认订单信息</li>
        <li class="step3">3.支付宝担保付款</li>
        <li class="step4">4.确认收货</li>
        <li class="step5">5.完成</li>
    </ul>
    <div class="title_bar">
        <div class="filed1">货品</div>
        <div class="filed2">单价(元)</div>
        <div class="filed3">&nbsp;</div>
        <div class="filed4">数量</div>
        <div class="filed5">金额(元)</div>
        <div class="filed6">操作</div>
    </div>
    <div class="title_bar">
        <div class="filed_left">供应商：<a href="#">河源蜂蜜经营部</a> <a href="http://wpa.qq.com/msgrd?v=3&uin=416351551&site=qq&menu=yes"><img onload="if(this.width>16) $(this).next().text('在线洽谈');" src="http://wpa.qq.com/pa?p=2:416351551:4" alt="给我留言" /><span>给我留言</span></a></div><div class="filed_right"><span>本店不支持混批</span> <a href="http://shop14.ds568.net">继续采购</a></div>
    </div>
    <div class="pro_item_wrap">
        <div class="item_1"><input type="checkbox" />&nbsp;</div>
        <div class="item_2"><img width="56" height="56" src="http://i02.c.aliimg.com/img/ibank/2012/887/740/491047788_1135752292.summ.jpg" /></div>
        <div class="item_3"><a href="#">（厂家直销）袋装洗手液500ml袋装抑菌洗手液招商代理加盟总经销 </a></div>
        <div class="item_4">
            <p>2000-3999 瓶： 2.50</p>
            <p class="gray">4000-4999 瓶： 2.40</p>
            <p class="gray">≥5000瓶： 2.30</p>
        </div>
        <div class="item_5">×</div>
        <div class="item_6"><a href="javascript:void(0);"> -</a>&nbsp;<input value="123" />&nbsp;<a href="javascript:void(0);">+</a></div>
        <div class="item_7"> ＝</div>
        <div class="item_8">5000.00</div>
        <div class="item_9"><a href="javascript:void(0)">删除</a></div>
    </div>
    <div class="pro_item_wrap">
        <div class="item_1"><input type="checkbox" />&nbsp;</div>
        <div class="item_2"><img width="56" height="56" src="http://i02.c.aliimg.com/img/ibank/2012/887/740/491047788_1135752292.summ.jpg" /></div>
        <div class="item_3"><a href="#">（厂家直销）袋装洗手液500ml袋装抑菌洗手液招商代理加盟总经销 </a></div>
        <div class="item_4">
            <p>2000-3999 瓶： 2.50</p>
            <p class="gray">4000-4999 瓶： 2.40</p>
            <p class="gray">≥5000瓶： 2.30</p>
        </div>
        <div class="item_5">×</div>
        <div class="item_6"><a href="javascript:void(0);"> -</a>&nbsp;<input value="123" />&nbsp;<a href="javascript:void(0);">+</a></div>
        <div class="item_7"> ＝</div>
        <div class="item_8">5000.00</div>
        <div class="item_9"><a href="javascript:void(0)">删除</a></div>
    </div>
    <div class="pro_item_wrap item_bottom">
        <div class="btm_left"><input type="checkbox" id="chk_1" /><label for="chk_1">全选</label> <a class="del_chk" href="javascript:void(0);">删除所选 </a></div>
        <p class="btm_right">货品金额总计(不包含运费)：<span class="amount">5000.00</span>元<span class="margin_1em"></span><a class="make_order" href="javascript:void(0);"><span>确认下单</span></a></p>
    </div>
</div>
</asp:Content>

