$(function() {
    $(".toolbarctn a:contains(添加)").wBox({
        title: "添加地区",
        html: "<div class='addwrap'>地区名称：<input /> <input type='button' id='savearea' value='保存' /></div>",
        show: false,
        callBack: function() {
            $("#savearea").click(function() {
                var an = $.trim($(this).prev().val());
                if (an == "") {
                    alert("请输入地区名称。");
                } else {
                    $.ajax({
                        url: "action.aspx",
                        type: "POST",
                        data: { action: "add", parentid: $("#crtid").val(), an: an },
                        success: function(data, state) {
                            location = location.href;
                        },
                        error: function(req, state, err) {
                            alert("提交出错。");
                            $("body").append(req.responseText);
                        }
                    });
                }
            });
        }
    }).click(function() {
        return false;
    });

    var aid = 0;
    $(".lkedit").wBox({
        title: "修改地区",
        html: "<div class='addwrap'>地区名称：<input /> <input type='button' id='savearea' value='保存' /></div>",
        show: false,
        callBack: function() {
            $("#savearea").click(function() {
                var an = $.trim($(this).prev().val());
                if (an == "") {
                    alert("请输入地区名称。");
                } else {
                    $.ajax({
                        url: "action.aspx",
                        type: "POST",
                        data: { action: "edit", id: aid, an: an },
                        success: function(data, state) {
                            $(".addwrap input:first").val(an);
                            location = location.href;
                        },
                        error: function(req, state, err) {
                            alert("提交出错。");
                            $("body").append(req.responseText);
                        }
                    });
                }
            });
        }
    }).click(function() {
        aid = $(this).attr("aid");
        $(".addwrap input:first").val($(this).attr("an"));
    });


});