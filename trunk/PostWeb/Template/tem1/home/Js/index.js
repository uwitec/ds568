$(document).ready(function(){
    //获取数据
    var getdata=function(subData,_beforeSend,_complete,_success){
        $.ajax({
            url:"?",
            data:subData,
            success:function(data,state){
                _success(data);
            },
            error:function(req,state,err){
                alert(req.responseText)
            },beforeSend:function(){
                _beforeSend();
            },
            complete:function(){
                _complete();
            }
        });
    };
    
    //公司简介
//    getdata({action:"cominfo",memberid:getQueryString("member_id")},
//        function(){//发送前
//            $("#about").css("visibility","hidden");
//        },
//        function(){//完成
//            $("#about").css("visibility","visible");
//        },
//        function(data){//成功
//            $("#about").html(data.split('^')[0]);
//            $(".AboutImg").show().attr("src",data.split('^')[1])
//          
//        }
//    );
    
    //滚动精品推荐
    var TzCon=TzCon=$(".TzContent1")
	var imgLeng=TzCon.find("ul li").length;//滚动产品数目
	
    var RollImg=function(){
        var sl= TzCon.scrollLeft();
        if(sl>=imgLeng*176){
            TzCon.scrollLeft(0);
        }
        TzCon.animate({scrollLeft:TzCon.scrollLeft()+176},600,function(){
            setTimeout(RollImg,3500);
        });
    }
    
	if(imgLeng>=4){//至少4个产品才能滚动
	    //复制精品推荐图片用于滚动
	    $(".TzContent1 ul").append($(".TzContent1 ul").html())
	    //开始滚动精品推荐
	    setTimeout(RollImg,3000);
	}

});