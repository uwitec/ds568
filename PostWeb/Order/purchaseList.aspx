<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="purchaseList.aspx.cs" Inherits="Order_Purchase_purchaseList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" rev="stylesheet" href="css/order.css" type="text/css"  />    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="pur_logo">我的进货单</div>
<ul class="navwrap">
    <li class="sthead">&nbsp;</li>
    <li class="step1 curent">1.选择货品</li>
    <li class="step2">2.确认订单信息</li>
    <li class="step3">3.选择付款方式并付款</li>
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
    <div class="filed_left">供应商：<a href="#">河源蜂蜜经营部</a> <a href="http://wpa.qq.com/msgrd?v=3&uin=416351551&site=qq&menu=yes"><img onload="if(this.width>16) $(this).next().text('在线洽谈');" src="http://wpa.qq.com/pa?p=2:416351551:4" alt="给我留言" /><span>给我留言</span></a></div><div class="filed_right"></div>
</div>
</asp:Content>

