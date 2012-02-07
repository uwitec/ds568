$(document).ready(function() {

    //调用ajax后需要执行的事件
    var albHover = function() {
        //鼠标经过
        $(".listctn li").hover(function() {
            $(this).addClass("ab_hover").find(".albtitle").addClass("hvcl");
        },
            function() {
                $(this).removeClass("ab_hover").find(".albtitle").removeClass("hvcl");
            }
        ).click(function() {
            $("#albumID").val($(this).attr("aid"));
        });


    }
    albHover();

    var pageIndex = 1; //当前页
    var ajaxReq = function(_data, _beforeSend, _complete, _success) {
        $.ajax({
            url: "Album_List.aspx",
            type: "POST",
            data: _data,
            success: function(data, state) {
                _success(data);
            },
            beforeSend: function() {
                _beforeSend();
            },
            error: function(req, state, err) {
                alert("出错");
                //$("body").append(req.responseText)
            },
            complete: function() {
                _complete();
            }
        });
    }

    //添加相册
    $("#addAlbum").click(function() {
        wb = $(this).wBox({
            title: "创建相册",
            target: ".wbwrap",
            show: true,
            callBack: function() {
                var albn = $(".albumName").eq(1);
                var pswd = $(".pmpsd").eq(1);
                //添加时清空各项的值
                albn.val('');
                pswd.val('');
                $("input[name=pm]").eq(3).attr("checked", "checked");
                $(".psw").hide();

                $(".btnsub").eq(1).click(function() {
                    if (albn.val().trim() == "") {
                        alert("请输入相册名称。");
                        return;
                    }
                    if ($("input[name=pm]:checked").val() == "1" && $(".pmpsd").eq(1).val().trim() == "") {
                        alert("请输入访问密码。");
                        return;
                    }
                    $.ajax({
                        url: "Album_List.aspx",
                        type: "POST",
                        data: { action: "addAlbum", albumName: albn.val(), pm: $("input[name=pm]:checked").val(), pwd: pswd.val() },
                        success: function(data, state) {
                            if (Number(data)) {
                                location.reload();
                            } else
                                alert(data)
                        },
                        beforeSend: function() {

                        },
                        error: function(req, state, err) {
                            alert("创建相册出错。" + req.responseText);

                        }
                    });
                });
            }
        });
        return false;
    });

    //根据是否选择了访问密码，显示或隐藏密码输入框
    $("input[name=pm]").click(function() {
        if ($(this).val() == "1") {
            $(".psw").show()
        } else
            $(".psw").hide();
    });

    //切换上传模式
    $(".upload_type_wrap li").click(function() {
        $(".upload_type_wrap li").removeClass("current_ut");
        $(this).addClass("current_ut").find("a").blur();
    });

    //转换文件大小
    var covertSize = function(size) {
        return size > 1024 * 1024 ? Math.round(size / 1024 * 1024) + "MB" : (size > 1024 ? Math.round(size / 1024) + "KB" : size + "B")
    }
    //文件上传
    $("#uploadify").uploadify({
        'uploader': '/js/uploadify/uploadify.swf',
        'script': '/js/uploadify/Upload.aspx',
        'cancelImg': '/js/uploadify/cancel.png',
        'folder': 'UploadFile',
        'queueID': 'fileQueue1',
        'auto': false,
        'multi': true,
        'width': 143,
        'height': 28,
        'sizeLimit': 4096 * 1024,
        'queueSizeLimit': 5,
        'buttonImg': '/Member/Manage/Album/Images/upBtn.gif',
        'fileExt': '*.jpg;*.gif;*.png;*.bmp',
        'fileDesc': '*.jpg;*.gif;*.png;*.bmp',
        'onComplete': function(event, ID, fileObj, response, data) {

        },
        'onSelect': function(event, queueId, fileObj) {
            $(".upimg_list").append("<li><div class=\"infoL\">" + fileObj.name + "</div><div class=\"infoM\">" + covertSize(fileObj.size) + "</div><div class=\"infoR\"><a href='javascript:;' qid='" + queueId + "' title='删除'>&nbsp;</a></div></li>");
        },
        'onSelectOnce': function(event, data) {
            //文件选择完成后绑定删除事件
            $(".infoR a").click(function() {
                $('#uploadify').uploadifyCancel($(this).attr("qid"));
                $(this).parent().parent().slideUp(200, function() {
                    $(this).remove();
                });
            });

            //所有文件大小
            $("#totalSize").text(covertSize(data.allBytesTotal));
            //所有文件个数
            $("#fileCount").text(data.fileCount);
            //设置全部删除和上传图片按扭状态
            if (data.fileCount > 0)
                $("#delAll,#uploadImg").removeClass("dsab");
        },
        'onCancel': function(event, queueId, fileObj, data) {
            //所有文件大小
            $("#totalSize").text(covertSize(data.allBytesTotal));
            //所有文件个数
            $("#fileCount").text(data.fileCount);
            //设置全部删除和上传图片按扭状态
            if (data.fileCount == 0)
                $("#delAll,#uploadImg").addClass("dsab");
        },
        'onError': function(event, queueId, fileObj, errorObj) {


        }
    });

    //清除列表
    $("#delAll").click(function() {
        $("#uploadify").uploadifyClearQueue();
        $(".upimg_list li").slideUp(200, function() {
            $(".upimg_list li").remove();
        });
    });

    //上传
    $("#uploadImg").click(function() {
        
        var albumid = $("#albumID").val();
        if (!$(this).hasClass("dsab")&&albumid!="") {
            if (!$(this).attr("disabled")) {
                $('#uploadify').uploadifySettings('script', '/js/uploadify/Upload.aspx?albumID=' +albumid );
                $('#uploadify').uploadifyUpload();
            }
        }
    });

});