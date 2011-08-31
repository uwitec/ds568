$(document).ready(function(){
    //将第七个以后的类别隐藏
    $(".lmlist li:nth-child(n+8)").css("display","none");
    //处理显示更多
    if($(".lmlist li").length>8){
        $(".lmlist li:last").css("display","inline").click(function(){
            $(".lmlist li:nth-child(n+8)").toggle();
            $(this).toggle();
            var lk=$(this).find("a")
            if(lk.text()=="显示更多"){
                lk.text("精简显示").addClass("cMore2");
            }else{
                lk.text("显示更多").removeClass("cMore2");
            }
        });
    }
    
    //地区插件
    Area.Create($(".cArea"));
    Area.CurrentPt=Area.PositionType.right;//设定显示位置
});