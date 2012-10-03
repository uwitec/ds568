<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="DSAdmin_Theme_add" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <Custom:Header runat="server" />
    <link href="../css/common.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .htm-main{width:776px;margin:0 auto;margin-top:10px;}
        .item-main-wrap{line-height:18px;}
        .item-main-wrap .input-bg{width:180px;}
        .itemL{width:120px;text-align:right;float:left;}
        .itemR{float:left;}
        .item-main-wrap li{overflow:auto;margin-bottom:10px;}
        .hmenu li{margin-left:1px;_margin-left:-2pxpx;}
        
        .th-model-wrap{padding-top:10px;}
        .sub-model-menu{height:24px;border-bottom:solid 1px #a1b5b4;margin-top:8px;}
        .sub-model-menu li{cursor:pointer;float:left;display:block;line-height:22px;text-align:center;border:solid 1px #a1b5b4; position:relative;top:1px;padding:0px 8px; background-color:#F3F3F3;}
        .sub-model-menu li.crt{border-bottom-color:White; background-color:White;}
        .fontselbold img{cursor:pointer;}
        
    </style>
    <style type="text/css">
/* 颜色输入框
------------------------------ */
input.html_color{border: medium none;
    cursor: pointer;
    font-size: 0;
    height: 18px;
    line-height: 0;
    padding: 0;
    vertical-align: middle;
    width: 18px;border-radius: 2px 2px 2px 2px}

/* 颜色选择器
------------------------------ */
.html_colorpane{display:none;position:absolute;z-index:999;}
.html_colorpane h5{position:relative;width:220px;padding:0 5px;border:1px solid #000;border-bottom:none;background:#fff;color:#999;font:normal 12px/20px "\5B8B\4F53";}
.html_colorpane h5 span{cursor:pointer;}
.html_colorpane h5 em{position:absolute;top:0;right:5px;font:normal 16px/20px Tahoma;cursor:pointer;}
.html_colorpane table{border-collapse:collapse;table-layout:fixed;empty-cells:show;}
.html_colorpane td{position:static;width:10px;height:10px;padding:0;border:1px solid #000;font-size:0;line-height:0;cursor:pointer;}
</style>
     <script type="text/javascript" src="../js/chili-2.2.js"></script>
     <script type="text/javascript" src="../js/recipes.js"></script>
     <script type="text/javascript" src="../js/colorselect.js"></script>
     <script type="text/javascript" src="/js/ajaxupload.js"></script>
    <script type="text/javascript" src="js/add.js"></script>
</head>
<body>
    <input type="hidden" name="the_id" value="<%=Request["id"] %>" />
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
            <li>
                <div class="mLeft"></div>
                <div class="mMiddle">预览图</div>
                <div class="mRight"></div>
            </li>
        </ul>
        <div class="th-model-wrap">
            <h3>公司招牌设置效果示例：</h3>
            <div><img src="images/hintpic.gif" /></div>
            <ul class="sub-model-menu">
                <li class="crt">设定招牌背景图</li>
                <li>设置公司名称字体</li>
                <li style="float:right;border:none; background-color:White;top:-1px;"><a id="btn-sign-save" class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a></li>
            </ul>
            <ul class="item-main-wrap" style="margin-top:10px;">
                <li>
                    <div class="itemL" style="text-align:left;"><input type="radio" checked class="valign" name="signType" value="0" id="signType1"  /><label for="signType1">背景图</label></div>
                    <div class="itemR"></div>
                </li>
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="signfile" id="signfile" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="招牌背景" id="signimg" src="#" onerror="javascript:this.style.display='none'" style="width:80%;" />
                    </div>
                </li>
                <li>
                    <div class="itemL" style="text-align:left;"><input type="radio" class="valign" name="signType" value="1" id="signType2"  /><label for="signType2">选择背景色</label></div>
                    <div class="itemR"><input id="color_a" type="text" class="html_color" readonly /></div>
                </li>
          </ul>
          <ul class="item-main-wrap" style="display:none;margin-top:10px;" >
            <li>
                <div class="itemL" >显示状态：</div>
                <div class="itemR"><input type="radio" checked class="valign" value="True" name="comns" id="comns1"  /><label for="comns1">显示</label> <input type="radio" checked class="valign" value="False" name="comns" id="comns2"  /><label for="comns2">不显示</label></div>
            </li>
            <li>
                <div class="itemL" >文字样式：</div>
                <div class="itemR">
                    <table cellpadding=0 cellspacing=0>
                        <tr>
                            <td><select  name="comfontName"><option value="宋体">宋体</option><option value="仿宋">仿宋</option><option value="黑体">黑体</option><option value="楷体">楷体</option></select><select  name="comfontSize"><option value="12">12</option><option value="14">14</option><option value="16">16</option><option value="18">18</option><option value="20">20</option><option value="22">22</option><option value="24">24</option><option value="26">26</option><option value="28">28</option><option value="30">30</option></select></td>
                            <td style="padding-left:12px;"><span class="fontselbold"><img   id="fontBold" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"  id="fontItalic"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img id="fontColor" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span></td>
                        </tr>
                    </table>
                </div>
            </li>
            
        </ul>
        </div>
        <div class="th-model-wrap" style="display:none;"></div>
        <div class="th-model-wrap" style="display:none;"></div>
        <div class="th-model-wrap" style="display:none;">
            <ul class="item-main-wrap" style="margin-top:10px;"> 
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="thume" id="thume" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="预览图" id="thumeimg" src="#" onerror="javascript:this.style.display='none'" style="width:80%;" />
                    </div>
                </li>
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <a id="btn-thume-save" class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</body>
</html>
