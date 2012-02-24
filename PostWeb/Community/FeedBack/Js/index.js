$(function() {
    //更新验证码
    $("#chgvali").click(function() {
        $(".imgCode").attr("src", "/checkcode.aspx?rd=" + new Date().toTimeString());
        return false;
    });
    $("#chgvali").click();

    //-----------验证开始------------

    $.validator.addMethod("requiredOne", function(value, element, param) {//增加验证函数
        var b = true;
        $(param).each(function() {
            if ($(this).val() == "") {
                if (b)
                    b = false;
            }
        });
        return b;
    },
        "固话或手机至少填写一项"
    );

    var fvalid = $("#form1").validate({
        focusInvalid: true,
        errorPlacement: function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success: function(label) {
            label.remove();
        },
        groups: { phone: "phoneCountry phoneArea phoneNumber", email: "emailUid emailCom" },
        rules: {
            title: { required: true, minlength: 4, maxlength: 50 },
            content: { required: true, rangelength: [10, 500] },
            emailUid: { required: true },
            emailCom: { required: true },
            companyName: { required: true, minlength: 4, maxlength: 100 },
            phoneCountry: { digits: true, minlength: 2, maxlength: 2 },
            phoneArea: { digits: true, minlength: 3, maxlength: 4 },
            phoneNumber: { digits: true, minlength: 6, maxlength: 10 },
            mobile: { requiredOne: "#phoneCountry,#phoneArea,#phoneNumber", digits: true, minlength: 11, maxlength: 11 },
            valcode: { required: true, minlength: 4, maxlength: 4 }
        },
        messages: {
           
        }
    });
    //-----------验证结束------------

    $(".linkSubmit").click(function() {
        var b = fvalid.form();
        if (b) {
            $.ajax({
                url: "action.aspx?action=sendmsg&" + $("#form1").serialize(),
                cache:false,
                success: function(data, state) {
                    if(data!=""){
                        alert(data);
                        $("#chgvali").click();
                    }else
                        location = "Sendfq.aspx";
                },
                error: function(req, state, err) {
                    $("body").append(req.responseText);
                    alert("抱歉，提交留言出错。");
                },
                beforeSend: function() {
                    $(".loading2").show();
                    $(".ulBtn").hide();
                },
                complete: function() {
                    $(".loading2").hide();
                    $(".ulBtn").show();
                }
            });
        }
    });
});