<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reg.aspx.cs" Inherits="Member_Join_reg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户注册</title>
    <Custom:Header ID="Header1" runat="server" />
    <link href="css/reg.css" rel="stylesheet" type="text/css" />
    <link href="/js/css/validate.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/jquery.validate.min.js"></script>
    <script type="text/javascript" src="/js/messages_cn.js"></script>
    <script type="text/javascript" src="js/reg.js"></script>
   
</head>
<body>

    <div class="main">
        <div class="overflowAuto">
            <div class="logo floatL bold"><img src="http://i01.c.aliimg.com/images/cn/home/070827/logo2.gif" />免费注册</div>
            <div class="contact floatR gray">
                <a href="#">登陆</a> | <a href="#">返回点石首页</a> | <a href="#">帮助中心</a>
                <div class="help overflowAuto">
                    <div class="floatR">&nbsp;或拔打<span class="kfphone bold">0755-43456567</span></div>
                    <a class="qqonline floatR gray" href="http://wpa.qq.com/msgrd?v=3&uin=416351551&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:416351551:4" alt="给我留言" />在线客服</a>
                    <div class="floatR">如需帮助，请咨询&nbsp;</div>
                </div>
            </div>
        </div>
        <div class="headLine"></div>
        <div class="baseInfo">
            <div class="title bold">基本信息
                <div class="hLine">&nbsp;</div>
                <div class="block bl1"></div>
                <div class="block bl2"></div>
                <div class="block bl3"></div>
                <div class="block bl4"></div>
            </div>
        </div>
        <form  runat="server" id="form1">
        <input type="hidden" name="action" />
        <div class="regContainer overflowAuto">
            <div class="conLeft floatL">
                <ul>
                    <li><span class="marginL12"></span>电子邮箱<span class="star">*</span><input class="txtbox" name="email" id="email" type="text" /></li>
                    <li>会员登录名<span class="star">*</span><input class="txtbox" name="account" id="account" type="text" /></li>
                    <li><span class="marginL42"></span>密码<span class="star">*</span><input class="txtbox" name="password" id="password" type="password" /></li>
                    <li><span class="marginL12"></span>确认密码<span class="star">*</span><input class="txtbox" name="password2" id="password2" type="password" /></li>
                </ul>
                <div class="baseInfo">
                    <div class="title bold">公司信息
                        <div class="hLine">&nbsp;</div>
                        <div class="block bl1"></div>
                        <div class="block bl2"></div>
                        <div class="block bl3"></div>
                        <div class="block bl4"></div>
                    </div>
                </div>
                <ul>
                    <li><span class="marginL12"></span>公司名称<span class="star">*</span><input class="txtbox" name="companyName" id="companyName" type="text" /></li>
                    <li><span class="marginL12"></span>真实姓名<span class="star">*</span><input class="txtbox trueName" name="trueName" id="trueName" type="text" />
                        <input class="mType" name="sex" id="sex1" value="先生"  type="radio" checked /><label for="sex1">先生</label>
                        <input class="mType"  name="sex" id="sex2" value="女士" type="radio" /><label for="sex2">女士</label>
                        
                    </li>
                    <li><span class="marginL12"></span>固定电话<span class="star">*</span><input class="txtbox phone-qh" name="phoneqh" id="phoneqh" type="text" />-<input class="txtbox phone-hm" name="phonehm" id="phonehm" type="text" />-<input class="txtbox phone-fj" name="phonefj" id="phonefj" type="text" /></li>
                    <li><span class="marginL42"></span>手机<span class="star">&nbsp;</span><input class="txtbox mobile" name="mobile" id="mobile" type="text" /></li>
                    <li><span class="marginL12"></span>主营行业<span class="star">*</span><input class="txtbox" name="mainIndustry" id="mainIndustry" type="text" /></li>
                    <li><span class="marginL12"></span>公司地区<span class="star">*</span><input class="txtbox" readonly name="area" id="area" type="text" /></li>
                    <li><span class="marginL12"></span>会员身份<span class="star">*</span>
                        <input class="mType" name="memberType" id="mt1" value="0"  type="radio" /><label for="mt1">卖家</label>
                        <input class="mType"  name="memberType" id="mt2" value="1" type="radio" /><label for="mt2">买家</label>
                        <input class="mType" name="memberType" id="mt3" value="2" checked type="radio" /><label for="mt3">两者都是</label>
                    </li>
                </ul>
                <div class="baseInfo">
                    <div class="title bold">服务条款
                        <div class="hLine">&nbsp;</div>
                        <div class="block bl1"></div>
                        <div class="block bl2"></div>
                        <div class="block bl3"></div>
                        <div class="block bl4"></div>
                    </div>
                </div>
                <ul>
                    <li><span class="marginL28"></span>验证码<span class="star">*</span><input class="txtbox chkBox" name="email" type="text" /><img src="http://my.b2b.hc360.com/my/ValidImage.jsp?Seed=0.16553570900864034" /> <a class="chgCC" href="#">看不清，换一张</a></li>
                    <li><span class="marginL28"></span><span class="marginL42"></span><span class="star"></span><input type="checkbox" id="cb1" checked /><label for="cb1">我已看过并同意</label><a class="ServiceTerms" href="#">《点石服务条款》</a></li>
                    <li>
                        <asp:LinkButton ID="LinkButton1" CssClass="subBtn" runat="server"> 
                            <div class="btnl"></div><div class="btnm">立即成为点石会员</div><div class="btnr"></div>
                        </asp:LinkButton>   
                   </li>
                </ul>
            </div>
            <div class="conRight">
                <ul class="servicePoint">
                    <li class="tagHead bold">为什么要注册点石IT网会员？</li>
                    <li>获得优质货源信息</li>
                    <li>浏览最新市场行情</li>
                    <li>建立个性化企业网站</li>
                    <li>拓展全球商业人脉</li>
                </ul>
            </div>
        </div>
        </form>
        <div class="bottom">
            <ul class="overflowAuto">
                <li>阿里巴巴版权所有 1999-2011
                    <a href="http://info.china.alibaba.com/biznews/pages/alihome/js_zzq.html">
                    著作权与商标声明</a></li>
                <li><a href="http://info.china.alibaba.com/biznews/pages/alihome/js_fl.html">法律声明</a></li>
                <li><a href="http://info.china.alibaba.com/biznews/pages/alihome/js_fw.html">服务条款</a></li>
                <li><a href="http://info.china.alibaba.com/biznews/pages/alihome/js_ys.html">隐私声明</a></li>
                <li><a href="http://page.china.alibaba.com/shtml/about/ali_china8.shtml" 
                        target="_blank">联系我们</a></li>
                <li><a href="http://page.china.alibaba.com/sitemap/sitemap.html">网站地图</a></li>
                <li class="no_border"><a href="http://tiyan.china.alibaba.com/">产品体验中心</a></li>
            </ul>
        </div>
    </div>
</body>
</html>
