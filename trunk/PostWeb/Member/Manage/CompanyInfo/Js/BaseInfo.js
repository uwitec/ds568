$(document).ready(function(){
    
    //-----------验证开始------------
    
    var fvalid=$(".mstForm").validate({
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
             if(element.attr("name")=="oserver")
                error.appendTo($(".osererror div")).removeClass("valid");
             else
                error.appendTo(element.parent()).removeClass("valid");  //表示添加到元素后面，
        },
        success:function(label){
            label.addClass("valid");//成功时执行的函数
        },
        groups:{ba:"busAreaDet busArea"},
        rules:{
            regArea:{required:true},
            busAreaDet:{required:true},
            busArea:{required:true},
            cName:{required:true,minlength:4,maxlength:100},
            BusType:{required:true},
            BusModel:{required:true},
            RegCapital:{required:true,number:true},
            YearEst:{required:true},
            ZipCode:{required:true,digits:true,minlength:6,maxlength:6},
            profile:{required:true,minlength:50},
            MainIndu:{required:true},
            oserver:{required:true}
        },
        messages:{
            
        }
    });
    //-----------验证结束------------
    
    //提交按扭事件
    $(".subBtn").click(function(){
        var b=fvalid.form();
        return b;
         
    });
    
    //添加注册年份
    var ya=$("#year-area").val().split('-');
    $(".YearEst").append("<option value=''>-请选择-</option>");
    for(var i=Number(ya[0]);i<=Number(ya[1]);i++){
        $(".YearEst").append("<option value='"+i+"'>"+i+"</option>");
    }
    
    //选择公司注册地
    Area({
        trigger:$(".regArea"),//设置触发对象，必选
        eventClass:"click",//设置显示触发事件为点击
        enableProvince:false,//禁用省份选择
        showAllArea:false
    });
    //选择经营地址
    Area({
        trigger:$(".busArea"),//设置触发对象，必选
        eventClass:"click",//设置显示触发事件为点击
        enableProvince:false,//禁用省份选择
        showAllArea:false
    });
    
    //主营产品更多产品
    $(".morep").click(function(){
        $(".morep,.oser").toggle();
    });
    $(".moreb").click(function(){
        $(".moreb,.bser").toggle();
    });
    
    //限制公司简介字数
    $(".profile").bind("keyup",function(){
        this.value = this.value.slice(0,1800);
    });
});

 