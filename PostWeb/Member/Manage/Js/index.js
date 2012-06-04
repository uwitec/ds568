$(function () {
    $(".menu a,.fix_ctn a").not(".nolk").click(function () {
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
            $(".app_wrap").not("img").fadeOut(500)
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

    $("input[name=kw]").val(function () {
        return $(this).attr("dv");
    }).focus(function () {
        if ($(this).val() == $(this).attr("dv")) {
            $(this).val('').css("color", "#555");
            $(".sch_wrap *").css("background-color", "White")
            $(".sch_btn").css("background-position", "-50px -150px");
        }
    }).blur(function () {
        if ($(this).val() == '') {
            $(this).val($(this).attr("dv")).css("color", "gray");
            $(".sch_wrap *").css("background-color", "#f1f1f1");
            $(".sch_btn").css("background-position", "0 -150px");
        }
    });

    //检查未读消息，若为0则隐藏提醒标志。
    $(".mc_block").text(function () {
        if ($(this).text() == "0") {
            $(this).hide();
        }
        return $(this).text();
    });

});