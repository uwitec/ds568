﻿$(function() {
    $(".box-mn li").click(function() {
        var ind = $(".box-mn li").removeClass("current").index(this);
        $(this).addClass("current");
        $(".com_wrap").hide().eq(ind).show();
    });

    $(".sug-item img").click(function() { 
        $(this).attr("src","/checkcode.aspx?rd="+Math.random())
    });
})