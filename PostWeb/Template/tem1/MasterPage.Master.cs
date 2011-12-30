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
using Com.DianShi.BusinessRules.Member;
[PartialCaching(1800,"member_id",null,null)]
public partial class MasterPage : System.Web.UI.MasterPage
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new DS_DiyProCategory_Br();
        Repeater1.DataSource = bl.Query("memberid=@0","px",int.Parse(Request.QueryString["member_id"]));
        Repeater1.DataBind();

        //联系信息
        var vmbbl = new View_Members_Br();
        var list = vmbbl.Query("id=@0", "", int.Parse(Request.QueryString["member_id"]));
        Repeater2.DataSource = list;
        Repeater2.DataBind();
        var md=list.Single();
        ViewState["comName"] = md.CompanyName;
        ViewState["address"]=md.BusinessAddress;
 
    }

   

}

