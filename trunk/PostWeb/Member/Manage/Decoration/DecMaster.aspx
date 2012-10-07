<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DecMaster.aspx.cs" Inherits="Member_Manage_Decoration_DecMaster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>装修旺铺</title>
    <Custom:Header ID="Hd1" runat="server" />
    <link rel="Stylesheet" href="css/DesMaster.css" />
    <script type="text/javascript" src="js/DecMaster.js"></script>
</head>
<body style="overflow:hidden">
    <div class="topbar">
        <div class="barbody">
            <div class="logo">&nbsp;</div>
            <div class="dc-menu">选择模板
                <div class="dec-wrap">
                    <div class="stopbox">
                        <div class="gapbox">您可以点击模板图片修改网站风格</div>
                        <div class="close"><img alt="关闭" src="http://style.org.hc360.com/images/detail/mysite/siteconfig/close.gif" /></div>
                    </div>
                    <ul class="theme-wrap">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <li>
                                    <a class="theimg" href="javascript:;" theid="<%#Eval("id") %>"><img onload="changeImg(this,98,98)" src="<%#Com.DianShi.BusinessRules.ShopConfig.DS_ShopTheme_Br.ThemePath((int)Eval("ID"))+Eval("Thume") %>"  /><em class="thename"><%#Eval("ThemeName") %></em></a>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
            </div>
            <div class="btn-wrap"><a id="btn-thume-save" class="commBtn" href="javascript:void(0);"><span class="cb_l">&nbsp;</span><span class="cb_m">保存</span><span class="cb_r">&nbsp;</span></a></div>
                <%--<div class="spline"></div>--%>
        </div>
    </div>
    <iframe  src="http://shop<%=_userData.Member.ID %>.ds568.net" framespacing="0"   frameborder="0"  border="0"   width="100%"   name="mainFrame" id="mainFrame" />
</body>
</html>
