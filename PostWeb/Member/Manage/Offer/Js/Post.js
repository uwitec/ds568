﻿$(document).ready(function(){
   function cliclick(obj){
       var li=$(obj)
      
       li.parent().find("li").removeClass("selected");
       li.addClass("selected");
       var nul=li.parent().next();
       nul.empty();//清空当前li对应ul的下一个ul的li
       if(li.parent().attr("id")=="c1")//如果点击的是第一个ul则除了第二个外，还要清除第三个ul
            $("#c3").empty();
       if(li.hasClass("hassub")){//点击时如果存在子类目，则进行获取
            $.get("post.aspx",{action:"subcat",pid:li.attr("cid"),rd:Math.random()},
                function (data, textStatus){
                nul.append(data);
                nul.find("li").click(function(){
                   cliclick(this)
                });
            });
       }
       var c1v=$.trim($("#c1 li.selected").text());
       var c2v=$("#c2 li.selected").text();
       var c3v=$("#c3 li.selected").text();
       if(c2v!="")
          c1v+=" > "+c2v;
       if(c3v!="")
          c1v+=" > "+c3v;
       $(".Remind span").text(c1v);
       
       //加载属性
       $(".property").load("post.aspx",{action:"property",cid:li.attr("cid"),rd:Math.random()},function(){
               
       });
   }
   $(".iRight ul li").click(function(){
        cliclick(this)
   });
   
   $("#acatdiy").click(function(){
       $(".catDiy").toggle();
   });
   
   
   //价格区间
   $(".tdlast a").click(function(){
      $(".hidden:hidden:first").show();
      if($(".hidden:visible").length==2){
         $(this).parent().parent().hide();
         $(".hidden:first").find("a").hide();
      }
      return false;
   });
   
   $(".hidden a").click(function(){
       $(this).parent().parent().hide();
       if($(".hidden:visible").length==1){
           $(".hidden:first").find("a").show();
           $(".priceRang tr:last").show();
       }
       return false;
   });
   
   $(".upbtn input").click(function(){
       wBox=$(this).wBox({
            title: "添加产品图片",
            requestType: "iframe",
            target:"addimg.aspx?ind="+$(".upbtn input").index(this),
            show:true,
            drag:false
        });
       
   });
   
   $(".upbtn a").click(function(){
       var ind=$(".upbtn a").index(this);
       $("#img0"+ind).attr("src","");
       $(".upbtn input").eq(ind).val("上传图片")
       $(this).hide();
       return false;
   });
   
   KindEditor.lang({
		diyimg: '插入图片' 
   });
   KindEditor.plugin('diyimg', function(K) {
	    var self = this, name = 'diyimg';
	    window.diyimg=self;
	    self.clickToolbar(name, function() {
			//self.insertHtml('<strong>测试内容</strong>');
			wBox=$(document).wBox({
                title: "插入图片",
                requestType: "iframe",
                target:"adddetailimg.aspx",
                show:true,
                drag:false
            });
		});
	});
	
	KindEditor.ready(function(K) {
		 K.create('textarea[name="content"]', {
			resizeType : 1,
			allowPreviewEmoticons : false,
			allowImageUpload : false,
			items :[
				'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
				 'strikethrough','table','|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
				'insertunorderedlist', '|', 'diyimg', 'link','source']
		});
	});
   
   //添加自定义分类
   $("#addCat").click(function(){
       var wbox=$(this).wBox({
          title: "添加分类",
          target:"#wrall",
          show:true,
          drag:false,
          callBack:function(){
            $(".saveCat").eq(1).click(function(){
                var catname=$(".catname").eq(1).val().trim();
                if(catname!=""){
                    $.ajax({
                       url:"?action=addcat&catname="+encodeURI(catname),
                       cache:false,
                       complete:function(req, Status){
                            if(req.responseText.indexOf("id")>-1){
                                var id=req.responseText.split('=')[1];
                                $("select[name=shopCat]").append("<option value='"+id+"'>"+catname+"</option>")
                                $("select[name=shopCat] option[value="+id+"]").attr("selected","true")
                                wbox.close();
                            }else
                                alert(req.responseText);
                       },
                       error:function(){
                           alert("添加分类出错。");
                       }
                   });
               }
            });
          }
      });
   });
   
   //-----------验证开始------------
    var fvalid=$(".mstForm").validate({
        focusInvalid: true,
        errorPlacement:function(error, element) { //设置错误提示位置,此函数为默认，可不设置
            error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success:function(label){
            //label.addClass("valid").text("填写正确");//成功时执行的函数
        },
       
        rules:{
            shopCat:{required:true},
            proTitle:{required:true}
            
        },
        messages:{
            email:{equalTo:function(){
                         if($(".cemail").val()=="") 
                            return "尚未获取验证码，请点击发送验证码";
                         else
                            return "您的电子邮箱发生了更改，请重新获取验证码"
                     }
                 },
           valiCode:{minlength:"请输入6位验证码",maxlength:"请输入6位验证码"}
        }
    });
    //-----------验证结束------------
   
});