<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" AutoEventWireup="true"   CodeFile="index_home.aspx.cs" Inherits="index_home"  %>
<%@ OutputCache Duration="1800" VaryByParam="none" VaryByCustom="Host" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/template/tem1/home/css/focusimg.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #about{line-height:20px;}
    </style>
    <script type="text/javascript" src="/template/tem1/home/js/index.js"></script>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="headTopic" runat="server"  id="DefaultR"></div>
    <div runat="server" visible="false" id="Roll_Img_wrap">
    <!--焦点图开始-->
    <div class="flash-box">
      <div class="focusImg">
        <div class="autoImg">
          <div class="scrollwrapper">
            <div style="WIDTH: 3100px" class="imgBox">
              <div class="layt"><img runat="server" id="RM_1" src="530045538_1340326976.jpg" /></div>
              <div class="layt"><img runat="server" id="RM_2" src="530046693_1340326976.jpg" /></div>
              <div class="layt"><img runat="server" id="RM_3" src="530045520_1340326976.jpg" /></div>
            </div>
          </div>
          <div class="switchable-nav">
            <ul>
              <li class="active">•</li>
              <li>•</li>
              <li>•</li>
            </ul>
          </div>
        </div>
      </div>
    </div>
    <script type="text/javascript" src="/template/tem1/home/js/vGlobal.js"></script>
    <!--焦点图结束-->
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MiddleRight">
        <!--========关于我们开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    关于我们</div>
                <div class="AHRight">
                    <a href="/template/tem1/profile/index_profile.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="AboutBody justify">
                <img onerror="javascript:this.style.display='none'" class="AboutImg" src="<%=_vMember.ComImg.Split('|')[0] %>" />
                <span id="about">&nbsp;&nbsp;&nbsp;&nbsp;<%=string.IsNullOrEmpty(_vMember.Profile) ? "" : (_vMember.Profile.Length > 500 ? _vMember.Profile.Substring(0, 500) + "…（<a href='../profile/index_profile.aspx'>未完</a>）。" : _vMember.Profile)%></span>
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
                    <a href="../product/index_product.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="TzBody" id="TzBody">
                <div class="TzContent1">
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                 <li>
                                    <div class="TzImg">
                                        <a href="/template/tem1/product/product_show.aspx?pro_id=<%#Eval("id") %>">
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
                    <a href="../product/index_product.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="NewBody" id="NewBody">
                <div class="NewContent">
                    <ul>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                     <li>
                                        <div class="NewImg">
                                            <a href="/template/tem1/product/product_show.aspx?pro_id=<%#Eval("id") %>">
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
                            <li><%#Eval("TrueName") %> <%#Eval("Gender")%> （<%#Eval("Position")%>）
                                <a  href="http://wpa.qq.com/msgrd?v=3&uin=<%#Eval("qq") %>&site=qq&menu=yes"><img onload="if(this.width>16) $(this).next().text('在线洽谈');"  src="http://wpa.qq.com/pa?p=2:<%#Eval("qq") %>:4" alt="给我留言" /><span>给我留言</span></a></li>
                         </ul>
                         <ul>
                             <li>电<span class="marginLeft1em"></span><span class="marginLeft1em"></span>话： <%#Eval("Phone").ToString().TrimEnd('-')%></li>
                         </ul>
                         <ul>
                             <li>移动电话： <%#Eval("Mobile") %></li>
                         </ul>
                         <ul>
                             <li>传<span class="marginLeft1em"></span><span class="marginLeft1em"></span>真： <%#Eval("Fax").ToString().TrimEnd('-')%></li>
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
