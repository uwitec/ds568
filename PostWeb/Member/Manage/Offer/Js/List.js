$(document).ready(function(){
    //设置当前选中列表
    var state=$("#showType").val();
    var curmn=$(".hmenu li[state="+state+"]").find("div").removeClass("lunsl munsl runsl").filter(".mMiddle");
    curmn.html(curmn.find("a").html());
    
    //全选
    $("#chkAll").change(function(){
        $("input[name=chb_pro]").attr("checked",$(this).attr("checked"));
    });
    
    //删除确认
    $(".btnDel").click(function(){
        using('messager',function(){$.messager.confirm('系统提示', '确认删除吗，删除后将不能恢复?', function(r){
		       if(r){
		           $("#action").val("del")
		           $("form").submit();
		       }
		    })
		});
		return false;
    });
});