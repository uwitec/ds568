var proid=$("#proid").val();
$.getJSON("post.aspx?action=json&id="+proid,function(md){
   //还原系统分类
   $("#sysCat option[value="+md.SysCatID+"]").attr("selected","selected");
   $("#sysCat").change();
   //还原商铺分类
   $("#shopCat option[value="+md.ShopCatID+"]").attr("selected","selected");
   $("#shopCat").change();
   //还原标题
   $("#proTitle").val(md.Title);
});
