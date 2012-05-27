$(function () {
    $(".menu a").click(function () {
        $("#mainFrame").attr("src", $(this).attr("href"));
        return false;
    });

    function iFrameHeight() {
        var ifm = document.getElementById("mainFrame");
        ifm.height = $(window).height() - 44;
    }
    setInterval(iFrameHeight, 2000);
});