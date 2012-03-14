 $(function(){
    $("#top_dssch_btn").click(function(){
        if(confirm('点石网主站尚在建设中，您可以先预览我们的主页。')){open('/home/index.aspx','_blank','scrollbars=yes');}
    });
    $("#top_sch_btn").click(function(){
        location="../product/index_product.aspx?"+$("#top_pro_name").serialize().replace(/top_/g,"");
    });
    
    $("#mst_sch_btn").click(function(){
        location="../product/index_product.aspx?"+$("#mst_pro_name,#mst_low_price,#mst_height_price").serialize().replace(/mst_/g,"");
    });
    
    $("#duty_free").wBox({title:'免责声明',opacity:0.2,target:"#dtfr"});
    
    //设置当前选中菜单
    $(".HeaderMenuBar ul li a").each(function(){
        if(location.href.indexOf($(this).attr("surl"))>0){
            $(this).parent().addClass("Check")
        }
    });
});