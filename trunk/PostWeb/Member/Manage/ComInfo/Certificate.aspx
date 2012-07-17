<%@ Page Title="" Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Certificate.aspx.cs" Inherits="Member_Manage_ComInfo_Certificate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="Stylesheet" type="text/css" href="Css/Certificate.css" />
<script type="text/javascript">
    $(function() {
        //设置选中项
        var state = $("#showType").val();
        var curmn = $(".hmenu li[state=" + state + "]").find("div").removeClass("lunsl munsl runsl")
    })
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<input type="hidden" id="showType" value="<%=Request["show_type"] %>" />
<ul class="hmenu">
     <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
             <li state="<%#(byte)Container.DataItem %>">
                 <div class="mLeft lunsl"></div>
                 <div class="mMiddle munsl"><a href="?show_type=<%#(byte)Container.DataItem %>"><%#Container.DataItem %></a></div>
                 <div class="mRight runsl"></div>
            </li>
        </ItemTemplate>
    </asp:Repeater>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="scctn">
<div class="Remind">
   展示证书，彰显公司实力，为公司信用加分！<a class="commBtn" href="CtfPost.aspx"><span class="cb_l">&nbsp;</span><span class="cb_m">发布新证书</span><span class="cb_r">&nbsp;</span></a>
</div>
</div>
<table cellpadding=0 cellspacing=0 class="tblist">
    <tr><th colspan=2>图片</th><th>名称</th><th>发证机构</th><th>状态</th><th>有效日期</th><th>操作</th></tr>
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <tr><td class="tdcb"><input type="checkbox" value="<%#Eval("id") %>" name="chb_pro" /></td><td><img src="<%#Eval("Img1") %>" onload="changeImg(this,80,80)" /></td><td><%#Eval("title") %></td><td>---</td><td><%#Eval("categoryname") %></td><td><%#((DateTime)Eval("ExpiredDate")).ToString("yyyy-MM-dd")%></td><td><a href="post.aspx?id=<%#Eval("id") %>">修改</a> / <a href="#">删除</a></td></tr>        
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr class="altr"><td class="tdcb"><input type="checkbox" value="<%#Eval("id") %>" name="chb_pro" /></td><td><img src="<%#Eval("Img1") %>" onload="changeImg(this,80,80)" /></td><td><%#Eval("title") %></td><td>---</td><td><%#Eval("categoryname")%></td><td><%#((DateTime)Eval("ExpiredDate")).ToString("yyyy-MM-dd")%></td><td><a href="post.aspx?id=<%#Eval("id") %>">修改</a> / <a href="#">删除</a></td></tr>        
        </AlternatingItemTemplate>
    </asp:Repeater>
</table>
</asp:Content>

