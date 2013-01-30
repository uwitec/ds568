<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" AutoEventWireup="true"   CodeFile="index_home.aspx.cs" Inherits="index_home"  %>
<%@ Import Namespace="Com.DianShi.BusinessRules.ShopConfig" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="server">
    <%="商铺首页,"+_vMember.CompanyName %>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/template/tem1/home/css/focusimg.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #about{line-height:20px;}
    </style>
    <script type="text/javascript" src="/template/tem1/home/js/index.js"></script>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <%if (!_ShopConfig.AdType.HasValue || _ShopConfig.AdType.Equals((byte)DS_ShopConfig_Br.AdType.单图广告))
      { %>
        <div class="headTopic" <%=string.IsNullOrEmpty(_ShopConfig.AdSigleImg)?"":"style=\"background-image:url("+_ShopConfig.AdSigleImg+")\"" %> ></div>
    <%}
      else if (_ShopConfig.AdType.Equals((byte)DS_ShopConfig_Br.AdType.多图广告))
      { %>
    <!--多图广告开始-->
    <div class="flash-box" >
      <div class="focusImg" >
        <div class="autoImg">
          <div class="scrollwrapper">
            <div style="WIDTH: 4000px" class="imgBox">
                <%
                    var ty = _ShopConfig.GetType();
                    int imgnum = 0;
                    for (int i = 1; i <= 4; i++)
                    {
                        var img=ty.GetProperty("AdMutiImg" + i).GetValue(_ShopConfig,null) as string;
                        if (!string.IsNullOrEmpty(img)) {
                            imgnum++;
                             %>
                            <div class="layt"><img  src="<%=img %>" /></div>
                            <%
                        }
                    }
                %>
              
            </div>
          </div>
          <div class="switchable-nav">
            <ul>
              <%
                    for (int i = 1; i <= imgnum; i++)
                    {
                        %>
                            <li <%=i==1?"class=\"active\"":""%> >•</li>
                        <%
                    }
               %>
            </ul>
          </div>
        </div>
      </div>
    </div>
    <script type="text/javascript" src="/template/tem1/home/js/vGlobal.js"></script>
    <!--多图广告结束-->
    <%} %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MiddleRight">
        <!--========关于我们开始=============-->
        <div class="About">
            <div class="box-hd AboutHead">
                <div class="AHLeft">
                    关于我们</div>
                <div class="AHRight">
                    <a href="/template/tem1/profile/index_profile.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="box-ctn AboutBody justify">
                <img onerror="javascript:this.style.display='none'" class="AboutImg" src="<%=_vMember.ComImg.Split('|')[0] %>" />
                <span id="about">&nbsp;&nbsp;&nbsp;&nbsp;<%=string.IsNullOrEmpty(_vMember.Profile) ? "" : (_vMember.Profile.Length > 500 ? _vMember.Profile.Substring(0, 500) + "…（<a href='../profile/index_profile.aspx'>未完</a>）。" : _vMember.Profile)%></span>
            </div>
        </div>
        <!--========关于我们结束=============-->
        <div class="Split12px">
        </div>
        <!--========精品推荐开始=============-->
        <div class="TzProduct">
            <div class="box-hd TzHead">
                <div class="TzHLeft">
                    精品推荐</div>
                <div class="TzHRight">
                    <a href="../product/index_product.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="box-ctn TzBody" id="TzBody">
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
            <div class="box-hd NewHead">
                <div class="NewHLeft">
                    最新产品</div>
                <div class="NewHRight">
                    <a href="../product/index_product.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="box-ctn NewBody" id="NewBody">
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
            <div class="box-hd AboutHead">
                <div class="AHLeft">
                   联系我们</div>
                <div class="AHRight">
                    <a href="../profile/index_profile.aspx">更多&gt;&gt;</a></div>
            </div>
            <div class="box-ctn AboutBody">
                <ul>
                <li><%=_vMember.TrueName %> <%=_vMember.Gender %> （<%=_vMember.Position %>）
                    <a  href="http://wpa.qq.com/msgrd?v=3&uin=<%=_vMember.QQ %>&site=qq&menu=yes"><img onload="if(this.width>16) $(this).next().text('在线洽谈');"  src="http://wpa.qq.com/pa?p=2:<%=_vMember.QQ %>:4" alt="给我留言" /><span>给我留言</span></a></li>
                </ul>
                <ul>
                    <li>电<span class="marginLeft1em"></span><span class="marginLeft1em"></span>话： <%=string.IsNullOrEmpty(_vMember.Phone)?"":_vMember.Phone.TrimEnd('-')%></li>
                </ul>
                <ul>
                    <li>移动电话： <%=_vMember.Mobile %></li>
                </ul>
                <ul>
                    <li>传<span class="marginLeft1em"></span><span class="marginLeft1em"></span>真： <%=string.IsNullOrEmpty(_vMember.Fax)?"":_vMember.Fax.TrimEnd('-')%></li>
                </ul>
                <ul>
                    <li>经营地址： <%=_vMember.BusinessAddress %> </li>
                </ul>
                <ul>
                    <li>公司主页： <a href="<%=_vMember.HomePage %>" target="_blank"><%=_vMember.HomePage %></a></li>
                </ul>
            </div>
        </div>
        <!--========联系我们结束=============-->
    </div>
</asp:Content>
