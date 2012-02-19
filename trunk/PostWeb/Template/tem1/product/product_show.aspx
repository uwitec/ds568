﻿<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="product_show.aspx.cs" Inherits="Template_tem1_product_product_show"
    Title="Untitled Page" %>
<%@ Register src="~/Template/tem1/product/Property.ascx" tagname="Property" tagprefix="uc1" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="Server">
<title><%=ViewState["title"] %></title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ContentMiddle
        {
            overflow: hidden;
        }
    </style>
    <script type="text/javascript" src="js/pro_show.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<input type="hidden" id="priceRang" value="<%=ViewState["priceRang"] %>" />
    <div class="MiddleRight">
        <!--========产品内容开始=============-->
        <div class="pTitle">
            <%=ViewState["title"] %>
        </div>
        <div class="Split12px">
        </div>
        <div class="divProHead">
            <div class="pPic">
                <table class="pPicTop" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="center">
                            <div>
                                <img id="bigimg" onerror="javascript:$(this).hide()" src="<%=ViewState["img1"] %>" /></div>
                        </td>
                    </tr>
                </table>
                <ul class="pPicBottom">
                    <li>
                        <div>
                            <img onerror="javascript:$(this).hide()" src="<%=ViewState["img1"] %>" />
                        </div>
                    </li>
                    <li class="lisplit"></li>
                    <li>
                        <div>
                            <img onerror="javascript:$(this).parent().parent().hide()" src="<%=ViewState["img2"] %>" />
                        </div>
                    </li>
                    <li class="lisplit"></li>
                    <li>
                        <div>
                            <img onerror="javascript:$(this).parent().parent().hide()" src="<%=ViewState["img3"] %>" />
                        </div>
                    </li>
                </ul>
            </div>
            <div class="pInfo">
                <ul class="ul004">
                    <li class="pInfoH">数量(<%=ViewState["unit"] %>)</li><li class="pInfoH">单价(元/<%=ViewState["unit"] %>)</li>
                    <li class="pInfoL" >5-29</li><li class="pInfoL"><span class="Amount fontSize14 bold">
                        57.00</span> 元/<%=ViewState["unit"] %></li>
                    <li class="pInfoL">≥30</li><li class="pInfoL"><span class="Amount fontSize14 bold">57.00</span>
                        元/<%=ViewState["unit"] %></li>
                    <li class="pInfoL">≥30</li><li class="pInfoL"><span class="Amount fontSize14 bold">57.00</span>
                        元/<%=ViewState["unit"] %></li>
                </ul>
                <div class="Split12px">
                    &nbsp;</div>
                <div class="divOrder">
                    <ul class="ul005">
                        <li class="odli1">我要订购：
                            <input id="txtOrderNum" class="txtBox orderNum" value="1" type="text" /><div class="updownContainer">
                                <a href="javascript:void(0)" class="up"></a><a href="javascript:void(0)" class="down">
                                </a>
                            </div>
                        </li>
                        <li class="odli1">
                            <dl>
                                <dd class="dd001">
                                    &nbsp;</dd>
                                <dd class="d-btn-buy">
                                    <a title="点击此按钮，到下一步确认购买信息。" target="_self" href="#" id="J_LinkOrder" class="dmtrack"
                                        dmt="addtoorder1">立即购买</a>
                                </dd>
                                <dd class="d-btn-add">
                                    <a title="加入进货单" target="_self" href="#" id="J_LinkPurchase" class="dmtrack" dmt="addtocart1">
                                        加入进货单</a>
                                </dd>
                                <dd class="d-tip-add">
                                    <a target="_blank" href="http://service.china.alibaba.com/kf/detail/2410329.html"
                                        class="dmtrack" dmt="carthelp">什么是进货单?</a>
                                </dd>
                            </dl>
                            <div class="divLine1">
                            </div>
                        </li>
                        <li class="msgTitle">供应商目前不在线，请在下面留言:</li>
                        <li>
                            <input id="inpMsg" name="inpMsg" value="请输入关于您产品的问题（70字以内）" type="text" /><input
                                id="btnSend" type="button" value="发送" />
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--========产品内容结束=============-->
        <!--========产品详细开始=============-->
        <div class="divProDetail">
            <ul class="ulProDetailTitle">
                <li>
                    <div class="dLeft dLeftChk">
                        <span></span><a href="javascript:;">详细信息</a></div>
                    <div class="dRight dRightChk">
                    </div>
                </li>
                <li>
                    <div class="dLeft">
                        <span></span><a href="javascript:;">批发说明</a></div>
                    <div class="dRight">
                    </div>
                </li>
                <li>
                    <div class="dLeft">
                        <span></span><a href="javascript:;">运费说明</a></div>
                    <div class="dRight">
                    </div>
                </li>
                <li>
                    <div class="dLeft">
                        <span></span><a href="javascript:;">联系方式</a></div>
                    <div class="dRight">
                    </div>
                </li>
            </ul>
            <div class="proProperty">
                <div class="pContent1">
                    <uc1:Property ID="Property1" runat="server" />
                    
                    <div class="description-detail">
                        <%=ViewState["Detail"]%>
                        <script type="text/javascript">
                            //产品描术图片自缩放
                           $(".description-detail img").each(function(){
                               changeImg(this,742,742)
                           });
                        </script>
                    </div>
                </div>
                <div class="pContent2 oflAuto">
                    <div class="pInfoH propertyPf">
                        批发说明</div>
                    <div class="de-blockbd">
                        <div class="de-leftcon float-l">
                            <div class="de-top oflAuto">
                                <p class="de-hunpi float-l marginTop8">
                                    混批</p>
                                <div class="float-l">
                                </div>
                                <em class="float-l">支持混批，[150]元以上起批 或者 [2]kg以上起批 </em>
                            </div>
                            <div class="de-info">
                                <p>
                                    量大有优惠</p>
                            </div>
                        </div>
                        <div class="de-rightcon">
                            <div class="de-top oflAuto">
                                <em class="float-l">什么是混批？</em>
                            </div>
                            <div class="de-info justify">
                                <p>
                                    混批是指不限产品的种类和样式，买家只要采购总价（或总量）达到或高于设置金额（或数量）即可享受批发价格。</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="pContent3">
                    <div class="pInfoH propertyPf">
                        运费说明</div>
                    <div class="proContent">
                       87元起减免8元运费,如果量大可再商议。
                    </div>
                </div>
                <div class="pContent4">
                    <div class="pInfoH propertyPf">
                        联系方式</div>
                    <div class="proContent">
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <div class="ctctn">
                                    <span class="ctname"><%#Eval("TrueName") %></span> <%#Eval("Gender")%> | <%#Eval("Position")%> <a class="ctqq" target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=416351551">
                                        <img border="0" src="http://wpa.qq.com/pa?p=1:416351551:1" title="给我发消息" alt="给我发消息"></a>
                                </div>
                                <ul class="ctlist">
                                    <li>手机：<%#Eval("Mobile") %></li>
                                    <li>电话：<%#Eval("Phone").ToString().TrimEnd('-')%></li>
                                    <li>传真：<%#Eval("Fax").ToString().TrimEnd('-')%></li>
                                    <li>地址：<%#Eval("BusinessAddress")%></li>
                                    <li>邮编：<%#Eval("ZipCode")%></li>
                                    <li>网址：<a href="<%#Eval("HomePage") %>" target="_blank"><%#Eval("HomePage") %></a></li>
                                </ul>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
                <div class="moreHead">
                    <div class="pInfoH propertyPf">
                        <div class="moreTitle">
                            供应商的其他相关信息</div>
                        <div class="moreProduct">
                            <a href="index_product.aspx?member_id=<%=Request.QueryString["member_id"] %>">查看该供应商更多供应产品</a></div>
                    </div>
                    <div class="moreContent">
                        <a id="J_sugPre" href="javascript:;"><span class="disabled">上一组</span></a>
                        <div class="suggest" >
                            <div class="suggestContainer">
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <div>
                                            <ul>
                                                <li ><a class="linkImg" href="product_show.aspx?member_id=<%#Request.QueryString["member_id"] %>&pro_id=<%#Eval("id") %>">
                                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                                        onload="changeImg(this,100,100)" alt="<%#Eval("title") %>" src="<%#Eval("img1") %>" /></a>
                                                    <h4>
                                                        <a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱"><%#Eval("title") %></a></h4>
                                                    <p class="fontSize14">
                                                        ¥ <em class="Amount  bold"><%#double.Parse(Eval("priceRang").ToString().Split('|')[0].Split(',')[1]).ToString("N2") %></em><br />
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                
                            </div>
                        </div>
                        <a id="J_sugNext" href="javascript:;"><span class="disabled">下一组</span></a>
                    </div>
                </div>
                <div class="moreCategory">
                    <div class="propertyPf">您可以通过以下类目找到类似信息</div>
                    <div class="categoryLink" ><%=ViewState["category"] %></div>
                </div>
               
            </div>
        </div>
        <!--========产品详细结束=============-->
    </div>
    <div class="thrumFrame">
    </div>
</asp:Content>
