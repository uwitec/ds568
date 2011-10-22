<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenu.ascx.cs" EnableViewState="true" Inherits="Member_Manage_UserControl_LeftMenu" %>
<div class="headTitle <%=ViewState["icon"] %>"><%=ModleName%></div>
<ul class="leftMenu">
    <%=Menu %>
</ul>
<script type="text/javascript">
    $(document).ready(function(){
        $(".leftMenu a:contains('<%=MenuName %>')").addClass("selNod");
    });
</script>