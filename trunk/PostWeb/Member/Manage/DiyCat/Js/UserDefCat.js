$(document).ready(function(){
    //添加分类
    $("#btnAdd").click(function(){
        $(this).wBox({
            title: "添加分类",
            target:"#divadd",
            show:true
        });
    });
});