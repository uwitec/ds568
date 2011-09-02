<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="product_show.aspx.cs" Inherits="Template_tem1_product_product_show"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ContentMiddle
        {
            overflow: hidden;
        }
    </style>

    <script type="text/javascript">
    $(document).ready(function(){
        //切换产品缩略图                 
       var fra=$(".thrumFrame")
       $(".pPicBottom  li").not(".lisplit").mouseover(function(){
          fra.css("left",$(this).offset().left)
          fra.css("top",$(this).offset().top-4)
          fra.css("display","block")
       });
       $(".pPicBottom  li:first").mouseover()
      
       //更改订购产品数量
       $(".up").click(function(){
           $("#txtOrderNum").val(Number($("#txtOrderNum").val())+1)
       });
       $(".down").click(function(){
           if(Number($("#txtOrderNum").val())>1){
             $("#txtOrderNum").val(Number($("#txtOrderNum").val())-1)
           }
       });
      
       //留言框事件
       $("#inpMsg").focus(function(){
           var obj=$(this);
           obj.css("color","black")
           if(obj.val()==obj.attr("defaultValue")){
               obj.val("")
           }
       }).blur(function(){
           var obj=$(this);
           obj.css("color","#bfbfbf")
           if(obj.val()==""){
               obj.val(obj.attr("defaultValue"))
           }
       });
      
       //产品详细卡切换
       $(".dLeft a").click(function(){
           $(".divProDetail ul li div").removeClass("dLeftChk").removeClass("dRightChk")
           $(this).parent().addClass("dLeftChk").next().addClass("dRightChk")
           $(this).blur();
           $(".pContent1,.pContent2,.pContent3,.pContent4").hide();
           $(".pContent"+($(".divProDetail ul li").index($(this).parent().parent())+1)).show();
          
       });
      
       //产品描术图片自缩放
       $(".description-detail img").each(function(){
           changeImg(this,742,742)
       });
       
       //计算更多商家产品信息列表的长度，因为要滚动
       var divlen=$(".suggestContainer div").length;
       var lin=0
       if(divlen%5>0)
          lin =5-divlen%5;//必须够5的整数，不够则增加
       $(".suggestContainer").css("width",$(".suggestContainer div").length*140+lin*140);
       for(var i=0;i<lin;i++){
           $(".suggestContainer").append("<div></div>");
       }
       
       //上一组，下一组事件
       $("#J_sugNext span").click(function(){
           if($(this).hasClass("active")){
               var sl=$(".suggest").scrollLeft();
               $(".suggest").animate({scrollLeft:sl+5*140},600,function(){
                   if($(".suggest").scrollLeft()==$(".suggestContainer").width()-700){
                       $("#J_sugNext span").removeClass("active")
                       $("#J_sugNext span").addClass("disabled")
                   }else{
                       $("#J_sugPre span").removeClass("disabled")
                       $("#J_sugPre span").addClass("active")
                   }
               });
           }
           $(this).parent().blur(); 
       });
        $("#J_sugPre span").click(function(){
           if($(this).hasClass("active")){
                var sl=$(".suggest").scrollLeft();
                $(".suggest").animate({scrollLeft:sl-5*140},600,function(){
                   if($(".suggest").scrollLeft()==0){
                       $("#J_sugPre span").removeClass("active")
                       $("#J_sugPre span").addClass("disabled")
                   }else{
                       $("#J_sugNext span").removeClass("disabled")
                       $("#J_sugNext span").addClass("active")
                   }
                }); 
           }
           $(this).parent().blur(); 
       });
        $("#J_sugPre").click(function(){
          $(this).blur()
       });
       $("#J_sugNext").click(function(){
          $(this).blur()
       });
       
       
    });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="MiddleRight">
        <!--========产品内容开始=============-->
        <div class="pTitle">
            原装正品音乐天使 JH-MA UK2 插卡音箱 TF/U盘迷你小音箱
        </div>
        <div class="Split12px">
        </div>
        <div class="divProHead">
            <div class="pPic">
                <table class="pPicTop" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="center">
                            <div>
                                <img src="http://a2.att.hudong.com/08/44/01300000369368127558441488234.jpg" />
                            </div>
                        </td>
                    </tr>
                </table>
                <ul class="pPicBottom">
                    <li>
                        <div>
                            <img src="http://i04.c.aliimg.com/img/ibank/2010/585/731/199137585_1508253996.summ.jpg" />
                        </div>
                    </li>
                    <li class="lisplit"></li>
                    <li>
                        <div>
                            <img src="http://i02.c.aliimg.com/img/ibank/2010/486/731/199137684_1508253996.summ.jpg" />
                        </div>
                    </li>
                    <li class="lisplit"></li>
                    <li>
                        <div>
                            <img src="http://i00.c.aliimg.com/img/ibank/2010/228/921/186129822_1508253996.summ.jpg" />
                        </div>
                    </li>
                </ul>
            </div>
            <div class="pInfo">
                <ul class="ul004">
                    <li class="pInfoH">数量(个)</li><li class="pInfoH">单价(元/个)</li>
                    <li class="pInfoL">5-29</li><li class="pInfoL"><span class="Amount fontSize14 bold">
                        57.00</span> 元/个</li>
                    <li class="pInfoL">≥30</li><li class="pInfoL"><span class="Amount fontSize14 bold">57.00</span>
                        元/个</li>
                    <li class="pInfoL">≥30</li><li class="pInfoL"><span class="Amount fontSize14 bold">57.00</span>
                        元/个</li>
                </ul>
                <div class="Split12px">
                    &nbsp;</div>
                <div class="divOrder">
                    <ul class="ul005">
                        <li class="odli1">我要订购：
                            <input id="txtOrderNum" class="txtBox orderNum" value="1" type="text" /><div class="updownContainer">
                                <a href="javascript:void(0)" class="up"></a><a href="javascript:void(0)" class="down">
                                </a>
                            </div>
                        </li>
                        <li class="odli1">
                            <dl>
                                <dd class="dd001">
                                    &nbsp;</dd>
                                <dd class="d-btn-buy">
                                    <a title="点击此按钮，到下一步确认购买信息。" target="_self" href="#" id="J_LinkOrder" class="dmtrack"
                                        dmt="addtoorder1">立即购买</a>
                                </dd>
                                <dd class="d-btn-add">
                                    <a title="加入进货单" target="_self" href="#" id="J_LinkPurchase" class="dmtrack" dmt="addtocart1">
                                        加入进货单</a>
                                </dd>
                                <dd class="d-tip-add">
                                    <a target="_blank" href="http://service.china.alibaba.com/kf/detail/2410329.html"
                                        class="dmtrack" dmt="carthelp">什么是进货单?</a>
                                </dd>
                            </dl>
                            <div class="divLine1">
                            </div>
                        </li>
                        <li class="msgTitle">供应商目前不在线，请在下面留言:</li>
                        <li>
                            <input id="inpMsg" name="inpMsg" value="请输入关于您产品的问题（70字以内）" type="text" /><input
                                id="btnSend" type="button" value="发送" />
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!--========产品内容结束=============-->
        <!--========产品详细开始=============-->
        <div class="divProDetail">
            <ul class="ulProDetailTitle">
                <li>
                    <div class="dLeft dLeftChk">
                        <span></span><a href="javascript:;">详细信息</a></div>
                    <div class="dRight dRightChk">
                    </div>
                </li>
                <li>
                    <div class="dLeft">
                        <span></span><a href="javascript:;">批发说明</a></div>
                    <div class="dRight">
                    </div>
                </li>
                <li>
                    <div class="dLeft">
                        <span></span><a href="javascript:;">运费说明</a></div>
                    <div class="dRight">
                    </div>
                </li>
                <li>
                    <div class="dLeft">
                        <span></span><a href="javascript:;">联系方式</a></div>
                    <div class="dRight">
                    </div>
                </li>
            </ul>
            <div class="proProperty">
                <div class="pContent1">
                    <table>
                        <tbody>
                            <tr>
                                <td class="fieldHead">
                                    箱体材料
                                </td>
                                <td>
                                    金属
                                </td>
                                <td class="fieldHead">
                                    声道
                                </td>
                                <td>
                                    双声道
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    调节形式
                                </td>
                                <td>
                                    按键
                                </td>
                                <td class="fieldHead">
                                    信噪比
                                </td>
                                <td>
                                    &ge;80db
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    造型
                                </td>
                                <td>
                                    长方体
                                </td>
                                <td class="fieldHead">
                                    颜色
                                </td>
                                <td>
                                    黑,红,银,蓝,绿
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    品牌
                                </td>
                                <td>
                                    音乐天使
                                </td>
                                <td class="fieldHead">
                                    包装
                                </td>
                                <td>
                                    纸盒
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    型号
                                </td>
                                <td>
                                    UK
                                </td>
                                <td class="fieldHead">
                                    功率
                                </td>
                                <td>
                                    3W*2
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    规格
                                </td>
                                <td>
                                    60/件
                                </td>
                                <td class="fieldHead">
                                    新奇特
                                </td>
                                <td>
                                    充电音响
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    使用场合
                                </td>
                                <td>
                                    广告促销、会议庆典、办公福利、商务公关、答谢客户、开业典礼、节日庆祝、婚庆、生日、乔迁、毕业升学、外事、其他
                                </td>
                                <td class="fieldHead">
                                    送礼对象
                                </td>
                                <td>
                                    送父母/长辈、送孩子/宝宝、送女友/老婆、送男友/老公、送朋友、送同事、送客户、送领导、送同学、送恩师、送老外、送哥哥/弟弟、送姐姐/妹妹、其他
                                </td>
                            </tr>
                            <tr>
                                <td class="fieldHead">
                                    是否提供加工定制
                                </td>
                                <td>
                                    否
                                </td>
                                <td class="fieldHead">
                                </td>
                                <td>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <div class="description-detail">
                        <img alt="" src="http://i00.c.aliimg.com/img/ibank/2010/930/840/199048039_1508253996.jpg" />
                        <img alt="" src="http://i02.c.aliimg.com/img/ibank/2010/017/740/199047710_1508253996.jpg" />
                    </div>
                </div>
                <div class="pContent2 oflAuto">
                    <div class="pInfoH propertyPf">
                        批发说明</div>
                    <div class="de-blockbd">
                        <div class="de-leftcon float-l">
                            <div class="de-top oflAuto">
                                <p class="de-hunpi float-l marginTop8">
                                    混批</p>
                                <div class="float-l">
                                </div>
                                <em class="float-l">支持混批，[5000]元以上起批 或者 [100]个以上起批 </em>
                            </div>
                            <div class="de-info">
                                <p>
                                    量大有优惠</p>
                            </div>
                        </div>
                        <div class="de-rightcon">
                            <div class="de-top oflAuto">
                                <em class="float-l">什么是混批？</em>
                            </div>
                            <div class="de-info justify">
                                <p>
                                    混批是指不限产品的种类和样式，买家只要采购总价（或总量）达到或高于设置金额（或数量）即可享受批发价格。</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="pContent3">
                    <div class="pInfoH propertyPf">
                        运费说明</div>
                    <div class="proContent">
                        供应商尚未提供运费说明详情，请联系供应商以获取相关信息
                    </div>
                </div>
                <div class="pContent4">
                    <div class="pInfoH propertyPf">
                        联系方式</div>
                          <div class="proContent">
                        供应商尚未提供联系方式详情，请联系供应商以获取相关信息
                    </div>
                </div>
                <div class="moreHead">
                    <div class="pInfoH propertyPf">
                        <div class="moreTitle">
                            供应商的其他相关信息</div>
                        <div class="moreProduct">
                            <a href="#">查看该供应商更多供应产品</a></div>
                    </div>
                    <div class="moreContent">
                        <a id="J_sugPre" href="javascript:;"><span class="disabled">上一组</span></a>
                        <div class="suggest" >
                            <div class="suggestContainer">
                                <div>
                                     <ul>
                                      <li>
                                        <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                        <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                            src="http://img.china.alibaba.com/img/ibank/2011/201/867/246768102_1508253996.summ.jpg" /></a>
                                         <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                          <p class="fontSize14">¥ <em class="Amount  bold">60.00</em><br /></p>
                                    </li>
                                    </ul>
                                </div>
                                <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2011/473/867/246768374_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >最新铝合金插卡音箱 便携音箱 TT6 音箱 最小巧音箱（显示歌词）</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">70.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                       <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/017/740/199047710_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >原装正品音乐天使，3UK，插卡音箱，铝合金音响 便携音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">69.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                   <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/584/514/185415485_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >铝合金插卡音箱 TT2 铝合金音响 插卡迷你音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">29.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2011/201/867/246768102_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/845/740/199047548_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                  <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/804/341/199143408_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                   <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2011/792/767/246767297_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                  <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/684/740/199047486_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                  <div>
                                     <ul>
                                      <li>
                                        <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                        <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                            src="http://img.china.alibaba.com/img/ibank/2011/201/867/246768102_1508253996.summ.jpg" /></a>
                                         <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                          <p class="fontSize14">¥ <em class="Amount  bold">60.00</em><br /></p>
                                    </li>
                                    </ul>
                                </div>
                                <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2011/473/867/246768374_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >最新铝合金插卡音箱 便携音箱 TT6 音箱 最小巧音箱（显示歌词）</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">70.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                       <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/017/740/199047710_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >原装正品音乐天使，3UK，插卡音箱，铝合金音响 便携音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">69.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                   <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/584/514/185415485_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >铝合金插卡音箱 TT2 铝合金音响 插卡迷你音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">29.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2011/201/867/246768102_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                 <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/845/740/199047548_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                  <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/804/341/199143408_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                   <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2011/792/767/246767297_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                                  <div>
                                     <ul>
                                      <li>
                                    <a class="linkImg" href="http://detail.china.alibaba.com/buyer/offerdetail/898157321.html" >
                                    <img onerror="javascript:this.src='http://img.china.alibaba.com/news/upload/5002027/48x48_1276134613200.gif'"
                                        src="http://img.china.alibaba.com/img/ibank/2010/684/740/199047486_1508253996.summ.jpg" /></a>
                                     <h4><a href="#" title="UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱" >UK2升级版UK2B 音乐天使最新产品 外置电池 礼品音箱</a></h4>
                                      <p class="fontSize14">¥ <em class="Amount  bold">55.00</em><br /></p>
                                </li>
                                    </ul>
                                </div>
                            </div>
                    
                        </div>
                        <a id="J_sugNext" href="javascript:;"><span class="active">下一组</span></a>
                    </div>
                </div>
                <div class="moreCategory">
                    <div class="propertyPf">您可以通过以下类目找到类似信息</div>
                    <div class="categoryLink" ><a href="#">家用电器</a> &gt; <a href="#">音响产品</a> &gt; <a href="#">音箱</a></div>
                </div>
               
            </div>
        </div>
        <!--========产品详细结束=============-->
    </div>
    <div class="thrumFrame">
    </div>
</asp:Content>
