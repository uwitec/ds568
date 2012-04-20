<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="DSAdmin_Area_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <Custom:Header runat="server" ID="Header1" />
    <script type="text/javascript" src="/dsadmin/js/dsadmin.js"></script>
    <script type="text/javascript" src="js/area.js"></script>
    <link href="/DSAdmin/tab/css/tab.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .tabList tr td{ text-align:center;}
        .scctn{ position:absolute;right:26px;top:10px;}
        .scctn *{}
        .txtbox{width:120px;line-height:18px;height:18px;}
        .addwrap{padding:30px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <input id="crtid" type="hidden" value="<%=ViewState["pid"] %>" />
    <Custom:ToolBar runat="server" ID="ToolBar1" />
   <table  border="0" class="tabList" align="center" cellpadding="0" cellspacing="1">
        <tr class="tbhead">
            <td width="60" align=center>
                全<input type="checkbox" id="chkall" />选
            </td>
            <td>
               地区名称
            </td>
            <td>操作</td>
            <td>
                排序
            </td>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                <td>
                    <div align="center">
                        <input name="checkboxid" type="checkbox" value="<%#Eval("ID") %>" />
                    </div>
                </td>
                <td>
                   <%#Eval("AreaName")%>
                </td>
                <td><a href="?id=<%#Eval("id") %>">下级地区</a> / <a class="lkedit" an="<%#Eval("areaname") %>" aid="<%#Eval("id") %>" href="javascript:void(0);">修改</a></td>
                <td>
                    <div class="order">
                        <asp:LinkButton ID="LinkButton1" OnClick="LinkButtonPx_Click" pid='<%#Eval("ID")%>' ToolTip="置上" cn="True" CssClass="pxup" runat="server">&nbsp;</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" OnClick="LinkButtonPx_Click" pid='<%#Eval("ID")%>' ToolTip="置下" cn="False" CssClass="pxdown" runat="server">&nbsp;</asp:LinkButton>
                    </div>
                </td>
            </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
     <div class="scctn">
        当前路径：<%=ViewState["area"]%>
    </div>
    </form>
</body>
</html>
















 