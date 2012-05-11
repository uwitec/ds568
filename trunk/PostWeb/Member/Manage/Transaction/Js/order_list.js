$(function() {
    var pageIndex = 0;     //页面索引初始值
    var pageSize = 3;    //每页显示条数初始化，修改显示条数，修改这里即可  
    var ispost = false;   //开关调用分页
    //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
    $(".pagerwrap").pagination(Number($("#rc").val()), {
        callback: PageCallback,
        prev_text: '上一页',       //上一页按钮里text
        next_text: '下一页',       //下一页按钮里text
        items_per_page: pageSize,  //显示条数
        num_display_entries: 6,    //连续分页主体部分分页条目数
        current_page: pageIndex,   //当前页索引
        num_edge_entries: 1        //两侧首尾分页条目数
    });
    ispost = true;

    //翻页调用
    function PageCallback(index, jq) {
        if (ispost)
            InitTable(index);
    }

    //请求数据
    function InitTable(pageIndex) {
        $.ajax({
            type: "POST",
            data: { action: "pager", pageIndex: (pageIndex + 1), pageSize: pageSize, orderNum: $("#orderNum").val(), orderState: $("#orderState").val(), startDate: $("#startDate").val(), endDate: $("#endDate").val(), proName: $("#proName").val() },
            success: function(data) {
                $(".tblist tr:nth-child(n+2)").remove();
                $(".tblist").append($(data).find(".tblist tr:nth-child(n+2)"));
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            },
            beforeSend: function() {
                $(".tblist").addClass("loading3").find("tr:nth-child(n+2)").addClass("hidden");
            },
            complete: function() {
                $(".tblist").removeClass("loading3").find("tr:nth-child(n+2)").removeClass("hidden");
            }
        });
    }

    //搜索
    $("#btnSearch").click(function() {
        location = "?" + $(".scctn ul input").serialize();
    });

    //设定搜索时间：三天，一周，一个月
    $("#threeDay,#week,#month").click(function() {
        var date = new Date();
        $("input[name=endDate]").val(date.getFullYear() + "-" + (date.getMonth()+1) + "-" + date.getDate());
        date.setDate(date.getDate() - $(this).attr("day"));
        $("input[name=startDate]").val(date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate());
    });

});