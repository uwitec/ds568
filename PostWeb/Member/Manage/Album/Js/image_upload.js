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
    
    //文件上传
    $("#uploadify0").uploadify({
        'uploader': '/js/uploadify/uploadify.swf',
        'script': '/js/uploadify/Upload.aspx',
        'cancelImg': '/js/uploadify/cancel.png',
        'folder': 'UploadFile',
        'queueID':'fileQueue',
        'auto': false,
        'multi':false,
        'width':'74',
        'height':'23',
        'sizeLimit':4096*1024,
        'buttonImg':'/js/uploadify/open.png',
        'fileExt':'*.jpg;*.gif;*.png;*.bmp',
        'fileDesc':'*.jpg;*.gif;*.png;*.bmp',
        'onComplete':function(event, ID, fileObj, response, data){
            fc=0;
            $("#tb0").val("");
            $(".divsub input").removeClass("chgbg").attr("disabled","disabled");
            selImg(response);
        },
        'onSelect':function(event, queueId, fileObj)
        {
            fc++;
            $("#tb0").val(fileObj.name);
            $("#clear0").attr("qid",queueId)
            $(".divsub input").addClass("chgbg").removeAttr("disabled");
        },
        'onCancel':function(event,queueId,fileObj,data){
            $("#tb0").val("")
            if(fc>0)
               fc--;
            if(fc==0)
                $(".divsub input").removeClass("chgbg").attr("disabled","disabled");
        },
        'onError':function(event,queueId,fileObj,errorObj){
            if(errorObj.type=="File Size"){
                alert("不能上传超过4MB的文件。")
                $("#tb0").val("");
            }
         
        }
   });
   
});