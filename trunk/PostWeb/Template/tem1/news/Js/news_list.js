$(function(){

    var bindact=function(){
        $(".lkdel").click(function(){
            var nid=$(this).attr("nid")
            $.ajax({
                type:"POST",
                data:{action:"del",id:nid},
                success:function(data,state){
                    ispg=false;
                    InitTable(pageIndex);
                },
                error:function(req,state,err){
                    alert("删除出错。");
                    $("body").append(req.responseText);
                },
                beforeSend:function(){
                    $(".tblist").addClass("loading3").find("tr:nth-child(n+1)").addClass("hidden")
                },
                complete:function(){
                    $(".tblist").removeClass("loading3").find("tr:nth-child(n+1)").removeClass("hidden")
                }
            });
        });
    }
    
    var pageIndex = 0;     //页面索引初始值
    var pageSize = 12;     //每页显示条数初始化，修改显示条数，修改这里即可  
                                             
    //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
    var pg=function(){
        $(".pagerwrap").pagination(Number($("#rc").val()), {
            callback:InitTable,
            prev_text: '上一页',       //上一页按钮里text
            next_text: '下一页',       //下一页按钮里text
            items_per_page: pageSize,  //显示条数
            num_display_entries: 6,    //连续分页主体部分分页条目数
            current_page: pageIndex,   //当前页索引
            num_edge_entries: 1        //两侧首尾分页条目数
        });
    }
    var ispg=false;
    //翻页调用
    function PageCallback(index, jq) {   
        InitTable(index);
    }

     //请求数据
    function InitTable(pageIndex) {  
        $.ajax({ 
            type: "POST",
            data:{action:"pager",pageIndex:(pageIndex + 1),pageSize: pageSize},              
            success: function(data) {                      
               $(".newsBody ul").remove();
               $(".newsBody").append($(data).find(".newsBody ul"));
               $("#rc").val($(data).find("#rc").val());
               if(!ispg){
                   pg();
                   ispg=true;
               }
               //bindact();
            },
            error:function(req,state,err){
                $("body").append(req.responseText);
            },
            beforeSend:function(){
                $(".newsBody").addClass("loading3").find("ul").addClass("hidden")
            },
            complete:function(){
                $(".newsBody").removeClass("loading3").find("ul").removeClass("hidden")
            }
        });            
    }  
    
    InitTable(0);    //Load事件，初始化表格数据，页面索引为0（第一页）
    
    
})