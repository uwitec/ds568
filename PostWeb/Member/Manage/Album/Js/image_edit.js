$(function(){
    //保存
    $("#saveimg").click(function(){
        var postdata={};
        postdata.action="edit";
        postdata.imglist="";
        $(".edit_row_wrap").each(function(ind){
            var imgmodel={};
            imgmodel.ID=$(this).attr("imgid");
            imgmodel.Title=$(this).find(".fdcontent input").val();
            imgmodel.Descript=$(this).find(".fdcontent textarea").text();
            imgmodel.FontConver=$(this).find(".fcwrap input").attr("checked");
            imgmodel.AlbumID=$("#albumid").val();
            postdata.imglist+=",{"+$.param(imgmodel).replace(/&/g,"',").replace(/=/g,":'")+"'}";
            
        });
       
        if(postdata.imglist!=""){
            postdata.imglist="["+postdata.imglist.substring(1)+"]";
            $.ajax({
                type:"POST",
                data:postdata,
                success:function(data,state){
                    location="Image_List.aspx?id="+$("#albumid").val();
                },
                error:function(req,state,err){
                    alert("保存出错。");
                    $("body").append(req.responseText);
                },
                beforeSend:function(){
                    $("#saveimg").addClass("loading").find("div").addClass("vhide");
                },
                complete:function(){
                    $("#saveimg").removeClass("loading").find("div").removeClass("vhide");
                }
            });
        }
        
    });
});
