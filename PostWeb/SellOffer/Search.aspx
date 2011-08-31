<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Product_Search" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/search.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form runat="server" id="form1">
<div  class="mainContent overflowAuto">
    <!--======左边开始===========-->
    <div class="contentLeft floatL overflowAuto" >
        <div class="searchInfo">
            <div class="sCategory floatL">所有类目</div><div class="sDetail floatL gray">共找到<span class="bold red">62415</span>条符合"<span class="bold">国产手机</span>"查询结果</div>
        </div>
        
        <div class="catDetail martop8">
            <ul>
                 <li class="sltTag">
                    <ul class="catItem"> 
                       <li class="itemTitle">您已选择：</li>
                       <li class="sltItemContent">
                            <ul>
                                <li><a href="javascript:;">200万</a></li>
                                <li><a href="javascript:;">诺基亚</a></li>
                                <li><a href="javascript:;">CDMA</a></li>
                                <li><a href="javascript:;">滑盖</a></li>
                            </ul>
                       </li>
                    </ul>
                </li>
                <li class="liCat">
                    <ul class="catItem"> 
                       <li class="itemTitle">类目：</li>
                       <li class="itemContent">
                            <ul>
                                <li><a href="#">手机</a></li>
                                <li><a href="#">手机外壳</a></li>
                                <li><a href="#">手机挂件</a></li>
                                <li><a href="#">电话卡</a></li>
                                <li><a href="#">手机保护套</a></li>
                                <li><a href="#">其他手机配件</a></li>
                                <li><a href="#">手写笔</a></li>
                                <li><a href="#">手机IC</a></li>
                                <li><a href="#">手机连接器</a></li>
                                <li><a href="#">手机擦</a></li>
                            </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
            </ul>
           
            <ul>
                <li class="liProperty">
                    <ul class="catItem overflowAuto">
                       <li class="itemTitle">摄像头像素：</li>
                       <li class="itemContent">
                           <ul>
                               <li><a href="#">200万</a></li>
                               <li><a href="#">130万</a></li>
                               <li><a href="#">500万</a></li>
                               <li><a href="#">320万</a></li>
                               <li><a href="#">300万</a></li>
                               <li><a href="#">30万</a></li>
                           </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
                <li class="liProperty">
                    <ul class="catItem overflowAuto">    
                       <li class="itemTitle">品牌：</li>
                       <li class="itemContent">
                           <ul>
                              <li><a href="#">诺基亚</a></li>
                              <li><a href="#">HTC</a></li>
                              <li><a href="#">苹果</a></li>
                              <li><a href="#">三星</a></li>
                              <li><a href="#">黑莓</a></li>
                              <li><a href="#">摩托罗拉</a></li>
                              <li><a href="#">索尼爱立信</a></li>
                          </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
                <li class="liProperty">
                    <ul class="catItem overflowAuto">
                       <li class="itemTitle">网络制式：</li>
                       <li class="itemContent">
                           <ul>
                               <li><a href="#">GSM</a></li>
                               <li><a href="#">CDMA</a></li>
                               <li><a href="#">3G(WCDM...</a></li>
                               <li><a href="#">双模双待</a></li>
                               <li><a href="#">双卡双待</a></li>
                           </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
                <li class="liProperty">
                    <ul class="catItem overflowAuto">
                       <li class="itemTitle">外形：</li>
                       <li class="itemContent">
                           <ul>
                               <li><a href="#">滑盖</a></li>
                               <li><a href="#">直板</a></li>
                               <li><a href="#">翻盖</a></li>
                           </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li> 
                  <li class="liProperty">
                    <ul class="catItem overflowAuto">
                       <li class="itemTitle">摄像头像素：</li>
                       <li class="itemContent">
                           <ul>
                               <li><a href="#">200万</a></li>
                               <li><a href="#">130万</a></li>
                               <li><a href="#">500万</a></li>
                               <li><a href="#">320万</a></li>
                               <li><a href="#">300万</a></li>
                               <li><a href="#">30万</a></li>
                           </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
                <li class="liProperty">
                    <ul class="catItem overflowAuto">    
                       <li class="itemTitle">品牌：</li>
                       <li class="itemContent">
                           <ul>
                              <li><a href="#">诺基亚</a></li>
                              <li><a href="#">HTC</a></li>
                              <li><a href="#">苹果</a></li>
                              <li><a href="#">三星</a></li>
                              <li><a href="#">黑莓</a></li>
                              <li><a href="#">摩托罗拉</a></li>
                              <li><a href="#">索尼爱立信</a></li>
                          </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
                <li class="liProperty">
                    <ul class="catItem overflowAuto">
                       <li class="itemTitle">网络制式：</li>
                       <li class="itemContent">
                           <ul>
                               <li><a href="#">GSM</a></li>
                               <li><a href="#">CDMA</a></li>
                               <li><a href="#">3G(WCDM...</a></li>
                               <li><a href="#">双模双待</a></li>
                               <li><a href="#">双卡双待</a></li>
                           </ul>
                       </li>
                       <li><a href="javascript:;" class="catMore">更多</a></li>
                    </ul>
                </li>
            </ul>
            <div class="Arrow"></div>
        </div>
        <div class="mpContainer"><div class="moreProperty">更多</div></div>
        <!---========商品列表头开始==========-->
        <div class="pListHead">
            <ul class="floatL" >
                <li class="sltMn"><div class="mL"></div><div class="mM">所有产品</div><div class="mR"></div></li>
                <li style="height:24px;"><div class="mL"></div><div class="mM">人气</div><div class="mR"></div></li>
            </ul>
            <div class="paper floatR">
               <webdiyer:AspNetPager CustomInfoSectionWidth="50" CustomInfoStyle="text-align:right" runat="server" CustomInfoHTML="%currentPageIndex%/%pageCount%&nbsp;" ShowCustomInfoSection="Left"   ShowPageIndexBox="Never" ShowFirstLast="false" ShowMoreButtons="false"   NextPageText="下一页" PrevPageText="上一页" RecordCount="1228" CssClass="pages pages2"  ShowPageIndex="false" ID="AspNetPager2" ></webdiyer:AspNetPager>
            </div>       
        </div>
        <div class="pListHead2">
            单价 <input class="txtP" name="minPri" type="text" /> 至 <input class="txtP" name="maxPri" type="text" /> 元<span class="margin_1em"></span>起订量 <input class="txtP" name="maxPri" type="text" /> 以下<span class="margin_2em"></span><input name="btnSearch" class="proBtnSearch" type="button" value="确定" />
        </div>

        <ul class="plistHead3">
            <li class="filterItem"><a href="javascript:;" class="switchView floatL">切换到大图</a></li>
            <li class="filterItem busClass">
                所有经营模式
                <ul>
                    <li><a  href="#">所有经营模式</a></li>
                    <li><a  href="#">生产加工</a></li>
                    <li><a href="#">批发经销</a></li>
                    <li><a href="#">招商代理</a></li>
                    <li><a href="#">商业服务</a></li>
                </ul>
            </li>
            <li class="filterItem busClass">
              默认排序
                    <ul>
                        <li class="by_price_asc"><a href="#">价格从低到高</a></li>
                        <li class="by_price_desc"><a href="#">价格从高到低</a></li>
                        <li class="by_hot_desc"><a href="#">人气从高到低</a></li>
                        <li class="by_default"><a href="#">默认排序</a></li>
                    </ul>
               
            </li>
            <li class="filterItem liPrice">
                <a href="javascript:;" class="price_orderChk">价格</a>
            </li>
            <li class="filterItem pArea">
                所在地
            </li>
            <li class="filterItem pContact">
                联系方式
            </li>
        </ul>
        <!---========商品列表头结束==========-->
        <!--=========商品列表开始==========-->
        <div class="pListBody">
            <ul>
                <li><a href="#" class="plistImg"><img width="100" height="100"  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul>    
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/cc/11/cc1149f57fabbf61ac32ca60ecfbaffd.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/1e/98/1e984f54188174419c1531332abb32d5.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/dc/08dcd1535199cf93ccbfd11f567a6e4c.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
            
             <ul>
                <li><a href="#" class="plistImg" ><img  src="http://resource.360hqb.com/thumbs/product/08/fc/08fcd61bc9f3996c99495641c9c9907d.88.jpg" /></a></li>
                <li class="liPinfo">
                    <div class="pName"><a href="#">三星（Samsung）B3410 GSM手机（白色） 2G手机 大陆行货 联保</a></div>
                    <div class="pDetail">商品类型:全新 品牌:苹果 网络制式:双卡双待 型号:罗盘4GS 外形:直板 售后类型:店铺三包 </div>
                    <div class="cName"><a href="#">英达伟行货手机专卖</a>&nbsp;<img class="imgRz" alt="已通过实名认证" src="http://www.360hqb.com/misc/images/icon/rz.gif" /></div>
                </li>
                <li class="lipPrice">
                    <div><span class="￥">￥</span><span class="red bold">60.00</span></div> 
                    <div>10000部起</div>
                </li>
                <li class="liBuyGuarantee">
                    <div><img src="images/Guarantee.gif"  /></div>
                </li>
                <li class="liArea">
                    <div>广东</div>
                    <div>深圳市福田区</div>
                </li>
                <li class="liContact">
                    <div><a href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                    <div><a href="#" class="contactPhone"></a></div>
                </li>
            </ul> 
        </div>
        <!-----------商品列表厨窗样式----------->
        <div class="pListbody2">
            <ul>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                 <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
                <li>
                    <a href="#" class="pListImg2" ><img src="http://resource.360hqb.com/thumbs/product/b3/49/b349a54049a7ce5d361bcc6fb6552f2f.160.jpg" /></a>
                    <div class="pName2"><a href="#" title="Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻">Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻Moto摩托罗拉 me511 侧空翻</a></div>
                    <div class="linkQQ"><img class="floatL" src="images/cxt.gif" /><a class="floatR"  href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img  src="http://wpa.qq.com/pa?p=2:1152152478:4" alt="给我留言" /></a></div>
                    <div class="pPrice"><span class="￥">￥</span><span class="red bold">1000.00</span><span class="margin_1em"></span><span>10000部起</span></div>
                    <div class="cName2"><a href="#" title="深圳市福田区远望源通讯市场新恒丰源通讯行">深圳市福田区远望源通讯市场新恒丰源通讯行</a></div>
                </li>
            </ul>
        </div>
        <!--=========商品列表结束==========-->
    </div>
    <!--======左边结束===========-->
    <!--======右边开始===========-->
    <div class="contentRight floatR overflowAuto">
            <Custom:SearchAD runat="server" ID="SearchAD1" />
    </div>
    <!--======右边结束===========-->
</div>
<div class="pagerContainer">
 <!--=========分页开始========-->
    <webdiyer:AspNetPager CssClass="pages"  AlwaysShowFirstLastPageNumber="true"  ShowDisabledButtons="false" ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager4" NumericButtonCount="7" runat="server" RecordCount="1228"
        FirstPageText="首页" LastPageText="尾页" TextBeforePageIndexBox="共100页 第"  TextAfterPageIndexBox="页 "  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"  ShowPageIndexBox="Always" PrevPageText="上一页">
    </webdiyer:AspNetPager>
        <!--=========分页结束========-->
</div>
</form>
<script type="text/javascript" src="js/jsProductSearch.js"></script>
</asp:Content>

