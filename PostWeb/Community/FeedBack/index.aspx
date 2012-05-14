<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Community_FeedBack_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线留言</title>
    <link href="css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/lib.js"></script>
    <link href="/js/Validate/css/validate.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/Validate/jquery.validate.min.js"></script>
    <script type="text/javascript" src="/js/Validate/messages_cn.js"></script>
    <script type="text/javascript" src="js/index.js"></script>
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
         <form id="form1">
         <input type="hidden" name="member_id" value="<%=Request.QueryString["member_id"] %>" />
        <div class="contentH">
            接收方
        </div>
        <div class="content01">
            <ul>
                <li>公司名称 <a href="javascript:;"><%=ViewState["company"]%></a></li>
                <li class="contactMan">联系人 <a href="javascript:;"><%=ViewState["trueName"] %> <%=ViewState["Gender"]%></a> <a class="linkQQ" target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=<%=ViewState["qq"] %>">
                                        <img border="0" src="http://wpa.qq.com/pa?p=1:<%=ViewState["qq"] %>:4" title="给我发消息" alt="给我发消息"></a></li>
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
                    <input id="emailUid" class="input124" value="<%=ViewState["email_1"] %>" name="emailUid" type="text" /><span class="mouse">@</span><input id="emailCom" class="input97" value="<%=ViewState["email_2"] %>"  name="emailCom" type="text" /></td>
            </tr>
            <tr>
                <td class="filedTitle" >公司名称 <span class="star">*</span></td><td>
                    <input id="companyName" class="input234" value="<%=ViewState["mycompany"] %>"  name="companyName" type="text" />
                    </td>
            </tr>
             <tr>
                <td class="filedTitle tips" ></td><td class="tips">
                    <span class="gray">固定电话和手机号码至少填写一项</span>
                    </td>
            </tr>
            <tr>
                <td class="filedTitle" >固定电话 <span class="marL6"></span></td><td><input id="phoneCountry" value="86" class="input32"  name="phoneCountry" type="text" /><span class="marL6"></span><input id="phoneArea" value="<%=ViewState["phone_1"] %>" class="input52"  name="phoneArea" type="text" /><span class="marL6"></span><input id="phoneNumber" class="input128" value="<%=ViewState["phone_2"] %>"  name="phoneNumber" type="text" />
                    </td>
            </tr>
               <tr>
                <td class="filedTitle">手机号码 <span class="marL6"></span></td><td>
                    <input id="mobile" class="input234" value="<%=ViewState["mobile"] %>"  name="mobile" type="text" />
                    </td>
            </tr>
             <tr>
                <td class="filedTitle">验证码 <span class="star">*</span></td><td>
                    <input id="valcode" class="input124"  name="valcode" type="text" /><span class="marL6"></span><img class="imgCode" src="" id="regValImg"> <a id="chgvali" href="javascript:;">看不清，换一个</a></td>
            </tr>
              <tr>
                <td class="filedTitle"></td><td>
                  <a class="Server" href="javascript:;">点击阅读点石网服务条款</a>
                  </td>
            </tr>
              <tr>
                <td class="filedTitle"></td><td>
                    <div class="loading2">数据提交中··</div>
                    <ul class="ulBtn overflowAuto">
                        <li class="btnLeft"></li>
                        <li class="btnMiddle"><a class="linkSubmit" href="javascript:;">同意服务条款并发送留言</a></li>
                        <li class="btnRight"></li>
                    </ul>
                   </td>
            </tr>
           </table>
        </div>
        </form>
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
