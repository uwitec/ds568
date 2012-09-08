<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="DSAdmin_Theme_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <Custom:Header runat="server" />
    <link href="../css/common.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .htm-main{width:776px;margin:0 auto;margin-top:10px;}
        .item-main-wrap{line-height:18px;}
        .item-main-wrap input{width:180px;}
        .itemL{width:120px;text-align:right;float:left;}
        .itemR{float:left;}
        .item-main-wrap li{overflow:auto;margin-bottom:10px;}
        .hmenu li{margin-left:1px;_margin-left:-2pxpx;}
    </style>
    <script type="text/javascript" src="js/add.js"></script>
</head>
<body>
    <div class="htm-main">
        <div class="hd-bar">主题管理 》添加主题</div>
        <ul class="item-main-wrap">
            <li>
                <div class="itemL">主题名称：</div>
                <div class="itemR"><input class="input-bg" name="themeName" /></div>
            </li>
            
        </ul>
        <ul class="hmenu">
           
            <li class="mn-wrap-crt">
                <div class="mLeft"></div>
                <div class="mMiddle">招牌</div>
                <div class="mRight"></div>
            </li>
            <li>
                <div class="mLeft"></div>
                <div class="mMiddle">广告</div>
                <div class="mRight"></div>
            </li>
            <li>
                <div class="mLeft"></div>
                <div class="mMiddle">背景</div>
                <div class="mRight"></div>
            </li>  
        </ul>
    </div>
</body>
</html>
