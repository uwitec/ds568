$(document).ready(function(){
    
    //调用ajax后需要执行的事件
    var albHover=function(){
        //鼠标经过
        $(".listctn li").hover(function(){
                $(this).addClass("ab_hover").find(".albbg span").css("display","block");
                $(this).find(".albtitle").addClass("hvcl");
            },
            function(){
                $(this).removeClass("ab_hover").find(".albbg span").css("display","none");
                $(this).find(".albtitle").removeClass("hvcl");
            }
        );
        
        //绑定修改相册
        $(".edit_alb").click(function(){
            wb=$(this).wBox({
                title: "修改相册属性",
                target:".wbwrap",
                show:true
            });
            return false;
        });
        
        //绑定删除相册
        $(".del_alb").click(function(){
            if(confirm("确定删除["+$(this).attr("an")+"]吗？")){
                $.ajax({
                    type:"POST",
                    data:{action:"del",aid:$(this).attr("aid")},
                    success:function(data,state){
                        if(Number(data)){
                            $("#pgcount").text(data)
                            pageIndex++;
                            $("#pre").click();
                        }else
                            alert(data);
                    }
                });
            }
        });
    }
    albHover();
    
    var pageIndex=1;//当前页
    var ajaxReq=function(_data,_beforeSend,_complete,_success){
        $.ajax({
            type:"POST",
            data:_data,
            success:function(data,state){
                _success(data);
            },
            beforeSend:function(){
                _beforeSend();
            },
            error:function(req,state,err){
                alert("出错");
                //$("body").append(req.responseText)
            },
            complete:function(){
                _complete();
            }
        });
    }
   
    //上一页下一页
    $("#pre,#next").click(function(){
        var data={};
        data.action="chgPage";
        var b=false;//记录是否是第一页或最后一页
        if($(this).attr("id")=="pre"){//如果是上一页
            if(pageIndex>1){
                data.pgind=--pageIndex;
                b=true;
            }
        }else{//如果是下一页
            if(pageIndex<Number($("#pgcount").text())){
                data.pgind=++pageIndex;
                b=true;
            }
        }
        if(!b) return;//如果已经是第一页或最后一页则不执行下面分页代码
        $("#ctpind").text(pageIndex)
        ajaxReq(data,function(){
                $(".listctn").addClass("loading").find("li").css("visibility","hidden");
            },
            function(){
                $(".listctn").removeClass("loading").find("li").css("visibility","visible");
            },
            function(_data){
                $(".listctn li").remove();
                $(".listctn").append($(_data).find(".listctn li"));
                albHover();
              
            }
        );
        return false;
    });
    
    //添加相册
    $("#addAlbum").click(function(){
        wb=$(this).wBox({
            title: "创建相册",
            target:".wbwrap",
            show:true,
            callBack:function(){
                var albn=$(".albumName").eq(1);
                var pswd=$(".pmpsd").eq(1);
                //添加时清空各项的值
                albn.val('');
                pswd.val('');
                $("input[name=pm]").eq(3).attr("checked","checked");
                
                $(".btnsub").eq(1).click(function(){
                    if(albn.val().trim()==""){
                        alert("请输入相册名称。");
                        return;
                    }
                    $.ajax({
                        type:"POST",
                        data:{action:"addAlbum",albumName:albn.val(),pm:$("input[name=pm]:checked").val(),pwd:pswd.val()},
                        success:function(data,state){
                            if(Number(data)){
                                $("#pgcount").text(data)
                                wb.close();
                                pageIndex=2;
                                $("#pre").click();
                                
                            }else
                                alert(data)
                        },
                        beforeSend:function(){
                            
                        },
                        error:function(req,state,err){
                            alert(req.responseText);
                           
                        }
                    });
                });
            }
        });
        return false;
    });
    
   
});