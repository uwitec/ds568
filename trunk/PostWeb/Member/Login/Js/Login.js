$(document).ready(function(){
    //提交时判断是否保存密码
    $(".subBtn").click(function(){
        $.cookie("ds_userid",null)
        $.cookie("ds_pwd",null)
        if($("#slg").attr("checked")){
            $.cookie("ds_userid",$("#uid").val(),{expires:7});
            $.cookie("ds_pwd",$("#pwd").val(),{expires:7});
        }
    });
    //还原保存的帐号和密码在输入框中
    if($.cookie("ds_userid")){
        $("#uid").val($.cookie("ds_userid"))
        $("#pwd").val($.cookie("ds_pwd"))
    }
    
});