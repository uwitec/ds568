<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Member_Login_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户登录</title>
    <link href="Css/login.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/jquery142min.js"></script>
</head>
<body>
    <div class="main">
        <div class="overflowAuto">
            <div class="logo floatL bold"><img src="http://i01.c.aliimg.com/images/cn/home/070827/logo2.gif" />登录</div>
            <div class="contact floatR gray">
                <a href="#">返回首页</a> | <a href="#">帮助中心</a>
                <div class="help overflowAuto">
                    <div class="floatR">&nbsp;或拔打<span class="kfphone bold">0755-43456567</span></div>
                    <a class="qqonline floatR gray" href="http://wpa.qq.com/msgrd?v=3&uin=416351551&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:416351551:4" alt="给我留言" />在线客服</a>
                    <div class="floatR">如需帮助，请咨询&nbsp;</div>
                </div>
            </div>
        </div>
        <div class="midcon overflowAuto">
            <div class="floatL"><img width="500" src="https://loginchina.alibaba.com/img/25489_719516335.jpg" /></div>
            <div class="lgf floatR">
                <div class="lghead"></div>
                <div class="lgmiddle">
                    <div class="lgtitle"><span class="floatL">会员登录</span><a class="floatR" href="#">帮助</a></div>
                    <ul class="lgcon">
                        <li class="uid">会员登录名：<input type="text" name="uid" class="txtbox" /> <a href="#">找回登录名</a></li>
                        <li class="pwd">密码：<input type="text" name="pwd" class="txtbox" /> <a href="#">找回密码</a></li>
                        <li class="slg"><input type="checkbox" name="slg" />保存密码，一周内免登录</li>
                        <li class="lgbtn overflowAuto">
                            <a href="javascript:;" class="subBtn floatL"><div class="btnl"></div><div class="btnm">登录</div><div class="btnr"></div></a>
                            <a href="#" class="reg floatL">免费注册</a>
                        </li>
                    </ul>
                    <div class="spline"></div>
                    <ul class="lgremark">
                        <li class="rmkt">登录后您可以：</li>
                        <li>发布供应信息，让买家主动找上您！</li>
                        <li>发布求购信息，帮您寻找优质卖家！</li>
                        <li>查看最新求购，立即网上接单！</li>
                        <li>展示企业的服务能力，让千万买家主动联系您！</li>
                        <li>展示企业实力，吸引优秀人才加盟！</li>
                       
                    </ul>
                </div>
                <div class="lgbottom"></div>
            </div>
        </div>
        
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
