<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_product.aspx.cs" Inherits="index_product"
    Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
	$(document).ready(function(){
		$(".div001").click(function(){
			if($(this).hasClass("div002")){
				$(this).removeClass("div002");
				$(".ul001").show(300);
			}else{
				$(this).addClass("div002");
				$(".ul001").hide(300);
			}
		});	
	});
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MiddleRight">
        <!--========产品内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    所有产品</div>
                <div class="div001">
                </div>
            </div>
            <div class="AlbumBody">
                <ul class="ul001">
                    <li><a href="#">铝及铝合金材(1)</a></li>
                    <li><a href="#">草坪灯(6) </a></li>
                    <li><a href="#">LED灯具(135) </a></li>
                    <li><a href="#">格栅灯(10) </a></li>
                    <li><a href="#">投射灯(8) </a></li>
                    <li><a href="#">其他室外照明灯具(4) </a></li>
                    <li><a href="#">灯杯(1) </a></li>
                    <li><a href="#">射灯、杯灯(11) </a></li>
                    <li><a href="#">筒灯(1) </a></li>
                    <li><a href="#">其他灯具配附件(9) </a></li>
                    <li><a href="#">其他金属加工材(1) </a></li>
                    <li><a href="#">其他常规照明(7) </a></li>
                </ul>
                <ul class="ul002">
                    <li><span>搜索本旺铺产品：</span>产品名<input name="" class="proNameInput" type="text" /></li>
                    <li>&nbsp;&nbsp;价格<input name="" class="minPrice" type="text" />&nbsp;到&nbsp;<input
                        name="" type="text" class="maxPrice" /></li>
                    <li>
                        <input name="SearchBtn2" id="SearchBtn2" type="button" class="SearchBtn" /></li>
                </ul>
                <ul class="ul003">
                    <li></li>
                </ul>
                <div class="NewContent">
                    <ul>
                        <li>
                            <div class="NewImg">
                                <a href="product_show.aspx"><img alt="" src="http://i05.c.aliimg.com/img/ibank/2010/079/972/209279970_1778649337.search.jpg" /></a>
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i04.c.aliimg.com/img/ibank/2010/558/147/199741855_1508253996.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i02.c.aliimg.com/img/ibank/2010/017/740/199047710_1508253996.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i02.c.aliimg.com/img/ibank/2010/552/746/199647255_1508253996.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i03.c.aliimg.com/img/ibank/2010/584/514/185415485_1508253996.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/862/032/209230268_1778649337.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/311/545/209545113_1778649337.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i03.c.aliimg.com/img/ibank/2010/091/125/209521190_1778649337.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/079/972/209279970_1778649337.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i04.c.aliimg.com/img/ibank/2010/558/147/199741855_1508253996.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i02.c.aliimg.com/img/ibank/2010/017/740/199047710_1508253996.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i02.c.aliimg.com/img/ibank/2010/552/746/199647255_1508253996.search.jpg" />
                            </div>
                            <div class="ProductTitle">
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i03.c.aliimg.com/img/ibank/2010/584/514/185415485_1508253996.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/862/032/209230268_1778649337.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/311/545/209545113_1778649337.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                        <li>
                            <div class="NewImg">
                                <img border="0" alt="" src="http://i03.c.aliimg.com/img/ibank/2010/091/125/209521190_1778649337.search.jpg" />
                            </div>
                            <div>
                                自行车音箱自行车音响携带方便，插..
                            </div>
                            <div class="def-price">
                                ￥<span class="price" unit="元/个">72.00</span>
                            </div>
                            <div class="mgbt8">
                                <span class="mixText">20个起</span>
                                <img align="absmiddle" src="http://i05.c.aliimg.com/images/app/winport/layout/list/mix.gif"
                                    class="mix-imgmid">
                                <img class="imgmid" src="http://i02.c.aliimg.com/images/cn/market/b2bauction/logo_alipay.gif"
                                    align="absmiddle" title="本商品交易支持支付宝，买家收货确认后，卖家才能拿到钱，保障你的交易安全。" />
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--========产品内容结束=============-->
    </div>
</asp:Content>
