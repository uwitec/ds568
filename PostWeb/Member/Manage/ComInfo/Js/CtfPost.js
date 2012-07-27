$(function () {

    //-----------验证开始------------
    var fvalid = $(".mstForm").validate({
        focusInvalid: true,
        errorPlacement: function (error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success: function (label) {
            label.remove();
        },
        rules: {
            ctfname: { required: true, minlength: 2, maxlength: 50 },
            startdate: { required: true, date: true },
            enddate: { date: true },
            issag: { required: true, minlength: 2, maxlength: 50 },
            ctfimg: { required: true, accept: "jpg,gif" },
            ctfprofile: { minlength: 10, maxlength: 500 }
        },
        messages: {
            ctfimg: { required: "请上传证书", accept: "证书文件格式不正确" }
        }
    });
    //-----------验证结束------------

    var _url = "Action.ashx"

    //提交
    $(".commBtn").click(function () {
        if ($(this).hasClass("loading2")) return false;
        var b = fvalid.form();
        if (b) {
            $(".commBtn").addClass("loading2").find(".cb_m").text("数据提交中…");
            $.ajaxFileUpload({
                url: _url + "?time=" + Math.random(),
                type: "POST",
                secureuri: false,
                fileElementId: 'ctfimg',
                data: { myaction: "addctf", ctfname: $("input[name=ctfname]").val(), ctfnumber: $("input[name=ctfnumber]").val(), ctfprofile: $("textarea[name=ctfprofile]").val(), ctftype: $("select[name=ctftype]").val(), enddate: $("input[name=enddate]").val(), issphone: $("input[name=issphone]").val(), issag: $("input[name=issag]").val(), isswebsite: $("input[name=isswebsite]").val(), startdate: $("input[name=startdate]").val() },
                dataType: "json",
                success: function (data, status) {
                    if (data.succ) {
                        alert("提交成功。");
                    }
                    else if (data.lgout) {
                        alert(data.msg);
                        open("/member/login/Signin.aspx?return_url=" + location.href, "_top");
                    }
                    else {
                        alert(data.msg);
                    }
                },
                error: function (data, status, e) {
                    //alert("上传失败，请检查文件格式和大小是否符合要求。");
                    alert(e);
                },
                complete: function () {
                    $(".commBtn").removeClass("loading2").find(".cb_m").text("提交审核");
                }
            });
        }
    });


    var id = $("#ctfid").val();
    if (id != "") {
        $.ajax({
            url: _url + "?time=" + Math.random(),
            type: "POST",
            data: { action: "getmd", id: id },
            dataType: "json",
            success: function (data) {
                //$("select[name=ctftype] option[value=" + data.CtfType + "]").attr("selected", "selected")
                $("input[name=ctfname]").val(data.CtfName);alert("123")
            },
            error: function (req) {
                $("body").append(req.responseText)
            },
            beforeSend: function () {

            },
            complete: function () {

            }
        });
    }

})