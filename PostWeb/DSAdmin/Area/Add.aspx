<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="DSAdmin_Area_Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加地区</title>
    <Custom:Header runat="server" ID="Header1" />
    <script type="text/javascript" src="/js/EasyUi/easyloader.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-top:10px;text-align:center;">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1"
            runat="server" Text="保存" />
    </div>
    </form>
</body>
</html>
