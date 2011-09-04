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
        

    }

    private void LinkButton1_Click(object sender, EventArgs e) {
        var blMember = new DS_Members_Br();
        var mb = blMember.CreateModel();
        var blCompany = new DS_CompanyInfo_Br();
        var com = blCompany.CreateModel();
        mb.Email = Request.Form["email"];
        mb.UserID = Request.Form["account"];
        mb.Password = Request.Form["password"];
        com.CompanyName = Request.Form["companyName"];
        mb.TrueName = Request.Form["trueName"];
        mb.Gender = Request.Form["sex"];
        mb.Phone = Request.Form["phone"];
        mb.Mobile = Request.Form["mobile"];
        com.MainIndustry = Request.Form["mainIndustry"];
        com.Province = Request.Form["area"];
        com.City = "";
        com.MemberType = byte.Parse(Request.Form["memberType"]);
    }
}
