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
using Com.DianShi.BusinessRules.ShopConfig;
public partial class DSAdmin_Theme_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_ShopTheme_Br();
        Repeater1.DataSource = bl.Query("","");
        Repeater1.DataBind();
    
    }
     
}
