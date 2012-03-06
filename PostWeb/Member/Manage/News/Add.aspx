<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Member_Manage_News_Add" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="Css/Add.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">发布公司动态</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="proctn">
    <table cellpadding=0 cellspacing=0 class="tblist">
        <tr><th >分类名称</th><th>分类图片</th><th>排序</th><th>分类产品</th><th>操作</th></tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr><td><input class="txtbox ctname" id="ctname_<%#Container.ItemIndex %>" value="<%#Eval("CategoryName") %>" /></td><td>--</td><td>--</td><td><a href="#">供应产品列表</a></td><td>
                    <div class="cmctn_1" ind="<%#Container.ItemIndex %>"><a href="#"  class="lkedit">修改</a> / <a href="#"  class="lkdel" catid="<%#Eval("id") %>">删除</a></div>
                    <div class="cmctn_2" ind="<%#Container.ItemIndex %>"><a href="#" cid="<%#Eval("id") %>"  class="lkupdate">更新</a> / <a href="#"  class="lkcancel" >取消</a></div>
                </td></tr>      
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr class="altr">
                    <td ><input class="txtbox ctname" id="ctname_<%#Container.ItemIndex %>" value="<%#Eval("CategoryName") %>" /></td><td>--</td><td>--</td><td><a href="#">供应产品列表</a></td><td>
                        <div class="cmctn_1" ind="<%#Container.ItemIndex %>"><a href="#" class="lkedit">修改</a> / <a href="#"  class="lkdel" catid="<%#Eval("id") %>">删除</a></div>
                        <div class="cmctn_2" ind="<%#Container.ItemIndex %>"><a href="#" cid="<%#Eval("id") %>" class="lkupdate">更新</a> / <a href="#"  class="lkcancel" >取消</a></div>
                    </td>
                </tr> 
            </AlternatingItemTemplate>
        </asp:Repeater>
    </table>
</div>
</asp:Content>

