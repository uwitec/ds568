using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Transaction;
public partial class Template_tem1_product_Action : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act)
            {
                case "add_pur":
                    
                    UserData ud;
                    if (!UserData.ChkObjNull(UserData.ObjType.购物车))
                    {
                        ud = Session["UserData"] as UserData;
                        ud.ShoppingCart = new DS_Cart();
                    }
                    ud.ShoppingCart.Add();
                    break;
                default:
                    break;
            }
        }
    }
}
