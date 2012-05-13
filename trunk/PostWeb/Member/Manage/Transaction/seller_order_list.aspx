<%@ Page  Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="seller_order_list.aspx.cs" Inherits="Member_Manage_Transaction_seller_order_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/order_list.css" rel="stylesheet" type="text/css" />
    <link href="/js/pager/pagination.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/Calendar1.js"></script>
    <script type="text/javascript" src="/js/pager/pagination.js"></script>
    <script type="text/javascript" src="js/order_list.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="rc" value="<%=ViewState["rc"] %>" />
<input type="hidden" id="orderNum" value="<%=Request.QueryString["orderNum"] %>" />
<input type="hidden" id="startDate" value="<%=Request.QueryString["startDate"] %>" />
<input type="hidden" id="endDate" value="<%=Request.QueryString["endDate"] %>" />
<input type="hidden" id="orderState" value="<%=Request.QueryString["orderState"] %>" />
<input type="hidden" id="proName" value="<%=Request.QueryString["proName"] %>" />
<ul class="hmenu">
     <li>
         <div class="mLeft"></div>
         <div class="mMiddle">全部订单</div>
         <div class="mRight"></div>
    </li>
    <li class="request"><span class="red"></span><span class="gray"></span></li>
</ul>
<div class="scctn">
    <ul>
        <li><span style="margin-left:1em;"></span><b>订单号：</b><input name="orderNum" class="txtbox keyword" />&nbsp;<b> 货品名称：</b><input name="proName" class="txtbox keyword" /></li>
        <li><b>交易状态：</b><select name="orderState">
            <option value="">全部</option>
            <option value="0">等待卖家确认订单</option>
            </select>
        </li>
        <li><b>成交时间：</b><input type="text" name="startDate" readonly="readonly" onfocus="calendar()" maxlength="10" class="txtbox keyword date" /> - <input name="endDate" onfocus="calendar()" readonly="readonly" maxlength="10" class="txtbox keyword date" />&nbsp;&nbsp;[ <a href="javascript:void(0);" id="threeDay" day="2">最近3天</a> <a href="javascript:void(0);" id="week" day="6">最近1周</a> <a href="javascript:void(0);" id="month" day="29">最近1月</a> ] </li>
    </ul>
    <div class="scwrap"><div>&nbsp;</div>
        &nbsp;<input id="btnSearch" type="button" value="搜索" /></div>
</div>
<div class="proctn">
    <table cellpadding=0 cellspacing=0 class="tblist">
        <tr><th colspan="2">货品</th><th>单价</th><th>数量</th><th>总金额</th><th>订单状态</th><th>操作</th></tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr><td><div class="imgwrap"><img src="<%#Eval("ImgUrl") %>" onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'" onload="changeImg(this,80,80)" /></div></td><td><%#Eval("proname") %></td><td><%#Eval("price") %></td><td><%#Eval("pronum") %></td><td><%#Eval("amount")%></td><td><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Transaction.DS_Cart.State),Eval("state")) %></td><td class="act_wrap"><a  class="od_det" href="javascript:void(0);" oid="<%#Eval("OrderID") %>">详情</a><a class="od_del" dtid="<%#Eval("id") %>" href="javascript:void(0);">删除</a></td></tr>        
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr class="altr"><td><div class="imgwrap"><img src="<%#Eval("ImgUrl") %>" onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'" onload="changeImg(this,80,80)" /></div></td><td><%#Eval("proname") %></td><td><%#Eval("price") %></td><td><%#Eval("pronum")%></td><td><%#Eval("amount")%></td><td><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Transaction.DS_Cart.State),Eval("state")) %></td><td class="act_wrap"><a class="od_det" href="javascript:void(0);" oid="<%#Eval("OrderID") %>">详情</a><a class="od_del" dtid="<%#Eval("id") %>" href="javascript:void(0);">删除</a></td></tr>        
            </AlternatingItemTemplate>
        </asp:Repeater>
    </table>
    <div class="pagerwrap"></div>
    <div class="client_det_wrap">
        <div class="ovline">&nbsp;</div>
        <table cellpadding=0 cellspacing=1>
            <tr>
                <td class="tdfild">买家姓名：</td><td class="tdval" id="Name"></td>
                <td class="tdfild">手机：</td><td class="tdval" id="Mobile"></td>
                <td class="tdfild">电话：</td><td class="tdval" id="Phone"></td>
                
            </tr>
            <tr>
                <td class="tdfild">所在地区：</td><td  class="tdval" id="Area"></td>
                <td class="tdfild">街道地址：</td><td  class="tdval" id="Street"></td>
                <td class="tdfild">邮编：</td><td class="tdval" id="Zipcode"></td>
            </tr>
            <tr>
                <td class="tdfild">备注：</td><td style="height:50px;" colspan="5" id="Remark"></td>
            </tr>
        </table>
    </div>
</div>
</asp:Content>

