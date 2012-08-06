$(function() {

    //设置选中项
    var state = $("#showType").val();
    var curmn = $(".hmenu li[state=" + state + "]").find("div").removeClass("lunsl munsl runsl");

    //删除事件
    var bindact = function() {
        $(".del").click(function() {
            var obj = $(this);
            if (obj.hasClass("loading2")) return false;
            var id = obj.attr("ctfid");
            $.ajax({
                url: "action.ashx",
                type: "POST",
                data: { myaction: "del", id: id },
                dataType: "json",
                success: function(data) {
                    obj.parent().parent().slideUp(300, function() {
                        $(this).remove();
                    });
                },
                error: function(req) {
                    alert("删除出错。");
                },
                beforeSend: function() {
                    obj.addClass("loading2").find("span").addClass("hidden");
                },
                complete: function() {
                    obj.removeClass("loading2").find("span").removeClass("hidden");
                }
            });
            return false;
        });
    }

    var pageIndex = 0;     //页面索引初始值
    var pageSize = 8;     //每页显示条数初始化，修改显示条数，修改这里即可  

    //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
    var pg = function() {
        $(".pagerwrap").pagination(Number($("#rc").val()), {
            callback: InitTable,
            prev_text: '上一页',       //上一页按钮里text
            next_text: '下一页',       //下一页按钮里text
            items_per_page: pageSize,  //显示条数
            num_display_entries: 6,    //连续分页主体部分分页条目数
            current_page: pageIndex,   //当前页索引
            num_edge_entries: 1        //两侧首尾分页条目数
        });
    }
    var ispg = false;
    //翻页调用
    function PageCallback(index, jq) {
        InitTable(index);
    }

    //请求数据
    function InitTable(pageIndex) {
        $.ajax({
            type: "POST",
            data: { action: "pager", pageIndex: (pageIndex + 1), pageSize: pageSize, showType: $("#showType").val() },
            success: function(data) {
                $(".tblist tr:nth-child(n+1)").remove();
                $(".tblist").append($(data).find(".tblist tr:nth-child(n+1)"));
                $("#rc").val($(data).find("#rc").val());
                if (!ispg) {
                    pg();
                    ispg = true;
                }
                bindact();
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            },
            beforeSend: function() {
                $(".tblist").addClass("loading3").find("tr:nth-child(n+2)").addClass("hidden")
            },
            complete: function() {
                $(".tblist").removeClass("loading3").find("tr:nth-child(n+2)").removeClass("hidden")
            }
        });
    }

    InitTable(0);    //Load事件，初始化表格数据，页面索引为0（第一页）


})