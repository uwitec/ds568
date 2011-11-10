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
    
    //文件上传
    $("#uploadify,#uploadify1,#uploadify2").uploadify({
        'uploader': '/js/uploadify/uploadify.swf',
        'script': '/js/uploadify/Upload.aspx',
        'cancelImg': '/js/uploadify/cancel.png',
        'folder': 'UploadFile',
        
        'auto': false,
        'multi': true,
        //'buttonText':'浏览文件',
        'fileExt':'*.rar;*.DOC;*.XLS;*.PPT;*.TXT',
        'fileDesc'    : '*.rar;*.doc;*.xls;*.ppt;*.txt',
        'onComplete':function(event, ID, fileObj, response, data){
        },
        'onSelectOnce' : function(event,data) {
          var fileSize=(data.allBytesTotal/1024).toFixed(2)
          if(fileSize>4*1024){
            alert("上传文件不能大于4MB！")
            $('#uploadify').uploadifyClearQueue()
          }
          $(this).hide();
        }
   });
       
});