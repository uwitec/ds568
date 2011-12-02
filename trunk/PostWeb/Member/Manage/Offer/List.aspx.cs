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
using Com.DianShi.BusinessRules.Product;
public partial class Member_Manage_Offer_List : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("供应管理", "管理供应信息");
        
        var vs = Enum.GetValues(typeof(DS_Products_Br.State));
        Repeater1.DataSource = vs;
        Repeater1.DataBind();
        if (string.IsNullOrEmpty(Request.QueryString["show_type"]) || vs.Cast<DS_Products_Br.State>().Where(a=>((byte)a).ToString().Equals(Request.QueryString["show_type"])).Count().Equals(0))
        {
            Response.Redirect("list.aspx?show_type="+(byte)vs.GetValue(0));
        }
    }

    public int GetProCount(byte state) {
        var bl = new DS_Products_Br();
        var ud = Session["UserData"] as UserData;
        return bl.Query("MemberID=@0 and state=@1","",ud.Member.ID,state).Count();
    }
}
