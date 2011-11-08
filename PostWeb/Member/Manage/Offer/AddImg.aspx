<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddImg.aspx.cs" Inherits="Member_Manage_Offer_AddImg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>上传产品图片</title>
    <Custom:Header runat="server" ID="Header1" />
    <link href="Css/AddImg.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/addimg.js"></script>
</head>
<body>
    <form id="form1" runat="server">
  <ul class="headmn"><li class="tag">&nbsp;</li><li class="selmemo">选择您要添加图片的来源</li>
    <li class="menu1"><div>图片管家</div></li>
    <li class="menu2"><div>我的电脑</div></li>
  </ul>
  <div class="ctn">
        <div class="ctnshow1">
            <div class="selctn gray"><select name="selAlbum"><option>我的相册</option></select> 请从您的图片管家中点击选择图片</div>
            <ul class="imgList">
                <li><img onload="changeImg(this,61,61)" src="http://img.china.alibaba.com/img/ibank/2011/951/799/376997159_1213661768.summ.jpg" /></li>
            </ul>
        </div>
        <div class="ctnshow2"></div>
  </div>
    </form>
</body>
</html>
