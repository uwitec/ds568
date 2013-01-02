<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="DSAdmin_Theme_add" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <Custom:Header runat="server" />
    <link href="../css/common.css" rel="stylesheet" type="text/css" />
    <link href="css/add.css" rel="stylesheet" type="text/css" />
 
     <script type="text/javascript" src="../js/chili-2.2.js"></script>
     <script type="text/javascript" src="../js/recipes.js"></script>
     <script type="text/javascript" src="../js/colorselect.js"></script>
     <script type="text/javascript" src="/js/ajaxupload.js"></script>
    <script type="text/javascript" src="js/add.js"></script>
    <style type="text/css">
        .posi-wrap,.chanle-margin{margin-top:10px;}
        .posi-wrap input{padding:0;margin:0;line-height:14px;height:auto;}
        .posi-wrap label{margin-right:10px;}
    </style>
</head>
<body>
    <input type="hidden" name="the_id" value="<%=Request["id"] %>" />
    <div class="htm-main">
        <div class="hd-bar">主题管理 》添加主题<a href="list.aspx">&lt;&lt;返回列表&nbsp;</a></div>
        <ul class="item-main-wrap">
            <li>
                <div class="itemL">主题名称：</div>
                <div class="itemR"><input class="input-bg" name="themeName" /><input type="button" class="btnsavethename" value="保存" /></div>
            </li>
        </ul>

        <!----------菜单START-------------->
        <ul class="hmenu">
            <li class="mn-wrap-crt">
                <div class="mLeft"></div>
                <div class="mMiddle">招牌</div>
                <div class="mRight"></div>
            </li>
            <li>
                <div class="mLeft"></div>
                <div class="mMiddle">导航</div>
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
        <!----------菜单END-------------->

        <!----------招牌START-------------->
        <div class="th-model-wrap">
            <h3>公司招牌设置效果示例：</h3>
            <div><img src="images/hintpic.gif" /></div>
            <ul id="smm-1" class="sub-model-menu">
                <li class="crt">设定招牌背景图</li>
                <li>设置公司名称字体</li>
                <li style="float:right;border:none; background-color:White;top:-1px;" class="licommon"><a id="btn-sign-save" class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a></li>
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
                    <div class="itemR"><input id="color_a" type="text" class="html_color fc" readonly /></div>
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
                            <td style="padding-left:12px;"><span class="fontselbold"><img   id="fontBold" class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal" class="ft" id="fontItalic"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img id="fontColor" class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span></td>
                        </tr>
                    </table>
                </div>
            </li>
          </ul>
        </div>
        <!----------招牌END-------------->

        <!----------导航start-------------->
        <div class="th-model-wrap" style="display:none;">
            <h3>航设置效果示例：</h3><br />
            <div><img src="images/nav.gif" /></div>
            <div class="posi-wrap"><b>导航显示方式：</b><input type="radio" id="posi1"  name="posi" /><label for="posi1">整体居左</label><input type="radio" id="posi2" name="posi" /><label for="posi2">整体居中</label><input type="radio" id="posi3" name="posi" /><label for="posi3">整体居右</label></div>
            <div class="chanle-margin"><b>菜单之间的距离：</b>
                    <select name="chanle-margin">
                        <option value="">默认</option>
                        <option value="1">紧凑</option>
                        <option value="2">较紧凑</option>
                        <option value="3">普通</option>
                        <option value="4">较分散</option>
                        <option value="5">分散</option>
                    </select>
            </div>
            <ul  class="sub-model-menu">
                <li class="crt">选中状态的导航</li>
                <li>未选中状态的导航</li>
                <li>导航背景</li>
            </ul>
            <ul class="item-main-wrap" style="margin-top:10px;">
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="NavBgSelFile" id="NavBgSelFile" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="菜单选中状态背景" id="NavBgSelImg"  src="#" onerror="javascript:this.style.display='none'"  />
                    </div>
                </li>
              
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <a  class="commBtn navSave" navtype="NavBgSel" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                    </div>
                </li>
          </ul>
          <ul class="item-main-wrap" style="display:none;margin-top:10px;" >
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="NavBgNormalFile" id="NavBgNormalFile" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="菜单未选中状态背景" id="NavBgNormalImg"  src="#" onerror="javascript:this.style.display='none'"  />
                    </div>
                </li>
              
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <a  class="commBtn navSave" navtype="NavBgNormal" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                    </div>
                </li>
          </ul>
          <ul class="item-main-wrap" style="display:none;margin-top:10px;" >
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="NavBgFile" id="NavBgFile" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="菜单未选中状态背景" id="NavBgImg"  src="#" onerror="javascript:this.style.display='none'"  />
                    </div>
                </li>
              
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <a  class="commBtn navSave" navtype="NavBg" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                    </div>
                </li>
          </ul>
        </div>
        <!----------导航end-------------->

        <!----------广告START-------------->
        <div class="th-model-wrap" style="display:none;">
            <ul id="smm-2" class="sub-model-menu" style="position:relative;left:-10px;width:772px;">
                <li class="crt" style="margin-left:10px;">单图广告</li>
                <li>多图广告</li>
            </ul>
            
            <!----单图广告--->
            <div class="sub-item-wrap">
                <ul class="item-main-wrap" style="margin-top:10px;">
                    <li>
                        <div class="itemL" >显示图片：</div>
                        <div class="itemR">
                            <input type="file"   name="adfile1" id="adfile1" />
                        </div>
                    </li>
                    <li>
                        <div class="itemL" >&nbsp;</div>
                        <div class="itemR">
                            <img  id="adsigleimg" src="#" onerror="javascript:this.style.display='none'" onload="changeImg(this,500,200)" />
                        </div>
                    </li>
                    <li>
                        <div class="itemL">显示文字：</div>
                        <div class="itemR adsigle" style="padding-left:12px;">
                            <table cellpadding=0 cellspacing=0 >
                                <tr>
                                    <td>第一行文字显示：<input class="input-bg adsigletxt" name="adsigletxt1"  /></td>
                                    <td style="padding-left:12px;"><span class="fontselbold"><img   id="img-fb1" class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"  id="img-ft1" class="ft"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img id="img-fc1" class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span>
                                        <input type="hidden" name="fb1" /><input type="hidden" name="ft1" /><input type="hidden" name="fc1" />
                                    </td>
                                </tr>
                            </table>
                           <table cellpadding=0 cellspacing=0>
                                <tr>
                                    <td>第二行文字显示：<input class="input-bg adsigletxt" name="adsigletxt2"  /></td>
                                    <td style="padding-left:12px;"><span class="fontselbold"><img   id="img-fb2" class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"  id="img-ft2" class="ft"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img id="img-fc2" class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span>
                                        <input type="hidden" name="fb2" /><input type="hidden" name="ft2" /><input type="hidden" name="fc2" />
                                    </td>
                                </tr>
                            </table>
                            <table cellpadding=0 cellspacing=0>
                                <tr>
                                    <td>第三行文字显示：<input class="input-bg adsigletxt" name="adsigletxt3" /></td>
                                    <td style="padding-left:12px;"><span class="fontselbold"><img   id="img-fb3" class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"  id="img-ft3" class="ft"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img id="img-fc3" class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span>
                                        <input type="hidden" name="fb3" /><input type="hidden" name="ft3" /><input type="hidden" name="fc3" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </li>
                    <li>
                        <div class="itemL" style="width:20px;">&nbsp;</div>
                        <div class="itemR">
                            <a id="ad-sigle-save" class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                        </div>
                    </li>
                </ul>
            </div>
            
            <!----多图广告--->
            <div class="sub-item-wrap ad-muti-wrap" style="display:none;">
                <ul id="smm-3" class="sub-model-menu" >
                    <li class="crt" >场景一</li>
                    <li>场景二</li>
                    <li>场景三</li>
                    <li>场景四</li>
                </ul>
                <ul class="item-main-wrap ad-muti-list" style="margin-top:10px;">
                    <li>
                        <div class="itemL" >显示图片：</div>
                        <div class="itemR">
                            <input type="file"  />
                        </div>
                    </li>
                    <li>
                        <div class="itemL" >&nbsp;</div>
                        <div class="itemR">
                           <img src="#" class="thumeimg" onerror="javascript:this.style.display='none'" onload="changeImg(this,500,200)"  />
                        </div>
                    </li>
                    <li>
                        <div class="itemL">显示文字：</div>
                        <div class="itemR" style="padding-left:12px;">
                            <table cellpadding=0 cellspacing=0>
                                <tr>
                                    <td>第一行文字显示：<input class="input-bg" name="admutitext1"  /></td>
                                    <td style="padding-left:12px;"><span class="fontselbold"><img   class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"   class="ft"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img  class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span>
                                        <input type="hidden" name="admtfb1" /><input type="hidden" name="admtft1" /><input type="hidden" name="admtfc1" />
                                    </td>
                                </tr>
                            </table>
                            <table cellpadding=0 cellspacing=0>
                                <tr>
                                    <td>第二行文字显示：<input class="input-bg" name="admutitext2"  /></td>
                                    <td style="padding-left:12px;"><span class="fontselbold"><img   class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"   class="ft"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img  class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span>
                                        <input type="hidden" name="admtfb2" /><input type="hidden" name="admtft2" /><input type="hidden" name="admtfc2" />
                                    </td>
                                </tr>
                            </table>
                            <table cellpadding=0 cellspacing=0>
                                <tr>
                                    <td>第三行文字显示：<input class="input-bg" name="admutitext3"  /></td>
                                    <td style="padding-left:12px;"><span class="fontselbold"><img  class="fb" val="normal" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif"><img val="normal"  class="ft"  src="http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif"><img  class="fc" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/font_1.gif"></span>
                                    <input type="hidden" name="admtfb3" /><input type="hidden" name="admtft3" /><input type="hidden" name="admtfc3" />
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </li>
                    <li>
                        <div class="itemL" style="width:20px;">&nbsp;</div>
                        <div class="itemR">
                            <input type="hidden" name="admutiind" value="0" />
                            <a   class="commBtn btn-muti-save" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                        </div>
                    </li>
                </ul>
            </div>
            <!----多图广告--->

            <!----不显示--->
            <%--<div class="sub-item-wrap" style="display:none;">
                <div class="adshow-wrap">
                   
                </div>
                <div style="overflow:auto;padding-left:120px;">
                    <a  class="commBtn btn-adshow" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a>
                </div>
            </div>--%>
        </div>
        <!----------广告END-------------->

        <!----------背景-------------->
        <div class="th-model-wrap model-bg" style="display:none;">
            <h3>旺铺背景设置效果示例：</h3>
            <div><img src="images/BackgPic.gif" /></div>
            <ul id="smm-bg" class="sub-model-menu">
                <li class="crt">设定内背景图</li>
                <li>设定外背景图</li>
                <li style="float:right;border:none; background-color:White;top:-1px;" class="licommon"><a id="btnbgsave" class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a></li>
            </ul>
            <ul class="item-main-wrap" style="margin-top:10px;">
              
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="InnerBg" id="InnerBg" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="内背景" class="imginner" src="#" onerror="javascript:this.style.display='none'" onload="changeImg(this,300,300)" />
                    </div>
                </li>
               
          </ul>
          <ul class="item-main-wrap" style="margin-top:10px;display:none;">
                
                <li>
                    <div class="itemL" style="width:20px;">&nbsp;</div>
                    <div class="itemR">
                        <input type="file"   name="OuterBg" id="OuterBg" />
                    </div>
                </li>
                <li>
                    <div class="itemL" >&nbsp;</div>
                    <div class="itemR">
                        <img alt="外背景" class="imgouter" src="#" onerror="javascript:this.style.display='none'" onload="changeImg(this,300,300)" />
                    </div>
                </li>
          </ul>
        </div>
        <!----------背景END-------------->

        <!----------预览图start-------------->
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
        <!----------预览图end-------------->

    </div>
</body>
</html>
