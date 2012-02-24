<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sendfq.aspx.cs" Inherits="Community_FeedBack_Sendfq" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线留言</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/lib.js"></script>
      <style type="text/css">
        .main{ background-image:none;}
    </style>
</head>
<body>
   
    <div class="main overflowAuto">
        <div class="head01">
            <div class="head01Left"><img src="http://i01.c.aliimg.com/images/cn/home/070827/logo2.gif" /></div>
            <div class="head01Right"><a href="/member/login/signin.aspx">登录</a> | <a href="javascript:;alert('帮助中心完善中，请稍后访问。')">帮肋中心</a></div>
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
        <li>点石网版权所有 2011-2012
            <a href="#">
            著作权与商标声明</a></li>
        <li><a href="#">法律声明</a></li>
        <li><a href="#">服务条款</a></li>
        <li><a href="#">隐私声明</a></li>
        <li><a href="#" 
                target="_blank">联系我们</a></li>
        <li><a href="#">网站地图</a></li>
    </ul>
        </div>
</body>
</html>
