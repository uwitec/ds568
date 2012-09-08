$(function(){
    var tid=$("#msgtid").val();
    //设置当前选中标签
    var curmn=$(".hmenu li:first")
    if(tid){
        curmn=$(".hmenu li[tid="+tid+"]");
    }
    curmn = curmn.addClass("mn-wrap-crt").find(".mMiddle");
    curmn.html(curmn.find("a").html());
    
    var pageIndex = 0;     //页面索引初始值
    var pageSize = $("#ps").val();     //每页显示条数初始化，修改显示条数，修改这里即可  
                                                   
    //分页，PageCount是总条目数，这是必选参数，其它参数都是可选
    var pg=function(){
        $(".pagerwrap").pagination(Number($("#pc").val()), {
            callback:InitTable,
            prev_text: '上一页',       //上一页按钮里text
            next_text: '下一页',       //下一页按钮里text
            items_per_page: pageSize,  //显示条数
            num_display_entries: 6,    //连续分页主体部分分页条目数
            current_page: pageIndex,   //当前页索引
            num_edge_entries: 1        //两侧首尾分页条目数
        });
    }
    pg();
    
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
               bitclick();
               $(".ulwrap li:first").click();
            },
            error:function(req,state,err){
                $("body").append(req.responseText);
            },
            beforeSend:function(){
                $(".ulwrap").addClass("loading3").find("li").addClass("hidden")
            },
            complete:function(){
                $(".ulwrap").removeClass("loading3").find("li").removeClass("hidden")
            }
        });            
    }  
    
    InitTable(0);    //Load事件，初始化表格数据，页面索引为0（第一页）
    
    var bitclick=function(){
        $(".ulwrap>li").click(function(){
            var msgid=$(this);
            $.ajax({
                cache:false,
                data:{action:"getdetail",id:msgid.attr("msgid")},
                success:function(data,state){
                    $(".msgdetail").html(data);
                    msgid.find("span").addClass("isView");
                },
                error:function(req,state,err){
                    $(".msgdetail").html("获取数据出错。");
                },
                beforeSend:function(){
                    $(".ulwrap li").removeClass("crtitem");
                    msgid.addClass("crtitem");
                    $(".msgdetail").addClass("loading3");
                },
                complete:function(){
                    $(".msgdetail").removeClass("loading3");
                }
            });
        });
    }
    //全选
    $(".atbar input").click(function(){
        $(".ulwrap li input").attr("checked",$(this).attr("checked"));    
    });
    
    //删除
    $("#msg_del").click(function(){
        var msgids=$(".ulwrap li input[checked=true]").serialize().replace(/ch=/g,"").replace(/&/g,",");
        if(msgids=="") return;
        $.ajax({
            type:"POST",
            data:{action:"del",ids:msgids},
            success:function(data,state){
                $("#pc").val(Number($("#pc").val())-msgids.split(',').length);
                pg();
                InitTable(0);
                $(".atbar input").attr("checked","")
            },
            error:function(req,state,err){
                $(".msgdetail").html("删除出错。");
            }
        });
    });
    
    //标为已读或未读
    var chgState=function(b){
        var chkobj=$(".ulwrap li input[checked=true]")
        var msgids=chkobj.serialize().replace(/ch=/g,"").replace(/&/g,",");
        if(msgids=="") return;
        $.ajax({
            type:"POST",
            data:{action:"chgstate",ids:msgids,isview:(b?"True":"False")},
            success:function(data,state){
                if(b)
                    chkobj.each(function(){
                        $(this).next().addClass("isView")
                    });
                else
                    chkobj.each(function(){
                        $(this).next().removeClass("isView");
                    });
            },
            error:function(req,state,err){
                alert("修改状态出错。");
            }
        });
    };
    
    $("#msg_nv").click(function(){
        chgState(true)
    });
    $("#msg_hv").click(function(){
        chgState(false)
    });
    
});