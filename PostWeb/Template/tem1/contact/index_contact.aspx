<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_contact.aspx.cs" Inherits="Template_tem1_contact_index_contact"
    Title="Untitled Page" %>
<asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="Server">
<title>联系我们</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
<script type="text/javascript" src="js/contact.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<input type="hidden" id="mapNid" value="<%=ViewState["mapNid"] %>" />
    <div class="MiddleRight">
        <!--========内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    联系方式</div>
            </div>
            <div class="contactBody contacts">
                <div>
                    <div class="companyName">
                        <%=ViewState["comName"] %></div>
                    <dl class="contact-man">
                        <dt>联系人：</dt>
                        <dd>
                            <a href="../profile/index_profile.aspx?member_id=<%=Request.QueryString["member_id"] %>" ><%=ViewState["TrueName"]%></a>&nbsp;<%=ViewState["Gender"]%>（<%=ViewState["position"] %>）&nbsp;&nbsp;
                        </dd>
                        <dd>
                            <a target="blank" href="http://wpa.qq.com/msgrd?V=1&Uin=416351551">
                                <img border="0" src="http://wpa.qq.com/pa?p=1:416351551:1" title="给我发消息" alt="给我发消息"></a></dd>
                    </dl>
                    <div class="credit">
                        <a href="javascript:;alert('诚信档案尚未开放，请稍后访问。')" title="点击查看信用状况">查看信用状况</a>
                    </div>
                    <div class="contactsLine"></div>
                </div>
                <ul class="contactsDetail">
                    <li>电<span class="marginLeft1em"></span><span class="marginLeft1em"></span>话： <%=ViewState["phone"] %></li>
                    <li>移动电话： <%=ViewState["mobile"]%></li>
                    <li>传<span class="marginLeft1em"></span><span class="marginLeft1em"></span>真： <%=ViewState["fax"]%></li>
                    <li>地<span class="marginLeft1em"></span><span class="marginLeft1em"></span>址： <%=ViewState["address"]%></li>
                    <li>邮<span class="marginLeft1em"></span><span class="marginLeft1em"></span>编： <%=ViewState["zipcode"]%></li>
                    <li class="comLink">公司主页：
                      <a href="<%=ViewState["homepage"] %>" target="_blank"><%=ViewState["homepage"] %></a>
                    
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
