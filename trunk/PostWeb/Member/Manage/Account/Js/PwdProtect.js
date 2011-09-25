$(document).ready(function(){
    
    //-----------验证开始------------
    var fvalid=$(".mstForm").validate({
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success:function(label){
            label.addClass("valid").text("填写正确");//成功时执行的函数
        },
       
        rules:{
            passsafe_question:{required:true},
            otherQuestion:{required:function(){
                    if($(".safeQuestion").val()=="7")
                        return true;
                    else
                        return false;
                }
            },
            answer:{required:true,rangelength:[2,20]},
            answer2:{required:true,rangelength:[2,20],equalTo:"#answer"}
        },
        messages:{
            answer2:{equalTo:"两次密保答案输入不一致"}
        }
    });
    //-----------验证结束------------
    
    //提交按扭事件
    $(".subBtn").click(function(){
        var b=fvalid.form();
        return b;
         
    });
    
    //选择问题事件
    $(".safeQuestion").change(function(){
        if($(this).val()=="7")
            $(".ctnOq").show();
        else
            $(".ctnOq").hide();
    });
    $(".safeQuestion").change();
    
    //禁止确认密保框进行粘贴
    $("#answer2").bind("paste",function(){
        return false;
    });
    
    $("#chgquestion").click(function(){
        using("window",function(){
            $("#popwindow").css("display","block")
            $("#popwindow").window({
                collapsible:false,
                minimizable:false,
                maximizable:false,
                modal:true,
                title:"密保问题",
                draggable:false,
             
                tools:[{
                    iconCls:'icon-add',
                    handler:function(){
                        alert('add');
                    }
                },{
                    iconCls:'icon-remove',
                    handler:function(){
                        alert('remove');
                    }
                }]
            });
            
        });
    });
 
});

window.vlsucc=function(){
    $(".ctList").hide();
    $(".validSuccess").show();
}

 