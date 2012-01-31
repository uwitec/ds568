$(function(){
    $(".subwrap ul").css("width",$(".subwrap ul li").length*77);
    $(".subwrap ul li").click(function(){
        $(".subwrap ul li").removeClass("crtimg");
        $(this).addClass("crtimg")
        $(".corect").css({"left":$(this).offset().left+26,"top":$(this).offset().top+33}).show();
    });
})