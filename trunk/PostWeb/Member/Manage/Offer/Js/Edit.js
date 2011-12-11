var proid=$("#proid").val();
var product_md=null;//产品Model
$.getJSON("post.aspx?action=json&id="+proid+"&rd="+new Date().toLocaleString(),function(md){
    product_md=md;//保存model,用于加载属性后再还原
   //还原系统分类
   $("#sysCat option[value="+md.SysCatID+"]").attr("selected","selected");
   $("#sysCat").change();
   //还原商铺分类
   $("#shopCat option[value="+md.ShopCatID+"]").attr("selected","selected");
   $("#shopCat").change();
   //还原标题
   $("#proTitle").val(md.Title);
   //图片
   $("#img00").show().attr("src",md.Img1);
   $("#img01").show().attr("src",md.Img2);
   $("#img02").show().attr("src",md.Img3);
   //详细介绍
   KE.html(md.Detail);
   //单位
   $("#unit option[value="+md.Unit+"]").attr("selected","selected");
   $("#unit").change();
   //供应总量
   if(md.MaxNumber)
       $("#maxNumber").val(md.MaxNumber);
   //价格区间
   var prs=md.PriceRang.split('|');
   $.each(prs,function(ind,val){
      var vs=val.split(',')
      $("#wb"+(ind+1)).val(vs[0]);
      if(vs.length>0)
          $("#wprice"+(ind+1)).val(vs[1]);
      if(ind>0){
        $(".tdlast a").click();
      }
   });
   

   //有效期
   var d1 = eval("new "+md.ExpiredDate.split('/')[1]);  
   var d2 = eval("new "+md.CreateDate.split('/')[1]);
   var day=(d1.getTime()-d2.getTime())/(24*3600*1000);//计算日期差
   $("input[name=Period][value="+day+"]").attr("checked",true);
   
});

//设置属性值
var setPrtVal=function(ind){
   var prt=$(".Property"+ind)
   var val=$(product_md).attr("Property"+ind);
   if(val){
       if(prt.length==1){
           prt.val(val);
       }else if(prt.length>1){
           if(prt.eq(0).attr("type")=="checkbox"){
              var vs=val.split(',');
              for(var i=0;i<vs.length;i++){
                  prt.filter("[value="+vs[i]+"]").attr("checked",true);
              }
           }else{
               prt.filter("[value="+val+"]").attr("checked",true);
           }
       }
   }
}

