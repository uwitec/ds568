<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Post.aspx.cs" Inherits="Member_Manage_Offer_Post" Title="发布产品" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="Css/Post.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/KindEditor/kindeditor-min.js"></script>
<script type="text/javascript" src="/KindEditor/lang/zh_CN.js"></script>
<script type="text/javascript">
	KindEditor.ready(function(K) {
		 K.create('textarea[name="content"]', {
			resizeType : 1,
			allowPreviewEmoticons : false,
			allowImageUpload : false,
			items : [
				'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold', 'italic', 'underline',
				 'strikethrough','table','|', 'justifyleft', 'justifycenter', 'justifyright', 'insertorderedlist',
				'insertunorderedlist', '|', 'image', 'link','source']
		});
	});
</script>
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
<div class="item divrang">
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
    <div class="iRight floatL gray"><input type="text" maxlength="60" name="proTitle" class="txtbox proTitle" /> 最长30个汉字（60个字符），建议在标题中包含产品名称和相应关键词
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">产品图片：</div>
    <div class="iRight floatL gray">建议您上传产品实拍大图，帮助买家直观了解您的产品细节
    </div>
</div>
<div class="item divrang">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
        <div class="imguplodctn">
            <div class="imgctn"><img src="" id="img00" onload="changeImg(this,110,110)" onerror="$(this).hide()" /></div>
            <div class="upbtn"><input type="button" value="上传图片" /><a href="#">删除</a></div>
        </div>
        <div class="imguplodctn">
            <div class="imgctn imgctn2"><img src="" id="img01" onload="changeImg(this,110,110)" onerror="$(this).hide()" /></div>
            <div class="upbtn"><input type="button" value="上传图片" /><a href="#">删除</a></div>
        </div>
        <div class="imguplodctn">
            <div class="imgctn imgctn3"><img src="" id="img02" onload="changeImg(this,110,110)" onerror="$(this).hide()" /></div>
            <div class="upbtn"><input type="button" value="上传图片" /><a href="#">删除</a></div>
        </div>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">详细说明：</div>
    <div class="iRight floatL gray">请从产品性能、用途、包装、售后服务等方面来描述，建议您在详细说明中插入产品细节图
    </div>
</div>
<div class="item divrang">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
    <textarea id="Textarea1" name="content" style="width:660px;height:200px;visibility:hidden;"></textarea>
    <div>1、插入图片时请勿盗用他人图片、以免引起纠纷。</div>
    2、您可添加点石网内部链接， 加入其它网站链接、系统将自动过滤
    </div>
</div>
<div class="stepTitle">交易信息</div>
<div class="item">
    <div class="iLeft floatL">计量单位：</div>
    <div class="iRight floatL">
        <select name="unit" class="prounit">
            <option>套</option>
        </select>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">价格区间：</div>
    <div class="iRight floatL gray">
       请如实填写产品价格，方便买家订购
    </div>
</div>
<div class="item divrang">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL gray">
       <table cellpadding=0 cellspacing=0 class="priceRang">
            <thead>
                <tr>
                    <th  class="th1" colspan="3">
                        购买数量</th>
                    <th  colspan="4">
                        产品单价</th>
                </tr>
            </thead>
            <tr>
                <td class="tdfirst">购买 <input  name="wb1" class="txtbox" size="20"  type="text" value="1" /></td>
                <td> </td>
                <td class="td3"> 本及以上：</td>
                <td><input  name="wprice1"  size="20" class="txtbox" type="text" value="10.00" />&nbsp;</td>
                <td><span class="price_money">元</span>/</td>
                <td>本</td>
                <td class="tdaction">&nbsp;</td>
            </tr>
             <tr class="hidden">
                <td class="tdfirst">购买 <input  name="wb1" size="20" class="txtbox" type="text" value="1" /></td>
                <td> </td>
                <td class="td3"> 本及以上：</td>
                <td><input  name="wprice1"  size="20" type="text" class="txtbox" value="10.00" />&nbsp;</td>
                <td><span class="price_money">元</span>/</td>
                <td>本</td>
                <td class="tdaction">&nbsp;<a href="#">删除</a></td>
            </tr>
            <tr class="hidden">
                <td class="tdfirst">购买 <input  name="wb1" size="20" class="txtbox" type="text" value="1" /></td>
                <td> </td>
                <td class="td3"> 本及以上：</td>
                <td><input  name="wprice1"  size="20" type="text" class="txtbox" value="10.00" />&nbsp;</td>
                <td><span class="price_money">元</span>/</td>
                <td>本</td>
                <td class="tdaction">&nbsp;<a href="#">删除</a></td>
            </tr>
            <tr>
                <td class="tdlast" colspan="7"><a href="#">增加价格区间</a></td>
            </tr>
       </table>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">最小起订量：</div>
    <div class="iRight floatL">
       <input name="minNumber" type="text" class="txtbox" />
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>信息有效期：</div>
    <div class="iRight floatL">
       <input type="radio" name="Period" id="Period1" /><label for="Period1">10天</label>
       <input type="radio" name="Period" id="Period2" /><label for="Period2">20天</label>
       <input type="radio" name="Period" id="Period3" /><label for="Period3">1个月</label>
       <input type="radio" name="Period" id="Period4" /><label for="Period4">3个月</label>
       <input type="radio" name="Period" id="Period5" /><label for="Period5">6个月</label>
    </div>
</div>
<div class="endline">&nbsp;</div>
<div class="item divsub">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
       <asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="同意协议条款，我要发布" />
    </div>
</div>
</asp:Content>
