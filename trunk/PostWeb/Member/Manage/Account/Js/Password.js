$(document).ready(function(){
    
    //-----------验证开始------------
    $.validator.addMethod("pwd",function(value, element){//增加验证函数(验证字母和数字组合)
             var tel = /^[A-Za-z0-9]+$/;
             return this.optional(element) || (tel.test(value));    
        },
        "只能输入数字或字母的组合"
    );	
    
    var fvalid=$(".mstForm").validate({
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success:function(label){
            label.addClass("valid").text("填写正确");//成功时执行的函数
        },
       
        rules:{
            pwd:{required:true,rangelength:[6,20],pwd:true},
            npwd:{required:true,rangelength:[6,20],pwd:true},
            npwd2:{required:true,rangelength:[6,20],pwd:true,equalTo:"#npwd"}
        },
        messages:{
            npwd2:{equalTo:"两次新密码输入不一致"}
        }
    });
    //-----------验证结束------------
    
    //提交按扭事件
    $(".subBtn").click(function(){
        var b=fvalid.form();
        return b;
         
    });
    
});

 