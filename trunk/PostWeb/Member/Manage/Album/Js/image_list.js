$(document).ready(function(){
    //绑定修改相册
    $(".edit_alb2").click(function(){
        var alb=$(this)
        wb=$(this).wBox({
            title: "修改相册属性",
            target:".wbwrap",
            show:true,
            callBack:function(){
                var albn=$(".albumName").eq(1);
                var pswd=$(".pmpsd").eq(1);
                //修改时还原各项的值
                albn.val(alb.attr("an"));
                pswd.val(alb.attr("pwd"));
                $("input[name=pm][value="+alb.attr("pm")+"]").eq(1).attr("checked","checked");
                if(alb.attr("pm")=="1")
                    $(".psw").show();
                else
                    $(".psw").hide();
                $(".btnsub").eq(1).click(function(){
                    if(albn.val().trim()==""){
                        alert("请输入相册名称。");
                        return;
                    }
                    if($("input[name=pm]:checked").val()=="1"&&$(".pmpsd").eq(1).val().trim()==""){
                        alert("请输入访问密码。");
                        return;
                    }
                    $.ajax({
                        url:"Album_List.aspx",
                        type:"POST",
                        data:{action:"editAlbum",albumName:albn.val(),pm:$("input[name=pm]:checked").val(),pwd:pswd.val(),id:alb.attr("aid")},
                        success:function(data,state){
                            if(Number(data)){
                                wb.close();
                                $(".albname").text(albn.val());
                                alb.attr("an",albn.val());
                                alb.attr("pwd",pswd.val());
                                alb.attr("pm",$("input[name=pm]:checked").val());
                                $(".permiss").text($("label[for="+$("input[name=pm]:checked").attr("id")+"]").eq(1).text());
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
    
    //根据是否选择了访问密码，显示或隐藏密码输入框
    $("input[name=pm]").click(function(){
        if($(this).val()=="1"){
            $(".psw").show()
        }else
            $(".psw").hide();
    });
    
    //全选
    $("#chk_all").click(function(){
        $(".imgname input").attr("checked",$(this).attr("checked"));
    });
    
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
        data.id=$("#alb_id").val();
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
                $(".img_list").addClass("loading").find("li").css("visibility","hidden");
            },
            function(){
                $(".img_list").removeClass("loading").find("li").css("visibility","visible");
                imghover();
            },
            function(_data){
                $(".img_list li").remove();
                $(".img_list").append($(_data).find(".img_list li"));
                //albHover();
              
            }
        );
        return false;
    });
    
    //跳转到第几页
    $("#jump").click(function(){
        var ind=Number($("#pgbox").val());
        if(ind||ind==0){
            if(ind>0&&ind<=Number($("#pgcount").text())){
                pageIndex=ind+1;
                $("#pre").click();
            }else
                alert("页码超出范围。");
        }
    });
    
    
    var imghover=function(){
        //显示或隐藏设置封面
        $(".ctnimg").hover(function(){
                $(this).find(".setcovert").show();
            },
            function(){
                $(this).find(".setcovert").hide();
            }
        );
        
        //点击设置为封面
        $(".setcovert").click(function(){
            var _src=$(this).parent().find("img").attr("src");
            $.ajax({
                type:"POST",
                data:{action:"setcovert",albumid:$("#alb_id").val(),src:_src},
                success:function(){
                    $("#imgcovert").attr("src",_src);
                },
                error:function(req,state,err){
                    alert("设置封面出错。");
                },
                beforeSend:function(){
                    
                }
            });
        });
        
        //点击图片进入图片详细
        $(".img_ctn").click(function(){
            location="Image_Detail.aspx?img_id="+$(this).attr("imgid");
        });
    }
    imghover();
    
    //删除
    $(".img_del").click(function(){
        var ids="";
        $(".imgname input").each(function(){
            if($(this).attr("checked"))
                ids+=$(this).attr("imgid")+",";
        });
        if(ids==""){
            alert("请选择要删除的图片。");
            return;
        }
        if(!confirm("您确定要删除选中的图片吗？\n\r图片删除后将不可恢复。")) return;
        $.ajax({
            type:"POST",
            data:{action:"del",id:ids,albumid:$("#alb_id").val()},
            success:function(data,state){
                if(Number(data)){
                    $("#pgcount").text(data);
                    if(pageIndex>Number(data))
                        pageIndex=Number(data)+1;
                    else
                        pageIndex++;
                    $("#pre").click();
                }else
                    alert(data);
            },
            error:function(req,state,err){
                alert("删除出错。");
                $("body").append(req.responseText);
            },
            beforeSend:function(){
                $(".img_list").addClass("loading").find("li").css("visibility","hidden");
            },
            complete:function(){
                $(".img_list").removeClass("loading").find("li").css("visibility","visible");
            }
            
        });
    });
    
    //移动
    $(".img_move").click(function(){
        alert("移动功能尚未完善，请稍后使用。")
    });
    
});