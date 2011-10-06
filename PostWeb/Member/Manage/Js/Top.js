$(document).ready(function(){
    $(".tbcon a").click(function(){
        $(".tbcon a").removeClass("menuHover");
        $(this).blur().addClass("menuHover");
    });
});