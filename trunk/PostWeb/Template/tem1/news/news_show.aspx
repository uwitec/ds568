<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="news_show.aspx.cs" Inherits="Template_tem1_news_news_show" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                        <div class="newsContent justify">
                            <%#Server.UrlDecode(Eval("content").ToString()) %>
                        </div>
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
                 <div class="comentBody">
                    <div class="comfloor">
                        第3楼</div>
                    <div class="comContent">
                        <ul>
                            <li class="comCheck">
                                <input id="Checkbox1" type="checkbox" /></li>
                            <li class="comHeadFace">
                                <img src="http://i01.c.aliimg.com/club/upload/pic/user/h/e/b/c/hebchangcheng_s.jpeg" onerror="javascript:this.src='http://i00.c.aliimg.com/blog/images/club/ebook/pic85x85.jpg'" /></li>
                            <li class="comLiDetail">
                                <div>
                                    <b><a href="#" target="_blank">alwdeguan</a></b><span class="marginLeft1em"></span><a
                                        href="javascript:;"><img src="../images/button_dgzh.gif" /></a><span class="marginLeft1em"></span><a
                                            href="#" target="_blank">(http://alwdeguan.blog.china.alibaba.com)</a></div>
                                <div class="comConDetail">
                                    明天是端午节，送你只香甜粽子：以芬芳的祝福为叶，以宽厚的包容为米，以温柔的叮咛做馅，再用友情的丝线缠绕，愿你品尝出人生的美好和这五月五的情怀！ 

                                </div>
                                <div class="comDate">
                                    2011-05-15 11:16:50<br />
                                    <a href="#" target="_blank">(http://alwdeguan.blog.china.alibaba.com)</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="comReply">
                        <a href="javascript:;">回复此评论</a></div>
                    <div class="comDel">
                        116.30.211.23
                        <input id="Button1" type="button" value="删除评论" /></div>
                </div>
                <div class="comentBody">
                    <div class="comfloor">
                        第2楼</div>
                    <div class="comContent">
                        <ul>
                            <li class="comCheck">
                                <input id="Checkbox2" type="checkbox" /></li>
                            <li class="comHeadFace">
                                <img src="324" onerror="javascript:this.src='http://i00.c.aliimg.com/blog/images/club/ebook/pic85x85.jpg'" /></li>
                            <li class="comLiDetail">
                                <div>
                                    <b><a href="#" target="_blank">alwdeguan</a></b><span class="marginLeft1em"></span><a
                                        href="javascript:;"><img src="../images/button_dgzh.gif" /></a><span class="marginLeft1em"></span><a
                                            href="#" target="_blank">(http://alwdeguan.blog.china.alibaba.com)</a></div>
                                <div class="comConDetail">
                                    这个消息对中小卖家来说，是个不好的消息。总之，天上不会掉馅饼！
                                </div>
                                <div class="comDate">
                                    2011-05-15 11:16:50<br />
                                    <a href="#" target="_blank">(http://alwdeguan.blog.china.alibaba.com)</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="comReply">
                        <a href="javascript:;">回复此评论</a></div>
                    <div class="comDel">
                        116.30.211.23
                        <input id="Button2" type="button" value="删除评论" /></div>
                </div>
                <div class="comentBody">
                    <div class="comfloor">
                        第1楼</div>
                    <div class="comContent">
                        <ul>
                            <li class="comCheck">
                                <input id="Checkbox3" type="checkbox" /></li>
                            <li class="comHeadFace">
                                <img src="213.jpg" onerror="javascript:this.src='http://i00.c.aliimg.com/blog/images/club/ebook/pic85x85.jpg'" /></li>
                            <li class="comLiDetail">
                                <div>
                                    <b><a href="#" target="_blank">alwdeguan</a></b><span class="marginLeft1em"></span><a
                                        href="javascript:;"><img src="../images/button_dgzh.gif" /></a><span class="marginLeft1em"></span><a
                                            href="#" target="_blank">(http://alwdeguan.blog.china.alibaba.com)</a></div>
                                <div class="comConDetail">
                                    这个消息对中小卖家来说，是个不好的消息。总之，天上不会掉馅饼！
                                </div>
                                <div class="comDate">
                                    2011-05-15 11:16:50<br />
                                    <a href="#" target="_blank">(http://alwdeguan.blog.china.alibaba.com)</a>
                                </div>
                            </li>
                        </ul>
                    </div>
                    <div class="comReply">
                        <a href="javascript:;">回复此评论</a></div>
                    <div class="comDel">
                        116.30.211.23
                        <input id="Button3" type="button" value="删除评论" /></div>
                </div>
                <div class="comentBody comSelectAll">
                    <div class="comContent">
                        <ul>
                            <li>
                                <input id="Checkbox5" type="checkbox" />全部选择</li>
                            <li class="comLiDetail">
                                <input id="Button4" type="button" value="删除所选评论" /></li>
                        </ul>
                    </div>
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
                    <textarea id="TextArea1" cols="20" rows="2"></textarea></li></ul></div>
                <div class="publishComent-btn"><input id="Button5" type="button" class="iptSubmit" value="提交" /><span class="marginLeft1em"></span><span class="marginLeft1em"></span><span class="marginLeft1em"></span><input id="Button6" class="iptReset" type="button" value="重置" /></div>
            </div>
        </div>
    </div>
    <!--========内容结束=============-->
    </div>
</asp:Content>
