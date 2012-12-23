<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master"  AutoEventWireup="true"
    CodeFile="news_show.aspx.cs" Inherits="Template_tem1_news_news_show" %>
    <asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="server">
    <%=title+","+ _vMember.CompanyName%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<style type="text/css">
    .nocoment{ text-align:center;line-height:32px;display:none;}
    .lgwrap{width:300px;height:100px;line-height:100px; text-indent:30px;}
    .loading2{ background-position:12px center;}
    .lgitem{overflow:auto;zoom:1;margin-top:10px;}
    .lgiL{width:80px;float:left; text-align:right;}
    .lgiR{float:left;}
    .lgbody{display:none;}
    .itwrap{width:300px;height:120px;}
    span.loading2{padding-left:28px;display:none;}
    .cmpwd{width:150px;}
    .newsContent{overflow:hidden;}
</style>
<script type="text/javascript" src="js/news_show.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <input type="hidden" id="pid" value="<%=Request.QueryString["news_id"] %>" />
    <div class="MiddleRight">
        <!--========内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    公司新闻</div>
            </div>
            <div class="newsBody">
                <asp:Repeater ID="Repeater1" runat="server" EnableViewState="false" >
                    <ItemTemplate> 
                        <h3>
                            <img align="absMiddle" src="../../images/icon_06.gif" /><%#Eval("title") %></h3>
                        <div class="gray">
                            <%#((DateTime)Eval("updatedate")).ToString("yyyy年MM月dd日 hh:mm:ss") %> | 阅读：(<%#Eval("hits") %>) | 评论：(<%#Eval("coment") %>)
                        </div>
                        <div class="newsFontSize">
                            浏览字体：<a href="javascript:;" onclick="$('.newsContent *').css({'font-size':'16px','line-height':'27px'})">大</a>
                            <a href="javascript:;" onclick="$('.newsContent *').css({'font-size':'14px','line-height':'24px'})">
                                中</a> <a href="javascript:;" onclick="$('.newsContent *').css({'font-size':'12px','line-height':'21px'})">
                                    小</a>
                        </div>
                        <div class="newsContent">
                            <%#Server.UrlDecode(Eval("content").ToString()) %>
                        </div>
                         <script type="text/javascript">
                            //图片自缩放
                           $(".newsContent img").each(function(){
                               changeImg(this,708,1000)
                           });
                        </script>
                   </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <div class="About marginTop8">
            <div class="AboutHead">
                <div class="AHLeft">
                    文章评论</div>
            </div>
            <div class="newsComent">
                <asp:Repeater ID="Repeater2" runat="server" EnableViewState="false">
                    <ItemTemplate>
                        <div class="comentBody">
                            <div class="comfloor">
                                第<%#replyNum-Container.ItemIndex %>楼</div>
                            <div class="comContent">
                                <ul>
                                    <li class="comCheck">
                                        <input  style="visibility:<%=ViewState["isLogin"].ToString()=="0"?"hidden":"visible" %>"  type="checkbox" name="cmid" value="<%#Eval("id") %>" /></li>
                                    <li class="comHeadFace">
                                        <img  src="<%#Eval("avater") %>" alt="个人头像" onerror="javascript:this.src='http://i00.c.aliimg.com/blog/images/club/ebook/pic85x85.jpg'" /></li>
                                    <li class="comLiDetail">
                                        <div>
                                            <b><%#Eval("UserID") %></b><span class="marginLeft1em"></span><a  target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=<%#Eval("qq") %>"><img src="../images/button_dgzh.gif" /></a><span class="marginLeft1em"></span><a
                                                    href="http://shop<%#Eval("memberid") %>.ds568.net" target="_blank">(http://shop<%#Eval("memberid") %>.ds568.net)</a></div>
                                        <div class="comConDetail">
                                            <%#Server.UrlDecode(Eval("content").ToString()) %>
                                        </div>
                                        <div class="comDate">
                                            <%#Eval("createdate") %><br />
                                            <a href="http://shop<%#Eval("memberid") %>.ds568.net" target="_blank">(http://shop<%#Eval("memberid") %>.ds568.net)</a>
                                        </div>
                                         
                                    </li>
                                </ul>
                            </div>
                            <div class="comReply" style="visibility:<%=ViewState["isLogin"].ToString()=="0"?"hidden":"visible" %>">
                                <a href="javascript:void(0);" >回复此评论</a></div>
                            <div class="comDel" style="visibility:<%=ViewState["isLogin"].ToString()=="0"?"hidden":"visible" %>">
                                <%#Eval("ip") %>
                                <input  type="button"  class="del_comment" cmid="<%#Eval("id") %>" value="删除评论" /><span class="loading2">提交中…</span></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="nocoment">
                当前还没有评论。</div>
            <div class="comSelectAll" style="visibility:<%=ViewState["isLogin"].ToString()=="0"?"hidden":"visible" %>">
                <div class="comContent">
                    <ul>
                        <li>
                            <input id="Checkbox5" type="checkbox" />全部选择</li>
                        <li class="comLiDetail">
                            <input id="Button4" class="del_All" type="button" value="删除所选评论" /><span class="loading2">提交中…</span></li>
                    </ul>
                </div>
            </div>
        </div>
        
        <div class="About marginTop8">
            <div class="AboutHead">
                <div class="AHLeft">
                    发表评论</div><div class="comTips">请严格遵守相关法律，严禁恶意评论和垃圾评论</div>
            </div>
            <div class="publishComent overFlowAuto">
                <div class="publishComent-cont overFlowAuto"><ul><li>内容：</li><li>
                    <textarea  id="coment" cols="20" rows="2"></textarea></li></ul></div>
                <div class="publishComent-btn"><span class="loading2">数据提交中…</span>
                    <div class="scmwrap"><input  type="button" class="iptSubmit" value="提交" /><span class="marginLeft1em"></span><span class="marginLeft1em"></span><span class="marginLeft1em"></span><input id="Button6" class="iptReset" type="button" value="重置" /></div></div>
            </div>
        </div>
    <!--========内容结束=============-->
        <div class="lgbody">
            <div class="itwrap">
                <div class="lgitem">
                    <div class="lgiL">
                        用户名：</div>
                    <div class="lgiR">
                        <input  class="cmuid txtBox" /></div>
                </div>
                <div class="lgitem">
                    <div class="lgiL">
                        密<span class="marginLeft1em"></span>码：</div>
                    <div class="lgiR">
                        <input type="password" class="txtBox cmpwd" /></div>
                </div>
                <div class="lgitem">
                    <div class="lgiL">
                        &nbsp;</div>
                    <div class="lgiR"><span class="loading2">数据提交中…</span>
                        <div class="actctn"><input type="button" class="btnlogin" value="登录" /><span class="marginLeft1em"></span><a href="/member/join/reg.aspx">免费注册</a></div></div>
                </div>
            </div>
        </div>
  </div>
 
</asp:Content>
