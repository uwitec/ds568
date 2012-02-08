$(document).ready(function() {

    //调用ajax后需要执行的事件
    var albHover = function() {
        //鼠标经过
        $(".listctn li").hover(function() {
                if(!$(this).hasClass("alsel"))
                    $(this).addClass("ab_hover").find(".albtitle").addClass("hvcl");
            },
            function() {
                if(!$(this).hasClass("alsel"))
                    $(this).removeClass("ab_hover").find(".albtitle").removeClass("hvcl");
            }
        ).click(function() {
            $("#albumID").val($(this).attr("aid"));
            $(".listctn li").removeClass("alsel")
            $(this).removeClass("ab_hover").addClass("alsel").find(".albtitle").removeClass("hvcl");
            $("#abnctn").show();
            $("#selabn").text($(this).attr("abn"));
            $(".step2").addClass("step2enb"); 
            var ind=$(".listctn li").index(this)+1;
            var rowInd=ind%5==0?ind/5:Math.floor(ind/5)+1;
            $(".listctn").addClass("afterSel").animate({"scrollTop":(rowInd-1)*210},600,function(){
                $("#stepwrap").show();
            });
            
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
        'sizeLimit': 200 * 1024,//200KB
        'queueSizeLimit': 5,
        'buttonImg': '/Member/Manage/Album/Images/upBtn.gif',
        'fileExt': '*.jpg;*.gif;*.png;*.bmp',
        'fileDesc': '*.jpg;*.gif;*.png;*.bmp',
        'onComplete': function(event, ID, fileObj, response, data) {
            $(".infoR a[qid="+ID+"]").addClass("cpl");
        },
        'onSelect': function(event, queueId, fileObj) {
            if(fileObj.size>200 * 1024){
                alert(fileObj.name+" 大小超过了200 KB\n\r请压缩处理后再上传。");
                return false;
            }
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
            if(errorObj.type=="File Size"){
                $('#uploadify').uploadifyCancel(queueId);
            }
        
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
        
        if(!$(this).hasClass("dsab")){
            if(albumid!=""){
                $("#uploadify").uploadifySettings('script', '/js/uploadify/Upload.aspx?albumID=' +albumid );
                $("#uploadify").uploadifyUpload();
            }else
                alert("请先挑选相册。");
        }
    });

});