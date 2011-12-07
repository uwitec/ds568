var proid=$("#proid").val();
$.getJSON("post.aspx?action=json&id="+proid+"&rd="+Math.random(),function(md){
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
   $("#maxNumber").val(md.MaxNumber.replace("null",""));
});
