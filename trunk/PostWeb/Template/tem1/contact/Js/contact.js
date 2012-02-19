$(function(){
   var mapurl="http://searchbox.mapbar.com/publish/template/template1010/index.jsp?CID=ds568&tid=tid1010&nid={nid}&width=700&height=450&control=2&infopoi=1&infoname=1&zoom=10" 
   //如果设置了地图
   if($("#mapNid").val()!=""){
      $("#map").show().attr("src",mapurl.replace("{nid}",$("#mapNid").val()));
   }
});