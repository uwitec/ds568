$(function () {
    $(".menu a,.fix_ctn a").click(function () {
        $("#mainFrame").attr("src", $(this).attr("href"));
        return false;
    });

    function iFrameHeight() {
        var ifm = document.getElementById("mainFrame");
        ifm.height = $(window).height() - 44;
    }
    setInterval(iFrameHeight, 2000);


    var ishover = false;
    var fadeOut = function () {
        if (ishover)
            $(".app_wrap").fadeOut(500)
    }
    $(".mnhv a").hover(function () {
        $(".app_wrap").fadeIn(500);
        ishover = false;
    },
        function () {
            ishover = true;
            setTimeout(fadeOut, 300);
        }
    );

    $(".app_wrap").hover(function () {
        ishover = false;
    },
        function () {
            ishover = true;
            setTimeout(fadeOut, 300);
        }
    );

});