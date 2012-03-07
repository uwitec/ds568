$(function(){
    KindEditor.ready(function(K) {
		 KE=K.create('#content', {
			resizeType : 1,
			allowPreviewEmoticons : false,
			allowImageUpload : false,
			items :[
				'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
				 'strikethrough','table','|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
				'insertunorderedlist', '|', 'diyimg', 'link','source']
		});
	});
	
	$("#save").click(function(){
	    var title=$.trim($("input[name=news_title]").val());
	    if(title==""){
	        alert("请输入标题。")    
	        return false;
	    }
	    
	    $.ajax({
	        type:"POST",
	        data:{action:"add",title:title,content:encodeURI(KE.html())},
	        success:function(data,state){
	        
	        },
	        error:function(req,state,err){
	        
	        },
	        beforeSend:function(){
	        
	        },
	        complete:function(){
	            
	        }
	    });
	});
})