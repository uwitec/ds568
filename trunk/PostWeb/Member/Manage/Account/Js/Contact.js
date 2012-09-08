$(document).ready(function () {

    //-----------验证开始------------
    $.validator.addMethod("numAndChar", function (value, element) {//增加验证函数(验证以字母开头，字母和数字组合)
        var tel = /^[A-Za-z]\w+$/;
        return this.optional(element) || (tel.test(value));
    },
        "只能输入以字母开头的数字或字母组合"
    );
    $.validator.addMethod("pwd", function (value, element) {//增加验证函数(验证字母和数字组合)
        var tel = /^[A-Za-z0-9]+$/;
        return this.optional(element) || (tel.test(value));
    },
        "只能输入数字或字母的组合"
    );
    $.validator.addMethod("mobile", function (value, element) {//增加验证函数(验证手机号码)
        var tel = /^(13|15|18)[0-9]{9}$/;
        return this.optional(element) || (tel.test(value));
    },
        "请输入正确的手机号码"
    );

    var fvalid = $("#form1").validate({
        //onkeyup:false,//为true时，当ajax远程验证时此选项会增加服务器负荷
        focusInvalid: true,
        errorPlacement: function (error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success: function (label) {
            //label.addClass("valid").text("填写正确");//成功时执行的函数
        },
        groups: { phone: "phoneqh phonehm phonefj", fax: "faxqh faxhm faxfj" },
        rules: {
            email: { required: true, email: true },
            trueName: { required: true, minlength: 2, maxlength: 4 },
            sex: { required: true },
            position: { required: true, minlength: 2 },
            phoneqh: { required: true, digits: true, rangelength: [3, 4] },
            phonehm: { required: true, digits: true, rangelength: [7, 8] },
            phonefj: { digits: true, rangelength: [3, 4] },
            mibile: { mobile: true },
            faxqh: { digits: true, rangelength: [3, 4] },
            faxhm: { required: function () {
                return $.trim($("input[name=faxqh]").val()) != "";
            }, digits: true, rangelength: [7, 8]
            },
            faxfj: { digits: true, rangelength: [3, 4] },
            webSite: { url: true },
            qq: { required: true, digits: true, rangelength: [6, 15] }
        },
        messages: {
            phoneqh: { rangelength: "格式错误", digits: "格式错误" },
            phonehm: { rangelength: "格式错误", digits: "格式错误" },
            phonefj: { rangelength: "格式错误", digits: "格式错误" },
            faxqh: { rangelength: "格式错误", digits: "格式错误" },
            faxhm: { rangelength: "格式错误", digits: "格式错误" },
            faxfj: { rangelength: "格式错误", digits: "格式错误" },
            qq: { digits: "QQ号码必须为数字" }
        }
    });
    //-----------验证结束------------

    //提交按扭事件
    $(".subBtn").click(function () {
        var b = fvalid.form();
        if (b) {
            $.ajax({
                url: "?action=save&" + $(".ctList input").serialize(),
                cache: false,
                dataType: "json",
                success: function (data, state) {
                    if (data.succ) {
                        alert("保存成功。");
                    } else {
                        alert(data.msg)
                    }
                },
                error: function (req, state, err) {
                    alert("系统发生意外，保存出错。");
                },
                beforeSend: function () {
                    $(".subBtn,#subload").toggle();
                },
                complete: function () {
                    $(".subBtn,#subload").toggle();
                }
            });
        }
    });

    //切换标签
    $(".hmenu li").not(":last").click(function () {
        var ind = $(".hmenu li").removeClass("mn-wrap-crt").index(this);
        $(this).addClass("mn-wrap-crt");
        $(".ctList,.atater").hide().eq(ind).show();
    });

    //上传头像
    $("#lk_up").click(function () {
        open("/member/avater/upload_avater.aspx", "_blank");
    });
    opencallBack = function (src) {
        $(".atater_img img").attr("src", src);

        $(".up_tips_h span").text(function () {
            if ($(this).text().indexOf('还没有') > 0) {
                $(".up_tips_h a").text('点此修改');
                return "不满意自己的头像，请 "
            }
            return $(this).text();
        });
    }

});