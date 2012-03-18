$(document).ready(function(){
     
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