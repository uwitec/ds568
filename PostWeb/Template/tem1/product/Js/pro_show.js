
    $(document).ready(function(){
        //切换产品缩略图                 
       var fra=$(".thrumFrame")
       $(".pPicBottom  li").not(".lisplit").mouseover(function(){
          fra.css("left",$(this).offset().left)
          fra.css("top",$(this).offset().top-4)
          fra.css("display","block");
          $("#bigimg").attr("src",$(this).find("img").attr("src"));
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
      
       
       
       //计算更多商家产品信息列表的长度，因为要滚动
       var divlen=$(".suggestContainer div").length;
       $(".suggestContainer").css("width",(divlen+(5-(divlen%5>0?divlen%5:5)))*140);//使Container长度恰好为700的倍数
       
       if($(".suggestContainer").width()>700)//如果需要滚动，激活下一组按扭
          $("#J_sugNext span").addClass("active")
          
       //上一组，下一组事件
       $("#J_sugNext span").click(function(){
           if($(this).hasClass("active")){
               var sl=$(".suggest").scrollLeft();
               $(".suggest").animate({scrollLeft:sl+5*140},600,function(){
                   if($(".suggest").scrollLeft()>=$(".suggestContainer").width()-700){
                       $("#J_sugNext span").removeClass("active").addClass("disabled");
                   }
                   $("#J_sugPre span").removeClass("disabled").addClass("active");
               });
           }
           $(this).parent().blur(); 
       });
       $("#J_sugPre span").click(function(){
           if($(this).hasClass("active")){
                var sl=$(".suggest").scrollLeft();
                $(".suggest").animate({scrollLeft:sl-5*140},600,function(){
                   if($(".suggest").scrollLeft()==0){
                       $("#J_sugPre span").removeClass("active").addClass("disabled")
                   }
                   $("#J_sugNext span").removeClass("disabled").addClass("active")
                }); 
           }
           $(this).parent().blur(); 
       });
//       $("#J_sugPre").click(function(){
//          $(this).blur()
//       });
//       $("#J_sugNext").click(function(){
//          $(this).blur()
//       });
       
       //处理显示数据
       var pr=$("#priceRang").val();//价格区间
       if(pr!=""){
           var prs=pr.split('|');
           var pi=$(".pInfoL");
           var ind=0;
           for(var i=0;i<prs.length;i++){
               if(i+1<prs.length){
                   pi.eq(ind).show().text(prs[i].split(',')[0]+"-"+Number(prs[i+1].split(',')[0]-1));
               }else{
                   pi.eq(ind).show().text("≥"+prs[i].split(',')[0]);
               }
               pi.eq(ind+1).show().find("span").text(prs[i].split(',')[1]);
               ind+=2;
           }
           $("#txtOrderNum").val(prs[0].split(',')[0]);//最低起订量
       }
       
       
    });
  