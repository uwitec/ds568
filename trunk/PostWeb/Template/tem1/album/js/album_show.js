 
$(document).ready(function(){
	//图片展示开始
	$('img.image1').data('ad-desc', 'Whoa! This description is set through elm.data("ad-desc") instead of using the longdesc attribute.<br>And it contains <strong>H</strong>ow <strong>T</strong>o <strong>M</strong>eet <strong>L</strong>adies... <em>What?</em> That aint what HTML stands for? Man...');
    $('img.image1').data('ad-title', 'Title through $.data');
    $('img.image4').data('ad-desc', 'This image is wider than the wrapper, so it has been scaled down');
    $('img.image5').data('ad-desc', 'This image is higher than the wrapper, so it has been scaled down');
    var galleries = $('.ad-gallery').adGallery();
    
    //些函数于用设置过渡效果
    $('#switch-effect').change(
      function() {
        galleries[0].settings.effect = $(this).val();
        return false;
      }
    );
    
    $('#toggle-slideshow').click(
      function() {
        galleries[0].slideshow.toggle();
        return false;
      }
    );
    $('#toggle-description').click(
      function() {
        if(!galleries[0].settings.description_wrapper) {
          galleries[0].settings.description_wrapper = $('#descriptions');
        } else {
          galleries[0].settings.description_wrapper = false;
        }
        return false;
      }
    );
    //图片展示结束
 
    //点击其他相册事件
    $(".SelectOrder").click(function(){
	    $(".SelectOrder ul").slideDown();
    });
    
    $(".SelectOrder ul").hover(function(){
            $(".SelectOrder ul").show();
        },
        function(){
            $(".SelectOrder ul").slideUp();
        }
    );
    
    //使当前选中相册加粗
    $(".SelectOrder ul li[aid="+$("#albumid").val()+"]").addClass("Selected");
    
    //绑定上下本相册
    $(".PrevAlbum,.NextAlbum").click(function(){
        var obj,txt
        if($(this).text().indexOf("上")>-1){
            obj=$(".Selected").prev();
            txt="已是第一本相册。";
        }else{
            obj=$(".Selected").next();
            txt="已是最后一本相册。";
        }
        if(obj.length>0){
            location=obj.find("a").attr("href");
        }else{
            alert(txt);
        }
        return false;
    });
    
    //如果相册超过15项，则设置下拉框的高，以便使其可滚动
    if($(".SelectOrder ul li").length>15){
        $(".SelectOrder ul").height(15*20);
    }
});
	
 