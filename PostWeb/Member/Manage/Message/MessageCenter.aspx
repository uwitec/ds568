<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MessageCenter.aspx.cs" Inherits="Member_Manage_Message_MessageCenter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>消息中心</title>
    <Custom:Header ID="Header1" runat="server" />
    <link href="/Member/Manage/Css/Master.css" rel="stylesheet" type="text/css" />
    <link rel="Stylesheet" type="text/css" href="Css/msgct.css" />
</head>
<body>
    <form id="form1" runat="server">
     <div class="mainctn">
         <div class="msghd">消息中心</div>
         <ul class="hmenu">
            <li>
                 <div class="mLeft "></div>
                 <div class="mMiddle ">最近消息</div>
                 <div class="mRight "></div>
            </li>
            <li>
                 <div class="mLeft lunsl"></div>
                 <div class="mMiddle munsl"><a href="javascript:;">系统通知</a></div>
                 <div class="mRight runsl"></div>
            </li>
            <li>
                 <div class="mLeft lunsl"></div>
                 <div class="mMiddle munsl"><a href="javascript:;">留言互动</a></div>
                 <div class="mRight runsl"></div>
            </li>
            <li class="request"><%--<a href="#">已过滤消息</a>--%></li>
        </ul>
        <div class="listctn"></div>
     </div>
    </form>
</body>
</html>
