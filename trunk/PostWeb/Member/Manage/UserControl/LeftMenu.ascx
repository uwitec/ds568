<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenu.ascx.cs" Inherits="Member_Manage_UserControl_LeftMenu" %>
<div class="headTitle <%=ViewState["icon"] %>"><%=ModleName%></div>
<ul class="leftMenu">
    <!--<li><a class="selNod" href="/Member/Manage/Offer/Post.aspx">修改联系信息</a></li>-->
    <%=Menu %>
</ul>
<script type="text/javascript">
    $(document).ready(function(){
        $(".leftMenu a:contains('<%=MenuName %>')").addClass("selNod");
    });
</script>