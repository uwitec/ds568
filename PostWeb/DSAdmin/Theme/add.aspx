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
        
    </style>
</head>
<body>
    <div class="htm-main">
        <div class="hd-bar">主题管理 》添加主题</div>
        <ul class="item-main-wrap">
            <li>
                <div class="itemL">主题名称：</div>
                <div class="itemR"><input class="input-bg" name="themeName" /></div>
            </li>
            <li>
                <div class="itemL">招牌图片：</div>
                <div class="itemR"><input class="input-bg" name="themeName" /></div>
            </li>
        </ul>
    </div>
</body>
</html>
