$(function() {

    var id = $("#ctfid").val();
    //-----------验证开始------------

    $.validator.addMethod("ctfreq", function(value, element) {//增加验证函数(验证以字母开头，字母和数字组合)
        if (id == "") {
            return $("#ctfimg").val() != "";
        }
        return true;
    },
        "请上传证书"
    );

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
            startdate: { required: true, date: true },
            enddate: { date: true },
            issag: { required: true, minlength: 2, maxlength: 50 },
            ctfimg: { ctfreq: true, accept: "jpg,gif" },
            ctfprofile: { minlength: 10, maxlength: 500 }
        },
        messages: {
            ctfreq: { accept: "证书文件格式不正确" }
        }
    });
    //-----------验证结束------------

    var _url = "Action.ashx"


    //提交
    $(".commBtn").click(function() {
        if ($(this).hasClass("loading2")) return false;
        var b = fvalid.form();
        if (b) {
            $(".commBtn").addClass("loading2").find(".cb_m").text("数据提交中…");
            $.ajaxFileUpload({
                url: _url + "?time=" + Math.random(),
                type: "POST",
                secureuri: false,
                fileElementId: 'ctfimg',
                data: { myaction: "ctf", id: id, ctfname: $("input[name=ctfname]").val(), ctfnumber: $("input[name=ctfnumber]").val(), ctfprofile: $("textarea[name=ctfprofile]").val(), ctftype: $("select[name=ctftype]").val(), enddate: $("input[name=enddate]").val(), issphone: $("input[name=issphone]").val(), issag: $("input[name=issag]").val(), isswebsite: $("input[name=isswebsite]").val(), startdate: $("input[name=startdate]").val() },
                dataType: "json",
                success: function(data, status) {
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
                error: function(data, status, e) {
                //alert("上传失败，请检查文件格式和大小是否符合要求。");
                    $("body").append(data.responseText)
                    alert(e);
                },
                complete: function() {
                    $(".commBtn").removeClass("loading2").find(".cb_m").text("提交审核");
                }
            });
        }
    });

    function getDateTime(date) {
        var year = date.getFullYear();
        var month = date.getMonth() + 1;
        var day = date.getDate();
        var hh = date.getHours();
        var mm = date.getMinutes();
        var ss = date.getSeconds();
        return year + "-" + month + "-" + day + " " + hh + ":" + mm + ":" + ss;
    }


    if (id != "") {
        $.ajax({
            url: _url + "?time=" + Math.random(),
            type: "POST",
            data: { myaction: "getmd", id: id },
            dataType: "json",
            success: function(data) {
                $("select[name=ctftype] option[value=" + data.CtfType + "]").attr("selected", "selected")
                $("input[name=ctfname]").val(data.CtfName);
                $("input[name=startdate]").val(getDateTime(eval("new " + data.StartDate.replace(/\//g, ""))));
                if (data.EndDate)
                    $("input[name=enddate]").val(getDateTime(eval("new " + data.EndDate.replace(/\//g, ""))));
                $("input[name=ctfnumber]").val(data.CtfNumber);
                $("input[name=issag]").val(data.IssuingAgency);
                $("input[name=issphone]").val(data.IssPhone);
                $("input[name=isswebsite]").val(data.IssWebSite);
                $("textarea[name=ctfprofile]").text(data.CtfProfile);
                $("#ctf-img").attr("src", data.CtfImg).show();
            },
            error: function(req) {
                $("body").append(req.responseText)
            },
            beforeSend: function() {

            },
            complete: function() {

            }
        });
    }

})