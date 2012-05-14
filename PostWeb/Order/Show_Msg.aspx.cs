using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Member;
public partial class Order_Show_Msg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new View_Members_Br();
        var md=bl.GetSingle(Request.Url);
        ViewState["qq"] = md.QQ;
        ViewState["memberid"] = md.ID;
    }
}
