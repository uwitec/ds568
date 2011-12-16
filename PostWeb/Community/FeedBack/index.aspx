<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Community_FeedBack_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线留言</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/lib.js"></script>
</head>
<body>
   
    <div class="main overflowAuto">
        <div class="head01">
            <div class="head01Left"><img src="http://i01.c.aliimg.com/images/cn/home/070827/logo2.gif" /></div>
            <div class="head01Right"><a href="#">登录</a> | <a href="#">帮肋中心</a></div>
        </div>
        <div class="head02">
            <ul class="overflowAuto" >
                <li class="steptitle">
                    留言步骤
                </li>
                <li class="step1">
                    填写留言单
                </li>
                <li class="stepSplit">&gt;</li>
                <li class="step2">留言成功</li>
            </ul>
        </div>
        
        <div class="contentH">
            接收方
        </div>
        <div class="content01">
            <ul>
                <li>公司名称 <a href="#">广东省深圳市动感者科技有限公司 </a></li>
                <li class="contactMan">联系人 <a href="#">方伟泽 先生</a> <a class="linkQQ" target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=416351551">
                                        <img border="0" src="http://wpa.qq.com/pa?p=1:416351551:4" title="给我发消息" alt="给我发消息"></a></li>
            </ul>
        </div>
        
         <div class="contentH">
            填写内容
        </div>
        <div class="content02">
           <table>
            <tr>
                <td class="filedTitle">标题</td><td>
                    <input id="title" value="我对贵公司很感兴趣" name="title" type="text" /></td>
            </tr>
            <tr>
                <td class="filedTitle" valign="top">内容</td><td>
                    <textarea id="content" class="overflowAuto" name="content" cols="20" rows="2"></textarea>
                    </td>
            </tr>
           </table>
        </div>
        
          <div class="contentH">
            填写我的联系方式
        </div>
        <div class="content03">
           <table>
            <tr>
                <td class="filedTitle">电子邮箱 <span class="star">*</span></td><td>
                    <input id="emailUid" class="input124"  name="emailUid" type="text" /><span class="mouse">@</span><input id="emailCom" class="input97"  name="emailCom" type="text" /></td>
            </tr>
            <tr>
                <td class="filedTitle" >公司名称 <span class="star">*</span></td><td>
                    <input id="companyName" class="input234"  name="companyName" type="text" />
                    </td>
            </tr>
             <tr>
                <td class="filedTitle tips" ></td><td class="tips">
                    <span class="gray">固定电话和手机号码至少填写一项</span>
                    </td>
            </tr>
            <tr>
                <td class="filedTitle" >固定电话 <span class="marL6"></span></td><td><input id="phoneCountry" value="86" class="input32"  name="phoneCountry" type="text" /><span class="marL6"></span><input id="phoneArea" class="input52"  name="phoneArea" type="text" /><span class="marL6"></span><input id="phoneNumber" class="input128"  name="phoneNumber" type="text" />
                    </td>
            </tr>
               <tr>
                <td class="filedTitle">手机号码 <span class="marL6"></span></td><td>
                    <input id="Text2" class="input234"  name="companyName" type="text" />
                    </td>
            </tr>
             <tr>
                <td class="filedTitle">验证码 <span class="star">*</span></td><td>
                    <input id="valcode" class="input124"  name="valcode" type="text" /><span class="marL6"></span><img class="imgCode" src='http://checkcode.china.alibaba.com/service/checkcode?sessionID=RsJsZuSRpHBz8bn6x3vAAfwD3-OirkF0N-LBuI' id="regValImg"></td>
            </tr>
              <tr>
                <td class="filedTitle"></td><td>
                  <a class="Server" href="javascript:;">点击阅读阿里巴巴服务条款</a>
                  </td>
            </tr>
              <tr>
                <td class="filedTitle"></td><td>
                    <ul class="ulBtn overflowAuto">
                        <li class="btnLeft"></li>
                        <li class="btnMiddle"><a class="linkSubmit" href="Sendfq.aspx">同意服务条款并发送留言</a></li>
                        <li class="btnRight"></li>
                    </ul>
                   </td>
            </tr>
           </table>
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
</body>
</html>
