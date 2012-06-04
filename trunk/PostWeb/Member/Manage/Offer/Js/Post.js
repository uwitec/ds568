$(document).ready(function () {
    //-----------验证开始------------

    var fvalid = $(".mstForm").validate({
        focusInvalid: true,
        errorPlacement: function (error, element) { //设置错误提示位置,此函数为默认，可不设置
            if (element.hasClass("et"))//如果是价格区间
                error.appendTo($(".priceRang").parent());
            else
                error.appendTo(element.parent());  //表示添加到元素后面，
        },
        success: function (label) {
            label.remove()
        },

        rules: {
            shopCat: { required: true },
            wb2: {//第二个价格区间
                required: function () {
                    return $(".hidden:first").is(":visible");
                }
            },
            wprice2: {//第二个价格区间
                required: function () {
                    return $(".hidden:first").is(":visible");
                }
            },
            wb3: {//第三个价格区间
                required: function () {
                    return $(".hidden:last").is(":visible");
                }
            },
            wprice3: {//第三个价格区间
                required: function () {
                    return $(".hidden:last").is(":visible");
                }
            },
            maxNumber: { digits: true, range: [1, 100000] }
        },
        groups: { prc1: "wb1 wprice1 wb2 wprice2 wb3 wprice3" },
        messages: {
            catid: { required: "请选择 系统分类" },
            shopCat: { required: "请选择 商铺分类" },
            unit: { required: "请选择 单位" },
            Period: { required: "请选择 信息有效期" },
            proTitle: { required: "请填写 信息标题" },
            wb1: { required: "请填写 正确的价格区间" },
            wprice1: { required: "请填写 正确的价格区间" },
            wb2: { required: "请填写 正确的价格区间" },
            wprice2: { required: "请填写 正确的价格区间" },
            wb3: { required: "请填写 正确的价格区间" },
            wprice3: { required: "请填写 正确的价格区间" }
        }
    });
    //-----------验证结束------------

    //加载属性
    function loadPrt(catid) {
        $(".property").load("post.aspx", { action: "property", cid: catid, rd: Math.random() }, function () {
            if ($("#proid").val() != "") {//如果存在产品ID,表示修改，此时执行还原属性代
                //设置属性
                for (var i = 1; i <= 24; i++) {
                    setPrtVal(i)
                }
            }

        });
    }

    function cliclick(obj) {
        var li = $(obj)

        li.parent().find("li").removeClass("selected");
        li.addClass("selected");
        var nul = li.parent().next();
        nul.empty(); //清空当前li对应ul的下一个ul的li
        if (li.parent().attr("id") == "c1")//如果点击的是第一个ul则除了第二个外，还要清除第三个ul
            $("#c3").empty();
        if (li.hasClass("hassub")) {//点击时如果存在子类目，则进行获取
            $.get("post.aspx", { action: "subcat", pid: li.attr("cid"), rd: Math.random() },
                function (data, textStatus) {
                    nul.append(data);
                    nul.find("li").click(function () {
                        cliclick(this)
                    });
                });
        } else {//如果当前分类是页子结点
            $("#sysCat option:first").attr("selected", "true"); //使常用分类变为第一项
            $("#catid").val(li.attr("cid")); //保存当前选择分类的ID
            loadPrt(li.attr("cid"))//加载属性

            var c1v = $.trim($("#c1 li.selected").text());
            var c2v = $("#c2 li.selected").text();
            var c3v = $("#c3 li.selected").text();
            if (c2v != "")
                c1v += " > " + c2v;
            if (c3v != "")
                c1v += " > " + c3v;
            $(".Remind span").text(c1v); //显示当前选择的分类
        }

    }



    //点击分类
    $(".iRight ul li").click(function () {
        cliclick(this)
    });

    //自选类别
    $("#acatdiy").click(function () {
        $(".catDiy").toggle();
    });


    //价格区间
    $(".tdlast a").click(function () {
        $(".hide:hidden:first").show();
        if ($(".hide:visible").length == 2) {
            $(this).parent().parent().hide();
            $(".hide:first").find("a").hide();
        }
        return false;
    });

    //删除一行价格区间
    $(".hide a").click(function () {
        $(this).parent().parent().hide();
        $("#" + $(this).attr("et")).empty();
        if ($(".hide:visible").length == 1) {
            $(".hide:first").find("a").show();
            $(".priceRang tr:last").show();
        }
        return false;
    });

    //上传产品图片
    var imgInd = 0; //当前上传图片索引
    $(".upbtn input").click(function () {
        imgInd = $(".upbtn input").index(this);
    });
    var prowBox = $(".upbtn input").wBox({
        title: "添加产品图片",
        requestType: "iframe",
        target: "addimg.aspx",
        show: false,
        drag: false
    });

    //删除产品图片
    $(".upbtn a").click(function () {
        var ind = $(".upbtn a").index(this);
        $("#img0" + ind).attr("src", "");
        $(".upbtn input").eq(ind).val("上传图片")
        $(this).hide();
        return false;
    });

    //上传产品对话框完成产品选择或上传后回调的函数
    setImgUrl = function (imgUrl) {
        $("#img0" + imgInd).show().attr("src", imgUrl);
        $(".upbtn input").eq(imgInd).val("重新上传")
        $(".upbtn a").eq(imgInd).show();
        prowBox.close();
    }

    //自定义插件
    KindEditor.lang({
        diyimg: '插入图片'
    });
    KindEditor.plugin('diyimg', function (K) {
        var self = this, name = 'diyimg';
        window.diyimg = self;
        self.clickToolbar(name, function () {
            detImgBox = $(this).wBox({
                title: "插入图片",
                requestType: "iframe",
                target: "adddetailimg.aspx",
                show: true,
                drag: false
            });
        });
    });
    KindEditor.ready(function (K) {
        KE = K.create('textarea[name="content"]', {
            resizeType: 1,
            allowPreviewEmoticons: false,
            allowImageUpload: false,
            items: [
				'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
				 'strikethrough', 'table', '|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
				'insertunorderedlist', '|', 'diyimg', 'link', 'source']
        });
    });

    //给弹窗调用的插入图片回调函数
    insertDetImg = function (html) {
        detImgBox.close();
        diyimg.insertHtml(html);
    }

    //添加自定义分类
    var diycatbox = $("#addCat").wBox({
        title: "添加分类",
        target: "#wrall",
        show: false,
        callBack: function () {
            $(".saveCat").eq(1).click(function () {
                var catname = $(".catname").eq(1).val().trim();
                if (catname != "") {
                    $.ajax({
                        url: "?action=addcat&catname=" + encodeURI(catname),
                        cache: false,
                        complete: function (req, Status) {
                            if (req.responseText.indexOf("id") > -1) {
                                var id = req.responseText.split('=')[1];
                                $("select[name=shopCat]").append("<option value='" + id + "'>" + catname + "</option>")
                                $("select[name=shopCat] option[value=" + id + "]").attr("selected", "true")
                                diycatbox.close();
                            } else
                                alert(req.responseText);
                        },
                        error: function () {
                            alert("添加分类出错。");
                        }
                    });
                }
            });
        }
    });


    //常用分类
    $("#sysCat").change(function () {
        var v = $(this).val();
        if (v != "") {
            $(".catDiy").hide();
            $("#catid").val(v)
            $(".Remind span").text($(this).find("option[value=" + v + "]").text());
            loadPrt(v)//加载属性
        }
    });

    //选择单位
    $(".prounit").change(function () {
        $(".untxt").text($(this).val());
    });
    $(".prounit").change();

    //控制价格区间购卖数量的输入值为数字
    $("#wb1,#wb2,#wb3,#wprice1,#wprice2,#wprice3").keydown(function (e) {
        // 注意此处不要用keypress方法，否则不能禁用　Ctrl+V 与　Ctrl+V,具体原因请自行查找keyPress与keyDown区分，十分重要，请细查
        if ($.browser.msie) {  // 判断浏览器
            var b = ((event.keyCode > 47) && (event.keyCode < 58)) || (event.keyCode == 8);
            if (this.id.indexOf("wprice") > -1)
                b = b || event.keyCode == 190
            if (b) {// 判断键值  
                return true;
            } else {
                return false;
            }
        } else {
            var b = ((e.which > 47) && (e.which < 58)) || (e.which == 8) || (e.which == 17)
            if (this.id.indexOf("wprice") > -1)
                b = b || e.which == 190
            if (b) {
                return true;
            } else {
                return false;
            }
        }
    }).focus(function () {
        this.style.imeMode = 'disabled';   // 禁用输入法,禁止输入中文字符
        // imeMode有四种形式，分别是：
        // active 代表输入法为中文
        // inactive 代表输入法为英文
        // auto 代表打开输入法 (默认)
        // disable 代表关闭输入法
    });

    //获取某一属性值
    var getPrtVal = function (ind) {
        var prt = $(".Property" + ind)
        if (prt.length == 1) {
            return prt.val();
        } else if (prt.length > 1) {
            if (prt.eq(0).attr("type") == "checkbox") {
                var str = "";
                for (var i = 0; i < prt.length; i++) {
                    if (prt.eq(i).attr("checked")) {
                        str += prt.eq(i).attr("value") + ",";
                    }
                }
                if (str.replace(",", "") == "")
                    return null;
                else
                    return str.substring(0, str.length - 1);
            } else {
                if (prt.filter("[checked]").length > 0)
                    return prt.filter("[checked]").val();
                else
                    return null;
            }
        } else
            return null;
    }
    //获取表单数据
    var getFormVal = function () {
        var subDate = {};
        if ($("#proid").val() != "") {//如果存在产品model,表示修改
            subDate.action = "edit";
            subDate.id = $("#proid").val();
        }
        else
            subDate.action = "add";
        subDate.sysCatID = $("#catid").val();
        subDate.shopCat = $("#shopCat").val();
        subDate.proTitle = $("#proTitle").val();
        subDate.img00 = $("#img00").attr("src");
        subDate.img01 = $("#img01").attr("src");
        subDate.img02 = $("#img02").attr("src");
        subDate.unit = $("#unit").val();
        for (var i = 1; i <= 24; i++) {
            var rv = getPrtVal(i);
            if (rv != null)
                $(subDate).attr("property" + i, rv);
        }
        subDate.detail = encodeURI(KE.html());
        subDate.priceRang = $("#wb1").val() + "," + $("#wprice1").val();
        subDate.lowPrice = subDate.heightPrice = $("#wprice1").val()
        if ($(".hide:first").is(":visible")) {
            subDate.priceRang += "|" + $("#wb2").val() + "," + $("#wprice2").val();
            subDate.lowPrice = $("#wprice2").val();
        }
        if ($(".hide:last").is(":visible")) {
            subDate.priceRang += "|" + $("#wb3").val() + "," + $("#wprice3").val();
            subDate.lowPrice = $("#wprice3").val();
        }
        subDate.maxNumber = $("#maxNumber").val();
        subDate.expiredDate = $("input[name=Period]:checked").val();
        return subDate;
    }
    //提交
    $(".subBtn").click(function () {
        var b = fvalid.form();

        if (b) {
            $.ajax({
                type: "POST",
                url: "post.aspx",
                success: function (data) {
                    if (data == "True") {
                        alert("发布成功。");
                        location = "list.aspx"
                    } else
                        alert(data);
                },
                error: function (req, textStatus, errorThrown) {
                    alert("提交出错。");

                },
                data: getFormVal()
            });
        }
    });

    //若是修改产品，则加载修改脚本
    var proid = $("#proid").val();
    if (proid != "") {
        $.getScript("Js/Edit.js");
    }


});