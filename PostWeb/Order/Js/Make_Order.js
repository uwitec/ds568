$(function() {
    $(".a_l_chk input").click(function() {
        $(".address_list").removeClass("crt_ads");
        $("#ads_lt_" + $(this).attr("ind")).addClass("crt_ads");
        if (this.id == "a_l_chk_other") {
            $(".ads_det_item,.chk_body_right").show();
        }else
            $(".ads_det_item,.chk_body_right").hide();
    });
});