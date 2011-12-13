$(document).ready(function(){
    //添加分类
    $("#btnAdd").click(function(){
        wb=$(this).wBox({
            title: "添加分类",
            target:"#divadd",
            show:true
        });
    });
    
    var ajaxAction=function(subData,succ,before){
        $.ajax({
            url:"userdefcat.aspx",
            type:"POST",
            data:subData,
            beforeSend:function(){
                before(true);
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
                before(false);
               
            }
        });
    }
    
    //添加前后动作
    var addBefore=function(b){
        if(b){//显示加载
            $("#divadd ul li").css("visibility","hidden");
            $("#divadd ul").addClass("loading");
        }else{//隐藏加载
            $("#divadd ul li").css("visibility","visible");
            $("#divadd ul").removeClass("loading");
        }
    }
    
    $(".btnsub").click(function(){
        var cn=$.trim($(".catname").eq(1).val());
        if(cn!=""){
            ajaxAction({"action":"add","catname":cn},function(){wb.close();binddel();},addBefore);
        }
    });
    
    //删除前后动作
    var delBefore=function(b){
        if(b){//显示加载
            $(".tblist tr:nth-child(n+2)").css("visibility","hidden");
            $(".tblist").addClass("loading");
        }else{//隐藏加载
            $(".tblist tr:nth-child(n+2)").css("visibility","visible");
            $(".tblist").removeClass("loading");
        }
    }
    
     //绑定修改删除
    var binddel=function(){
        $(".lkdel").click(function(){
            var cid=$(this).attr("catid")
            ajaxAction({"action":"del","cid":cid},function(){
                binddel();
            },delBefore);
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