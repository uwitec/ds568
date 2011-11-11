$(document).ready(function(){
    $(".menu1 div,.menu2 div").click(function(){
        $(".menu1,.menu2").removeClass("menu1").addClass("menu2");
        var part=$(this).parent();
        part.removeClass("menu2").addClass("menu1");
        $(".ctnshow1,.ctnshow2").toggle();
    });
    
    $(".imgList li").hover(function(){
            $(this).css({"border-color":"#f7af0f","background-color":"#f8f3e8"})
        },
        function(){
            $(this).css({"border-color":"#ccc","background-color":"#fff"});
        }
    );
    
    //点击相册图片
    $(".imgList li img").click(function(){
        var ind=$("#hdind").val();
        parent.$("#img0"+ind).show().attr("src",this.src);
    });
    
    var fc=0;
    //文件上传
    $("#uploadify0,#uploadify1,#uploadify2").uploadify({
        'uploader': '/js/uploadify/uploadify.swf',
        'script': '/js/uploadify/Upload.aspx',
        'cancelImg': '/js/uploadify/cancel.png',
        'folder': 'UploadFile',
        'queueID':'fileQueue',
        'auto': false,
        'multi':false,
        'width':'74',
        'sizeLimit':4096*1024,
        'buttonImg':'/js/uploadify/open.png',
        'fileExt':'*.rar;*.DOC;*.XLS;*.PPT;*.TXT',
        'fileDesc'    : '*.rar;*.doc;*.xls;*.ppt;*.txt',
        'onComplete':function(event, ID, fileObj, response, data){
        },
        'onSelectOnce' : function(event,data) {
//             
               //$('#uploadify').uploadifyCancel(id);
               
             
       },
       'onSelect':function(event, queueId, fileObj)
       {
           fc++;
           var ind=event.target.id.replace("uploadify","");
//           var fileSize=(fileObj.size/1024).toFixed(2)
//           if(fileSize>4*1024){
//               alert("上传文件不能大于4MB！")
//               $('#uploadify'+ind).uploadifyCancel(queueId);
//               return;
//           }
           $("#tb"+ind).val(fileObj.name);
           $("#clear"+ind).attr("qid",queueId)
           $(".divsub input").addClass("chgbg").attr("disabled","");;
          
       },
       'onCancel':function(event,queueId,fileObj,data){
           if(fc>0)
              fc--;
           if(fc==0)
               $(" .divsub input").removeClass("chgbg").attr("disabled","disabled");
       },
       'onError':function(event,queueId,fileObj,errorObj){
           var ind=event.target.id.replace("uploadify","");
           $('#uploadify'+ind).uploadifyCancel(queueId);
           
           if(errorObj.type=="File Size"){
               alert("不能上传超过4MB的文件。")
               $("#tb"+ind).val("");
           }
       }
   });
   
   
   //清除
   $("#clear0,#clear1,#clear2").click(function(){
        var qid=$(this).attr("qid");
        alert(qid)
        var ind=this.id.replace("clear","");
        $('#uploadify'+ind).uploadifyCancel(qid);
        $("#tb"+ind).val("");
        return false;
   });
   
});