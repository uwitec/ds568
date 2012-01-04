<%@ Page Language="C#" MasterPageFile="~/Member/Manage/MasterPage.master" AutoEventWireup="true" CodeFile="BaseInfo.aspx.cs" Inherits="Member_Manage_CompanyInfo_BaseInfo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="Css/BaseInfo.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/BaseInfo.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<ul class="hmenu">
    <li>
        <div class="mLeft"></div>
        <div class="mMiddle">基本资料</div>
        <div class="mRight"></div>
    </li>
    <li class="request"><span class="red">*</span><span class="gray">表示该项必填</span></li>
</ul>
<div class="Remind">
   <div class="red"> 重要提醒：</div> 
   贵公司的资料上网后会受到其他客户及工商质检部门等多方关注，请如实填写！因此虚假信息产生的相关责任，将由贵公司自行承担！ 
</div>
<ul class="ctList">
    <li><span>公司名称：<label class="star">*</label></span><div class="floatL"><input  class="txtbox" value="<%=ViewState["companyName"] %>" name="companyName" maxlength="100" /></div></li>
    <li><span>企业类型：<label class="star">*</label></span><div class="floatL">
        <input type="hidden" id="HD_BusType" value="<%=ViewState["BusType"] %>" />
        <select  name="BusType" class="BusinessType">
             <option value="" > --请选择-- </option>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <option value="<%#Eval("ID") %>" > <%#Eval("BusType")%> </option>
                </ItemTemplate>
            </asp:Repeater>
        </select></div>
    </li>
    <li><span>经营模式：<label class="star">*</label></span><div class="floatL">
        <input type="hidden" id="HD_BusModel" value="<%=ViewState["BusModel"] %>" />
        <input  type="radio" value="生产厂家" name="BusModel" id="manufacturer"  /><label for="manufacturer" title="从事自主生产、代/加工制造业务的厂商" >生产厂家</label>
		<input  id="wholesale" type="radio" value="经销批发" name="BusModel"  /><label for="wholesale" title="从事产品经销、批发、分销的商家">经销批发</label>
		<input id="anufacturer" type="radio" value="商业服务" name="BusModel" /><label for="anufacturer" title="从事商业服务的商家。包括：培训、设计、物流、展会等。">商业服务</label>
		<input id="investment" type="radio" value="招商代理"  name="BusModel" /><label for="investment" title="以自己的店号、品牌、产品及其他象征营业的东西招募合作伙伴的商家。包括：代理、加盟、特许经营、连锁合作、专卖等。 ">招商代理</label>
		<input  id="other" type="radio" value="其他" name="BusModel" /><label for="bmother">其他</label></div>
    </li>
    <li><span>注册资本：<label class="star">*</label></span><div class="floatL">
        <input type="hidden" id="HD_CapitalType" value="<%=ViewState["CapitalType"] %>" />
        <input  class="txtbox RegCapital" value="<%=ViewState["RegCapital"] %>" name="RegCapital" maxlength="20" /> 万
        <select name="CapitalType" class="CapitalType">	 
            <option value="人民币" >人民币</option>
			<option value="港币" >港币</option>
			<option value="欧元" >欧元</option>
			<option value="美元" >美元</option>
			<option value="日元" >日元</option>
			<option value="新加坡元" >新加坡元</option>
			<option value="英镑" >英镑</option>
			<option value="法国法郎" >法国法郎</option>
			<option value="德国马克" >德国马克</option>
			<option value="荷兰盾" >荷兰盾</option>
			<option value="意大利里拉" >意大利里拉</option>
			<option value="加拿大元" >加拿大元</option>
			<option value="澳大利亚元" >澳大利亚元</option>
			<option value="西班牙比塞塔" >西班牙比塞塔</option>
			<option value="泰国铢" >泰国铢</option>
    </select>
		 <label class="gray">请根据营业执照如实填写</label></div>
    </li>
    
    <li><span>公司成立年份：<label class="star">*</label></span><div class="floatL">
        <input type="hidden" id="HD_YearEst" value="<%=ViewState["YearEst"] %>" />
        <select name="YearEst"  class="YearEst"><%=ViewState["yearest"]%></select></div>
    	<input type="hidden" id="year-area" value="1949-2011" />
    </li>
     <li><span>公司所在地：<label class="star">*</label></span>
        <div class="floatL">
        <input readonly class="txtbox companyAddress" name="companyAddress" value="<%=ViewState["companyAddress"] %>" maxlength="20" /></div></li>
     <li><span>注册地址：<label class="star">*</label></span>
        <div class="floatL">
        <input  class="txtbox regArea" name="regArea" value="<%=ViewState["regArea"] %>" maxlength="20" /></div></li>
     <li><span>经营地址：<label class="star">*</label></span>
        <div class="floatL"><input  class="txtbox busArea" value="<%=ViewState["busArea"] %>" name="busArea" maxlength="100" /></div></li>
    <li><span>邮政编码：<label class="star">*</label></span><div class="floatL"><input  class="txtbox ZipCode" value="<%=ViewState["ZipCode"] %>"  name="ZipCode"  maxlength="6" /></div></li>
    <li><span>主营产品：<label class="star">*</label></span>
        <input type="hidden" id="HD_oserver" value="<%=ViewState["os"] %>" />
        <input  class="txtbox oserver"  value="<%=ViewState["oserver0"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver1"] %>"  name="oserver"  maxlength="20" />
        <input  class="txtbox oserver" value="<%=ViewState["oserver2"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver3"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver4"] %>"  name="oserver"  maxlength="20" /> <a href="javascript:;" class="morep">更多</a>
    </li>
    <li class="oser"><span>&nbsp;</span><input  class="txtbox oserver" value="<%=ViewState["oserver5"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver6"] %>"  name="oserver"  maxlength="20" />
        <input  class="txtbox oserver" value="<%=ViewState["oserver7"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver8"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver9"] %>"  name="oserver"  maxlength="20" />
    </li>
    <li class="oser"><span>&nbsp;</span><input  class="txtbox oserver" value="<%=ViewState["oserver10"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver11"] %>"  name="oserver"  maxlength="20" />
        <input  class="txtbox oserver" value="<%=ViewState["oserver12"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver13"] %>"  name="oserver"  maxlength="20" /> <input  class="txtbox oserver" value="<%=ViewState["oserver14"] %>"  name="oserver"  maxlength="20" />
    </li>
    <li class="osererror"><span>&nbsp;</span><div class="floatL"></div>
    </li>
    <li class="buyser"><span>采购产品：</span>
        <input type="hidden" id="HD_buypro" value="<%=ViewState["ob"] %>" />
        <input  class="txtbox buypro"   name="buypro" value="<%=ViewState["buypro0"] %>" maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro1"] %>"  name="buypro"  maxlength="20" />
        <input  class="txtbox buypro"  value="<%=ViewState["buypro2"] %>" name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro3"] %>"  name="buypro"  maxlength="20" /> <input  class="txtbox buypro"  value="<%=ViewState["buypro4"] %>" name="buypro"  maxlength="20" /> <a href="javascript:;" class="moreb">更多</a>
    </li>
    <li class="bser"><span>&nbsp;</span><input  class="txtbox buypro" value="<%=ViewState["buypro5"] %>"  name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro6"] %>"  name="buypro"  maxlength="20" />
        <input  class="txtbox buypro" value="<%=ViewState["buypro7"] %>"  name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro8"] %>"  name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro9"] %>"  name="buypro"  maxlength="20" />
    </li>
    <li class="bser"><span>&nbsp;</span><input  class="txtbox buypro"  value="<%=ViewState["buypro10"] %>" name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro11"] %>"  name="buypro"  maxlength="20" />
        <input  class="txtbox buypro" value="<%=ViewState["buypro12"] %>"  name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro13"] %>"  name="buypro"  maxlength="20" /> <input  class="txtbox buypro" value="<%=ViewState["buypro14"] %>"  name="buypro"  maxlength="20" />
    </li>
    <li><span>主营行业：<label class="star">*</label></span><div class="floatL"><input  class="txtbox MainIndu" value="<%=ViewState["MainIndu"] %>"  name="MainIndu"  maxlength="100" /></div></li>
    <li class="liprofile"><span>公司简介：<label class="star">*</label></span><div class="floatL" ><textarea  class="txtbox profile" name="profile"><%=ViewState["profile"]%></textarea>
        <div class="gray proRemark">
            1、请用中文详细说明贵司的成立历史、主营产品、品牌、服务等优势；如果内容过于简单或仅填写单纯的产品介绍，<br />将有可能无法通过审核。
					<br />
			2、联系方式(电话、传真、手机、电子邮箱等)请在会员资料中填写，此处请勿重复填写.<br />
            50-1800个字
        </div></div>
    </li>
    
    <li><span>&nbsp;</span><asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="保存" /></li>
</ul>
</asp:Content>

