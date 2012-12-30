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
using Com.DianShi.Model.Member;
using Com.DianShi.BusinessRules.ShopConfig;
public partial class MasterPage : System.Web.UI.MasterPage
{
    public ShopBasePage BasePage;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        BasePage =this.Page as ShopBasePage;
        var bl = new DS_DiyProCategory_Br();
        int rc = 0;
        Repeater1.DataSource = bl.Query("memberid=@0", "px", 0, 10, ref rc, BasePage._vMember.ID);
        Repeater1.DataBind();
    }

   

}

