<%@ Page Language="C#" MasterPageFile="~/Template/tem1/MasterPage.Master" AutoEventWireup="true"
    CodeFile="index_profile.aspx.cs" Inherits="Template_tem1_profile_index_profile"
    Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="MiddleRight">
        <!--========内容开始=============-->
        <div class="About">
            <div class="AboutHead">
                <div class="AHLeft">
                    公司介绍</div>
            </div>
            <div class="profileBody">
                
                <script language="javascript" type="text/javascript">
                <!--
                var bannerAD=new Array();
                var adNum=0;
                                
		        bannerAD[0]="http://i05.c.aliimg.com/img/company/goldenphoto/42/38/14/423814.summ.jpg";
                bannerAD[1]="http://i05.c.aliimg.com/img/company/goldenphoto/42/38/15/423815.summ.jpg";
                bannerAD[2]="http://i04.c.aliimg.com/img/company/26/32/38/05/26323805_1.summ.jpg";
                                
                var preloadedimages=new Array();
                for (i = 0; i < bannerAD.length; i++){
                  preloadedimages[i]=new Image();
                  preloadedimages[i].src=bannerAD[i];
                }
                
                function setTransition(){
                if (document.all){
                  document.images.bannerADrotator.filters.revealTrans.Transition=Math.floor(Math.random()*23);
                  document.images.bannerADrotator.filters.revealTrans.apply();
                }
                }
                
                function playTransition(){
                if (document.all)
                  document.images.bannerADrotator.filters.revealTrans.play()
                }
                
                function nextAd(){
                if(adNum<bannerAD.length)adNum++ ;
                  else adNum=0;
                setTransition();
                if(adNum-1>=0)
                document.images.bannerADrotator.src=bannerAD[adNum-1];
                else
                document.images.bannerADrotator.src=bannerAD[adNum];
                //document.getElementById("des").innerHTML=bannerDE[adNum];
                playTransition();
                theTimer=setTimeout("nextAd()", 6000);
                }
                
               
                //-->
                </script>

                <img style="filter: revealTrans(duration=2,transition=20)" width="300" height="228"
                    src="http://i04.c.aliimg.com/img/company/26/32/38/05/26323805_1.summ.jpg" border="0"
                    name="bannerADrotator" alt="公司图片" onload="javascript:changeImg(this,322,341)" /><script>nextAd()</script>
                &nbsp;<%=ViewState["ct"]%>
            </div>
        </div>
        <div class="About NoTopBorder">
            <div class="AboutHead">
                <div class="AHLeft">
                    详细信息</div>
            </div>
            <div class="profileBody">
                <table width="98%" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#FFFFFF">
                    <tr>
                        <td width="17%" bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong><a href="http://dongganzhe168.cn.alibaba.com/athena/offerlist/dongganzhe168-sale-false.html"
                                    class=" draft_no_link">主营产品或服务</a>：</strong>
                            </div>
                        </td>
                        <td width="33%" bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" style="word-break: break-all" align="left">
                            插卡音箱;电话线;电话转接头;电话配件;
                        </td>
                        <td width="17%" bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>主营行业：</strong>
                            </div>
                        </td>
                        <td width="33%" valign="top" bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px;
                            padding-left: 5px; padding-right: 5px; padding-bottom: 3px;" align="left">
                            综合性公司 电脑音箱 音箱 木制工艺品 金属工艺品 其他数码产品
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>企业类型：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            个体经营
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>经营模式： </strong>
                            </div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            生产加工
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>注册资本：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            无需验资
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>公司注册地：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            广东省深圳市
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>员工人数：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            51 - 100 人
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>公司成立时间：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            2006 年
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>法定代表人/负责人：</strong>
                            </div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            方伟泽
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>年营业额： </strong>
                            </div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            人民币 1001 万元/年 - 2000 万元/年
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>主要经营地点：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            深圳华强北经济大厦D22
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>经营品牌：</strong></div>
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;" align="left">
                            <p>
                                动感者</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>是否提供加工/定制服务？</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            是(OEM加工;来样加工;ODM加工;来料代工加工;来料加工)
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>质量控制：</strong></div>
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;" align="left">
                            <p>
                                内部</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>工艺：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            印刷加工
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>服务领域：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            电器;礼品工艺品;通信;数码家电;运动、休闲
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>年进口额：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            人民币 31 万元 - 50 万元
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>年出口额：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            人民币 1001 万元 - 2000 万元
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>研发部门人数：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            11 - 20 人
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>厂房面积：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            1200 平方米
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>月产量：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            500000 台
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-left: 15px;
                            padding-right: 8px; padding-bottom: 3px;">
                            &nbsp;
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-right: 3px;
                            padding-bottom: 3px;">
                            <div align="right">
                                <strong>公司主页：</strong></div>
                        </td>
                        <td bgcolor="#FFFFFF" class="S lh15" style="padding-top: 3px; padding-left: 5px;
                            padding-right: 5px; padding-bottom: 3px;" align="left">
                            <a class="draft_no_link topicLink" href="http://www.dgz888.com" target="_blank">http://www.dgz888.com</a>
                            <br />
                            <a class="draft_no_link topicLink" href="http://dongganzhe168.cn.alibaba.com" target="_blank">
                                http://dongganzhe168.cn.alibaba.com</a>
                        </td>
                        <td bgcolor="#F0f0f0" class="S lh15" style="padding-top: 3px; padding-left: 15px;
                            padding-right: 8px; padding-bottom: 3px;">
                            &nbsp;
                        </td>
                        <td class="S lh15" style="padding-top: 3px; padding-left: 5px; padding-right: 5px;
                            padding-bottom: 3px;">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <!--========内容结束=============-->
    </div>
</asp:Content>
