$(function() {
    $("#top_dssch_btn").click(function() {
        if (confirm('点石网主站尚在建设中，您可以先预览我们的主页。')) { open('/home/index.aspx', '_blank', 'scrollbars=yes'); }
    });
    $("#top_sch_btn").click(function() {
        location = "../product/index_product.aspx?" + $("#top_pro_name").serialize().replace(/top_/g, "");
    });

    $("#mst_sch_btn").click(function() {
        location = "../product/index_product.aspx?" + $("#mst_pro_name,#mst_low_price,#mst_height_price").serialize().replace(/mst_/g, "");
    });

    $("#duty_free").wBox({ title: '免责声明', opacity: 0.2, target: "#dtfr" });

    //设置当前选中菜单
    $(".HeaderMenuBar ul li a").each(function() {
        if (location.href.indexOf($(this).attr("surl")) > 0) {
            $(this).parent().addClass("Check")
        }
    });

    //检查登录
    $.ajax({
        url: "/template/tem1/action.aspx",
        type: "POST",
        data: { action: "chkLogin" },
        dataType: "json",
        success: function(data, state) {
            if (data.succ) {
                $(".TopBarWelCome span,.TopBarWelCome a").toggle();
                $(".TopBarLogin").css("visibility", "hidden");
                $(".TopBarWelCome a:first").text(data.UserID);
            }
        }
    });

    //检查购物车
    odinfo = function() {
        $.ajax({
            url: "/template/tem1/action.aspx",
            type: "POST",
            data: { action: "chkCart" },
            dataType: "json",
            success: function(data, state) {
                if (data) {
                    $(".od_item_wrap li").not(":first,:last").remove();
                    $.each(data, function(ind, item) {
                        var li = $("<li pid='" + item.ProductID + "'></li>").addClass("OrderProduct").html($(".OrderProduct:first").html());
                        li.find(".ProductImg img").attr("src", item.ImgUrl);
                        li.find(".ProductName a").text(item.ProName).attr("href", "/template/tem1/product/product_show.aspx?pro_id=" + item.ProductID)
                        li.find(".Amount b").text(item.Price);
                        li.find(".proNum").text(item.ProNum);
                        li.find(".ProductDel a").attr("pid", item.ProductID);
                        li.insertBefore($(".od_item_wrap li:last"));
                    });

                    $(".ProductDel a").click(function() {
                        var pid = $(this).attr("pid")
                        $.ajax({
                            url: "/template/tem1/action.aspx",
                            type: "POST",
                            data: { action: "del_od", pid: pid },
                            dataType: "json",
                            success: function(data, state) {
                                if (data.succ) {
                                    $(".od_item_wrap li[pid=" + pid + "]").slideUp(300, function() {
                                        $(this).remove();
                                    });
                                    cartInfo();
                                } else {
                                    alert("抱歉，进货单数据已过期，请重新选择货品。");
                                    $(".od_item_wrap li").not(":first,:last").remove();
                                }
                            }
                        });
                    });
                }
            }
        });
    };
    odinfo();

    cartInfo = function() {
        $.ajax({
            url: "/template/tem1/action.aspx",
            type: "POST",
            data: { action: "cartInfo" },
            dataType: "json",
            success: function(data, state) {
                if (data.succ) {
                    $("#ptype_num").text(data.ProTypeNum);
                    $("#pro_nume").text(data.ProNum);
                    $("#od_amount").text(data.Amount);
                    $(".OrderBottom div").show();
                    $(".no_order").hide();
                } else {
                    $(".OrderBottom div").not(".OrderButtonContainer").hide();
                    $(".no_order").show();
                }
            },
            error: function(req, state, err) {
                $("body").append(req.responseText);
            }
        });
    };
    cartInfo();

});