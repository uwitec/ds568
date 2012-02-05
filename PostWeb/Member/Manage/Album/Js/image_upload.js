$(document).ready(function(){
    
    //调用ajax后需要执行的事件
    var albHover=function(){
        //鼠标经过
        $(".listctn li").hover(function(){
                $(this).addClass("ab_hover").find(".albtitle").addClass("hvcl");
            },
            function(){
                $(this).removeClass("ab_hover").find(".albtitle").removeClass("hvcl");
            }
        ).click(function(){
            //location="image_list.aspx?id="+$(this).attr("aid")
        });
        
         
    }
    albHover();
    
    var pageIndex=1;//当前页
    var ajaxReq=function(_data,_beforeSend,_complete,_success){
        $.ajax({
            url:"Album_List.aspx",
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
                        data:{action:"addAlbum",albumName:albn.val(),pm:$("input[name=pm]:checked").val(),pwd:pswd.val()},
                        success:function(data,state){
                            if(Number(data)){
                                location.reload();
                            }else
                                alert(data)
                        },
                        beforeSend:function(){
                            
                        },
                        error:function(req,state,err){
                            alert("创建相册出错。"+req.responseText);
                           
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
    
    //切换上传模式
    $(".upload_type_wrap li").click(function(){
        $(".upload_type_wrap li").removeClass("current_ut");
        $(this).addClass("current_ut").find("a").blur();
    });
   
});