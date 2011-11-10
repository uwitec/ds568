<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddImg.aspx.cs" Inherits="Member_Manage_Offer_AddImg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>上传产品图片</title>
    <Custom:Header runat="server" ID="Header1" />
    <link href="<%=Common.Constant.WebConfig("Resource") %>/Css/Pager.css" rel="stylesheet" type="text/css" />
    <link href="Css/AddImg.css" rel="stylesheet" type="text/css" />
     <link rel="Stylesheet" href="/js/uploadify/uploadify.css" />
    <script type="text/javascript" src="/js/uploadify/swfobject.js"></script>

    <script type="text/javascript" src="/js/uploadify/jquery.uploadify.v2.1.4.min.js"></script>
    <script type="text/javascript" src="js/addimg.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <input type="hidden" value="<%=Request.QueryString["ind"] %>" id="hdind" />
  <ul class="headmn"><li class="tag">&nbsp;</li><li class="selmemo">选择您要添加图片的来源</li>
    <li class="split">&nbsp;</li>
    <li class="menu1"><div>图片管家</div></li>
    <li class="split">&nbsp;</li>
    <li class="menu2"><div>我的电脑</div></li>
  </ul>
  <div class="ctn">
        <div class="ctnshow1">
            <div class="selctn gray"><select name="selAlbum"><option>我的相册</option></select> 请从您的图片管家中点击选择图片</div>
            <ul class="imgList">
                <li><img onload="changeImg(this,61,61)" class="wBox_close" src="http://img.china.alibaba.com/img/ibank/2011/951/799/376997159_1213661768.summ.jpg" /></li>
                <li><img onload="changeImg(this,61,61)" class="wBox_close" src="http://img.china.alibaba.com/img/ibank/2011/220/092/447290022_1213661768.summ.jpg" /></li>
                <li><img onload="changeImg(this,61,61)" class="wBox_close" src="http://img.china.alibaba.com/img/ibank/2011/951/799/376997159_1213661768.summ.jpg" /></li>
                <li><img onload="changeImg(this,61,61)" class="wBox_close" src="http://img.china.alibaba.com/img/ibank/2011/951/799/376997159_1213661768.summ.jpg" /></li>
                
            </ul>
            <!--=========分页开始========-->
            <div class="overflowAuto ppctn">
            <webdiyer:AspNetPager CssClass="pages"  AlwaysShowFirstLastPageNumber="true"  ShowDisabledButtons="false"  ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager4" NumericButtonCount="7" runat="server" RecordCount="100"
                FirstPageText="首页" LastPageText="尾页" TextBeforePageIndexBox="共100页 第"  TextAfterPageIndexBox="页 "  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"   PrevPageText="上一页">
            </webdiyer:AspNetPager></div>
        <!--=========分页结束========-->
        </div>
        <div class="ctnshow2">
            <div class="selctn gray">如果您不希望上传的图片在相册中公开展示，建议将图片上传到不公开相册中</div>
            <div class="item">
                <div class="itemL">选择相册：</div><div ><select name="selAlbum2"><option>我的相册</option></select></div> 
            </div>
            <div class="item">
                <div class="itemL">添加图片：</div><div ><input type="file" name="uploadify" id="uploadify" /></div>
            </div>
             <div class="item">
                <div class="itemL">&nbsp;</div><div ><input type="file" name="uploadify" id="uploadify1" /></div>
            </div>
            <div class="item">
                <div class="itemL">&nbsp;</div><div><input type="file" name="uploadify" id="uploadify2" /> </div>
            </div>
            
        </div>
  </div>
    </form>
</body>
</html>
