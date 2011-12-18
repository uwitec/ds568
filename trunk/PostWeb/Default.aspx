<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Com.ItOnline.Web._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="css/Globle.css" rel="stylesheet" type="text/css" />
    <link href="js/css/area.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/lib.js"></script>
    <script type="text/javascript" src="js/common.js"></script>
</head>
<body style="padding:20px;"> 
  <input class="Area" type="text" />
<script type="text/javascript">
    $(document).ready(function(){
        function cb(p,c){
            alert(p)
        }
        Area.Create($(".Area"),cb);
    });
</script>
<form id="form1" runat="server">
<asp:Button ID="Button1" runat="server" Text="Button" />
</form>
</body>
</html>

