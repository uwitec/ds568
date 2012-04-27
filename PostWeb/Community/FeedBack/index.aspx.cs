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
public partial class Community_FeedBack_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new View_Members_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["member_id"]));
        ViewState["company"] = md.CompanyName;
        ViewState["trueName"] = md.TrueName;
        ViewState["Gender"] = md.Gender;

        var ud = Session["UserData"] as UserData;
        if (UserData.ChkObjNull(UserData.ObjType.会员信息)) {
            var myinfo = bl.GetSingle(ud.Member.ID);
            string email = myinfo.Email;
            if (email.Contains("@")) {
                ViewState["email_1"] = email.Split('@')[0];
                ViewState["email_2"] = email.Split('@')[1];
            }
            ViewState["mycompany"] = myinfo.CompanyName;
            string[] phone = myinfo.Phone.Split('-');
            ViewState["phone_1"] = phone[0];
            ViewState["phone_2"] =phone.Length>1?phone[1]:"";
            ViewState["mobile"] = myinfo.Mobile;

        }
    }
}
