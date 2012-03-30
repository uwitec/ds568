<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="DSAdmin_Area_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <Custom:Header runat="server" ID="Header1" />
    <script type="text/javascript" src="/dsadmin/js/dsadmin.js"></script>
    <link href="/DSAdmin/tab/css/tab.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .tabList tr td{ text-align:center;}
        .scctn{ position:absolute;right:6px;top:6px;}
        .scctn *{float:left;}
        .txtbox{width:120px;line-height:18px;height:18px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <Custom:ToolBar runat="server" ID="ToolBar1" />
    <asp:TreeView ID="TreeView1" runat="server">
    </asp:TreeView>
    </form>
</body>
</html>
