$(document).ready(function(){
    $(".frame").height(Math.max(document.body.clientHeight,document.documentElement.clientHeight)-$(".head").height()-$(".holdspace").height()-$(".toolbar").height()-4);
    $(".tbcon a").click(function(){
        $(".frame").attr("src","Offer/Post.aspx");
        $(this).blur();
    });
});