$(document).ready(function(){
    $(".menu1 div,.menu2 div").click(function(){
        $(".menu1,.menu2").removeClass("menu1").addClass("menu2");
        $(this).parent().removeClass("menu2").addClass("menu1");
    });
});