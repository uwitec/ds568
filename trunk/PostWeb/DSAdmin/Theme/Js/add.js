$(function () {
    //克隆多图广告提交项
    var adMutiItem = $(".ad-muti-list:first");
    $(".ad-muti-wrap").append(adMutiItem.clone())
    $(".ad-muti-wrap").append(adMutiItem.clone())
    $(".ad-muti-wrap").append(adMutiItem.clone())
    $(".ad-muti-list").hide().eq(0).show();
    $(".ad-muti-list input[type=file]").each(function (i) {
        $(this).attr("id", "admutifile" + i).attr("name", "admutifile" + i)
    });


    $(".hmenu li").click(function () {
        var ind = $(".hmenu li").removeClass("mn-wrap-crt").index(this);
        $(this).addClass("mn-wrap-crt");
        $(".th-model-wrap").hide().eq(ind).show();
    });

    //所有标签切换
    $(".sub-model-menu li:not(.licommon)").click(function () {
        var parent = $(this).parent();
        var ind = parent.find("li").removeClass("crt").index(this);
        $(this).addClass("crt");
        var aditem = parent.parent().find(".sub-item-wrap")
        if (aditem.length > 0) {
            aditem.hide().eq(ind).show()
        } else {
            parent.parent().find(".item-main-wrap").hide().eq(ind).show();
        }
    });

    //字体是否加精
    $(".fb").click(function () {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_2.gif").attr("val", "bold")
        } else {
            $(this).attr("src", src).attr("val", "normal")
        }
    });
    //字体样式
    $(".ft").click(function () {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_2.gif").attr("val", "italic")
        } else
            $(this).attr("src", src).attr("val", "normal")
    });


    //颜色选择
    $(".fc").each(function () {
        $(this).colorSelect();
    });

    //图片保存公共方法
    var _url = "Action.ashx"
    var ajaxSave = function (postdata) {
        $(postdata.btn).addClass("loading2").find(".cb_m").text("数据提交中…");
        $.ajaxFileUpload({
            url: _url + "?time=" + Math.random(),
            type: "POST",
            secureuri: false,
            fileElementId: postdata.fileid,
            data: postdata,
            dataType: "json",
            success: function (data) {
                if (data.Succ) {
                    if (postdata.img) {
                        $(postdata.img).attr("src", data.imgUrl + "?rd" + Math.random()).show();
                    }
                    alert("提交成功。");
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
                $(postdata.btn).removeClass("loading2").find(".cb_m").text("保存");
            }
        });
    }

    //保存主题名称
    $(".btnsavethename").click(function () {
        $.ajax({
            url: _url,
            type: "post",
            dataType: "json",
            data: { myaction: "savethename", thename: $("input[name=themeName]").val(), id: $("input[name=the_id]").val() },
            success: function (data) {
                if (data.succ) {
                    alert("主题名称保存成功。");
                } else {
                    alert(data.msg)
                }
            },
            error: function (req) {
                alert("保存出错。");
            },
            beforeSend: function () {

            },
            complete: function () {

            }
        });
    });

    //提交导航背景
    $(".navSave").click(function () {
        if ($(this).hasClass("loading2")) return false;
        var navtype = $(this).attr("navtype");

        $("." + navtype).find("table").each(function () {
            $(this).find("img").each(function (ind) {
                if (ind < 2)
                    $(this).parent().find("input").eq(ind).val($(this).attr("val"));
                else {
                    $(this).parent().find("input").eq(ind).val($(this).css("background-color"));
                }
            });
        });
        var postdata = strToJson($("." + navtype).find("input,select").serialize());
        $.each({ myaction: "navSave", navtype: navtype, navmargin: $("select[name=chanle-margin]").val(), img: $("#" + navtype + "Img"), btn: this, id: $("input[name=the_id]").val(), fileid: navtype + "File" }, function (key, val) {
            postdata[key] = val;
        });
        ajaxSave(postdata);
    });

    //提交招牌
    $("#btn-sign-save").click(function () {
        if ($(this).hasClass("loading2")) return false;
        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }

        var cnstyle = "font-family:" + $("select[name=comfontName]").val() + ";font-size:" + $("select[name=comfontSize]").val() + "px;font-weight:" + $("#fontBold").attr("val") + ";font-style:" + $("#fontItalic").attr("val") + ";color:" + $("#fontColor").css("background-color");
        var data = { myaction: "signSave", img: $("#signimg"), btn: this, id: $("input[name=the_id]").val(), fileid: "signfile", themeName: themeName, signType: $("input[name=signType]:checked").val(), signBgColor: $("#color_a").css("background-color"), comNameShow: $("input[name=comns]:checked").val(), signStyle: cnstyle };
        ajaxSave(data);

    });

    //提交预览图
    $("#btn-thume-save").click(function () {
        if ($(this).hasClass("loading2")) return false;
        var themeName = $.trim($("input[name=themeName]").val());
        if (themeName == "") {
            alert("请输入主题名称。");
            return false;
        }
        ajaxSave({ myaction: "thumeSave", img: $("#thumeimg"), btn: this, fileid: 'thume', themeName: themeName, id: $("input[name=the_id]").val() });
    });

    //保存单图广告
    $("#ad-sigle-save").click(function () {
        if ($(this).hasClass("loading2")) return false;
        $(".adsigle table").each(function () {//把显示文字样式赋值给对应隐藏控件，以便提交
            var ipts = $(this).find("input[type=hidden]");
            var imgs = $(this).find("img");
            ipts.each(function () {
                var ind = ipts.index(this);
                if (ind < 2)
                    $(this).val(imgs.eq(ind).attr("val"));
                else {
                    $(this).val(imgs.eq(ind).css("background-color"));
                }
            });
        });

        var data = strToJson($(".adsigle input").serialize());
        data.myaction = "adSigleSave";
        data.id = $("input[name=the_id]").val();
        data.fileid = "adfile1";
        data.btn = this;
        data.img = $("#adsigleimg");
        ajaxSave(data);
    });

    //保存多图广告
    $(".btn-muti-save").click(function () {
        if ($(this).hasClass("loading2")) return false;
        var ind = $(".btn-muti-save").index(this);
        $("input[name=admutiind]").val(ind + 1);
        var mtwrap = $(".ad-muti-list").eq(ind);
        mtwrap.find("table").each(function () {
            var ipts = $(this).find("input[type=hidden]");
            var imgs = $(this).find("img");
            ipts.each(function () {
                var ind = ipts.index(this);
                if (ind < 2)
                    $(this).val(imgs.eq(ind).attr("val"));
                else {
                    $(this).val(imgs.eq(ind).css("background-color"));
                }
            });
        });

        var data = strToJson(mtwrap.find("input").serialize());
        data.myaction = "adMutiSave";
        data.id = $("input[name=the_id]").val();
        data.fileid = mtwrap.find("input[type=file]").attr("id");
        data.btn = this;
        data.img = $(".thumeimg").eq(ind);
        ajaxSave(data);

    });

    //保存是否显示广告
    //    $(".btn-adshow").click(function () {
    //        if ($(this).hasClass("loading2")) return false;
    //        var postdata = { myaction: "adshow", btn: this, adshow: $("input[name=adshow]:checked").val(), id: $("input[name=the_id]").val() };
    //        ajaxSave(postdata);
    //    });

    //保存背景
    $("#btnbgsave").click(function () {
        if ($(this).hasClass("loading2")) return false;
        var ind = $("#smm-bg li").index($("#smm-bg li.crt"));
        var postdata = { myaction: "bgSave", img: $(ind == 0 ? ".imginner" : ".imgouter"), btn: this, fileid: (ind == 0 ? "InnerBg" : "OuterBg"), id: $("input[name=the_id]").val() };
        ajaxSave(postdata);
    });

    //还原
    var id = $("input[name=the_id]").val();
    if (id != "") {
        $.ajax({
            url: _url,
            data: { myaction: "getmd", id: id },
            dataType: "json",
            success: function (data) {
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

                //导航
                $("select[name=chanle-margin]").val(data.NavMargin);
                $("#NavBgImg").attr("src", data.NavBg).show();
                $("#NavBgNormalImg").attr("src", data.NavBgNormal).show();
                $("#NavBgSelImg").attr("src", data.NavBgSel).show();
                //选中导航菜单字体
                var navSelCss = eval("(" + data.NavSelCss + ")");
                if (navSelCss) {
                    $(".NavBgSel select[name=comfontName]").val(navSelCss.family);
                    $(".NavBgSel select[name=comfontSize]").val(navSelCss.size);
                    if (navSelCss.weight != $(".NavBgSel img.fb").attr("val")) {
                        $(".NavBgSel img.fb").click();
                    }
                    if (navSelCss.style != $(".NavBgSel img.ft").attr("val")) {
                        $(".NavBgSel img.ft").click();
                    }
                    $(".NavBgSel img.fc").css("background-color", navSelCss.color);
                }
                //未选中导航菜单字体
                var navNormalCss = eval("(" + data.NavNormalCss + ")");
                if (navNormalCss) {
                    $(".NavBgNormal select[name=comfontName]").val(navNormalCss.family);
                    $(".NavBgNormal select[name=comfontSize]").val(navNormalCss.size);
                    if (navNormalCss.weight != $(".NavBgNormal img.fb").attr("val")) {
                        $(".NavBgNormal img.fb").click();
                    }
                    if (navNormalCss.style != $(".NavBgNormal img.ft").attr("val")) {
                        $(".NavBgNormal img.ft").click();
                    }
                    $(".NavBgNormal img.fc").css("background-color", navNormalCss.color);
                }

                //单图广告
                $("#adsigleimg").attr("src", data.AdSigleImg).show();
                var adobj = eval(data.AdSigleTxt);
                if (adobj) {
                    $.each(adobj, function (i, obj) {
                        $("input[name=adsigletxt" + (i + 1) + "]").val(obj.title);
                        $("input[name=fb" + (i + 1) + "]").val(obj.fontWeight);
                        if (obj.fontWeight != $("#img-fb" + (i + 1)).attr("val")) {
                            $("#img-fb" + (i + 1)).click();
                        }
                        $("input[name=ft" + (i + 1) + "]").val(obj.fontType);
                        if (obj.fontType != $("#img-ft" + (i + 1)).attr("val")) {
                            $("#img-ft" + (i + 1)).click();
                        }

                        $("input[name=fc" + (i + 1) + "]").val(obj.fontColor);
                        $("#img-fc" + (i + 1)).css("background-color", obj.fontColor);

                    })
                }

                //多图广告
                for (var i = 1; i <= 4; i++) {
                    var itemwrap = $(".ad-muti-list").eq(i - 1);
                    itemwrap.find(".thumeimg").attr("src", data["AdMutiImg" + i]).show();
                    var adobj = eval(data["AdMutiTxt" + i]);
                    if (adobj) {
                        $.each(adobj, function (i, obj) {
                            var tb = itemwrap.find("table").eq(i);
                            tb.find("input[name=admutitext" + (i + 1) + "]").val(obj.title);
                            tb.find("input[name=admtfb" + (i + 1) + "]").val(obj.fontWeight);

                            if (obj.fontWeight != tb.find(".fb").attr("val")) {
                                tb.find(".fb").click();
                            }

                            tb.find("input[name=admtft" + (i + 1) + "]").val(obj.fontType);
                            if (obj.fontType != tb.find(".ft").attr("val")) {
                                tb.find(".ft").click();
                            }

                            tb.find("input[name=admtfc" + (i + 1) + "]").val(obj.fontColor);
                            tb.find(".fc").css("background-color", obj.fontColor);

                        })
                    }
                }

                //广告是否显示
                $("input[name=adshow]:" + (data.AdShow == null || data.AdShow ? "first" : "last")).attr("checked", "checked");

                //背景图
                $(".imginner").attr("src", data.InnerBg).show();
                $(".imgouter").attr("src", data.OuterBg).show();

                //

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

});