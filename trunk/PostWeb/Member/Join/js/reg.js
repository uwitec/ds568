$(document).ready(function(){
    //绑定地区控件
    Area({
        trigger:$("input[name=area]"),
        eventClass:"click"
    });
   
    //-----------验证开始------------
    $.validator.addMethod("numAndChar",function(value, element){//增加验证函数(验证字母和数字组合)
             var tel = /^[A-Za-z0-9]+$/;
             return this.optional(element) || (tel.test(value));    
        },
        "只能输入字母或数字的组合"
    );	
    $.validator.addMethod("mobile",function(value, element){//增加验证函数(验证手机号码)
             var tel = /^(13|15|18)[0-9]{9}$/;
             return this.optional(element) || (tel.test(value));    
        },
        "请输入以13、15或18开头的手机号码,共11位"
    );
    
    
    $("#form1").validate({
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success:function(label){
            label.addClass("valid").text("填写正确");//成功时执行的函数
        },
        groups:{phone:"phoneqh phonehm phonefj"},
        rules:{
            email:{required:true,email:true},
            account:{required:true,rangelength:[5,15],numAndChar:true,remote:"reg.aspx"},
            password:{required:true,rangelength:[6,20],numAndChar:true},
            password2:{required:true,equalTo:"#password"},
            companyName:{required:true,minlength:4,maxlength:100},
            trueName:{required:true,minlength:2,maxlength:4},
            phoneqh:{required:true,digits:true,rangelength:[3,4]},
            phonehm:{required:true,digits:true,rangelength:[7,8]},
            phonefj:{digits:true,rangelength:[3,4]},
            mibile:{mobile:true},
            mainIndustry:{required:true,minlength:2},
            area:{required:true},
            chkCode:{required:true}
        },
        messages:{
            password2:{equalTo:"两次密码输入不一致"},
            phoneqh:{rangelength:"格式错误",digits:"格式错误"},
            phonehm:{rangelength:"格式错误",digits:"格式错误"},
            phonefj:{rangelength:"格式错误",digits:"格式错误"},
            account:{remote:"帐号已存在"}
        }
    });
    //-----------验证结束------------
    
    //提交按扭事件
    $(".subBtn").click(function(){
        $("#form1").submit();
        return false;
    });
    
});