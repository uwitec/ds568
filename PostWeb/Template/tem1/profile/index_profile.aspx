<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_profile.aspx.cs" Inherits="Template_tem1_profile_index_profile" %>
    <asp:Content ID="Content4" ContentPlaceHolderID="Title" runat="server">
    <%="公司简介,"+ _vMember.CompanyName%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript" src="js/profile.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<input type="hidden" value="<%=_vMember.ComImg %>" id="hdimgurl" />
    <div class="MiddleRight">
        <!--========内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    公司介绍</div>
            </div>
            <div class="profileBody">
                <div class="comimgCtn"></div>
               
                &nbsp;<%=_vMember.Profile%>
            </div>
        </div>
        <div class="About NoTopBorder">
            <div class="AboutHead">
                <div class="AHLeft">
                    详细信息</div>
            </div>
            <div class="profileBody">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <table width="98%" border="0" align="center"  cellpadding="0" cellspacing="1" bgcolor="#FFFFFF" style="line-height:30px;">
                    <tr>
                        <td width="17%" bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>主营产品或服务：</strong>
                            </div>
                        </td>
                        <td width="33%" bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" style="word-break: break-all" align="left">
                            <%#Eval("OfferService").ToString().TrimEnd(',')%>
                        </td>
                        <td width="17%" bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>主营行业：</strong>
                            </div>
                        </td>
                        <td width="33%" valign="top" bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px;
                            padding-left: 5px; padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("MainIndustry")%>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>企业类型：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#GetBt(Eval("BusinessType"))%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>经营模式： </strong>
                            </div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("BusinessModel")%>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>注册资本：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("CapitalType")%> <%#double.Parse(Eval("RegisteredCapital").ToString()).ToString("N2")%> 万
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>公司注册地：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("RegistrationArea")%>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>员工人数：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#GetStaffNum(Eval("Employees"))%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>公司成立时间：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("YearEstablished")%> 年
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>法定代表人/负责人：</strong>
                            </div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("LegalRepresentative")%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>年营业额： </strong>
                            </div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#GetTu(Eval("AnnualTurnover"))%>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>主要经营地点：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("BusinessAddress")%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>经营品牌：</strong></div>
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;" align="left">
                            <p>
                                <%#Eval("BrandName")%></p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>是否提供OEM代加工？</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                             <%#Eval("OEM") == null ? "--" : ((bool)Eval("OEM"))?"是":"否"%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>质量控制：</strong></div>
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;" align="left">
                            <p>
                                <%#Eval("QualityControl")%></p>
                        </td>
                    </tr>
                    
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>年进口额：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                             <%#GetTu(Eval("AnnualImports"))%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>年出口额：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                             <%#GetTu(Eval("AnnualExport"))%>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>研发部门人数：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#GetStaffNum(Eval("StudyEmployees"))%>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>厂房面积：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("StorageArea") == null ? "" : Eval("StorageArea").ToString() + " 平方米"%> 
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>月产量：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <%#Eval("Monthly") == null ? "" : Eval("Monthly").ToString() +" "+ Eval("MonthlyUnit")%> 
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-left: 15px;
                            padding-right: 8px; padding-bottom: 3px;">
                            &nbsp;
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>公司主页：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                           <a href="<%#Eval("HomePage") %>" target="_blank"><%#Eval("HomePage")%></a>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-left: 15px;
                            padding-right: 8px; padding-bottom: 3px;">
                            &nbsp;
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
        <!--========内容结束=============-->
    </div>
</asp:Content>
