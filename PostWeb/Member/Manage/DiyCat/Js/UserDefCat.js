$(document).ready(function(){
    //添加分类
    $("#btnAdd").click(function(){
        wb=$(this).wBox({
            title: "添加分类",
            target:"#divadd",
            show:true
        });
    });
    
    var ajaxAction=function(subData,succ){
        $.ajax({
            url:"userdefcat.aspx",
            type:"POST",
            data:subData,
            beforeSend:function(){
                $("#divadd ul li").css("visibility","hidden");
                $("#divadd ul").addClass("loading");
            },
            success:function(data,state){
                $(".tblist tr:nth-child(n+2)").remove();
                $(".tblist").append($(data).find(".tblist tr:nth-child(n+2)"));
                succ();
            },
            error:function(req,state,throwerror){
                var estr=req.responseText;
                estr=estr.substring(0,estr.indexOf("</title>"));
                alert(estr.substring(estr.indexOf("<title>")+"<title>".length));
            },
            complete:function(){
                $("#divadd ul li").css("visibility","visible");
                $("#divadd ul").removeClass("loading");
               
            }
        });
    }
    
    $(".btnsub").click(function(){
        var cn=$.trim($(".catname").eq(1).val());
        if(cn!=""){
            ajaxAction({"action":"add","catname":cn},function(){wb.close();binddel();});
        }
    });
    
     //绑定修改删除
    var binddel=function(){
        $(".lkdel").click(function(){
            var cid=$(this).attr("catid")
            ajaxAction({"action":"del","cid":cid},function(){
                binddel();
            });
            return false;
        });
        
        $(".lkedit").click(function(){
            var cn=$(this).parent().parent().find("td:first input");
            if($(this).text()=="修改"){
                cn.removeClass("catname").focus();
                $(this).text("保存");
            }else{
                cn.addClass("catname");
                $(this).text("修改");
            }
        });
    };
    binddel();
    
  
    
});