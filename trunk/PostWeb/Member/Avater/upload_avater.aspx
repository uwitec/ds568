<%@ Page Language="C#" AutoEventWireup="true" CodeFile="upload_avater.aspx.cs" Inherits="Member_Avater_upload_avater" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>上传头像</title>
    <link href="/css/Globle.css" rel="Stylesheet" type="text/css" />
    <link href="css/avatar.css" rel="Stylesheet" type="text/css" />
    <link href="css/ui-lightness/jquery-ui-1.8.21.custom.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="/js/lib.js"></script>
    <script src="js/ui.js" type="text/javascript"></script>
    <script src="js/fileupload.js" type="text/javascript"></script>
    <style type="text/css">
        .main_wrap{height: 554px;  margin:10px auto; width: 800px; background-color:#eef5ff;}
        .head{height:38px;line-height:38px;border:solid 1px #2d70c1; background:url(images/hd_bg.gif) repeat-x;font-family:"微软雅黑";font-size:24px;color:White;text-indent:8px;}
        .up_body{border:solid 4px #c7ddfe;height:510px;overflow:hidden;}
        .bd_left{width:660px;float:left;}
        .bd_right{margin-left:660px;_margin-left:657px;}
        .img_bg{width:606px;height:470px; background:url(images/img_bg.gif);margin:20px auto; position:relative;}
        .upload_img_bg{width:600px;height:464px;margin:3px auto;}
        .btnsel{overflow:hidden;background:url(images/btnsel.gif);margin:0 auto;width:150px;height:41px;display:block;line-height:14px;text-decoration:none; position:absolute; left:225px;top:210px;}
        .view_title{margin-top:50px;}
        .view_wrap{height:100px;width:100px; background-color:White;margin-top:8px;}
        .view_btn_wrap{margin-top:20px;}
        .view_btn{width:108px;height:31px; background:url(images/btnUpload.gif) no-repeat;border:none 0;}
        #avatarFile{filter:alpha(opacity=0);-moz-opacity:.0;opacity:0.0; cursor:pointer;}
        .btnsel2{width:108px;height:31px; background:url(images/btnsel2.gif) no-repeat;border:none 0;display:none;}
        .loading_wrap{height:50px;width:200px; background-color:White;position:absolute; left:212px;top:205px;display:none;border:solid 1px #ccc;}
    </style>
</head>
<body>
    <input type="hidden" id="member_id" value="<%=Request["member_id"] %>" />
    <div class="main_wrap">
        <div class="head">个人头像编辑器</div>
        <div class="up_body">
            <div class="bd_left">
                <div class="img_bg" id="divContenter">
                    <div class="upload_img_bg" id="divBG">
                        <div id="divCuter"></div>
                        
                    </div>
                    <a href="javascript:void(0);" class="btnsel loading"><input style="width:150px;height:40px;font-size:35px;"  type="file" id="avatarFile" name="avatarFile" /></a>
                    <div class="loading_wrap loading3"></div>
                </div>
            </div>
            <div class="bd_right">
                <div class="view_title">图片预览区域</div>
                <div class="view_wrap"><img id="imgAvatarView"style="width:100px;height:100px;" alt="头像" style="display: none;" /></div>
                <div class="view_btn_wrap"><input type="button"  class="view_btn" /></div>
                <div class="view_btn_wrap"><input type="button"  class="btnsel2" /></div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="js/avatar.js"></script>
</body>
</html>
