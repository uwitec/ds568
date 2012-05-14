<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Show_Msg.aspx.cs" Inherits="Order_Show_Msg" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
<link rel="stylesheet" rev="stylesheet" href="css/order.css" type="text/css"  />
<style type="text/css">
    .sthead{background-position:0 -200px;}
    .step1{background-position:-313px 0;}
    .step2{background-position:-310px -25px;}
    .step3{background-position:-310px -50px;}
    .sm_wrap{width:350px;margin:0 auto;overflow:auto;padding-top:100px;}
    .sm_wrap div{float:left;}
    .msg_wrap{height:300px;}
    .finish{ background:url(images/finish.png) no-repeat;width:45px;height:45px;margin-right:10px;}
</style>   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="order_wrap">
     <ul class="navwrap">
        <li class="sthead">&nbsp;</li>
        <li class="step1">1.选择货品</li>
        <li class="step2">2.确认订单信息</li>
        <li class="step3 curent">3.支付宝担保付款</li>
        <li class="step4">4.确认收货</li>
        <li class="step5">5.完成</li>
    </ul>
    <div class="msg_wrap">
        <div class="sm_wrap">
            <div class="finish">&nbsp;</div>
            <div class="msg_ctn"><h3>订单提交成功！</h3><p>您可以：<a   href="http://wpa.qq.com/msgrd?v=3&uin=<%=ViewState["qq"] %>&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:<%=ViewState["qq"] %>:4" alt="给我留言" />联系卖家发货</a> 或 <a href="http://shop<%=ViewState["memberid"] %>.ds568.net">继续购物</a></p></div>
        </div>
    </div>
</div>
</asp:Content>

