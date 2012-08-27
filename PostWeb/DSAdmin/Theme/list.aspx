<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="DSAdmin_Area_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <Custom:Header runat="server" ID="Header1" />
    <style type="text/css">
        .htm-main{width:776px;margin:0 auto;}
        .list-wrap ul{overflow:auto;}
        .list-wrap ul li{float:left;}
    </style>
</head>
<body>
    <div class="htm-main"></div>
    <div><input type="button" value="添加主题" /></div>
    <div class="list-wrap">
        <ul>
            <li>
                <div><img src="http://admin.baotel.cn/album/UploadImg/C0001/B00001/n95.jpg" onload="changeImg(this,120,120)" /></div>
                <div>套装1</div>
            </li>
            <li>
                <div><img src="http://admin.baotel.cn/album/UploadImg/C0001/B00025/iphone4.jpg" onload="changeImg(this,120,120)" /></div>
                <div>套装2</div>
            </li>
            <li>
                <div><img src="http://admin.baotel.cn/album/UploadImg/C0001/B00002/a510e.jpg" onload="changeImg(this,120,120)" /></div>
                <div>套装3</div>
            </li>
        </ul>
    </div>
    <div class="page-wrap"></div>
</body>
</html>















 