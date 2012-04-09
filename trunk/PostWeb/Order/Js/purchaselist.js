$(function() {
    $(".item_6 a").click(function() {
        var pid=$(this).attr("pid");
        var ind=$(this).attr("ind");
        var ipt=$(this).parent().find("input");
        var oid=$(this).parent().attr("oid");
        if ($.trim($(this).text()) == "+") {
            ipt.val(Number(ipt.val())+1)
        } else {
            ipt.val(Number(ipt.val())-1)
        }
     
        $.ajax({
            url:"action.aspx",
            type:"POST",
            dataType:"json",
            data:{action:"add_num",id:pid},
            success:function(data,state){
                $(".item_8").eq(ind).text(data.CrtProAmount)
                $("#am_"+oid).text(data.CrtOrderAmount);
            },
            error:function(req,state,err){
                //alert()
                $("body").append(req.responseText);
            },
            beforeSend:function(){
                
            },
            complete:function(){
                
            }  
        });
    });
})