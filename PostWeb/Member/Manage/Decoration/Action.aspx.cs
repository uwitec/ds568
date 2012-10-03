using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.ShopConfig;
public partial class Member_Manage_Decoration_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            var thebl = new DS_ShopTheme_Br();
            switch (act) { 
                case "viewThe":
                    var the = thebl.GetSingle(int.Parse(Request["id"]));
                    the.SignImg = DS_ShopTheme_Br.ThemePath(the.ID) + the.SignImg;
                    Response.Write(Common.JSONHelper.ObjectToJSON(the));
                    break;
            }
        }
    }
}
