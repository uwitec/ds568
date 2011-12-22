﻿<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" AutoEventWireup="true"   CodeFile="index_home.aspx.cs" Inherits="index_home"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="js/index.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!--========用户展示图开始=================-->
    <div class="headTopic">
    </div>
    <!--========用户展示图结束=================-->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MiddleRight">
        <!--========关于我们开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    关于我们</div>
                <div class="AHRight">
                    <a href="#">更多&gt;&gt;</a></div>
            </div>
            <div class="AboutBody justify">
                <img onerror="javascript:this.style.display='none'" class="AboutImg" src="#" />
                <span id="about">深圳市动感者科技有限公司，致力于多媒体音响产品的研发工作，生产规模雄厚并迅速扩大，成为—家集生产、开发与销售为一体的音响产品专业生产商，推出自有品牌"动感者"。公司本着精益求精的设计理念，全力打造多种视听产品，设立了市场信息中心，产品外观设计中心，产品研究开发实验室、国内自有品牌事业行销部、品牌推广市场部、国际贸易部及制造中心，并引进现代化的生产工艺设备和高素质管理人员。
                由于公司采用了当今业界最为成熟的生产流程，融入了制造领域内最为先进的科技成分，使得"动感者"产品以其卓越的品质，在市场上让消费者体验了完美生动的视听感受。这些高品质的产品，价格相对适中，坚持产品的高性价比路线，自面市
                （未完，全文请 查看更多 ） 深圳市动感者科技有限公司，致力于多媒体音响产品的研发工作，生产规模雄厚并迅速扩大，成为—家集生产、开发与销售为一体的音响产品专业生产商，推出自有品牌"动感者"</span>
            </div>
        </div>
        <!--========关于我们结束=============-->
        <div class="Split12px">
        </div>
        <!--========精品推荐开始=============-->
        <div class="TzProduct">
            <div class="TzHead">
                <div class="TzHLeft">
                    精品推荐</div>
                <div class="TzHRight">
                    <a href="#">更多&gt;&gt;</a></div>
            </div>
            <div class="TzBody" id="TzBody">
                <div class="TzContent1">
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                 <li>
                                    <div class="TzImg">
                                        <a href="#">
                                            <img  onload="changeImg(this,150,150)" alt="<%#Eval("title") %>" src="<%#Eval("img1") %>" /></a>
                                    </div>
                                    <div class="ProductTitle">
                                        <%#Eval("title") %>
                                    </div>
                                    <div class="def-price">
                                        ￥<span class="price"><%#double.Parse(Eval("priceRang").ToString().Split('|')[0].Split(',')[1]).ToString("N2") %></span>
                                    </div>
                                    <div class="mgbt8">
                                        <span class="mixText"><%#Eval("priceRang").ToString().Split('|')[0].Split(',')[0] %><%#Eval("unit") %>起</span>
                                        <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                            class="mix-imgmid">
                                        <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                            align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <!--========精品推荐结束=============-->
        <div class="Split12px">
        </div>
        <!--========最新产品开始=============-->
        <div class="NewProduct">
            <div class="NewHead">
                <div class="NewHLeft">
                    最新产品</div>
                <div class="NewHRight">
                    <a href="#">更多&gt;&gt;</a></div>
            </div>
            <div class="NewBody" id="NewBody">
                <div class="NewContent">
                    <ul>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                     <li>
                                        <div class="NewImg">
                                            <a href="#">
                                                <img  onload="changeImg(this,150,150)" alt="<%#Eval("title") %>" src="<%#Eval("img1") %>" /></a>
                                        </div>
                                        <div class="ProductTitle">
                                            <%#Eval("title") %>
                                        </div>
                                        <div class="def-price">
                                            ￥<span class="price"><%#double.Parse(Eval("priceRang").ToString().Split('|')[0].Split(',')[1]).ToString("N2") %></span>
                                        </div>
                                        <div class="mgbt8">
                                            <span class="mixText"><%#Eval("priceRang").ToString().Split('|')[0].Split(',')[0] %><%#Eval("unit") %>起</span>
                                            <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                                class="mix-imgmid">
                                            <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                                align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                                        </div>
                                    </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <!--========最新产品结束=============-->
        <div class="Split12px">
        </div>
        <!--========联系我们开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                   联系我们</div>
                <div class="AHRight">
                    <a href="../profile/index_profile.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="AboutBody">
                <asp:Repeater ID="Repeater3" runat="server">
                    <ItemTemplate>
                         <ul>
                            <li><a href="http://profile.china.alibaba.com/user/xuhechai.html"><%#Eval("TrueName") %></a> <%#Eval("Gender")%> （<%#Eval("Position")%>）
                                <a title="我不在网上，给我留个消息吧" onmousedown="aliclick(this, '?info_id=26806687');traceXunpanLog(this,'xuhechai','','');return traceParrotStatLog(this, 'alitalk', 'xuhechai', 'athena');"
                                    href="#" alitalk="{id:'xuhechai',siteID:'cnalichn',type:1}">给我留言</a></li>
                         </ul>
                         <ul>
                             <li>电 话： <%#Eval("Phone").ToString().TrimEnd('-')%></li>
                         </ul>
                         <ul>
                             <li>移动电话： <%#Eval("Mobile") %></li>
                         </ul>
                         <ul>
                             <li>传 真： <%#Eval("Fax").ToString().TrimEnd('-')%></li>
                         </ul>
                         <ul>
                             <li>经营地址： <%#Eval("BusinessAddress")%> </li>
                         </ul>
                         <ul>
                             <li>公司主页： <a href="<%#Eval("HomePage") %>" target="_blank"><%#Eval("HomePage") %></a></li>
                         </ul>
                    </ItemTemplate>
                </asp:Repeater>
               
            </div>
        </div>
        <!--========联系我们结束=============-->
    </div>
</asp:Content>
