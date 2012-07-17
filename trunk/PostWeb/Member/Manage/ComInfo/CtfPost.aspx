<%@ Page Title="" Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="CtfPost.aspx.cs" Inherits="Member_Manage_ComInfo_CtfPost" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link rel="Stylesheet" type="text/css" href="Css/ctfpost.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">填写证书信息</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<ul class="ctList">
    <li><span class="sp_filed">选择证书类别：<label class="star">*</label></span><div class="floatL">
        <select>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <option><%#Container.DataItem %></option>
                </ItemTemplate>
            </asp:Repeater>
        </select>
    </div></li>
    <li><span class="sp_filed">证书名称：<label class="star">*</label></span><div class="floatL">
        <input class="txtbox input-bg" />
    </div></li>
    
    <li><span class="sp_filed">&nbsp;</span><a class="commBtn" href="#"><span class="cb_l">&nbsp;</span><span class="cb_m">提交审核</span><span class="cb_r">&nbsp;</span></a></li>
</ul>
</asp:Content>

