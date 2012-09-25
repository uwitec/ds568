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
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_2.gif").attr("val", "bold")
        } else {
            $(this).attr("src", src).attr("val", "normal")
        }
    });
    $("#fontItalic").click(function () {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_2.gif").attr("val", "italic")
        } else
            $(this).attr("src", src).attr("val", "normal")
    });


    //上传
    var _url = "Action.ashx"
    //提交
    $("#btn-sign-save").click(function () {
        if ($(this).hasClass("loading2")) return false;

        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }
        var cnstyle = "font-family:" + $("select[name=comfontName]").val() + ";font-size:" + $("select[name=comfontSize]").val() + ";font-weight:" + $("#fontBold").attr("val") + ";font-style:" + $("#fontItalic").attr("val") + ";color:" + $("#fontColor").css("background-color");

        $("#btn-sign-save").addClass("loading2").find(".cb_m").text("数据提交中…");
        $.ajaxFileUpload({
            url: _url + "?time=" + Math.random(),
            type: "POST",
            secureuri: false,
            fileElementId: 'signfile',
            data: { myaction: "signSave", id: $("input[name=the_id]").val(), themeName: themeName, signType: $("input[name=signType]:checked").val(), signBgColor: $("#color_a").css("background-color"), comNameShow: $("input[name=comns]:checked").val(), signStyle: cnstyle },
            dataType: "json",
            success: function (data) {
                if (data.Succ) {
                    alert("提交成功。");
                    $("input[name=the_id]").val(data.Id);
                }
                else {
                    alert(data.Msg);
                }
            },
            error: function (data, status, e) {
                $("body").append(data.responseText)
                alert(e);
            },
            complete: function () {
                $("#btn-sign-save").removeClass("loading2").find(".cb_m").text("保存");
            }
        });

    });

    //还原
    var id = $("input[name=the_id]").val();
    if (id != "") {
        $.ajax({
            url: _url,
            data: { myaction: "getmd", id: id },
            dataType: "json",
            success: function (data) {
                $("#signimg").attr("src", data.SignImg).show();
                $("input[name=themeName]").val(data.ThemeName);
                $("#color_a").css("background-color", data.SignBgColor)
            },
            error: function (req) {
                $("body").append(req.responseText);
            },
            beforeSend: function () {
                $("#btn-sign-save").addClass("loading2").find(".cb_m").text("正在获取数据…");
            },
            complete: function () {
                $("#btn-sign-save").removeClass("loading2").find(".cb_m").text("保存");
            }

        });
    }




})