using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Com.DianShi.BusinessRules.Member;

public partial class Member_Join_reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton1.Click+=new EventHandler(LinkButton1_Click);

        if(IsPostBack) return;
        
        //ajax验证帐号是否存在
        if (!string.IsNullOrEmpty(Request.QueryString["account"]))
        {
            var blMember = new DS_Members_Br();
            Response.Write((!blMember.Exits(Request.QueryString["account"])).ToString().ToLower());
            Response.End();
        }
        
    }

    private void LinkButton1_Click(object sender, EventArgs e) {
        //try
        //{
            if (!Common.Validate.RegUid(Request.Form["account"])) {
                Common.MessageBox.Show(this, "用户帐号格式不正确", Common.MessageBox.InfoType.info, "history.back");
                return;
            }
            if (!Common.Validate.RegPwd(Request.Form["password"]))
            {
                Common.MessageBox.Show(this, "密码格式不正确", Common.MessageBox.InfoType.info, "history.back");
                return;
            }
            if (Session["CheckCode"] == null || Session["CheckCode"].ToString().ToLower() != Request.Form["chkCode"].ToLower())
            {
                Common.MessageBox.Show(this, "验证码有误，请重新输入", Common.MessageBox.InfoType.info, "history.back");
                return;
            }
            var blMember = new DS_Members_Br();
            var mb = blMember.CreateModel();
            var blCompany = new DS_CompanyInfo_Br();
            var com = blCompany.CreateModel();
            mb.Email = Request.Form["email"];
            mb.UserID = Request.Form["account"].Trim();
            mb.Password = Request.Form["password"].Trim();
            com.CompanyName = Request.Form["companyName"];
            mb.TrueName = Request.Form["trueName"];
            mb.Gender = Request.Form["sex"];
            mb.Phone = Request.Form["phone-qh"] + "-" + Request.Form["phone-hm"] + "-" + Request.Form["phone-fj"];
            mb.Mobile = Request.Form["mobile"];
            com.MainIndustry = Request.Form["mainIndustry"];
            com.Province = Request.Form["area"];
            com.City = "";
            com.County = "";
            com.MemberType = byte.Parse(Request.Form["memberType"]);
            com.OfferService = "";
            com.BuyService = "";
            com.MainIndustry = "";
            com.ComImg = "";
            blMember.Register(mb, com);
            Common.MessageBox.Show(this, "恭喜，用户注册成功", Common.MessageBox.InfoType.info, "function(){location='../Login/login.aspx'}");
        //}
        //catch(Exception ex) {
        //    Common.MessageBox.Show(this,"抱歉，提交发生意外，可尝试重新提交或联系我们客服人员解决",Common.MessageBox.InfoType.error,"history.back");
        //}
    }
}
