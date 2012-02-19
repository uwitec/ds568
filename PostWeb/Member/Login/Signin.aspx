<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signin.aspx.cs" Inherits="Member_Login_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户登录</title>
    <Custom:Header runat="server" ID="Header1" />
    <script type="text/javascript" src="/Js/jquery.cookie.js"></script>
    <script type="text/javascript" src="Js/Login.js"></script>
    <link href="Css/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="main">
        <div class="overflowAuto">
            <div class="logo floatL bold"><img src="http://i01.c.aliimg.com/images/cn/home/070827/logo2.gif" />登录</div>
            <div class="contact floatR gray">
                <a href="/home/index.aspx">返回首页</a> | <a href="#">帮助中心</a>
                <div class="help overflowAuto">
                    <div class="floatR">&nbsp;或拔打<span class="kfphone bold">15118829914</span></div>
                    <a class="qqonline floatR gray" href="http://wpa.qq.com/msgrd?v=3&uin=416351551&site=qq&menu=yes"><img src="http://wpa.qq.com/pa?p=2:416351551:4" alt="给我留言" />在线客服</a>
                    <div class="floatR">如需帮助，请咨询&nbsp;</div>
                </div>
            </div>
        </div>
        <div class="midcon overflowAuto">
            <div class="floatL"><img width="500" src="https://loginchina.alibaba.com/img/springfestival.jpg" /></div>
            <div class="lgf floatR">
                <div class="lghead"></div>
                <div class="lgmiddle">
                    <div class="lgtitle"><span class="floatL">会员登录</span><a class="floatR" href="#">帮助</a></div>
                    <form runat="server" id="form1" defaultbutton="LinkButton1">
                    <ul class="lgcon">
                        <li class="uid">会员登录名：<input type="text" tabindex="0" name="uid" id="uid" class="txtbox" /> <a  href="#">找回登录名</a></li>
                        <li class="pwd">密码：<input type="password"   name="pwd" id="pwd" class="txtbox" /> <a  href="#">找回密码</a></li>
                        <li class="slg"><input type="checkbox"  name="slg" id="slg" /><label for="slg">保存密码一周，(公共场所慎用)</label></li>
                        <li class="lgbtn overflowAuto">
                            <asp:LinkButton ID="LinkButton1"  CssClass="subBtn floatL" runat="server">
                                <div class="btnl"></div><div class="btnm">登录</div><div class="btnr"></div>
                            </asp:LinkButton>
                            <a href="/Member/Join/reg.aspx"  class="reg floatL">免费注册</a>
                        </li>
                    </ul>
                    </form>
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
