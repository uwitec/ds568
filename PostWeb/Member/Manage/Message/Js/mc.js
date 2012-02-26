$(function(){
    var tid=$("#msgtid").val();
    //设置当前选中标签
    var curmn=$(".hmenu li:first")
    if(tid){
        curmn=$(".hmenu li[tid="+tid+"]");
    } 
    curmn=curmn.find("div").removeClass("lunsl munsl runsl").filter(".mMiddle");
    curmn.html(curmn.find("a").html());
    
    var pageIndex = 0;     //页面索引初始值
    var pageSize = $("#ps").val();     //每页显示条数初始化，修改显示条数，修改这里即可  
                                                   
    //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
    $(".pagerwrap").pagination(Number($("#pc").val()), {
        callback:InitTable,
        prev_text: '上一页',       //上一页按钮里text
        next_text: '下一页',       //下一页按钮里text
        items_per_page: pageSize,  //显示条数
        num_display_entries: 6,    //连续分页主体部分分页条目数
        current_page: pageIndex,   //当前页索引
        num_edge_entries: 1        //两侧首尾分页条目数
    });
        
    //翻页调用
    function PageCallback(index, jq) {   
        InitTable(index);
    }

    //请求数据
    function InitTable(pageIndex) {  
        $.ajax({ 
            type: "POST",
            data:{action:"pager",pageIndex:(pageIndex + 1),pageSize: pageSize,tid:$("#msgtid").val()},              
            success: function(data) {                      
               $(".ulwrap li").remove();
               $(".ulwrap").append($(data).find(".ulwrap li"));
            },
            error:function(req,state,err){
                $("body").append(req.responseText);
            }
        });            
    }  
    
    InitTable(0);    //Load事件，初始化表格数据，页面索引为0（第一页）
});