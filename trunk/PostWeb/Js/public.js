// JavaScript Document

//按比例缩放
function changeImg(obj,width,height) {
    var image=new Image();
    image.src=obj.src;
    if ( image.width > width || image.height > height ) {
      var scale;
      var scale1 = image.width / width;
      var scale2 = image.height / height;

      if(scale1 > scale2){
        scale = scale1;
      }else{
        scale = scale2;
      }

      obj.height = image.height / scale;
      obj.width = image.width / scale;
    }
}

//----------地区插件开始-------------------
var Area=function(options){
    var setting={
        showAllArea:true,//是否显示所有地区选项
        eventClass:"hover",//触发控件显示的事件类型
        enableProvince:true,//省份是否可用
        callBack:null//回调函数
    }
    var opts = $.extend(setting, options);     
    var AreaBody=null;
    var TimeOut=null;
    var Create=function(obj){
        var areaArray=[
                          ['广东','广州','深圳','珠海','潮州','中山','东莞','佛山','惠州','汕头','汕尾','韶关','湛江','肇庆','河源','江门','揭阳','茂名','梅州','清远','阳江','云浮'],
                          ['浙江','杭州','宁波','温州','绍兴','台州','嘉兴','金华','丽水','湖州','衢州','舟山'],
                          ['江苏','南京','苏州','无锡','常州','淮安','镇江','扬州','徐州','连云港','南通','宿迁','泰州','盐城'],
                          ['山东','济南','青岛','烟台','济宁','滨州','莱芜','日照','潍坊','淄博','德州','威海','东营','菏泽','聊城','临沂','泰安','枣庄'],
                          ['河北','石家庄','保定','沧州','秦皇岛','承德','邯郸','唐山','邢台','廊坊','衡水','张家口'],
                          ['河南','郑州','洛阳','开封','焦作','安阳','南阳','周口','商丘','新乡','鹤壁','平顶山','三门峡','信阳','许昌','驻马店','漯河','濮阳'],
                          ['福建','福州','厦门','泉州','漳州','龙岩','南平','宁德','莆田','三明'],
                          ['辽宁','沈阳','大连','鞍山','丹东','抚顺','本溪','朝阳','铁岭','锦州','辽阳','阜新','葫芦岛','盘锦','营口'],
                          ['安微','合肥','芜湖','马鞍山','淮南','蚌埠','黄山','阜阳','淮北','铜陵','亳州','宣城','安庆','巢湖','池州','六安','滁州','宿州'],
                          ['广西','南宁','桂林','北海','柳州','梧州','玉林','百色','崇左','贵港','河池','贺州','来宾','防城港','钦州'],
                          ['山西','太原','大同','晋城','晋中','临汾','吕梁','朔州','长治','忻州','阳泉','运城'],
                          ['海南','海口','三亚','琼海','东方','儋州','万宁','文昌','定安县','五指山','屯昌县','澄迈县','临高县','白沙黎族自','昌江黎族自','乐东黎族自','陵水黎族自','琼中黎族苗','保亭黎族苗'],
                          ['内蒙古','呼和浩特','包头','赤峰','鄂尔多斯','呼伦贝尔','阿拉善盟','通辽','乌海','兴安盟','巴彦淖尔','乌兰察布盟','锡林郭勒盟'],
                          ['吉林','长春','吉林','四平','通化','白城','白山','辽源','松原','延边朝鲜族'],
                          ['黑龙江','哈尔滨','大庆','佳木斯','鹤岗','牡丹江','黑河','鸡西','七台河','齐齐哈尔','双鸭山','绥化','伊春','大兴安岭'],
                          ['湖北','武汉','黄冈','黄石','荆门','荆州','潜江','宜昌','鄂州','十堰','随州','天门','仙桃','咸宁','襄樊','孝感','神农架林区','恩施土家族'],
                          ['湖南','长沙','常德','株洲','岳阳','郴州','怀化','湘潭','张家界','衡阳','娄底','邵阳','益阳','永州','湘西土家族'],
                          ['江西','南昌','上饶','抚州','赣州','九江','鹰潭','吉安','景德镇','萍乡','新余','宜春'],
                          ['宁夏','银川','固原','石嘴山','吴忠','中卫'],
                          ['新疆','乌鲁木齐','哈密','和田','喀什','吐鲁番','阿克苏','阿拉尔','石河子','五家渠','克拉玛依','图木舒克','昌吉回族自','伊犁哈萨克','巴音郭楞蒙','博尔塔拉蒙','克孜勒苏柯','塔城地区','阿勒泰地区'],
                          ['清海','西宁','海东','果洛藏族自','海北藏族自','海南藏族自','黄南藏族自','玉树藏族自','海西蒙古族'],
                          ['陕西','西安','咸阳','汉中','安康','宝鸡','商洛','铜川','渭南','延安','榆林'],
                          ['甘肃','兰州','白银','酒泉','定西','嘉峪关','金昌','庆阳','陇南','平凉','天水','武威','张掖','甘南藏族自','临夏回族自'],
                          ['四川','成都','宜宾','绵阳','巴中','攀枝花','达州','德阳','遂宁','广安','广元','乐山','泸州','眉山','南充','内江','雅安','资阳','自贡','甘孜藏族自','凉山彝族自','阿坝藏族羌'],
                          ['云南','昆明','保山','丽江','玉溪','昭通','临沧','曲靖','普洱','楚雄彝族自','大理白族自','迪庆藏族自','怒江傈傈族','文山壮族苗','西双版纳傣','德宏傣族景','红河哈尼族'],
                          ['贵州','贵阳','安顺','毕节','铜仁','遵义','六盘水','黔东南苗族','黔南布依族','黔西南布依'],
                          ['西藏','拉萨','阿里','昌都','林芝','那曲','日喀则','山南'],
                          ['台湾','台北县','宜兰县','桃园县','新竹县','苗栗县','台中县','彰化县','南投县','云林县','嘉义县','台南县','高雄县','屏东县','台东县','花莲县','澎湖县','基隆市','新竹市','台中市','嘉义市','台南市','台北市','高雄市','金门县','连江县'],
                          ['香港','香港岛','九龙','新界'],
                          ['澳门','澳门半岛','澳门离岛']
                      ];
                      
        var htmlStr="<div class=\"area-ctn\">"+
                    "<ul class=\"area-all\"><li v=''>所有地区</li></ul>"+
                    "<ul class=\"area-Municipalities\">"+
                        "<li v='北京'>北京</li>"+
                        "<li v='上海'>上海</li>"+
                        "<li v='天津'>天津</li>"+
                        "<li v='重庆'>重庆</li>"+
                    "</ul>"+
                    "<ul class=\"area-province\">";
                    for(i=0;i<areaArray.length;i++){
                        htmlStr+="<li class=\"liprovince\" v='"+areaArray[i][0]+"'>"+areaArray[i][0];
                        if(areaArray[i].length>1){
                            htmlStr+="<ul>";
                            for(j=1;j<areaArray[i].length;j++){
                                htmlStr+="<li v='"+areaArray[i][j]+"'>"+areaArray[i][j]+"</li>";
                            }
                            htmlStr+="</ul>";
                        }
                        htmlStr+="</li>";
                    }
                    htmlStr+="</ul>"+"</div>";
        
        $("body").append(htmlStr);
       
        AreaBody=$(".area-ctn");
        AreaBody.hover(function(){
               clearTimeout(TimeOut);
           },
           function(){
               Hide();
           }
        );
        
        //点击地区，返回地区名称
        var selArea=["",""]
        var isCityClick=false;//表示点击的是否是市
        $(".area-ctn>ul>li").click(function(){//点击省
            selArea[0]=$(this).attr("v")
            var pc="";
            if(isCityClick)
                pc=selArea[0]+"- "+selArea[1];
            else{
                if(setting.enableProvince||$(this).parent().hasClass("area-Municipalities"))
                    pc=selArea[0];
                else
                    alert("请选择地级市作为地区。")
            }
            if(setting.callBack){//判断是否存在回调函数
                setting.callBack(pc);
            }else{//如果没有回调函数则将结果返回到输入框内
                obj.val(pc);
            }
            isCityClick=false;
            Hide();
        });
        $(".area-ctn>ul>li>ul>li").click(function(){//点击市,同时会触发点击省事件,因为市li包含在省li中
            selArea[1]=$(this).attr("v")
            isCityClick=true;
        });
        $(".area-ctn li").hover(function(){
                $(this).addClass("hover").css("color","White");
                var sub=$(this).find("ul")
                if(sub){sub.show()}
            },
            function(){
                $(this).removeClass("hover").css("color","#444");
                var sub=$(this).find("ul")
                if(sub){sub.hide()}
            }
        );
        if(!setting.showAllArea){
            $(".area-all").hide();
        }
        
        //触发显示地区控件
        if(obj){
            switch(setting.eventClass){
                case "click":
                    obj.click(function(){
                        var os=obj.offset();
                        if(options.align=="right")
                            Position(os.left-(AreaBody.width()-obj.width()),os.top+obj.height()+3);
                        else
                            Position(os.left,os.top+obj.height()+3);
                        Show();
                    }).mouseout(function(){
                        TimeOut=setTimeout(Hide,200); 
                    });
                break;
                default :
                    obj.hover(
                        function(){ 
                            var os=obj.offset();
                            if(options.align=="right")
                                Position(os.left-(AreaBody.width()-obj.width()),os.top+obj.height()+3);
                            else
                                Position(os.left,os.top+obj.height()+3);
                            Show();
                        },
                        function(){
                            TimeOut=setTimeout(Hide,200); 
                        }
                    );
                break;
            }  
        }
    }
    var Show=function(){
        AreaBody.show();
    }
    var Hide=function(){
        AreaBody.find("ul li ul").hide();
        AreaBody.hide();
        
    }
    var Position=function(x,y){
        AreaBody.css({"left":x,"top":y});
    }
    Create(options.trigger);
}
//----------地区插件结束-------------------