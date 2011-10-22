<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="DSAdmin_Product_Property_Add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <Custom:Header runat="server" ID="Header1" />
    <link href="/DSAdmin/tab/Css/tab.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table cellpadding=0 cellspacing=1 class="tab">
        <tr>
            <td class="tdtitle">当前分类：</td>
            <td>
                <%=new Com.DianShi.BusinessRules.Product.DS_SysProductCategory_Br().GetCategoryName(int.Parse(Request.QueryString["SysCatID"]),false).TrimEnd('>')%>
            </td>
        </tr>
        <tr>
            <td class="tdtitle">属性名称：</td>
            <td>
                <input class="txtbox" runat="server" id="cname"  /> 
            </td>
        </tr>
       <tr>
            <td class="tdtitle">控件类型：</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
         <tr>
            <td class="tdtitle">属性单位：</td>
            <td>
                <input class="txtbox" runat="server" id="unit"  /> 
            </td>
        </tr>
        <tr>
            <td class="tdtitle">映射序号：</td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="tdtitle"></td>
            <td>
                <asp:CheckBox ID="CheckBox1" Text="是否必填" runat="server" />
            </td>
        </tr>
    </table>
    <div class="divsub"><span></span><asp:Button ID="Button1" runat="server" CssClass="btn" Text="保存" /> <input type="button" class="btn" onclick="location='list.aspx?SysCatID=<%=Request.QueryString["SysCatID"] %>'" value="返回列表" /></div>
    </form>
</body>
</html>
