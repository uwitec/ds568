<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DecMaster.aspx.cs" Inherits="Member_Manage_Decoration_DecMaster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>装修旺铺</title>
    <Custom:Header ID="Hd1" runat="server" />
    <link rel="Stylesheet" href="css/DesMaster.css" />
    <script type="text/javascript" src="js/DecMaster.js"></script>
</head>
<body>
    <div class="topbar">
        <div class="barbody">
            <div class="logo"><img src="http://i05.c.aliimg.com/cms/upload/homepage/logo-homepage.png" height="25" /></div><div class="spline"></div>
        </div>
    </div>
    <iframe  src="http://shop<%=_userData.Member.ID %>.ds568.net" framespacing="0"   frameborder="0"  border="0"   width="100%"   name="conFrame" id="mainFrame" />
</body>
</html>
