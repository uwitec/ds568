$(function () {
    webconfig = true; //商铺页面会检查此值，以便判断是否处理装修状态

    //自适应高度
    function iFrameHeight() {
        var ifm = document.getElementById("mainFrame");
        ifm.height = $(window).height() - 44;
    }
    setInterval(iFrameHeight, 2000);

    $(".dc-menu").bind("click", function () {
        var ind = $(".dc-menu").index(this);
        var sdec = $(".dec-wrap").hide().eq(ind).show();
        var os = $(this).offset();
        sdec.css({ "left": os.left, "top": os.top + 39 });

    }).focus(function () { $(this).blur(); });

    $(".close img").bind("click", function () {
        $(".dec-wrap").hide(); return false;
    });

    var _url = "action.aspx";
    var theid;
    //应用
    $(".theme-wrap li a").click(function () {
        theid = $(this).attr("theid");
        $.ajax({
            url: _url,
            type: "POST",
            data: { action: "viewThe", id: theid },
            dataType: "json",
            success: function (data) {
                var cont = $("#mainFrame").contents();
                if (data.SignType == 0) {
                    $(".Head", cont).css({ "background-image": "url(" + data.SignImg + ")", "background-color": "Transparent" });
                } else {
                    $(".Head", cont).css({ "background-image": "none", "background-color": data.SignBgColor });
                }
                if (data.ComNameShow) {
                    $(".Head h1", cont).attr("style", data.ComNameCss);
                } else {
                    $(".Head h1", cont).css("display", "none");
                }

                $(".close img").click();
            },
            error: function (req) {
                alert("更换主题发生意外。" + req.responseText)
                $("body").append(req.responseText)
            },
            beforeSend: function () {
                $(".theme-wrap").addClass("loading2").find("li").addClass("hidden");
            },
            complete: function () {
                $(".theme-wrap").removeClass("loading2").find("li").removeClass("hidden");
            }
        });
    });

    //保存
    $("#btn-thume-save").click(function () {
        var btn = this;
        if ($(this).hasClass("loading2")) return false;
        $.ajax({
            url: _url,
            type: "POST",
            data: { action: "theSave", theid: theid },
            dataType: "json",
            success: function (data) {
                if (data.succ) {
                    alert("保存成功")
                } else {

                }
            },
            error: function (req) {
                alert("保存出错");
                $("body").append(req.responseText);
            },
            beforeSend: function () {
                $(btn).addClass("loading2").find(".cb_m").text("数据提交中…");
            },
            complete: function () {
                $(btn).removeClass("loading2").find(".cb_m").text("保存");
            }
        });
    });

})