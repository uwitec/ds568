<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Post.aspx.cs" Inherits="Member_Manage_Offer_Post" Title="发布产品" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="Css/Post.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="Js/Post.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">发布供应信息</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<ul class="stepctn">
    <li class="sleft"></li>
    <li class="sfirst">1.选择系统类目及自定义分类</li>
    <li class="smiddle">2.填写产品详细信息</li>
    <li class="smiddle">3.填写交易信息</li>
    <li class="smiddle">4.提交成功、等待审核</li>
    <li class="sright"></li>
</ul>
<div class="stepTitle">选择系统类目及自定义分类</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>系统分类：</div>
    <div class="iRight floatL">
        <select id="sysCat" name="sysCat">
            <option>==您经常使用的类目==</option>
        </select> 或 <a href="javascript:;" id="acatdiy">自选类目</a>
    </div>
</div>
<div class="item catDiy">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL"><ul id="c1">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <li cid="<%#Eval("id") %>" class="<%#(int)Eval("sc")>0?"hassub":"" %>"><%#Eval("CategoryName")%></li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
         <ul id="c2"></ul>
         <ul id="c3"></ul>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
       <div class="Remind">
      您当前选择的类目：<span></span>
      </div>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>自定义分类：</div>
    <div class="iRight floatL">
         <select name="shopCat">
            <option>==选择自定义分类==</option>
        </select>&nbsp;&nbsp;<a href="javascript:;">添加分类</a>
    </div>
</div>
<div class="stepTitle">填写详细信息</div>
<div class="item">
    <div class="iLeft floatL">产品属性：</div>
    <div class="iRight floatL gray">完整的产品属性有助于买家找到您的信息
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL property">
        <div class="prtctn overflowAuto">
            <div class="prtn floatL">品牌：</div>
            <div class="floatL">
                <input id="Text1" class="txtbox" type="text" /></div>
        </div>
        <div class="prtctn overflowAuto">
            <div class="prtn floatL">型号：</div>
            <div class="floatL">
                <input id="Text2" class="txtbox" type="text" /></div>
        </div>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>信息标题：</div>
    <div class="iRight floatL gray"><input type="text" name="proTitle" class="txtbox proTitle" /> 最长30个汉字（60个字符），建议在标题中包含产品名称和相应关键词
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">产品图片：</div>
    <div class="iRight floatL gray">建议您上传产品实拍大图，帮助买家直观了解您的产品细节
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
        <div class="imguplodctn">
            <div class="imgctn"></div>
            <div></div>
        </div>
    </div>
</div>
</asp:Content>
