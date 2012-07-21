﻿$(function() {

    //-----------验证开始------------
    var fvalid = $(".mstForm").validate({
        focusInvalid: true,
        errorPlacement: function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success: function(label) {
            label.remove();
        },
        rules: {
            ctfname: { required: true, minlength: 2, maxlength: 50 },
            startdate: { required: true, dateISO: true },
            enddate: { dateISO: true },
            issag: { required: true, minlength: 2, maxlength: 50 },
            ctfimg: { required: true, accept: "jpg,gif" },
            ctfprofile: { minlength: 10, maxlength: 500 }
        },
        messages: {
            ctfimg: { required: "请上传证书", accept: "证书文件格式不正确" }
        }
    });
    //-----------验证结束------------

    //提交
    $(".commBtn").click(function() {
    var b = fvalid.form();
        if (b) {
            $.ajaxFileUpload({
                url: "Action.ashx?time=" + Math.random(),
                type: "POST",
                secureuri: false,
                fileElementId: 'ctfimg',
                data: { myaction: "upload" },
                dataType: "json",
                success: function(data, status) {
                    if (data.succ) {
                        alert(data.fileName)
                    }
                    else if (data.lgout) {
                        alert(data.msg);
                        open("/member/login/Signin.aspx?return_url="+location.href, "_top");
                    }
                    else {
                        alert(data.msg);
                    }
                },
                error: function(data, status, e) {
                    alert("上传失败，请检查文件格式和大小是否符合要求。");

                },
                complete: function() {
                    //alert("1");
                }
            });
        }
    });
})