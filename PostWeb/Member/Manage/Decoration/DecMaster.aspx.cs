using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.ShopConfig;
public partial class Member_Manage_Decoration_DecMaster :  BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_ShopTheme_Br();
        Repeater1.DataSource = bl.Query("","id desc");
        Repeater1.DataBind();
    }
}
