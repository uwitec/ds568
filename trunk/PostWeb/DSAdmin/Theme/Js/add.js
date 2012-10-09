$(function() {
    $(".hmenu li").click(function() {
        var ind = $(".hmenu li").removeClass("mn-wrap-crt").index(this);
        $(this).addClass("mn-wrap-crt");
        $(".th-model-wrap").hide().eq(ind).show();
    });

    $("#smm-1 li").not(":last").click(function() {
        var ind = $("#smm-1 li").removeClass("crt").index(this);
        $(this).addClass("crt");
        $("#smm-1").parent().find(".item-main-wrap").hide().eq(ind).show();
    });

    $("#smm-2 li").click(function() {
        var ind = $("#smm-2 li").removeClass("crt").index(this);
        $(this).addClass("crt");
    });

    $("#fontColor").colorSelect();
    $("#color_a").colorSelect();
    $("#img-fc1").colorSelect();
    $("#img-fc2").colorSelect();
    $("#img-fc3").colorSelect();
    
    $(".fb").click(function() {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_2.gif").attr("val", "bold")
        } else {
            $(this).attr("src", src).attr("val", "normal")
        }
    });
    $(".ft").click(function() {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_2.gif").attr("val", "italic")
        } else
            $(this).attr("src", src).attr("val", "normal")
    });



    var _url = "Action.ashx"
    var ajaxSave = function(btn, fileID, data) {
        $(btn).addClass("loading2").find(".cb_m").text("数据提交中…");
        $.ajaxFileUpload({
            url: _url + "?time=" + Math.random(),
            type: "POST",
            secureuri: false,
            fileElementId: fileID,
            data: data,
            dataType: "json",
            success: function(data) {
                if (data.Succ) {
                    alert("提交成功。");
                    $("input[name=the_id]").val(data.ID);
                }
                else {
                    alert(data.Msg);
                }
            },
            error: function(data, status, e) {
                $("body").append(data.responseText)
                alert(e);
            },
            complete: function() {
                $(btn).removeClass("loading2").find(".cb_m").text("保存");
            }
        });
    }
    //提交招牌
    $("#btn-sign-save").click(function() {
        if ($(this).hasClass("loading2")) return false;
        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }
        var cnstyle = "font-family:" + $("select[name=comfontName]").val() + ";font-size:" + $("select[name=comfontSize]").val() + "px;font-weight:" + $("#fontBold").attr("val") + ";font-style:" + $("#fontItalic").attr("val") + ";color:" + $("#fontColor").css("background-color");
        var data = { myaction: "signSave", id: $("input[name=the_id]").val(), themeName: themeName, signType: $("input[name=signType]:checked").val(), signBgColor: $("#color_a").css("background-color"), comNameShow: $("input[name=comns]:checked").val(), signStyle: cnstyle };
        ajaxSave(this, 'signfile', data);

    });

    //提交预览图
    $("#btn-thume-save").click(function() {
        if ($(this).hasClass("loading2")) return false;
        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }
        ajaxSave(this, 'thume', { myaction: "thumeSave", themeName: themeName, id: $("input[name=the_id]").val() });
    });


    //还原
    var id = $("input[name=the_id]").val();
    if (id != "") {
        $.ajax({
            url: _url,
            data: { myaction: "getmd", id: id },
            dataType: "json",
            success: function(data) {
                $("#signimg").attr("src", data.SignImg).show();
                $("#thumeimg").attr("src", data.Thume).show();
                $("input[name=themeName]").val(data.ThemeName);
                $("#color_a").css("background-color", data.SignBgColor);
                $("input[name=signType]").removeAttr("checked").filter("[value=" + data.SignType + "]").attr("checked", "checked");
                $("input[name=comns]").removeAttr("checked").filter("[value=" + String(data.ComNameShow).replace("t", "T").replace("f", "F") + "]").attr("checked", "checked");
                var cncss = data.ComNameCss.split(';');
                $("select[name=comfontName]").val(cncss[0].replace("font-family:", ""));
                $("select[name=comfontSize]").val(cncss[1].replace("font-size:", "").replace("px", ""));
                if (cncss[2].replace("font-weight:", "") != $("#fontBold").attr("val")) {
                    $("#fontBold").click();
                }
                if (cncss[3].replace("font-style:", "") != $("#fontItalic").attr("val")) {
                    $("#fontItalic").click();
                }
                $("#fontColor").css("background-color", cncss[4].replace("color:", ""))
            },
            error: function(req) {
                $("body").append(req.responseText);
            },
            beforeSend: function() {
                $("#btn-sign-save").addClass("loading2").find(".cb_m").text("正在获取数据…");
            },
            complete: function() {
                $("#btn-sign-save").removeClass("loading2").find(".cb_m").text("保存");
            }

        });
    }




})