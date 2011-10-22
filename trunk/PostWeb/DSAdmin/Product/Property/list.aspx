<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="DSAdmin_Product_Property_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <Custom:Header runat="server" ID="Header1" />
    <script type="text/javascript" src="/dsadmin/js/dsadmin.js"></script>
    <link href="/DSAdmin/tab/css/tab.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .tabList tr td{ text-align:center;}
        .scctn{ position:absolute;right:6px;top:6px;display:none;}
        .scctn *{float:left;}
        .txtbox{width:120px;line-height:18px;height:18px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <Custom:ToolBar runat="server" ID="ToolBar1" />
    <table  border="0" class="tabList" align="center" cellpadding="0" cellspacing="1">
        <tr class="tbhead">
            <td width="60" align=center>
                全<input type="checkbox" id="chkall" />选
            </td>
            
            <td>
               属性名称
            </td>
            <td>
               产品分类
            </td>
            <td>类型</td>
            <td>单位</td>
            <td>映射序号</td>
            <td>必填</td>
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
                   <%#Eval("ProName")%>
                </td>
                  <td>
                   <%#new Com.DianShi.BusinessRules.Product.DS_SysProductCategory_Br().GetCategoryName((int)Eval("SysCatID"), false).TrimEnd('>')%>
                </td>
                <td><%#Enum.GetName(typeof(Com.DianShi.BusinessRules.Product.DS_Property_Br.ControlType),Eval("ControlType"))%></td>
                <td><%#Eval("Unit")%></td>
                <td><%#Eval("MapID")%></td>
                <td><%#((bool)Eval("Request"))?"是":"否"%></td>
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
    <div class="pageinfo">
        [共<%=ToolBar1.AspNetPager.RecordCount %>条记录] [共<%=ToolBar1.AspNetPager.PageCount %>页,每页<%=ToolBar1.AspNetPager.PageSize %>条记录] [当前<%=ToolBar1.AspNetPager.CurrentPageIndex %>/<%=ToolBar1.AspNetPager.PageCount %>页]
    </div>
    <div class="scctn">
        <input name="keyword"  class="txtbox" /><asp:Button ID="Button1"  runat="server" Text="搜索" />
    </div>
    </form>
</body>
</html>
