$(document).ready(function(){
    
    
    $(".listctn li").hover(function(){
            $(this).addClass("ab_hover");
        },
        function(){
            $(this).removeClass("ab_hover");
        }
    );
});