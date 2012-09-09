$(function () {
    $(".hmenu li").click(function () {
        $(".hmenu li").removeClass("mn-wrap-crt");
        $(this).addClass("mn-wrap-crt");
    });

    $(".sub-model-menu li").not(":last").click(function () {
        var ind = $(".sub-model-menu li").removeClass("crt").index(this);
        $(this).addClass("crt");
        $(".sub-model-menu").parent().find(".item-main-wrap").hide().eq(ind).show();
    });

    $("#color_a").colorSelect();
    $("#fontColor").colorSelect();

    $("#fontBold").click(function () {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_2.gif")
        } else
            $(this).attr("src",src)
    });
    $("#fontItalic").click(function () {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_2.gif")
        } else
            $(this).attr("src", src)
    });
})