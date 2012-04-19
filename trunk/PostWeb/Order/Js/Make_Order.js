$(function() {

    //-----------验证开始------------
    $.validator.addMethod("chkone", function(value, element) {//手机和固话必填一项
        if ($(".phone").val().replace("区号-电话号码-分机","") == "" && $(".mobile").val() == "") {
            return false;
        } else
            return true;
    },
        "电话和手机至少填写一项"
    );
    $.validator.addMethod("phone", function(value, element) {//验证固话
        if (value != "区号-电话号码-分机") {
            var tel = /(^\d{3,4}-\d{7,8}$)|(^\d{3,4}-\d{7,8}-\d{3,4}$)/;
            return this.optional(element) || (tel.test(value));
        } else
            return true;
    },
        "请输入正确的电话格式，如：0755-82350911或0755-82350911-6878"
    );
    $.validator.addMethod("vmobile", function(value, element) {//验证手机
        var tel = /^(13|15|18)[0-9]{9}$/;
        return this.optional(element) || (tel.test(value));
    },
        "请输入正确的手机号码"
    );


    var fvalid = $("#form1").validate({
        //onkeyup:false,//为true时，当ajax远程验证时此选项会增加服务器负荷
        focusInvalid: true,
        errorPlacement: function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success: function(label) {
            label.remove();
        },
        groups: { phone: "phone mobile" },
        rules: {
            zipcode: { required: true, digits: true, minlength: 5, maxlength: 5 },
            street: { required: true, minlength: 5, maxlength: 100 },
            username: { required: true, minlength: 2, maxlength: 4 },
            phone: { phone: true, chkone: true },
            mobile: { vmobile: true, chkone: true }
        },
        messages: {
            phone: {}
        }
    });
    //-----------验证结束------------


    $(".a_l_chk input").click(function() {
        $(".address_list").removeClass("crt_ads");
        $("#ads_lt_" + $(this).attr("ind")).addClass("crt_ads");
        if (this.id == "a_l_chk_other") {
            $(".ads_det_item,.chk_body_right").show();
        } else
            $(".ads_det_item,.chk_body_right").hide();
    });

    $(".btm_m textarea").text(function() {
        return $(this).attr("dv")
    }).focus(function() {
        if ($(this).text() == $(this).attr("dv"))
            $(this).text('').css("color", "#555");
    }).blur(function() {
        if ($.trim($(this).text()) == "")
            $(this).text($(this).attr("dv")).css("color", "gray");
    });

    $(".phone").val(function() {
        return $(this).attr("dv")
    }).focus(function() {
        if ($(this).val() == $(this).attr("dv"))
            $(this).val('').css("color", "#555");
    }).blur(function() {
        if ($.trim($(this).val()) == "")
            $(this).val($(this).attr("dv")).css("color", "gray");
    });

    $(".make_order").click(function() {
        var b = fvalid.form();

        return false;
    });

});