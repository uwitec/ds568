﻿$(function() {
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
        $(".sub-item-wrap").hide().eq(ind).show();
    });

    $("#smm-3 li").click(function() {
        var ind = $("#smm-3 li").removeClass("crt").index(this);
        $(this).addClass("crt");
        $("#smm-3").parent().find(".item-main-wrap").hide().eq(ind).show();
    });

    $("#fontColor").colorSelect();
    $("#color_a").colorSelect();
    $("#img-fc1").colorSelect();
    $("#img-fc2").colorSelect();
    $("#img-fc3").colorSelect();
    $("#img-fc4").colorSelect();
    $("#img-fc5").colorSelect();
    $("#img-fc6").colorSelect();

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
    var ajaxSave = function(postdata) {
        $(postdata.btn).addClass("loading2").find(".cb_m").text("数据提交中…");
        $.ajaxFileUpload({
            url: _url + "?time=" + Math.random(),
            type: "POST",
            secureuri: false,
            fileElementId: postdata.fileid,
            data: postdata,
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
                $(postdata.btn).removeClass("loading2").find(".cb_m").text("保存");
            }
        });
    }

    //保存主题名称
    $(".btnsavethename").click(function() {
        $.ajax({
            url: _url,
            type: "post",
            dataType: "json",
            data: { myaction: "savethename", thename: $("input[name=themeName]").val(), id: $("input[name=the_id]").val() },
            success: function(data) {
                if (data.succ) {
                    alert("主题名称保存成功。");
                } else {
                    alert(data.msg)
                }
            },
            error: function(req) {
                alert("保存出错。");
            },
            beforeSend: function() {

            },
            complete: function() {

            }
        });
    });

    //提交招牌
    $("#btn-sign-save").click(function() {
        if ($(this).hasClass("loading2")) return false;
        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }

        var cnstyle = "font-family:" + $("select[name=comfontName]").val() + ";font-size:" + $("select[name=comfontSize]").val() + "px;font-weight:" + $("#fontBold").attr("val") + ";font-style:" + $("#fontItalic").attr("val") + ";color:" + $("#fontColor").css("background-color");
        var data = { myaction: "signSave", btn: this, id: $("input[name=the_id]").val(), fileid: "signfile", themeName: themeName, signType: $("input[name=signType]:checked").val(), signBgColor: $("#color_a").css("background-color"), comNameShow: $("input[name=comns]:checked").val(), signStyle: cnstyle };
        ajaxSave(data);

    });

    //提交预览图
    $("#btn-thume-save").click(function() {
        if ($(this).hasClass("loading2")) return false;
        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }
        ajaxSave({ myaction: "thumeSave", btn: this, fileid: 'thume', themeName: themeName, id: $("input[name=the_id]").val() });
    });

    //单图广告
    $("#ad-sigle-save").click(function() {
        if ($(this).hasClass("loading2")) return false;
        $(".adsigle table").each(function() {//把显示文字样式赋值给对应隐藏控件，以便提交
            var ipts = $(this).find("input[type=hidden]");
            var imgs = $(this).find("img");
            ipts.each(function() {
                var ind = ipts.index(this);
                if (ind < 2)
                    $(this).val(imgs.eq(ind).attr("val"));
                else {
                    $(this).val(imgs.eq(ind).css("background-color"));
                }
            });
        });

        var data = strToJson($(".adsigle input").serialize()); alert($(".adsigle input").serialize())
        data.myaction = "adSigleSave";
        data.id = $("input[name=the_id]").val();
        data.fileid = "adfile1";
        data.btn = this;
        ajaxSave(data);
    });


    //还原
    var id = $("input[name=the_id]").val();
    if (id != "") {
        $.ajax({
            url: _url,
            data: { myaction: "getmd", id: id },
            dataType: "json",
            success: function(data) {
                $("#signimg").attr("src", data.SignImg).show(); //店招
                $("#thumeimg").attr("src", data.Thume).show(); //预览图
                $("input[name=themeName]").val(data.ThemeName); //主题名称
                $("#color_a").css("background-color", data.SignBgColor); //店招背景色
                $("input[name=signType]").removeAttr("checked").filter("[value=" + data.SignType + "]").attr("checked", "checked"); //店招类型
                $("input[name=comns]").removeAttr("checked").filter("[value=" + String(data.ComNameShow).replace("t", "T").replace("f", "F") + "]").attr("checked", "checked"); //店招公司名称样式
                var cncss = data.ComNameCss.split(';');
                $("select[name=comfontName]").val(cncss[0].replace("font-family:", ""));
                $("select[name=comfontSize]").val(cncss[1].replace("font-size:", "").replace("px", ""));
                if (cncss[2].replace("font-weight:", "") != $("#fontBold").attr("val")) {
                    $("#fontBold").click();
                }
                if (cncss[3].replace("font-style:", "") != $("#fontItalic").attr("val")) {
                    $("#fontItalic").click();
                }
                $("#fontColor").css("background-color", cncss[4].replace("color:", ""));
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