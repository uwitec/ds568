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
            mobile:{required:true,equalTo:".cmobile"},
            valiCode:{required:true,minlength:6,maxlength:6}
        },
        messages:{
            mobile:{equalTo:function(){
                         if($(".cmobile").val()=="") 
                            return "尚未获取验证码，请点击发送验证码";
                         else
                            return "您的手机号码发生了更改，请重新获取验证码"
                     }
                 },
           valiCode:{minlength:"请输入6位验证码",maxlength:"请输入6位验证码"}
        }
    });
    //-----------验证结束------------
    
    //提交按扭事件
    $(".subBtn").click(function(){
        var b=fvalid.form();
        return b;
         
    });
    
    //验证框焦点获取事件
    $("#valiCode").focus(function(){
        if($(this).val()==$(this).attr("defaultValue")){
            $(this).val('').removeClass("gray");
        }
    }).blur(function(){
        if($.trim($(this).val())==''){
            $(this).val($(this).attr("defaultValue")).addClass("gray");
        }
    });
    
    //发送验证码
    var isSending=false;
    $(".sendCC").click(function(){
        
        if(isSending) return;
        $(".cmobile").val($("#mobile").val());//保存当前mobile地址
        $.ajax({
            url: 'MobileValidate.aspx?action=vlmobile&mobile='+$("#mobile").val(),
            type: 'GET',
            timeout: 30000,
            cache:false,
            error: function(){
                using("messager",function(){$.messager.alert("系统提示","发送验证码错误，可尝试重新发送。","error")});
            },
            success: function(xml){
                using("messager",function(){$.messager.alert("系统提示","验证码已发送，请查看手机信息。","info")});
            },
            complete:function(){
               $(".sendCC").text("重新发送");
               isSending=false;
            }
        });
    }).ajaxStart(function(){
        isSending=true;
        $(this).text("正在发送验证码。。。")
    });
});

//验证成功后执行的事件
window.vlsucc= function(){
    $(".ctList").hide();
    $(".validSuccess").show();
}

//取消验证事件
window.cancelValidate= function(){
    $(".ctList").hide();
    $(".cancelValidate").show();
}