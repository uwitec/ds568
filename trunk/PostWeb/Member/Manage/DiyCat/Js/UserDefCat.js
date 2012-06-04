$(document).ready(function () {
    //添加分类

    $("#btnAdd").wBox({
        title: "添加分类",
        target: "#divadd",
        show:false
    });


    var ajaxAction = function (subData, succ, before) {
        $.ajax({
            url: "userdefcat.aspx",
            type: "POST",
            data: subData,
            beforeSend: function () {
                before(true);
            },
            success: function (data, state) {
                $(".tblist tr:nth-child(n+2)").remove();
                $(".tblist").append($(data).find(".tblist tr:nth-child(n+2)"));
                succ();
            },
            error: function (req, state, throwerror) {
                var estr = req.responseText;
                estr = estr.substring(0, estr.indexOf("</title>"));
                alert(estr.substring(estr.indexOf("<title>") + "<title>".length));
            },
            complete: function () {
                before(false);
            }
        });
    }

    //添加前后动作
    var addBefore = function (b) {
        if (b) {//显示加载
            $("#divadd ul li").css("visibility", "hidden");
            $("#divadd ul").addClass("loading");
        } else {//隐藏加载
            $("#divadd ul li").css("visibility", "visible");
            $("#divadd ul").removeClass("loading");
        }
    }

    $(".btnsub").click(function () {
        var cn = $.trim($(".catname").eq(1).val());
        if (cn != "") {
            ajaxAction({ "action": "add", "catname": cn }, function () { wb.close(); bindAct(); }, addBefore);
        }
    });

    //删除前后动作
    var delBefore = function (b) {
        if (b) {//显示加载
            $(".tblist tr:nth-child(n+2)").css("visibility", "hidden");
            $(".tblist").addClass("loading");
        } else {//隐藏加载
            $(".tblist tr:nth-child(n+2)").css("visibility", "visible");
            $(".tblist").removeClass("loading");
        }
    }

    //绑定修改删除
    var bindAct = function () {
        $(".lkdel").click(function () {
            if (confirm("确认删除此分类吗？")) {
                var cid = $(this).attr("catid")
                ajaxAction({ "action": "del", "cid": cid }, function () {
                    bindAct();
                }, delBefore);
            }
            return false;
        });

        //修改
        $(".lkedit").click(function () {
            var cn = $("#ctname_" + $(this).parent().attr("ind"));
            cn.removeClass("ctname");
            $(this).parent().parent().find("div").toggle();
            return false;
        });

        //取消
        $(".lkcancel").click(function () {
            var cn = $("#ctname_" + $(this).parent().attr("ind"));
            cn.addClass("ctname");
            cn.val(cn.attr("defaultValue"));
            $(this).parent().parent().find("div").toggle();
            return false;
        });


        //更新
        $(".lkupdate").click(function () {
            var cn = $.trim($("#ctname_" + $(this).parent().attr("ind")).val());
            if (cn != "") {
                ajaxAction({ action: "update", cid: $(this).attr("cid"), catname: cn }, function () {
                    bindAct();
                }, delBefore);
            } else
                alert("输入分类名称？");
            return false;
        });
    };
    bindAct();



});