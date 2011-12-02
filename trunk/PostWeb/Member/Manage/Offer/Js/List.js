$(document).ready(function(){
    //设置当前选中列表
    var state=$("#showType").val();
    var curmn=$(".hmenu li[state="+state+"]").find("div").removeClass("lunsl munsl runsl").filter(".mMiddle");
    curmn.html(curmn.find("a").html());
});