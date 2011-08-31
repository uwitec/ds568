$(document).ready(function(){
        //---------------处理类别属性-------------------------
        //处理类别项的底部横线是否显示
        function setCatBottomLine(){
            if($(".liProperty").length>0){
                var l=0;
                $(".liProperty").each(function(){
                    if($(this).is(":visible")){
                        l++;
                    }
                });
                if(l>0)
                    $(".liCat").css("border-bottom","solid 1px #F8BD59");
                else
                    $(".liCat").css("border-bottom","none");
            }
            else
                $(".liCat").css("border-bottom","none");
        }
        
        //设置箭头是否显示
        function setArrowVisble(){
            var l=0;
            $(".liProperty").each(function(){
                if($(this).is(":visible")){
                    l++;
                }
            });
            if(l>0)
                $(".Arrow").show();
            else
                $(".Arrow").hide()
        }
        
      
        //隐藏超出一行的部分li
        $(".itemContent ul li:nth-child(n+6)").css("display","none")
        $(".itemContent ul").each(function(){
            var ch=$(this).find("li")
            //如果li不超过5项，则隐藏更多按扭
            if(ch.length<6){
                $(this).parent().next().hide();
            }
        });
        
        
        //隐藏超出第三项的属性
        $(".liProperty:nth-child(n+4)").css("display","none")
        //如果多于三项，则显示更多属性按扭
        if($(".liProperty").length>2)
            $(".moreProperty").show();
         
        
        //处理更多按扭事件
        $(".catMore").click(function(){
            $(this).blur();
            $(this).parent().prev().find("ul li:nth-child(n+6)").toggle();
            if($(this).hasClass("catMore")){
                $(this).removeAttr("className").addClass("catMore2");
                $(this).text("隐藏")
            }
            else{
                $(this).removeAttr("className").addClass("catMore");
                $(this).text("更多")
            }
            
            //点击更多类别时隐藏各项属性，只保留类别
            var par=$(this).parent().parent().parent()
            if(par.hasClass("liCat")){
               par.parent().next().toggle(); 
               if($(".liProperty").length>2)
                 $(".moreProperty").toggle();
            }
            //点击后要完成的相关动作
            setCatBottomLine(); 
            setArrowVisble();     
        });
        //更多属性事件
        $(".moreProperty").click(function(){
            $(".liProperty:nth-child(n+4)").toggle();
            
            if($(this).text()=="更多")
            {
                $(this).text("收起").css("background-position","-131px -105px");
            }else{
                $(this).text("更多").css("background-position","-131px -82px");;
            }
        });
        
        //切换产品列表视图模式
        $(".switchView,.switchView2").click(function(){
            $(".pListBody,.pListbody2").toggle();
            $(this).blur();
            if($(this).hasClass("switchView"))
                $(this).removeClass("switchView").addClass("switchView2").text("切换到列表");
            else
                $(this).removeClass("switchView2").addClass("switchView").text("切换到大图");
        });
        
        //初始化类别项是否有下边线
        setCatBottomLine();
        //初始化箭头是否显示
        setArrowVisble()
});