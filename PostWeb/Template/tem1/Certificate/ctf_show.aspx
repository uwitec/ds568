<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ctf_show.aspx.cs" Inherits="Template_tem1_Certificate_ctf_show" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>企业证书</title>
    <style type="text/css">
        .main{text-align:center;margin-top:50px;}
    </style>
</head>
<body>
    <div class="main">
        <img src="<%=Request["img_url"] %>" onerror="this.style.display='none'" />
    </div>
</body>
</html>
