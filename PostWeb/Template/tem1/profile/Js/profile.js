$(document).ready(function(){
    var adNum=0;
    var imgurl=$("#hdimgurl").val().split('|');
    for(var i=0;i<imgurl.length;i++){
        $(".comimgCtn").append("<img src='"+imgurl[i]+"' width='300' height='228' />")
    }            
   
    function nextAd(){
        if(adNum<imgurl.length-1)
            adNum++ ;
        else 
            adNum=0;
        $(".comimgCtn img").eq(adNum-1).fadeOut(500)
        $(".comimgCtn img").eq(adNum).fadeIn(1000)
        theTimer=setTimeout(nextAd, 6000);
    }
    
    if(imgurl[0]!=""){
        if(imgurl.length>1)
            nextAd()
    }else
        $(".comimgCtn").hide();
});