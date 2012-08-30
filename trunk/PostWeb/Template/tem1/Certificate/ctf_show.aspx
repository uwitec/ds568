<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ctf_show.aspx.cs" Inherits="Template_tem1_Certificate_ctf_show" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>企业证书</title>
    <style type="text/css">
        .wp-t-l{width:24px;height:21px;}
        .wp-t-m{background:url(images/top-mid.png);}
        .wp-t-r{width:22px;}
        .wp-m-l{ background:url(images/left-mid.png);width:24px;}
        .wp-m-m{padding:4px 24px; background-color:#fbfbe1;}
        .wp-m-r{background:url(images/right-mid.png);width:22px;}
        .wp-b-l{height:20px;width:22px;}
        .wp-b-m{background:url(images/bottom-mid.png);}
        .wp-m-m div{padding:5px;border:solid 1px #ccc;}
    </style>
</head>
<body>
    <div class="main">
   
        <table cellpadding=0 cellspacing=0 align="center">
            <tr>
                <td class="wp-t-l"><img src="images/top-left.png" /></td>
                <td class="wp-t-m"></td>
                <td class="wp-t-r"><img src="images/top-right.png" /></td>
            </tr>
            <tr>
                <td class="wp-m-l"></td>
                <td class="wp-m-m"><div><img src="<%=Request["img_url"] %>" onerror="this.style.display='none'" /></div></td>
                <td class="wp-m-r"></td>
            </tr>
            <tr>
                <td class="wp-b-l"><img src="images/bottom-left.png" /></td>
                <td class="wp-b-m">&nbsp;</td>
                <td class="wp-b-r"><img src="images/bottom-right.png" /></td>
            </tr>
        </table>
    </div>
</body>
</html>
