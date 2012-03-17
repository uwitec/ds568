$(function() {
    if ($(".comentBody").length == 0) {
        $(".nocoment").show();
    }
    var wb = $(".iptSubmit").wBox({
        title: "登录点石",
        html: "<div class='lgwrap loading2'>正检查登录状态…</div>",
        callBack: function() {
            $.ajax({
                type: "POST",
                data: { action: "chklogin" },
                success: function(data, state) {
                    if (Number(data)) {
                        wb.close();
                        sbm();
                    } else {
                        $(".lgwrap").parent().html($(".lgbody").html()); //如果没有登录，显示登录框
                        $(".btnlogin:last").click(function() {//绑定登录按扭事件
                            var uid = $.trim($(".cmuid:last").val());
                            var pwd = $.trim($(".cmpwd:last").val());
                            if (uid != "" && pwd != "") {//登录
                                $.ajax({
                                    type: "POST",
                                    data: { action: "login", uid: uid, pwd: pwd },
                                    success: function(data, state) {
                                        if (Number(data)) {//登录成功
                                            wb.close();
                                            sbm();
                                        } else {//登录失败
                                            alert(data)
                                        }
                                    },
                                    error: function(req, state, err) {
                                        alert("登录发生意外。")
                                    },
                                    beforeSend: function() {
                                        $(".actctn:last").hide();
                                        $("span.loading2:last").show();
                                    },
                                    complete: function() {
                                        $(".actctn:last").show();
                                        $("span.loading2:last").hide();
                                    }
                                });
                            }
                        });
                    }

                },
                error: function(req, state, err) {
                    $(".lgwrap").html("<span class='red'>验证登录状态出错。</span>").removeClass("loading2");
                }
            });
        }
    });

    var sbm = function() {
        var ctn = $.trim($("#coment").text());
        if (ctn == "") {
            alert("请输入评论。");
            return;
        }
        $.ajax({
            type: "POST",
            data: { action: "comment", parent_id: $("#pid").val(), content: encodeURIComponent(ctn) },
            success: function(data, state) {
                $(".comentBody").remove();
                $(".newsComent").append($(data).find(".comentBody"));
                $("#coment").text('');
                $(".nocoment").hide();
            },
            error: function(req, state, err) {
                alert("提交评论出错。");
            },
            beforeSend: function() {
                $(".publishComent-btn span.loading2").show();
                $(".scmwrap").hide();
            },
            complete: function() {
                $(".publishComent-btn span.loading2").hide();
                $(".scmwrap").show();
            }
        });
    };

    //全选
    $("#Checkbox5").change(function() {
        $(".comCheck input").attr("checked", $(this).attr("checked"))
    });

    var del = function() {
        $(".comDel input").click(function() {
            if (confirm("确认删除此评论？")) {
                var obj = $(this);
                $.ajax({
                    type: "POST",
                    data: { action: "del", id: obj.attr("rpid") },
                    success: function(data, state) {
                        var item = obj.parent().parent();
                        item.slideUp(200, function() {
                            item.remove();
                        });
                    },
                    error: function(req, state, err) {
                        alert("删除出错。");
                        obj.show().next().hide();
                    },
                    beforeSend: function() {
                        obj.hide().next().show();
                    },
                    complete: function() {

                    }
                });
            }
        });
    };
    del();
});