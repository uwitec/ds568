$(document).ready(function(){
    $("#chkall").click(function(){
        $(".tabList input[type=checkbox]").attr("checked",this.checked)
    });
});