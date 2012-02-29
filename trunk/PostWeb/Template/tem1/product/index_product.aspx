<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" ValidateRequest="false" AutoEventWireup="true"
    CodeFile="index_product.aspx.cs" Inherits="index_product"
    Title="Untitled Page" %>
<asp:Content ID="Content3" ContentPlaceHolderID="Title" runat="server">
    <title>供应产品</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" rev="stylesheet" href="/css/Pager.css" type="text/css"  />
    <script type="text/javascript" src="js/product.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MiddleRight">
        <!--========产品内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    产品列表</div>
                <div class="div001">
                </div>
            </div>
            <div class="AlbumBody">
                <ul class="ul001">
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <li><a href="?cat_id=<%#Eval("id") %>"><%#Eval("categoryname") %>(<%#Eval("pcount") %>)</a></li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
                <ul class="ul002">
                    <li><span>搜索本旺铺产品：</span>产品名<input id="pro_name" name="pro_name" value="<%=Request.QueryString["pro_name"] %>" class="proNameInput" type="text" /></li>
                    <li>&nbsp;&nbsp;价格<input name="low_price" value="<%=Request.QueryString["low_price"] %>" id="low_price" class="minPrice" type="text" />&nbsp;到&nbsp;<input
                        name="height_price" id="height_price" value="<%=Request.QueryString["height_price"] %>" type="text" class="maxPrice" /></li>
                    <li>
                        <input name="SearchBtn2" id="SearchBtn2" type="button" class="SearchBtn" /></li>
                </ul>
                <ul class="ul003">
                    <li></li>
                </ul>
                <div class="NewContent">
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="NewImg">
                                        <a href="product_show.aspx?pro_id=<%#Eval("id") %>"><img  onload="changeImg(this,150,150)" alt="<%#Eval("title") %>" src="<%#Eval("img1") %>" /></a>
                                    </div>
                                    <div class="ProductTitle">
                                        <%#Eval("title") %>
                                    </div>
                                    <div class="def-price">
                                        ￥<span class="price" ><%#double.Parse(Eval("priceRang").ToString().Split('|')[0].Split(',')[1]).ToString("N2") %></span>
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
                    <div class="nopro">抱歉，没有找到符合条件的供应信息。请重新搜索或者<a href="index_product.aspx">查看全部供应信息！</a> </div>
                     <webdiyer:AspNetPager CssClass="pages"  AlwaysShowFirstLastPageNumber="true"  HorizontalAlign="Right" ShowDisabledButtons="false" ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager4" NumericButtonCount="7" runat="server"
        FirstPageText="首页" LastPageText="尾页" TextBeforePageIndexBox="共10页 到"  TextAfterPageIndexBox="页 " PageSize="16"  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"  ShowPageIndexBox="Always" PrevPageText="上一页">
    </webdiyer:AspNetPager>
                    &nbsp;
                </div>
            </div>
        </div>
        <!--========产品内容结束=============-->
    </div>
</asp:Content>
