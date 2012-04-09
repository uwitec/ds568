using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Transaction;
public partial class Order_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        switch(act){
            case "add_num":
                UserData ud = Session["UserData"] as UserData;
                if (!UserData.ChkObjNull(UserData.ObjType.购物车))
                {
                    ud = Session["UserData"] as UserData;
                    ud.ShoppingCart = new DS_Cart();
                }
                var odinfo = new DS_Cart.OrderInfo();
                ud.ShoppingCart.Add(int.Parse(Request.Form["id"]), 1, ref odinfo);
                var js = new System.Web.Script.Serialization.JavaScriptSerializer();
                Response.Write(js.Serialize(odinfo));
                break;
        }
    }
}
