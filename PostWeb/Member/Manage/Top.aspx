<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Top.aspx.cs" Inherits="Member_Manage_Top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/lib.js"></script>
    <script type="text/javascript" src="js/Top.js"></script>
</head>
<body>
    <div class="head">
        <div class="overflowAuto">
            <div class="logo floatL bold"><img style="display:none" src="http://i01.c.aliimg.com/images/cn/home/070827/logo2.gif" />商务中心</div>
            <div class="contact floatR gray">
                您好：<%=(Session["UserData"] as UserData).Member.UserID %> <a href="?action=out">【退出】</a> <a href="#">返回首页</a> | <a href="#">帮助中心</a>
            </div>
        </div>
    </div>
    <div class="holdspace"></div>
    <div class="toolbar">
        <div class="tbpd"></div>
        <ul class="tbcon">  
            <li>
                <a href="Offer/Post.aspx" target="conFrame">
                    <div class="icon-suply"></div>
                    <div class="wname">供应管理</div>
                </a>
            </li>
            <li>
                <a href="#" target="conFrame">
                    <div class="icon-purchasemanage"></div>
                    <div class="wname">采购管理</div>
                </a>
            </li>
            <li>
                <a href="#" target="conFrame">
                    <div class="icon-imagemanager"></div>
                    <div class="wname">相册管理</div>
                </a>
            </li>
            <li>
                <a href="#" target="conFrame">
                    <div class="icon-industryInformation"></div>
                    <div class="wname">公司动态</div>
                </a>
            </li>
            <li>
                <a href="ComInfo/BaseInfo.aspx" target="conFrame">
                    <div class="icon-privateseller"></div>
                    <div class="wname">公司资料</div>
                </a>
            </li>
            <li>
                <a href="#" target="conFrame">
                    <div class="icon-salemanagement"></div>
                    <div class="wname">交易管理</div>
                </a>
            </li>
            <li>
                <a href="#" target="conFrame">
                    <div class="icon-winporter"></div>
                    <div class="wname">装修商铺</div>
                </a>
            </li>
            <li>
                <a href="Account/Contact.aspx" target="conFrame">
                    <div class="icon-accountmanagement"></div>
                    <div class="wname">帐号管理</div>
                </a>
            </li>
        </ul>
    </div>
</body>
</html>
