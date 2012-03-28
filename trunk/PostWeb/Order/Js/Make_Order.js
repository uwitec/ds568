$(function() {
    $(".a_l_chk input").click(function() {
        $(".address_list").removeClass("crt_ads");
        $("#ads_lt_" + $(this).attr("ind")).addClass("crt_ads");
        if (this.id == "a_l_chk_other") {
            $(".ads_det_item,.chk_body_right").show();
        }else
            $(".ads_det_item,.chk_body_right").hide();
    });
    
    $(".btm_m textarea").text($(".btm_m textarea").attr("dv")).focus(function(){
        if($(this).text()==$(this).attr("dv"))
            $(this).text('').css("color","#555");
    }).blur(function(){
        if($.trim($(this).text())=="")
            $(this).text($(this).attr("dv")).css("color","gray");
    });
});