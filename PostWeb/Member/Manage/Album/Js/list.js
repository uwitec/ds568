$(document).ready(function(){
    
    //鼠标经过
    var albHover=function(){
        $(".listctn li").hover(function(){
                $(this).addClass("ab_hover").find(".albbg span").css("display","block");
                $(this).find(".albtitle").addClass("hvcl");
            },
            function(){
                $(this).removeClass("ab_hover").find(".albbg span").css("display","none");
                $(this).find(".albtitle").removeClass("hvcl");
            }
        );
    }
    albHover();
    
    var pageIndex=1;//当前页
    var ajaxReq=function(_data,_beforeSend,_complete,_success){
        $.ajax({
            data:_data,
            success:function(data,state){
                _success(data);
            },
            beforeSend:function(){
                _beforeSend();
            },
            error:function(req,state,err){
                alert("出错");
                $("body").append(req.responseText)
            },
            complete:function(){
                _complete();
            }
        });
    }
   
    //下一页
    $("#pre,#next").click(function(){
        var data={};
        data.action="chgPage";
        var b=false;//记录是否是第一页或最后一页
        if($(this).attr("id")=="pre"){//如果是上一页
            if(pageIndex>1){
                data.pgind=--pageIndex;
                b=true;
            }
        }else{//如果是下一页
            if(pageIndex<Number($("#pgcount").text())){
                data.pgind=++pageIndex;
                b=true;
            }
        }
        if(!b) return;//如果已经是第一页或最后一页则不执行下面分页代码
        $("#ctpind").text(pageIndex)
        ajaxReq(data,function(){
                $(".listctn").addClass("loading").find("li").css("visibility","hidden");
            },
            function(){
                $(".listctn").removeClass("loading").find("li").css("visibility","visible");
            },
            function(_data){
                $(".listctn li").remove();
                $(".listctn").append($(_data).find(".listctn li"));
                albHover();
            }
        );
        return false;
    });
});