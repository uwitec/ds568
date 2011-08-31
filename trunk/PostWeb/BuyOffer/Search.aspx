<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Company_Search" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/search.css" rel="stylesheet" type="text/css" />
<link href="/js/css/area.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form runat="server" id="form1">
<div  class="mainContent overflowAuto">
    <!--======左边开始===========-->
    <div class="contentLeft floatL overflowAuto" >
        <div class="searchInfo">
            <div class="sCategory floatL">所有类目</div><div class="sDetail floatL gray">共找到<span class="bold red">62415</span>条符合"<span class="bold">国产手机</span>"查询结果</div>
        </div>
        <div class="ftBody">
            <div class="ftTop">
                <div class="ftTopL"></div>
                <div class="ftTopM"></div>
                <div class="ftTopR"></div>
            </div>
            <div class="ftMiddle overflowAuto">
            <div class="fbTitle">筛选搜索结果</div>
            <div class="ftBody">
                <div class="ftTop">
                    <div class="ftTopL"></div>
                    <div class="ftTopM"></div>
                    <div class="ftTopR"></div>
                </div>
                <div class="ftMiddle overflowAuto">
                    <div class="lm floatL">类目</div>
                    <ul class="lmlist overflowAuto">
                        <li><a href="#">手机挂件</a><span>(19331)</span></li>
                        <li><a href="#">手机</a><span>(18632)</span></li>
                        <li><a href="#">综合性公司</a><span>(18015)</span></li>
                        <li><a href="#">广告促销礼品</a><span>(10697)</span></li>
                        <li><a href="#">手机充电器</a><span>(10295)</span></li>
                        <li><a href="#">手机电池</a><span>(9874)</span></li>
                        <li><a href="#">手机外壳</a><span>(6247)</span></li>
                        <li><a href="#">钥匙配饰</a><span>(5842)</span></li>
                        <li><a href="#">其他手机配件</a><span>(5670)</span></li>
                        <li><a href="#">手机耳机</a><span>(5169)</span></li>
                        <li><a href="#">摆挂件饰品</a><span>(4417)</span></li>
                        <li><a href="#">MP4</a><span>(4393)</span></li>
                        <li><a href="#">MP3</a><span>(4286)</span></li>
                        <li><a href="#">数码相机</a><span>(3825)</span></li>
                        <li><a href="#">礼品、工艺品、...</a><span>(3561)</span></li>
                        <li><a href="#">锂电池</a><span>(3455)</span></li>
                        <li><a href="#">手机数据线</a><span>(3294)</span></li>
                        <li><a href="#">其他移动电话</a><span>(3236)</span></li>
                        <li><a href="#">通讯产品加工</a><span>(3169)</span></li>
                        <li><a href="#">其他手机饰品</a><span>(2961)</span></li>
                        <li><a href="#">手机连接器</a><span>(2938)</span></li>
                        <li><a href="#">笔记本电脑</a><span>(2908)</span></li>
                        <li><a href="javascript:;" class="cMore">显示更多</a></li>
                    </ul>
                </div>
                <div class="ftBot" >
                    <div class="ftBotL"></div>
                    <div class="ftBotM"></div>
                    <div class="ftBotR"></div>
                </div>
            </div>
        </div>
            <div class="ftBot" >
                <div class="ftBotL"></div>
                <div class="ftBotM"></div>
                <div class="ftBotR"></div>
            </div>
        </div>
        <ul class="c_list_header">
            <li class="default-Order floatL">
                <a href="javascript:;">默认排序</a></li>
            <li class="endTime floatL">
                <a href="javascript:;">报价截止时间</a></li>
            <li class="publishTime floatL">
            <a href="javascript:;">信息发布时间</a></li>
             <li class="floatL">
                <div  class="condition_sel w100 buyClass">所有采购类型
                    <ul class="jrmx">
                        <li><a href="#">所有采购类型</a></li>
                        <li><a href="#">现货</a></li>
                        <li><a href="#">加工</a></li>
                        <li><a href="#">库存</a></li>
                        <li><a href="#">二手</a></li>
                    </ul>
                </div>
            </li>
            <li class="floatL">
               <div  class="condition_sel cArea">所有地区</div>
            </li>
            <li class="floatL">
                <div  class="condition_sel vip">所有会员
                 <ul class="jcnf">
                        <li><a href="#">所有会员</a></li>
                        <li><a href="#">VIP会员</a></li>
                        <li><a href="#">免费会员</a></li>
                    </ul>
                </div>
            </li>
        </ul>
        <ul class="BuyList">
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">手机电镀</a> 08/10</div>
                    <div>报价截止时间：08/14<span class="margin_1em"></span>（仅剩<span class="red">3</span>天）<span class="margin_1em"></span>已有<span class="red">4</span>人报价</div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">5</span>台
                    <div></div>
                </div>
                <div class="BuyType floatL" >二手</div>
                <div class="BuyArea floatL" >江苏<div>苏州昆山市</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">高价采购手机配件、手机液晶、手机机壳、手机排线、手机液晶玻璃</a> 08/10</div>
                    <div>报价截止时间：08/29<span class="margin_1em"></span>暂无人报价<span class="margin_1em"></span></div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">1000000</span>台
                    <div>(预计10000000台/年)</div>
                </div>
                <div class="BuyType floatL" >现货</div>
                <div class="BuyArea floatL" >广东<div>深圳市宝安区</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">手机电镀</a> 08/10</div>
                    <div>报价截止时间：08/14 （仅剩<span class="red">3</span>天）已有<span class="red">4</span>人报价</div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">1000000</span>台
                    <div>(预计10000000台/年)</div>
                </div>
                <div class="BuyType floatL" >二手</div>
                <div class="BuyArea floatL" >江苏<div>苏州昆山市</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">手机电镀</a> 08/10</div>
                    <div>报价截止时间：08/14 （仅剩<span class="red">3</span>天）已有<span class="red">4</span>人报价</div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">1000000</span>台
                    <div>(预计10000000台/年)</div>
                </div>
                <div class="BuyType floatL" >二手</div>
                <div class="BuyArea floatL" >江苏<div>苏州昆山市</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">手机电镀</a> 08/10</div>
                    <div>报价截止时间：08/14 （仅剩<span class="red">3</span>天）已有<span class="red">4</span>人报价</div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">1000000</span>台
                    <div>(预计10000000台/年)</div>
                </div>
                <div class="BuyType floatL" >二手</div>
                <div class="BuyArea floatL" >江苏<div>苏州昆山市</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">手机电镀</a> 08/10</div>
                    <div>报价截止时间：08/14 （仅剩<span class="red">3</span>天）已有<span class="red">4</span>人报价</div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">1000000</span>台
                    <div>(预计10000000台/年)</div>
                </div>
                <div class="BuyType floatL" >二手</div>
                <div class="BuyArea floatL" >江苏<div>苏州昆山市</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
            <li>
                <div class="BuyTitle floatL" >
                    <div><a href="#">手机电镀</a> 08/10</div>
                    <div>报价截止时间：08/14 （仅剩<span class="red">3</span>天）已有<span class="red">4</span>人报价</div>
                </div>
                <div class="BuyNumber floatL" >采购量：<span class="bold">1000000</span>台
                    <div>(预计10000000台/年)</div>
                </div>
                <div class="BuyType floatL" >二手</div>
                <div class="BuyArea floatL" >江苏<div>苏州昆山市</div></div>
                <div class="MemberType floatL">VIP会员</div>
            </li>
        </ul>
    </div>
    <!--======左边结束===========-->
    <!--======右边开始===========-->
    <div class="contentRight floatR overflowAuto" >
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
<script type="text/javascript" src="js/jsBuySearch.js"></script>
</asp:Content>