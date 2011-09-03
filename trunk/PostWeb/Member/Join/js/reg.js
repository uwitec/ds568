$(document).ready(function(){
    //绑定地区控件
    Area.Create($("input[name='area']"));
    
    //提交事件
    $(".subBtn").click(function(){
        $("form").submit();
    });
});