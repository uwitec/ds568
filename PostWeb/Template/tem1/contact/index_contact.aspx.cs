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
public partial class Template_tem1_contact_index_contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var vmbbl = new View_Members_Br();
        var md = vmbbl.GetSingle(int.Parse(Request.QueryString["member_id"]));
        ViewState["comName"] = md.CompanyName;
        ViewState["address"] = md.BusinessAddress;
        ViewState["TrueName"] = md.TrueName;
        ViewState["Gender"] = md.Gender;
        ViewState["position"] = md.Position;
        ViewState["phone"] = md.Phone.TrimEnd('-');
        ViewState["mobile"] = md.Mobile;
        ViewState["fax"] = md.Fax.TrimEnd('-');
        ViewState["homepage"] = md.HomePage;
        ViewState["zipcode"] = md.ZipCode;
        ViewState["mapNid"] = md.MapNid;
    }
}
