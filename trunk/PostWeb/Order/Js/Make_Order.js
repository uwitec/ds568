$(function() {

    //-----------验证开始------------
    $.validator.addMethod("chkone", function(value, element) {//手机和固话必填一项
        if ($(".phone").val().replace("区号-电话号码-分机", "") == "" && $(".mobile").val() == "") {
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

    $.validator.addMethod("varea", function(value, element) {//验证地区
        if ($("select[name=province]").val() == "" || $("select[name=city]").val() == "" || $("select[name=town]").val() == "") {
            return false;
        } else
            return true;
    },
        "请选择完整的地区"
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
        groups: { phone: "phone mobile", area: "province city town" },
        rules: {
            zipcode: { required: true, digits: true, minlength: 6, maxlength: 6 },
            street: { required: true, minlength: 5, maxlength: 100 },
            username: { required: true, minlength: 2, maxlength: 4 },
            phone: { phone: true, chkone: true },
            mobile: { vmobile: true, chkone: true },
            province: { varea: true },
            city: { varea: true },
            town: { varea: true }
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
    $(".a_l_chk input:last").click();

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
        if (b) {
            $.ajax({
            url: "action.aspx?action=sub_order&" + $("#form1").serialize(),
                cache:false,
                dataType: "json",
                success: function(data, state) {
                    if (data.succe) {
                        location = "Show_Msg.aspx"
                    } else {
                        alert(data.msg);
                    }
                },
                error: function(req, state, err) {
                    $("body").append(req.responseText);
                },
                beforeSend: function() {

                }
            });
        }
        return false;
    });

    //地区选择
    $("select[name=province],select[name=city]").change(function() {
        var id = $(this).val().split(',')[1];
        var obj = $("select[name=town]");
        obj[0].options.length = 1;
        if ($(this).attr("name") == "province") {
            obj = $("select[name=city]");
            obj[0].options.length = 1;
        }
        $.ajax({
            url: "action.aspx",
            data: { action: "chgarea", id: id },
            dataType: "json",
            success: function(data, state) {
                $.each(data, function(ind, area) {
                    obj[0].options[ind + 1] = new Option(area.AreaName, area.AreaName+","+area.ID);
                });
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            }
        });
    });


});