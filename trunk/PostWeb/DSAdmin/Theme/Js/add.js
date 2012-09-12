$(function() {
    $(".hmenu li").click(function() {
        $(".hmenu li").removeClass("mn-wrap-crt");
        $(this).addClass("mn-wrap-crt");
    });

    $(".sub-model-menu li").not(":last").click(function() {
        var ind = $(".sub-model-menu li").removeClass("crt").index(this);
        $(this).addClass("crt");
        $(".sub-model-menu").parent().find(".item-main-wrap").hide().eq(ind).show();
    });

    $("#color_a").colorSelect();
    $("#fontColor").colorSelect();

    $("#fontBold").click(function() {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/bold_2.gif")
        } else
            $(this).attr("src", src)
    });
    $("#fontItalic").click(function() {
        var src = "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_1.gif";
        if ($(this).attr("src") == src) {
            $(this).attr("src", "http://style.org.hc360.com/images/detail/mysite/siteconfig/italic_2.gif")
        } else
            $(this).attr("src", src)
    });


    //上传
    var _url = "Action.ashx"
    //提交
    $("#btn-sign-save").click(function() {
        if ($(this).hasClass("loading2")) return false;
            
            var themeName=$.trim($("input[name=themeName]").val());
            if(themeName==""){
                alert("请输入主题名称。");
                return false;
            }
            $("#btn-sign-save").addClass("loading2").find(".cb_m").text("数据提交中…");
            $.ajaxFileUpload({
                url: _url + "?time=" + Math.random(),
                type: "POST",
                secureuri: false,
                fileElementId: 'signfile',
                data: { myaction: "signSave", themeName: themeName },
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
                    $("body").append(data.responseText)
                    alert(e);
                },
                complete: function() {
                $("#btn-sign-save").removeClass("loading2").find(".cb_m").text("提交审核");
                }
            });
        
    });


    
 

})