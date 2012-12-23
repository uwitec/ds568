<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_news.aspx.cs" Inherits="Template_tem1_news_index_news" %>
    <asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="server">
    <%="企业资讯,"+_vMember.CompanyName %>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<link rel="stylesheet" rev="stylesheet" href="/css/Pager.css" type="text/css"  />
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
            <div class="pagerwrap">
              <webdiyer:AspNetPager CssClass="pages" AlwaysShow="true"  AlwaysShowFirstLastPageNumber="true" UrlPaging="true"  HorizontalAlign="Right" ShowDisabledButtons="false" ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager4" NumericButtonCount="7" runat="server"
                    FirstPageText="首页" LastPageText="尾页" TextBeforePageIndexBox="共10页 到"  TextAfterPageIndexBox="页 " PageSize="16"  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"  ShowPageIndexBox="Always" PrevPageText="上一页">
               </webdiyer:AspNetPager>
           </div>
        </div>
        <!--========内容结束=============-->
    </div>
</asp:Content>
