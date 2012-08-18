﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true" CodeFile="ctf_index.aspx.cs" Inherits="Template_tem1_Certificate_ctf_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
<link type="text/css" rel="Stylesheet" href="css/ctf_index.css" />
<style type="text/css">
    .MiddleLeft{display:none;}
</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="ctf-main">
    <div class="ctf-ctn-wrap">
        <div class="ctf-h">&nbsp;</div>
        <div class="ctf-list-wrap">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="ctf-list-item">
                        <div class="ctf-item-h"><div class="ctf-h-l">&nbsp;</div><div class="ctf-h-m"><div class="tag-icon"><%#Container.DataItem %></div></div><div class="ctf-h-r">&nbsp;</div></div>
                        <div class="ctf-item-bd">
                            <ul>
                                <asp:Repeater ID="Repeater2" runat="server">
                                    <ItemTemplate>
                                        <li>
                                            <dl>
                                                <dt>
                                                    <div class="ctf-img-bd">
                                                        &nbsp;<img width="100" src="<%#ctfdir %><%#Eval("ctfimg") %>" alt="<%#Eval("ctfname") %>" />&nbsp;
                                                    </div>
                                                </dt>
                                                <dd>
                                                    <%#Eval("ctfname") %>
                                                </dd>
                                                <dd>
                                                    发证机构：<%#Eval("IssuingAgency")%>
                                                </dd>
                                            </dl>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
 </div>
</asp:Content>

