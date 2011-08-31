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
            <li class="plly floatL">批量留言</li>
            <li class="floatL">
               <div  class="condition_sel cArea">所有地区</div>
            </li>
            <li class="floatL">
                <div  class="condition_sel w100">所有经营模式
                    <ul class="jrmx">
                        <li><a href="#">所有经营模式</a></li>
                        <li><a href="#">生产加工</a></li>
                        <li><a href="#">批发经销</a></li>
                        <li><a href="#">招商代理</a></li>
                        <li><a href="#">商业服务</a></li>
                    </ul>
                </div>
            </li>
            <li class="floatL">
                <div  class="condition_sel w100">所有注册年份
                 <ul class="jcnf">
                        <li><a href="#">所有注册年份</a></li>
                        <li><a href="#">超过5年</a></li>
                        <li><a href="#">超过3年</a></li>
                        <li><a href="#">超过1年</a></li>
                        <li><a href="#">不满1年</a></li>
                    </ul>
                </div>
            </li>
        </ul>
        <ul class="CompanyList">
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox1" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
            </li>
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox2" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
            </li>
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox3" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
            </li>
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox4" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
            </li>
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox5" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
            </li>
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox6" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
            </li>
            <li class="lilist overflowAuto">
                <div class="cCheck floatL">
                    <input id="Checkbox7" type="checkbox" />
                </div>
                <div class="comInfoContainer floatL">
                    <ul class="nameAddress">
                        <li class="Descript">
                            <div><a class="cName" href="#">深圳市心迪宝通信设备有限公司</a></div>
                            <div>我们的产品有：手机通讯产品、车载产品（行车记录仪/行驶记录仪）以及手机通讯产品、车载产品</div>
                            <div><b class="gray">经营地址：</b> <a href="#" class="lkAddress">广东 深圳市 宝安西乡宝盛华丰工业园</a></div>
                        </li>
                        <li class="registerData">2010</li>
                        <li class="regAmount">人民币2000万</li>
                        <li class="vipY">VIP会员第七年</li>
                        <li class="liContact">
                            <div><a class="qqonline" href="http://wpa.qq.com/msgrd?v=3&uin=1152152478&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:1152152478:47" alt="给我留言" /></a></div>
                            <div><a href="#" class="contactPhone"></a></div>
                        </li>
                    </ul>
                    <div class="BusinessModel overflowAuto">
                        <div class="floatL"><b class="gray">经营模式：</b>生产厂家<span class="marginL_40"></span><b class="gray">主营：</b></div>
                        <div class="floatL"><a href="#">三星手机</a>; <a href="#">夏普手机</a>;<a href="#"> 电视手机</a>; <a href="#">大显手机...</a></div>
                    </div>
                </div>
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
<script type="text/javascript" src="js/jsCompanySearch.js"></script>
</asp:Content>