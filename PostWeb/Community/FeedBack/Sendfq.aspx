<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sendfq.aspx.cs" Inherits="Community_FeedBack_Sendfq" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线留言</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../../../js/jquery142min.js"></script>
      <style type="text/css">
        .main{ background-image:none;}
    </style>
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
        <div class="SysInfo">
            <table>
                <tr>
                    <td rowspan=2 class="rightBg">
                    
                    </td>
                    <td class="msg">恭喜，留言发送成功</td>
                </tr>
                <tr><td class="msgTips">请您及时关注邮箱，查看留言回复！</td></tr>
            </table>
        </div>
         <div class="SearchDiv">
            <div class="spaceHoder"></div>
             <ul>
                <li class="searchTitle">继续查看其他信息：</li>
                <li><input id="keyWord" class="keyWord" name="keyWord" type="text" /></li>
                <li><input id="Submit1" class="searchSubmit" type="submit" value="" /></li>
             </ul>
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
