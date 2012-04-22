/*页面定位*/
// JavaScript Document
//焦点图轮播
var abs=function(src){
	var iXy=src.getBoundingClientRect();
	return {left:iXy.left,right:iXy.right,bottom:iXy.bottom,top:iXy.top}
}
var ss;
var className = "";
var count = 0;
var index = 0;
var disTime = 0;
var animateTime = 700;
play = function (obj) {
    if (obj.className != null) {
        className = obj.className;
    }
    if (obj.count != null) {
        count = obj.count;
    }
    if (obj.index != null) {
        index = obj.index;
    }
    if (obj.disTime != null) {
        disTime = obj.disTime;
    }
    if (obj.animateTime != null) {
        animateTime = obj.animateTime;
    }
    clearInterval(ss);
    ss = setInterval(steps, disTime + animateTime);
};
steps = function () {
    $("." + className).animate({ scrollLeft: index * 952 }, animateTime);
    $(".switchable-nav").find("li").eq(index - 1).removeClass("active");
    index++;
    $(".switchable-nav").find("li").eq(index - 1).addClass("active");
    if (index == count) index = 0;
};
next = function () {
    index++;
    if (index == count) index = 0;
    $("." + className).animate({ scrollLeft: index * 952 }, animateTime);
    $(".switchable-nav").find("li").eq(index - 1).removeClass("active");
    $(".switchable-nav").find("li").eq(index).addClass("active");
};
function showTopMenu(id) {
    $("#t_" + id).mouseenter(function () {
        $(this).addClass("hover");
        $("#tm_" + id).show();
    });
    $(".t-" + id).mouseleave(function () {
        $("#t_" + id).removeClass("hover");
        $("#tm_" + id).hide();
    });
    $("#tm_" + id).mouseleave(function () {
        $("#t_" + id).removeClass("hover");
        $(this).hide();
    });
};
function autoAd(){
	$(".hdadSm").hide();
	$(".hdadBj").css("display","none");
	$(".hdadBj").slideDown(1000);
	setTimeout(function(){$(".hdadBj").slideUp(1000);},5000);
	setTimeout(function(){$(".hdadSm").slideDown(1000);},6000);
}
$(document).ready(function(){
	//焦点图部分
	$(".layt").find("a").each(function () {
        $(this).append("<div class='layer' style='height:" + $(this).height() + "px;display:none;'></div>")
        $(this).hover(function () {
            $(this).find("div").eq(0).show();
        }, function () {
            $(this).find("div").eq(0).hide();
        });
    });
    $(".layt").each(function (_index) {
        $(this).mouseover(function () {
            $(".scrollwrapper").stop();
            clearInterval(ss);
            $(".scrollwrapper").animate({ scrollLeft: _index * 952 }, 100);
            $(".switchable-nav").find("li").removeClass("active");
            $(".switchable-nav").find("li").eq(_index).addClass("active");
            index = _index;
        });
        $(this).mouseout(function () {
            play({ index: index, count: count, className: className, disTime: disTime });
        });
    });
    $(".switchable-nav").find("li").each(function (_index) {
        $(this).hover(function () {
            $(".scrollwrapper").stop();
            clearInterval(ss);
            $(".scrollwrapper").animate({ scrollLeft: _index * 952 }, animateTime);
            $(".switchable-nav").find("li").removeClass("active");
            $(".switchable-nav").find("li").eq(_index).addClass("active");
            index = _index;
        }, function () {
            play({ index: index, count: count, className: className, disTime: disTime });
        });
    });
    $(".btn-next").click(function () {
        $(".scrollwrapper").stop();
        clearInterval(ss);
        next();
        play({ index: index, count: count, className: className, disTime: disTime });
    });
    $(".hotKinds").find("div").each(function (_index) {
        if (_index != 0) {
            $(this).hover(function () {
                $(this).css("border", "1px solid #dc0050");
                $(this).find("li").eq(0).find("a").css("color", "#dc0050");
            }, function () {
                if ($(this).attr("class").indexOf("bgcAlternate") > -1) $(this).css("border", "1px solid #f0f5f6");
                else $(this).css("border", "1px solid #FFFFFF");
                $(this).find("li").eq(0).find("a").css("color", "#333333");
            });
        }
    });
    showTopMenu("vjia");
    showTopMenu("nav");
    play({ index: 0, count: $(".layt").length, className: "scrollwrapper", disTime: 3000 });
	
	
})
