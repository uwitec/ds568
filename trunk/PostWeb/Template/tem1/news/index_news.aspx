<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_news.aspx.cs" Inherits="Template_tem1_news_index_news" Title="Untitled Page" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="Server">
<title>公司新闻</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<script type="text/javascript" src="/js/pager/pagination.js"></script>
<link href="/js/pager/pagination.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="js/news_list.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<input type="hidden" id="rc" value="<%=ViewState["rc"] %>" />
    <div class="MiddleRight">
        <!--========内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    公司新闻</div>
            </div>
            <div class="newsBody">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                         <ul>
                            <li>
                                <img align="absMiddle" src="../../images/icon_06.gif" /><a href="news_show.aspx?news_id=<%#Eval("ID") %>" target="_blank"><%#Eval("title") %></a></li>
                            <li class="gray"><span>阅读(<%#Eval("hits") %>) 评论(<%#Eval("coment") %>) <%#((DateTime)Eval("updatedate")).ToString("yyyy年MM月dd日 hh:mm:ss") %></span></li>
                         </ul>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="pagerwrap"></div>
        </div>
        <!--========内容结束=============-->
        
    </div>
</asp:Content>
