<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_home.aspx.cs" Inherits="index_home"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
	var itv
	var TzCon
	var isRoll=true
	$(document).ready(function(){
		TzCon=$(".TzContent1")
		//复制精品推荐图片用于滚动
		$(".TzContent1 ul").append($(".TzContent1 ul").html())
		
		//开始滚动精品推荐
		setTimeout(RollImg,3000)
		
	});
	
	//滚动精品推荐
	function RollImg(){
	    var sl= TzCon.scrollLeft();
	    if(sl>=1408){
	        TzCon.scrollLeft(0);
	    }
	    TzCon.animate({scrollLeft:TzCon.scrollLeft()+176},600,function(){
	        setTimeout(RollImg,3500);
	    });
	}
	 
	
    </script>

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
                <img onerror="javascript:this.style.display='none'" class="AboutImg" src="http://i04.c.aliimg.com/img/company/26/32/38/05/26323805_1.summ.jpg" />
                深圳市动感者科技有限公司，致力于多媒体音响产品的研发工作，生产规模雄厚并迅速扩大，成为—家集生产、开发与销售为一体的音响产品专业生产商，推出自有品牌"动感者"。公司本着精益求精的设计理念，全力打造多种视听产品，设立了市场信息中心，产品外观设计中心，产品研究开发实验室、国内自有品牌事业行销部、品牌推广市场部、国际贸易部及制造中心，并引进现代化的生产工艺设备和高素质管理人员。
                由于公司采用了当今业界最为成熟的生产流程，融入了制造领域内最为先进的科技成分，使得"动感者"产品以其卓越的品质，在市场上让消费者体验了完美生动的视听感受。这些高品质的产品，价格相对适中，坚持产品的高性价比路线，自面市
                （未完，全文请 查看更多 ） 深圳市动感者科技有限公司，致力于多媒体音响产品的研发工作，生产规模雄厚并迅速扩大，成为—家集生产、开发与销售为一体的音响产品专业生产商，推出自有品牌"动感者"
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
                        <li>
                            <div class="TzImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/079/972/209279970_1778649337.search.jpg" />
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
                            <div class="TzImg">
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
                            <div class="TzImg">
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
                            <div class="TzImg">
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
                            <div class="TzImg">
                                <img border="0" alt="" src="http://i03.c.aliimg.com/img/ibank/2010/584/514/185415485_1508253996.search.jpg" />
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
                            <div class="TzImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/862/032/209230268_1778649337.search.jpg" />
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
                            <div class="TzImg">
                                <img border="0" alt="" src="http://i05.c.aliimg.com/img/ibank/2010/311/545/209545113_1778649337.search.jpg" />
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
                            <div class="TzImg">
                                <img border="0" alt="" src="http://i03.c.aliimg.com/img/ibank/2010/091/125/209521190_1778649337.search.jpg" />
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
                        <li>
                            <div class="NewImg">
                                <a href="#">
                                    <img border="0" alt="" src="file://F:\VGDownloads\Temporary Internet Files\Content.IE5\KUV41YTR\202675349_1778649337[1].jpg" /></a>
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
        <!--========最新产品结束=============-->
        <div class="Split12px">
        </div>
        <!--========联系我们开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                   联系我们</div>
                <div class="AHRight">
                    <a href="#">更多&gt;&gt;</a></div>
            </div>
            <div class="AboutBody">
                <ul>
                    <li><a href="http://profile.china.alibaba.com/user/xuhechai.html">覃旭</a> 先生 （生产销售 经理）
                        <a title="我不在网上，给我留个消息吧" onmousedown="aliclick(this, '?info_id=26806687');traceXunpanLog(this,'xuhechai','','');return traceParrotStatLog(this, 'alitalk', 'xuhechai', 'athena');"
                            href="#" alitalk="{id:'xuhechai',siteID:'cnalichn',type:1}">给我留言</a></li>
                </ul>
                <ul>
                    <li>电 话： 86 0760 22837808</li>
                </ul>
                <ul>
                    <li>移动电话： 13531897321</li>
                </ul>
                <ul>
                    <li>传 真： 86 0760 22837808</li>
                </ul>
                <ul>
                    <li>地 址： 中国 广东 中山市 中山市小榄永宁岗头村工业区 </li>
                </ul>
                <ul>
                    <li>公司主页： <a href="http://xuhechai.cn.alibaba.com" target="_blank">http://xuhechai.cn.alibaba.com</a></li>
                </ul>
            </div>
        </div>
        <!--========联系我们结束=============-->
    </div>
</asp:Content>
