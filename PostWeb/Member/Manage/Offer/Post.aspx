<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="Post.aspx.cs" Inherits="Member_Manage_Offer_Post" Title="发布产品" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="Css/Post.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="/KindEditor/kindeditor-min.js"></script>
<script type="text/javascript" src="/KindEditor/lang/zh_CN.js"></script>
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
            <option value="">您经常使用的类目：</option>
            <option value="155">手机通讯 > 电话卡</option>
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
      </div><input type="hidden"  name="catid" id="catid" class="required" />
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>商铺分类：</div>
    <div class="iRight floatL">
         <select name="shopCat" id="shopCat">
            <option value="">==选择自定义分类==</option>
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                   <option value="<%#Eval("id") %>"><%#Eval("CategoryName") %></option>
                </ItemTemplate>
            </asp:Repeater>
        </select>&nbsp;&nbsp;<a href="javascript:;" id="addCat">添加分类</a>
        <div class="catctn"><div id="wrall">分类名称：<input class="catname" /><input type="button" class="saveCat" value="保存" /></div></div>
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
     
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>信息标题：</div>
    <div class="iRight floatL gray"><input type="text" maxlength="60"   name="proTitle" id="proTitle" class="txtbox proTitle required" /> 最长30个汉字（60个字符），建议在标题中包含产品名称和相应关键词
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
    <textarea id="content" name="content"></textarea>
    <div>1、插入图片时请勿盗用他人图片、以免引起纠纷。</div>
    2、您可添加点石网内部链接， 加入其它网站链接、系统将自动过滤
    </div>
</div>
<div class="stepTitle">交易信息</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>计量单位：</div>
    <div class="iRight floatL">
        <select name="unit" id="unit" class="prounit required">
			<option id="161" value="副" >副</option>
			<option id="241" value="锭" >锭</option>
			<option id="121" value="立方" >立方</option>
			<option id="141" value="分钟" >分钟</option>
			<option id="1" value="刀" >刀</option>
			<option id="2" value="公升" >公升</option>
			<option id="3" value="码" >码</option>
			<option id="4" value="升" >升</option>
			<option id="5" value="桶" >桶</option>
			<option id="6" value="面" >面</option>
			<option id="7" value="把" >把</option>
			<option id="8" value="包" >包</option>
			<option id="9" value="本" >本</option>
			<option id="10" value="部" >部</option>
			<option id="11" value="打" >打</option>
			<option id="12" value="袋" >袋</option>
			<option id="13" value="吊" >吊</option>
			<option id="14" value="顶" >顶</option>
			<option id="15" value="对" >对</option>
			<option id="16" value="吨" >吨</option>
			<option id="17" value="幅" >幅</option>
			<option id="18" value="个" >个</option>
			<option id="19" value="根" >根</option>
			<option id="20" value="公斤" >公斤</option>
			<option id="21" value="罐" >罐</option>
			<option id="22" value="毫米" >毫米</option>
			<option id="23" value="毫升" >毫升</option>
			<option id="24" value="盒" >盒</option>
			<option id="25" value="架" >架</option>
			<option id="26" value="件" >件</option>
			<option id="27" value="节" >节</option>
			<option id="28" value="具" >具</option>
			<option id="29" value="卷" >卷</option>
			<option id="30" value="卡" >卡</option>
			<option id="31" value="颗" >颗</option>
			<option id="32" value="棵" >棵</option>
			<option id="33" value="克" >克</option>
			<option id="34" value="块" >块</option>
			<option id="35" value="款" >款</option>
			<option id="36" value="厘米" >厘米</option>
			<option id="37" value="粒" >粒</option>
			<option id="38" value="辆" >辆</option>
			<option id="39" value="枚" >枚</option>
			<option id="40" value="米" >米</option>
			<option id="41" value="盆" >盆</option>
			<option id="42" value="片" >片</option>
			<option id="43" value="平方厘米" >平方厘米</option>
			<option id="44" value="平方米" >平方米</option>
			<option id="45" value="平方英尺" >平方英尺</option>
			<option id="46" value="瓶" >瓶</option>
			<option id="47" value="千克" >千克</option>
			<option id="48" value="束" >束</option>
			<option id="49" value="双" >双</option>
			<option id="50" value="台" >台</option>
			<option id="51" value="套" >套</option>
			<option id="52" value="条" >条</option>
			<option id="53" value="头" >头</option>
			<option id="54" value="箱" >箱</option>
			<option id="55" value="英寸" >英寸</option>
			<option id="56" value="盏" >盏</option>
			<option id="57" value="张" >张</option>
			<option id="58" value="支" >支</option>
			<option id="59" value="只" >只</option>
			<option id="60" value="株" >株</option>
			<option id="61" value="组" >组</option>
			<option id="62" value="尊" >尊</option>
			<option id="63" value="座" >座</option>
			<option id="64" value="票" >票</option>
			<option id="65" value="单" >单</option>
			<option id="181" value="磅" >磅</option>
			<option id="81" value="路" >路</option>
			<option id="221" value="平方尺" >平方尺</option>
        </select>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>价格区间：</div>
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
                <td class="tdfirst">购买 <input  name="wb1" id="wb1" class="txtbox et required"  size="20"  type="text"  /></td>
                <td> </td>
                <td class="td3"> <span class="untxt"></span>及以上：</td>
                <td><input  name="wprice1" id="wprice1" size="20" class="txtbox et required" type="text"  />&nbsp;</td>
                <td><span class="price_money">元</span>/</td>
                <td><span class="untxt"></span></td>
                <td class="tdaction">&nbsp;</td>
            </tr>
            <tr class="hidden">
                <td class="tdfirst">购买 <input  name="wb2" id="wb2" size="20" class="txtbox et" type="text"   /></td>
                <td> </td>
                <td class="td3"> <span class="untxt"></span>及以上：</td>
                <td><input  name="wprice2" id="wprice2"  size="20" type="text" class="txtbox et"   />&nbsp;</td>
                <td><span class="price_money">元</span>/</td>
                <td><span class="untxt"></span></td>
                <td class="tdaction">&nbsp;<a href="#" et="err2">删除</a></td>
            </tr>
            <tr class="hidden">
                <td class="tdfirst">购买 <input  name="wb3" id="wb3" size="20" class="txtbox et" type="text"  /></td>
                <td> </td>
                <td class="td3"> <span class="untxt"></span>及以上：</td>
                <td><input  name="wprice3" id="wprice3"  size="20" type="text" class="txtbox et"  />&nbsp;</td>
                <td><span class="price_money">元</span>/</td>
                <td><span class="untxt"></span></td>
                <td class="tdaction">&nbsp;<a href="#" et="err3">删除</a></td>
            </tr>
            <tr>
                <td class="tdlast" colspan="7"><a href="#">增加价格区间</a></td>
            </tr>
       </table>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL">供货总量：</div>
    <div class="iRight floatL">
       <input name="maxNumber" type="text" class="txtbox" /> <span class="untxt"></span>
    </div>
</div>
<div class="item">
    <div class="iLeft floatL"><span class="red">*</span>信息有效期：</div>
    <div class="iRight floatL">
       <input type="radio" name="Period" value="10" id="Period1" class="required" /><label for="Period1">10天</label>
       <input type="radio" name="Period" value="20" id="Period2" /><label for="Period2">20天</label>
       <input type="radio" name="Period" value="30" id="Period3" /><label for="Period3">1个月</label>
       <input type="radio" name="Period" value="90" id="Period4" /><label for="Period4">3个月</label>
       <input type="radio" name="Period" value="180" id="Period5" /><label for="Period5">6个月</label>
    </div>
</div>
<div class="endline">&nbsp;</div>
<div class="item">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
       提示：若无法提交请检查上面各必填项是否填写完整。
    </div>
</div>
<div class="item divsub">
    <div class="iLeft floatL">&nbsp;</div>
    <div class="iRight floatL">
      <input type="button" class="subBtn"  value="同意协议条款，我要发布" />
    </div>
</div>
</asp:Content>
