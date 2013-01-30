<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_contact.aspx.cs" Inherits="Template_tem1_contact_index_contact" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="Server">
联系我们
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<script type="text/javascript" src="js/contact.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<input type="hidden" id="mapNid" value="<%=_vMember.MapNid%>" />
    <div class="MiddleRight">
        <!--========内容开始=============-->
        <div class="About">
            <div class="box-hd AboutHead">
                <div class="AHLeft">
                    联系方式</div>
            </div>
            <div class="box-ctn contactBody contacts">
                <div>
                    <div class="companyName">
                        <%=_vMember.CompanyName %></div>
                    <dl class="contact-man">
                        <dt>联系人：</dt>
                        <dd>
                            <a href="../profile/index_profile.aspx" ><%=_vMember.TrueName%></a>&nbsp;<%=_vMember.Gender%>（<%=_vMember.Position%>）&nbsp;&nbsp;
                        </dd>
                        <dd>
                            <a target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=<%=_vMember.QQ %>">
                                <img border="0" src="http://wpa.qq.com/pa?p=1:<%=_vMember.QQ %>:1" title="给我发消息" alt="给我发消息"></a></dd>
                    </dl>
                    <div class="credit">
                        <a href="javascript:;alert('诚信档案尚未开放，请稍后访问。')" title="点击查看信用状况">查看信用状况</a>
                    </div>
                    <div class="contactsLine"></div>
                </div>
                <ul class="contactsDetail">
                    <li>电<span class="marginLeft1em"></span><span class="marginLeft1em"></span>话： <%=_vMember.Phone.TrimEnd('-')%></li>
                    <li>移动电话： <%=_vMember.Mobile%></li>
                    <li>传<span class="marginLeft1em"></span><span class="marginLeft1em"></span>真： <%=_vMember.Fax.TrimEnd('-')%></li>
                    <li>地<span class="marginLeft1em"></span><span class="marginLeft1em"></span>址： <%=_vMember.BusinessAddress%></li>
                    <li>邮<span class="marginLeft1em"></span><span class="marginLeft1em"></span>编： <%=_vMember.ZipCode%></li>
                    <li class="comLink">公司主页：
                      <a href="<%=_vMember.HomePage %>" target="_blank"><%=_vMember.HomePage%></a>
                    
                    </li>
                </ul>
                <div>
                    <iframe style="display:none;margin-top:12px;" id="map"  width="700px" height="450px" scrolling="no" border="0" frameborder="0" src=""></iframe>
                </div>
            </div>
        </div>
        <!--========内容结束=============-->
    </div>
</asp:Content>
