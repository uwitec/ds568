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
<ul class="ctList">
    <li><span>公司名称：<label class="star">*</label></span><div class="floatL"><input  class="txtbox" name="cName" maxlength="100" /></div></li>
    <li><span>企业类型：<label class="star">*</label></span><div class="floatL">
        <select  name="BusType" class="BusinessType">
             <option value="" > --请选择-- </option>
   			 <optgroup label="----------------------">
   			     <option value="24"  >个体经营</option>
			 </optgroup>	
			 <optgroup label="-----------------------">
                <option value="3"  >私营独资企业</option>
                <option value="8"  >私营合伙企业</option>
                <option value="9"  >私营有限责任公司</option>
                <option value="10"  >私营股份有限公司</option>
                <option value="4"  >国有企业</option>
                <option value="11"  >集体企业</option>
                <option value="12"  >股份合作企业</option>
                <option value="13"  >联营企业</option>
                <option value="29"  >有限责任公司</option>
                <option value="14"  >有限责任公司(国有独资或控股)</option>
                <option value="30"  >有限责任公司(自然人投资或控股)</option>
                <option value="27"  >一人有限责任公司</option>
                <option value="15"  >其他有限责任公司</option>
                <option value="16"  >股份有限公司</option>
                <option value="17"  >其他内资企业</option>
			 </optgroup>	
			 <optgroup label="----------------------">
                <option value="25"  >三来一补</option>
                <option value="26"  >法人分支机构</option>
                <option value="31"  >农民专业合作经济组织</option>
			</optgroup>	
			<optgroup label="----------------------">
                <option value="18"  >合资经营企业(港或澳、台资)</option>
                <option value="19"  >合作经营企业(港或澳、台资)</option>
                <option value="20"  >港、澳、台商独资经营企业</option>
                <option value="21"  >港、澳、台商投资股份有限公司</option>
                <option value="2"  >中外合资经营企业</option>
                <option value="22"  >中外合作经营企业</option>
                <option value="1"  >外资企业</option>
                <option value="23"  >外商投资股份有限公司</option>
			</optgroup>	
			<optgroup label="----------------------">
   				<option value="7"  >其他</option>
			</optgroup>
        </select></div>
    </li>
    <li><span>经营模式：<label class="star">*</label></span><div class="floatL">
        <input  type="radio" value="manufacturer" name="BusModel" id="manufacturer"  /><label for="manufacturer" title="从事自主生产、代/加工制造业务的厂商" >生产厂家</label>
		<input  id="wholesale" type="radio" value="wholesale" name="BusModel"  /><label for="wholesale" title="从事产品经销、批发、分销的商家">经销批发</label>
		<input id="anufacturer" type="radio" value="service" name="BusModel" /><label for="anufacturer" title="从事商业服务的商家。包括：培训、设计、物流、展会等。">商业服务</label>
		<input id="investment" type="radio" value="investment"  name="BusModel" /><label for="investment" title="以自己的店号、品牌、产品及其他象征营业的东西招募合作伙伴的商家。包括：代理、加盟、特许经营、连锁合作、专卖等。 ">招商代理</label>
		<input  id="other" type="radio" value="bmother" name="BusModel" /><label for="bmother">其他</label></div>
    </li>
    <li><span>注册资本：<label class="star">*</label></span><div class="floatL">
        <input  class="txtbox RegCapital"  name="RegCapital" maxlength="20" /> 万
        <select name="CapitalType" class="CapitalType">	 
            <option value="RMB" >人民币</option>
			<option value="HKD" >港币</option>
			<option value="EUR" >欧元</option>
			<option value="USD" >美元</option>
			<option value="JPY" >日元</option>
			<option value="SGD" >新加坡元</option>
			<option value="GBP" >英镑</option>
			<option value="FRF" >法国法郎</option>
			<option value="DEM" >德国马克</option>
			<option value="NLG" >荷兰盾</option>
			<option value="ITL" >意大利里拉</option>
			<option value="CAD" >加拿大元</option>
			<option value="AUD" >澳大利亚元</option>
			<option value="ESP" >西班牙比塞塔</option>
			<option value="THB" >泰国铢</option>
    </select>
		 <label class="gray">请根据营业执照如实填写</label></div>
    </li>
    <li><span>公司成立年份：<label class="star">*</label></span><div class="floatL">
        <select name="YearEst" class="YearEst"></select></div>
    	<input type="hidden" id="year-area" value="1949-2011" />
    </li>
     <li><span>公司注册地：<label class="star">*</label></span>
        <div class="floatL">
        <input readonly class="txtbox regArea" name="regArea" maxlength="20" /></div></li>
     <li><span>经营地址：<label class="star">*</label></span>
        <div class="floatL"><input  readonly  class="txtbox busArea" name="busArea"  maxlength="20" /> <input  class="txtbox" name="busAreaDet" maxlength="100" /></div></li>
    <li><span>邮政编码：<label class="star">*</label></span><div class="floatL"><input  class="txtbox ZipCode"   name="ZipCode"  maxlength="6" /></div></li>
    <li><span>主营产品：<label class="star">*</label></span>
        <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" />
        <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <a href="javascript:;" class="morep">更多</a>
    </li>
    <li class="oser"><span>&nbsp;</span><input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" />
        <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" />
    </li>
    <li class="oser"><span>&nbsp;</span><input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" />
        <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" /> <input  class="txtbox oserver"   name="oserver"  maxlength="20" />
    </li>
    <li class="osererror"><span>&nbsp;</span><div class="floatL"></div>
    </li>
    <li class="buyser"><span>采购产品：</span>
        <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" />
        <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <a href="javascript:;" class="moreb">更多</a>
    </li>
    <li class="bser"><span>&nbsp;</span><input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" />
        <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" />
    </li>
     <li class="bser"><span>&nbsp;</span><input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" />
        <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" /> <input  class="txtbox buypro"   name="buypro"  maxlength="20" />
    </li>
    <li><span>主营行业：<label class="star">*</label></span><div class="floatL"><input  class="txtbox MainIndu"   name="MainIndu"  maxlength="100" /></div></li>
    <li><span>公司简介：<label class="star">*</label></span><div class="floatL"><textarea  class="txtbox profile" name="profile"></textarea>
        <div class="gray proRemark">
            1、请用中文详细说明贵司的成立历史、主营产品、品牌、服务等优势；如果内容过于简单或仅填写单纯的产品介绍，将有可能无法通过审核。
					<br />
			2、联系方式(电话、传真、手机、电子邮箱等)请在会员资料中填写，此处请勿重复填写.<br />
            50-1800个字
        </div></div>
    </li>
    
    <li><span>&nbsp;</span><asp:Button ID="Button1" CssClass="subBtn" runat="server" Text="保存" /></li>
</ul>
</asp:Content>

