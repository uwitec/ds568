$(function() {
    //计算包含图片列表的ul的长度
    var imgItem = $(".subwrap ul li");
    $(".subwrap ul").css("width", imgItem.length * 77);
    //点击选择当前图片
    imgItem.click(function() {
        imgItem.removeClass("crtimg");
        $(this).addClass("crtimg")
        $(".corect").css({ "left": $(this).offset().left + 26, "top": $(this).offset().top + 33 }).show(); //设置勾的位置
       
        //判断是否第一张或最后一张，以便隐藏或显示上一张或下一张
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
                //$("body").append(req.responseText)
                alert("加载图片数据出错。");
            }
        });
        
        //选择其他图片后隐藏保存结果提示栏,并使确定扭按变为灰色
        $(".saveInfo").hide();
        $(".alkbtn").removeClass("dsab").addClass("dsab");
        
        //修改路径上的当前图片标题
        $("#crtimgname").text($(this).find(".tlctn").text());
        
        //判断当前图片是否已设为封面
        var src=$(this).find("img").attr("src").split('/');
        if($("#FrontCover").val()==src[src.length-1]){
            $(".actionctn a").eq(0).hide();
            $(".hascv").show();
        }else{
            $(".actionctn a").eq(0).show();
            $(".hascv").hide();
        }
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
        var _title=$(".imgtitle").val();
        $.ajax({
            type: "POST",
            data: { action: "save", img_id: $(".crtimg").attr("imgid"),title:_title,des:$(".imgdes").text() },
            timeout: 15000,
            success: function(data, state) {
               $(".saveInfo").show();
               $(".alkbtn").addClass("dsab");
               $(".crtimg .tlctn").text(_title);
               $("#crtimgname").text(_title);
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