﻿$(document).ready(function(){
    //隐藏或显示分类
	$(".div001").click(function(){
		if($(this).hasClass("div002")){
			$(this).removeClass("div002");
		}else{
			$(this).addClass("div002");
		}
		$(".ul001").slideToggle(200);
	});	
	
	//搜索
	$("#SearchBtn2").click(function(){
	    location="index_product.aspx?"+$("#pro_name,#low_price,#height_price").serialize();
	});
	
	if($(".NewContent ul li").length==0){
	    $(".nopro").show();
	}
});