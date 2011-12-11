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
public partial class Member_Manage_DiyCat_UserDefCat : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("供应管理", "产品自定义分类");

        var ud=Session["UserData"] as UserData;
        var bl = new DS_DiyProCategory_Br();
        Repeater1.DataSource = bl.Query("memberid=@0","px",ud.Member.ID);
        Repeater1.DataBind();
    }
}
