$(function () {
    $(".ctf-item-bd ul").each(function () {
        if ($(this).find("li").length == 0) {
            $(".ctf-list-item").eq($(".ctf-item-bd ul").index(this)).hide();
        }
    });
});