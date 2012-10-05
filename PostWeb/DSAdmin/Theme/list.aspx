<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="DSAdmin_Theme_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <Custom:Header runat="server" />
    <style type="text/css">
        .htm-main{width:776px;margin:0 auto;margin-top:10px;}
        .list-wrap ul{overflow:auto;}
        .list-wrap ul li{float:left;margin-right:10px;position:relative;}
        
        .img-wrap{width:125px;height:130px;border:solid 1px #ccc;padding:5px;text-align:center;line-height:130px;}
        .img-wrap img{ vertical-align:middle;}
        .thremTitle{line-height:18px;text-align:center;}
        .list-wrap ul li .action-wrap{color:white;width:132px;line-height:24px;opacity: 0.7;filter:alpha(opacity=70); position:absolute;top:116px;left:2px;display:none;text-align:center;color:#fff;background: none repeat scroll 0 0 #000000;font-style:normal;}
        .list-wrap ul li:hover .action-wrap{display:block;}
        .btn-ctn{padding:8px 0;}
    </style>
    <script type="text/javascript">
        $(function() {
            var _url = "Action.ashx";
            $(".action-wrap a").click(function() {
                var btn = $(this);
                $.ajax({
                    url: _url,
                    type: "POST",
                    data: { myaction: "del", id: btn.attr("theid") },
                    success: function(data) {
                        btn.parent().parent().remove();
                    },
                    error: function(req) {
                        alert(req.responseText)
                    },
                    beforeSend: function() {

                    },
                    complete: function() {

                    }
                });
                return false;
            });
        })
    </script>
</head>
<body>
    <div class="htm-main">
    <div class="btn-ctn"><input type="button" onclick="location='add.aspx'" value="添加主题" /></div>
    <div class="list-wrap">
        <ul>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <li>
                        <div class="img-wrap">&nbsp;<a class="lkimg" href="add.aspx?id=<%#Eval("id")%>"><img src="<%#Com.DianShi.BusinessRules.ShopConfig.DS_ShopTheme_Br.ThemePath((int)Eval("ID"))+Eval("Thume") %>" onload="changeImg(this,120,120)" /></a>&nbsp;</div>
                        <div class="thremTitle"><%#Eval("ThemeName")%></div>
                        <div class="action-wrap"><a theid="<%#Eval("id") %>" href="javascript:;">删除</a></div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
    <div class="page-wrap"></div>
    </div>
</body>
</html>















 