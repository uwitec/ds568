$(function(){
    //更新验证码
    $("#chgvali").click(function(){
        $(".imgCode").attr("src","/checkcode.aspx?rd="+new Date().toTimeString());
        return false;
    });
    $("#chgvali").click();
   
    //-----------验证开始------------
    var isvl=function(b){
        if(b){
            if($.trim($("#mobile").val())=="")
                return true;
        }else{
            if($.trim($("#phoneCountry").val())==""||$.trim($("#phoneArea").val())==""||$.trim($("#phoneNumber").val())=="")
                return true;
        }
        
        return false;
    }
    
    var fvalid=$("#form1").validate({
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success:function(label){
            label.remove();
        },
        groups:{phone:"phoneCountry phoneArea phoneNumber",email:"emailUid emailCom"},
        rules:{
            title:{required:true,minlength:4,maxlength:50},
            content:{required:true,rangelength:[10,500]},
            emailUid:{required:true},
            emailCom:{required:true},
            companyName:{required:true,minlength:4,maxlength:100},
            phoneCountry:{required:isvl(true),digits:true,minlength:2,maxlength:2},
            phoneArea:{required:isvl(true),digits:true,minlength:3,maxlength:4},
            phoneNumber:{required:isvl(true),digits:true,minlength:6,maxlength:10},
            mobile:{required:isvl(false),digits:true,minlength:11,maxlength:11},
            valcode:{required:true,minlength:4,maxlength:4}
        },
        messages:{
            phoneCountry:{required:"固话或手机至少填写一项"},
            phoneArea:{required:"固话或手机至少填写一项"},
            phoneNumber:{required:"固话或手机至少填写一项"},
            mobile:{required:"固话或手机至少填写一项"}
        }
    });
    //-----------验证结束------------
    
    $(".linkSubmit").click(function(){
        fvalid.form();
    });
});