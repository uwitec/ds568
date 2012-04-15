$(document).ready(function () {
    //设置当前选中列表
    var setCurMn = function () {
        var state = $("#showType").val();
        var curmn = $(".hmenu li[state=" + state + "]").find("div").removeClass("lunsl munsl runsl").filter(".mMiddle");
        curmn.html(curmn.find("a").html());
    }
    setCurMn();

    //全选
    $("#chkAll").change(function () {
        $("input[name=chb_pro]").attr("checked", $(this).attr("checked"));
    });
    //获取所先记录ID
    var getSelectedID = function () {
        var rs = "";
        $("input[name=chb_pro]").each(function () {
            if ($(this).attr("checked")) {
                rs += $(this).val() + ",";
            }
        });
        if (rs != "") {
            rs = rs.substring(0, rs.length - 1);
        }
        return rs;
    }

    //删除确认
    $("#btnDel").click(function () {
        if (confirm("确认删除吗，删除后将不能恢复?")) {
            var ids = getSelectedID();
            if (ids == "") {
                alert("请选中要删除的记录。");
                return;
            }
            var subData = {};
            subData.action = "del";
            subData.ids = ids;
            subData.show_type = $("#showType").val();

            $.ajax({
                url: "list.aspx",
                type: "POST",
                data: subData,
                ajaxSend: function () {

                },
                error: function () {
                    alert("删除出错。");
                },
                success: function (data, textStatus) {
                    $(".tblist tr:nth-child(n+3)").remove();
                    $(".tblist").append($(data).find(".tblist tr:nth-child(n+3)"));
                    $(".hmenu li").remove();
                    $(".hmenu").append($(data).find(".hmenu li")); //还原删除后的头部菜单
                    setCurMn(); //使当前类别菜单为选中状态
                    $("#chkAll").attr("checked", false)
                    alert('成功删除' + ids.split(',').length + '条记录。');
                }
            });
        }
    });

});