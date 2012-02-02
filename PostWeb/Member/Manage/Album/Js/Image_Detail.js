$(function() {
    //计算包含图片列表的ul的长度
    var imgItem = $(".subwrap ul li");
    $(".subwrap ul").css("width", imgItem.length * 77);
    //点击选择当前图片
    imgItem.click(function() {
        imgItem.removeClass("crtimg");
        $(this).addClass("crtimg")
        $(".corect").css({ "left": $(this).offset().left + 26, "top": $(this).offset().top + 33 }).show(); //设置勾的位置
        $(".sp1 img").attr("src", $(this).find("img").attr("src"))
        var ind = imgItem.index(this);
        if (ind == 0)
            $(".preImg").hide();
        else
            $(".preImg").show();
        if (ind == imgItem.length - 1)
            $(".nextImg").hide();
        else
            $(".nextImg").show();

        //加载图片数据
        $.ajax({
            type: "POST",
            data: { action: "loadimgdata", img_id: $(this).attr("imgid") },
            timeout: 15000,
            dataType: "json",
            success: function(data, state) {
                $(".sp1 img").attr("src", "/Resource/" + data.ImgUrl + "/" + data.ImgName);
                $(".imgtitle").val(data.ImgTitle);
                $(".imgdes").text(data.ImgDescript);
            },
            beforeSend: function() {

            },
            error: function(req, state, err) {
                alert("加载图片数据出错。");
            }
        });
    });

    var scrollImg = function(isPre, ind) {
        var sl = $(".subwrap").scrollLeft();
        var rollWidth = 0;
        if (isPre) {//如果动作为上一张
            if (sl > 0) rollWidth = -77;
        } else {
            if (sl < (imgItem.length - 3) * 77) rollWidth = 77;
        }

        //滚动
        $(".subwrap").animate({ scrollLeft: sl + rollWidth }, 100, function() {
            imgItem.removeClass("crtimg").eq(ind).click();
        });
    }

    //上一张
    $(".preImg").click(function() {
        var ind = imgItem.index($(".crtimg"));
        scrollImg(true, --ind);

    });

    //上一张
    $(".nextImg").click(function() {
        var ind = imgItem.index($(".crtimg"));
        scrollImg(false, ++ind);
    });
 
    //初始化当前选中的图片
    var crtimg = imgItem.filter("[imgid=" + $("#img_id").val() + "]");
    var ind = imgItem.index(crtimg);
    if (ind > 2)
        $(".subwrap").scrollLeft((ind - (imgItem.length > 4 ? 1 : 2)) * 77);
    crtimg.click();
    
    //保存
    $("#save").click(function(){
        if($(".alkbtn").hasClass("dsab")) return false;
        $(".imgdes").keyup();
        $.ajax({
            type: "POST",
            data: { action: "save", img_id: $(".crtimg").attr("imgid"),title:$(".imgtitle").val(),des:$(".imgdes").text() },
            timeout: 15000,
            success: function(data, state) {
               $(".saveInfo").show();
            },
            error: function(req, state, err) {
                $(".saveInfo").hide();
                alert("保存出错。");
            }
        });
    });
    
    //判断标题是否改变，若改变则使确定按扭可点击
    $(".imgtitle").keyup(function(){
        var dv=$(this).attr("defaultValue");
        if(dv!=$(this).val()&&$.trim($(this).val())!=""){
            $(".alkbtn").removeClass("dsab");
        }
    });
    var des=$(".imgdes").text();
    $(".imgdes").keyup(function(){
        var nv=$(this).text();
        if(des!=nv&&$.trim(nv)!=""){
            $(".alkbtn").removeClass("dsab");
        }
        if(nv.length>2000){
            $(this).text(nv.substring(0,2000));
        }
    });
})