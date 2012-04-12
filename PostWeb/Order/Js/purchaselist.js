$(function() {

    var chgNum = function(obj, num) {
        var pid = $(obj).attr("pid");
        var data = { action: "chg_num", id: pid, num: num };
        var oid = $(obj).parent().attr("oid");
        var ind = $(obj).parent().attr("ind");
        var mdw = $("#mdw_" + oid + " .pro_item_wrap[ind=" + ind + "]");
        $.ajax({
            url: "action.aspx",
            type: "POST",
            dataType: "json",
            data: data,
            success: function(data, state) {
                mdw.find(".item_8").text(data.CrtProAmount);
                mdw.find(".item_4").html(data.CrtPriceRang);
                var cam = 0;
                $("#mdw_" + oid + " .item_1 input").not(":checked").each(function() { 
                    cam+=Number($(this).parent().parent().find(".item_8").text());
                });
                
                $("#am_" + oid).text(data.CrtOrderAmount-cam);
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            }
        });
    }

    $(".item_6 a").click(function() {
        if ($(this).attr("disabled")) return;
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
        var mdw = $("#mdw_" + oid + " .pro_item_wrap[ind=" + ind + "]");
        $.ajax({
            url: "action.aspx",
            type: "POST",
            data: { action: "del", id: pid },
            dataType: "json",
            success: function(data, state) {
                if (data.CrtOrderAmount == 0) {
                    $("#odhd_" + oid + ",#mdw_" + oid + ",#odbt_" + oid).slideUp(300, function() {
                        $(this).remove();
                    });
                } else {
                    var cam = 0;
                    $("#mdw_" + oid + " .item_1 input").not(":checked").each(function() {
                        cam += Number($(this).parent().parent().find(".item_8").text());
                    });
                    $("#am_" + oid).text(data.CrtOrderAmount-cam);
                    mdw.slideUp(300, function() {
                        $(this).remove();
                    });
                }
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            }
        });
    });

    var chkclick = function(obj) {
        var ind = $(obj).attr("ind");
        var oid = $(obj).attr("oid");
        var mdw = $("#mdw_" + oid + " .pro_item_wrap[ind=" + ind + "]");
        var amount = Number($("#am_" + oid).text()); //当前订单总额
        var cam = Number(mdw.find(".item_8").text()); //当前产品项金额
        if (!$(obj).attr("checked")) {
            $("#odbt_" + oid + " .btm_left input").removeAttr("checked");
            mdw.css("background-color", "#f0f0f0");
            mdw.find(".item_6 a").attr("disabled", "disabled");
            $("#am_" + oid).text(amount - cam);
        } else {
            mdw.css("background-color", "#e2f2ff");
            mdw.find(".item_6 a").removeAttr("disabled");
            $("#am_" + oid).text(amount + cam);
        }
    }

    //全选
    $(".btm_left input").click(function() {
        var oid = $(this).attr("oid");
        if ($(this).attr("checked"))
            $("#am_" + oid).text("0");
        $(".item_1 input[oid=" + oid + "]").attr("checked", $(this).attr("checked")).each(function() {
            chkclick(this)
        });
    });

    $(".item_1 input").click(function() {
        chkclick(this)
    });

    //删除所选
    $(".del_chk").click(function() {
        var oid = $(this).attr("oid");
        var mdw = $("#mdw_" + oid + " .pro_item_wrap");
        mdw.find(".item_1 input:checked").each(function() {
            mdw.find(".item_9 a[ind=" + $(this).attr("ind") + "]").click();
        });
        return false;
    });
    
    //确认下单
    $(".make_order").click(function(){
        var oid=$(this).attr("oid");
        if($("#mdw_"+oid+" .item_1 input:checked").length==0){
            alert("您还没选择任何货品。");
            return false;
        }
        
        var ids="";
        $("#mdw_"+oid+" .item_1 input").not(":checked").each(function(){
            ids+=$(this).attr("pid")+",";
        });
        if(ids!=""){
            $.ajax({
                url:"action.aspx",
                type:"POST",
                data:{action:"dels",ids:ids},
                success:function(data,state){
                    location="Make_Order.aspx";
                },
                error:function(req,state,err){
                    alert("抱歉，确认订单出错，请联系客服人员。")
                },
                beforeSend:function(){
                    
                },
                complete:function(){
                    
                }
            });
        }else{
            location="Make_Order.aspx";
        }
        
        return false;
    });

})