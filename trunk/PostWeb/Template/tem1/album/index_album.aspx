<%@ Page Language="C#" MasterPageFile="~/template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_album.aspx.cs" Inherits="index_album" %>
<asp:Content ID="Content3" ContentPlaceHolderID="Title" runat="server">
   <title>我的相册</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" rev="stylesheet" href="/css/Pager.css" type="text/css"  />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="MiddleRight">
        <!--========我的相册开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    我的相册</div>
            </div>
            <div class="AlbumBody">
                <div class="AlbumBodyContainer">
                    <ul class="AlbumBody_Head">
                        <li class="AlbumBody_Head_title">全部相册</li><li class="AlbumBody_Head_Remark">我公司的图片分布于以下相册中，请查看</li>
                    </ul>
                    <div class="Split12px">
                    </div>
                    <ul class="AlbumList">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <li>
                                    <div class="AlbumImg">
                                        <a href="album_show.aspx?album_id=<%#Eval("id") %>" target="_blank">
                                            <img onload="changeImg(this,102,128)"   onerror="this.src='images/no-cover.gif'" src="<%#Eval("PictureNum").ToString().Equals("0") ? "images/no_photo.gif" : (Eval("FrontCover") == null ? "images/no-cover.gif" : Eval("FrontCover"))%>" /></a>
                                    </div>
                                    <div class="AlbumName">
                                        <a href="#"><%#Eval("AlbumName")%>(<%#Eval("PictureNum")%>)</a></div>
                                    <div>
                                        <%#((DateTime)Eval("UpdateDate")).ToShortDateString() %></div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
        </div>
        <div>
            <webdiyer:AspNetPager CssClass="pages" PageSize="20" HorizontalAlign="Right"  AlwaysShowFirstLastPageNumber="true"  ShowDisabledButtons="false" ShowFirstLast="false" CurrentPageButtonClass="cpb"  ID="AspNetPager4" NumericButtonCount="7" runat="server" 
                FirstPageText="首页" LastPageText="尾页"    TextAfterPageIndexBox="页 "  SubmitButtonText="确定" SubmitButtonClass="sBtn" ShowCustomInfoSection="Never" NextPageText="下一页"  ShowPageIndexBox="Always" PrevPageText="上一页">
            </webdiyer:AspNetPager>
        </div>
        <!--========我的相册结束=============-->
    </div>
</asp:Content>
