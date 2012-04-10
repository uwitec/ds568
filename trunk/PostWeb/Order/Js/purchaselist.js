$(function() {

    var chgNum = function(obj, num) {
        var pid = $(obj).attr("pid");
        var data = { action: "chg_num", id: pid, num: num };
        var oid = $(obj).parent().attr("oid");
        var ind = $(obj).parent().attr("ind");
        $.ajax({
            url: "action.aspx",
            type: "POST",
            dataType: "json",
            data: data,
            success: function(data, state) {
                $("#odwp_" + ind + " .item_8").text(data.CrtProAmount);
                $("#odwp_" + ind + " .item_4").html(data.CrtPriceRang);
                $("#am_" + oid).text(data.CrtOrderAmount);
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            }
        });
    }

    $(".item_6 a").click(function() {
        var ipt = $(this).parent().find("input");
        var num = 1;
        if ($.trim($(this).text()) == "+") {
            ipt.val(Number(ipt.val()) + 1)
        } else {
            ipt.val(Number(ipt.val()) - 1);
            num = -1;
        }
        chgNum(this, num);
    });

    var crtnum = 0;
    $(".item_6 input").focus(function() {
        crtnum = $(this).val();
    }).blur(function() {
        var stn = Number($(this).val()) - Number(crtnum);
        chgNum(this, stn);
    });

    //删除
    $(".item_9 a").click(function() {

        var pid = $(this).attr("pid");
        var oid = $(this).attr("oid");
        var ind = $(this).attr("ind");
        $.ajax({
            url: "action.aspx",
            type: "POST",
            data: { action: "del", id: pid },
            dataType: "json",
            success: function(data, state) {
                if (data.CrtOrderAmount == 0) {
                    $("#odhd_" + oid + ",#odwp_" + ind + ",#odbt_" + oid).slideUp(300, function() {
                        $(this).remove();
                    });
                } else {
                    $("#am_" + oid).text(data.CrtOrderAmount);
                    $("#odwp_" + ind).slideUp(300, function() {
                        $(this).remove();
                    });
                }
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            }
        });
    });

})