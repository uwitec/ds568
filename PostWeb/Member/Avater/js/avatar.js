$(function () {
    var __avatar_handlerUrl = "AvatarService.ashx?time=" + Math.random();
    var avatarFileName = "";
    var __avatar_size = 1;  //缩放比例
    var __avatar_x = 0;
    var __avatar_y = 0;
    var __avatar_w = 0;
    var __avatar_h = 0;

    $("#divBG").resizable().children().not("#divCuter").remove();
    var gbOS = $("#divBG").offset();
    $("#divCuter").resizable({ containment: "#divBG", aspectRatio: 1, minHeight: 20, minWidth: 20,
        stop: function () {
            _viewImg();
        }
    }).draggable({
        containment: "#divBG",
        scroll: false,
        stop: function () {
            _viewImg();
        }
    }).offset({ top: gbOS.top + 63, left: gbOS.left + 63 });   //把cuter主位在BG中间

    function _uploadImg() {
        $.ajaxFileUpload({
            url: __avatar_handlerUrl,
            secureuri: false,
            fileElementId: 'avatarFile',
            data: { myaction: "upload" },
            success: function (data) {
                $("#divBG").show();
                $(".btnsel").hide();
                var obj = $.parseJSON(data);
                if (obj.result == 1) {
                    var file = obj.msg;
                    avatarFileName = file;
                    __avatar_size = obj.size;
                    if (obj.size != 1) {
                        file += ".view.jpg";
                    }
                    var pof = $("#divContenter").offset();
                    $("#divBG").css({ "background-image": "url(" + file + ")",
                        width: obj.w,
                        height: obj.h
                    }).offset({ top: pof.top + (464 - obj.h) / 2 + 1, left: pof.left + (606 - obj.w) / 2 + 1 });
                    //设置cuter大小
                    var mh = Math.min(175, obj.h);
                    var mw = Math.min(175, obj.w);
                    $("#divCuter").height(mh).width(mw);
                    //使cuter居中
                    pof = $("#divBG").offset();
                    $("#divCuter").offset({ top: pof.top + (obj.h - mh) / 2 + 1, left: pof.left + (obj.w - mw) / 2 + 1 });
                    _viewImg();
                }
                else {
                    alert(obj.msg);
                }
            },
            error: function () {
                alert("上传失败，请检查文件是否符合格式要求。");
            },
            complete: function () {
                $("#avatarFile").change(function () {
                    _uploadImg();
                });
            }
        });
    }

    $("#avatarFile").change(function () {
        _uploadImg();
    });

    function _viewImg() {
        if (avatarFileName != "") {
            var c = $("#divCuter");
            var os1 = c.offset();
            var os2 = $("#divBG").offset();
            var width = c.width();
            var height = c.height();
            var x = os1.left - os2.left;
            var y = os1.top - os2.top;
            __avatar_x = x;
            __avatar_y = y;
            __avatar_h = height;
            __avatar_w = width;
            var img = __avatar_handlerUrl + "&myaction=view&file=" + avatarFileName + "&size=" + __avatar_size + "&x=" + x + "&y=" + y + "&w=" + width + "&h=" + height;
            $("#imgAvatarView").attr("src", img).show();
            $(".view_btn").css("background-image", "url(images/btnUpload2.gif)")
            $(".btnsel2").show();
        }
    }
    function _uploadAvatarOK() {
        if (avatarFileName != "") {
            $.get(__avatar_handlerUrl,
            { myaction: "save",
                size: __avatar_size,
                file: avatarFileName,
                x: __avatar_x,
                y: __avatar_y,
                h: __avatar_h,
                w: __avatar_w
            },
            function (data, status) {
                if (data == "1") {
                    if (OnAvatarUploaded) {//外部的函数
                        OnAvatarUploaded(avatarFileName);
                    }
                    $("#divSaveInfo").html("保存成功").css("color", "orange");
                }
                else {
                    $("#divSaveInfo").html("保存失败").css("color", "red");
                }
                $("#divBG").css("background", "none");
                $("#imgAvatarView").hide();
                avatarFileName = "";
                __avatar_size = 1;
                setTimeout('$("#divSaveInfo").html("");', 1500);
            }
        )
        }
    }

    $("#btnupload").click(function () {
        _uploadAvatarOK();
        $("#avatarFile").change(function () {
            _uploadImg();
        });
    });
    function _uploadAvatarCancel() {
        if (avatarFileName != "") {
            $.get(__avatar_handlerUrl, { myaction: "delete", size: __avatar_size, file: avatarFileName }, function (data, status) {
                $("#divBG").css("background", "none");
                $("#imgAvatarView").hide();
                avatarFileName = "";
                __avatar_size = 1;
            })
            if (OnAvatarUploadCancel) {//外部的函数
                OnAvatarUploadCancel();
            }
        }
    }

    $("#btncancel").click(function () {
        _uploadAvatarCancel()
    });

    function OnAvatarUploaded(file) {
        $("#img").attr("src", file + "?n=" + Math.random()); //防止缓存
    }

    $(".btnsel2").click(function () {
        $("#divBG,.btnsel2").hide();
        $(".btnsel").show();
        $(".view_btn").css("background-image", "url(images/btnUpload.gif)");
        $("#imgAvatarView").hide();
    });

});
    
