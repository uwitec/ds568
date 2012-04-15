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
        UserData ud = Session["UserData"] as UserData;
        if (!UserData.ChkObjNull(UserData.ObjType.购物车))
        {
            ud = Session["UserData"] as UserData;
            ud.ShoppingCart = new DS_Cart();
        }
        var js = new System.Web.Script.Serialization.JavaScriptSerializer();
        string act=Request["action"];
        switch(act){
            case "chg_num":
                var odinfo=ud.ShoppingCart.Add(int.Parse(Request.Form["id"]),int.Parse(Request.Form["num"]));
                Response.Write(js.Serialize(odinfo));
                break;
            case "del":
                odinfo=ud.ShoppingCart.Del(int.Parse(Request.Form["id"]));
                Response.Write(js.Serialize(odinfo));
                break;
            case "dels":
                odinfo = ud.ShoppingCart.Del(Request.Form["ids"].TrimEnd(','));
                Response.Write(js.Serialize(odinfo));
                break;
        }
    }
}
