﻿$(document).ready(function(){
    
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
            companyName:{required:true,minlength:4,maxlength:100},
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
    
    //处理管理体系认证点击
    $("input[name=MSCer]").click(function(){
        if($(this).attr("type")=="radio"){
            $("input[name=MSCer][type=text]").val('');
        }else{
            $("input[name=MSCer][type=radio]").attr("checked","");
        }
    });
    http://img04.hc360.cn/04/product/314/472/b/04-31447234.jpg
    
    //--------------还原公司信息开始---------------------
    $("select[name=Employees] option[value="+$("#HD_Employees").val()+"]").attr("selected",true);
    $("select[name=StudyEmployees] option[value="+$("#HD_StudyEmployees").val()+"]").attr("selected",true);
    $("select[name=unit] option[value="+$("#HD_unit").val()+"]").attr("selected",true);
    $("select[name=AnnualTurnover] option[value="+$("#HD_AnnualTurnover").val()+"]").attr("selected",true);
    $("select[name=AnnualImports] option[value="+$("#HD_AnnualImports").val()+"]").attr("selected",true);
    $("select[name=AnnualExport] option[value="+$("#HD_AnnualExport").val()+"]").attr("selected",true);
    $("input[name=MSCer][value="+$("#HD_MSCer").val()+"]").attr("checked","checked");
    if(!$("input[name=MSCer][value="+$("#HD_MSCer").val()+"]").attr("checked"))
        $("input[name=MSCer][type=text]").val($("#HD_MSCer").val())
    $("input[name=qc][value="+$("#HD_qc").val()+"]").attr("checked","checked");
    var mainmarket=$("#HD_mainmarket").val().split(',');
    for(var i=0;i< mainmarket.length;i++){
        $("input[name=mainmarket][value="+mainmarket[i]+"]").attr("checked","checked");
    }
    if($("#HD_oem").val()=="True")
        $("#OemOdmYes").attr("checked","checked");
    if($("#HD_oem").val()=="False")
        $("#OemOdmNo").attr("checked","checked");
    //--------------还原公司信息结束---------------------
});

 