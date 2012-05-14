<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Show_Msg.aspx.cs" Inherits="Order_Show_Msg" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" rev="stylesheet" href="css/order.css" type="text/css"  />
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
        <li class="step3">3.支付宝担保付款</li>
        <li class="step4">4.确认收货</li>
        <li class="step5">5.完成</li>
    </ul>
    
</div>
</asp:Content>

