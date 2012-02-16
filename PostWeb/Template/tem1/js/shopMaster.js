 $(function(){
    $(".BtnSearch").click(function(){
        if(confirm('点石网主站尚在建设中，您可以先预览我们的主页。')){open('/home/index.aspx','_blank','scrollbars=yes');}
    });
    $(".BtnSearch2").click(function(){
        location="../product/index_product.aspx?"+$("#member_id,#top_pro_name").serialize().replace(/top_/g,"");
    });
    
    $(".SearchBtn").click(function(){
        location="../product/index_product.aspx?"+$("#member_id,#mst_pro_name,#mst_low_price,#mst_height_price").serialize().replace(/mst_/g,"");
    });
});