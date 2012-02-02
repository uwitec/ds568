$(function() {
    //计算包含图片列表的ul的长度
    var imgItem = $(".subwrap ul li");
    $(".subwrap ul").css("width", imgItem.length * 77);
    //点击选择当前图片
    imgItem.click(function() {
        imgItem.removeClass("crtimg");
        $(this).addClass("crtimg")
        $(".corect").css({ "left": $(this).offset().left + 26, "top": $(this).offset().top + 33 }).show(); //设置勾的位置
        $(".sp1 img").attr("src", $(this).find("img").attr("src"))
        var ind = imgItem.index(this);
        if (ind == 0)
            $(".preImg").hide();
        else
            $(".preImg").show();
        if (ind == imgItem.length - 1)
            $(".nextImg").hide();
        else
            $(".nextImg").show();

        //加载图片数据
        $.ajax({
            type: "POST",
            data: { action: "loadimgdata", img_id: $(this).attr("imgid") },
            timeout: 15000,
            dataType: "json",
            success: function(data, state) {
                $(".sp1 img").attr("src", "/Resource/" + data.ImgUrl + "/" + data.ImgName);
            },
            beforeSend: function() {

            },
            error: function(req, state, err) {
                alert("加载图片数据出错。");
                //$("body").append(req.responseText);
            }
        });
    });

    var scrollImg = function(isPre, ind) {
        var sl = $(".subwrap").scrollLeft();
        var rollWidth = 0;
        if (isPre) {//如果动作为上一张
            if (sl > 0) rollWidth = -77;
        } else {
            if (sl < (imgItem.length - 3) * 77) rollWidth = 77;
        }

        //滚动
        $(".subwrap").animate({ scrollLeft: sl + rollWidth }, 100, function() {
            imgItem.removeClass("crtimg").eq(ind).click();
        });
    }

    //上一张
    $(".preImg").click(function() {
        var ind = imgItem.index($(".crtimg"));
        scrollImg(true, --ind);

    });

    //上一张
    $(".nextImg").click(function() {
        var ind = imgItem.index($(".crtimg"));
        scrollImg(false, ++ind);
    });

    //初始化当前选中的图片
    var crtimg = imgItem.filter("[imgid=" + $("#img_id").val() + "]");
    var ind = imgItem.index(crtimg);
    if (ind > 2)
        $(".subwrap").scrollLeft((ind - (imgItem.length > 4 ? 1 : 2)) * 77);
    crtimg.click();
})