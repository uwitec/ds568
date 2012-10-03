$(function() {
    webconfig = true; //商铺页面会检查此值，以便判断是否处理装修状态

    //自适应高度
    function iFrameHeight() {
        var ifm = document.getElementById("mainFrame");
        ifm.height = $(window).height() - 44;
    }
    setInterval(iFrameHeight, 2000);

    $(".dc-menu").bind("click", function() {
        var ind = $(".dc-menu").index(this);
        $(".dec-wrap").hide().eq(ind).show();

    }).focus(function() { $(this).blur(); });

    $(".close img").bind("click", function() {
        $(".dec-wrap").hide(); return false;
    });

    var _url = "action.aspx";
    //应用
    $(".theme-wrap li a").click(function() {
        var id = $(this).attr("theid")
        $.ajax({
            url: _url,
            type:"POST",
            data: { action: "viewThe", id: id },
            dataType: "json",
            success: function(data) {
                $(".Head", $("#mainFrame").contents()).css({ "background-image": "url("+data.SignImg+")" });
            },
            error: function(req) {
                alert("更换主题发生意外。" + req.responseText)
                $("body").append(req.responseText)
            },
            beforeSend: function() {
                $(".theme-wrap").addClass("loading2").find("li").addClass("hidden");
            },
            complete: function() {
                $(".theme-wrap").removeClass("loading2").find("li").removeClass("hidden");
            }
        });
    });

})