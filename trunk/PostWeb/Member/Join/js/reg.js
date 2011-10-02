$(document).ready(function(){
    //绑定地区控件
    Area({
        trigger:$("input[name=area]"),//设置触发对象，必选
        eventClass:"click",//设置显示触发事件为点击
        enableProvince:false,//禁用省份选择
        showAllArea:false
    });
   
    //-----------验证开始------------
    $.validator.addMethod("numAndChar",function(value, element){//增加验证函数(验证以字母开头，字母和数字组合)
             var tel = /^[A-Za-z]\w+$/;
             return this.optional(element) || (tel.test(value));    
        },
        "只能输入以字母开头的数字或字母组合"
    );	
    $.validator.addMethod("pwd",function(value, element){//增加验证函数(验证字母和数字组合)
             var tel = /^[A-Za-z0-9]+$/;
             return this.optional(element) || (tel.test(value));    
        },
        "只能输入数字或字母的组合"
    );	
    $.validator.addMethod("mobile",function(value, element){//增加验证函数(验证手机号码)
             var tel = /^(13|15|18)[0-9]{9}$/;
             return this.optional(element) || (tel.test(value));    
        },
        "请输入正确的手机号码"
    );
   
    
    var fvalid=$("#form1").validate({
        //onkeyup:false,//为true时，当ajax远程验证时此选项会增加服务器负荷
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success:function(label){
            //label.addClass("valid").text("填写正确");//成功时执行的函数
        },
        groups:{phone:"phoneqh phonehm phonefj"},
        rules:{
            email:{required:true,email:true},
            account:{required:true,rangelength:[5,15],numAndChar:true,remote:"reg.aspx"},
            password:{required:true,rangelength:[6,20],pwd:true},
            password2:{required:true,rangelength:[6,20],pwd:true,equalTo:"#password"},
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
            account:{remote:"登录名已存在"}
        }
    });
    //-----------验证结束------------
    
    //提交按扭事件
    $(".subBtn").click(function(){
        var b=fvalid.form();
        if(!b){
            using("messager",function(){
               $.messager.alert('系统提示','尚有信息未通过验证，请检查。',"info");
            });
        }
        return b;
         
    });
    
    //更换验证码
    $(".ccImg").attr("src","/checkcode.aspx?se="+Math.random())
    $(".chgCC").click(function(){
        $(".ccImg").attr("src","/checkcode.aspx?se="+Math.random())
    });
});