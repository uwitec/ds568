$(function () {
    webconfig = true; //商铺页面会检查此值，以便判断是否处理装修状态

    //自适应高度
    function iFrameHeight() {
        var ifm = document.getElementById("mainFrame");
        ifm.height = $(window).height() - 44;
    }
    setInterval(iFrameHeight, 2000);
})