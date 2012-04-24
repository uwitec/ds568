using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Transaction;
using Com.DianShi.BusinessRules.Sys;
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
            case "chgarea":
                var bl = new DS_Area_Br();
                Response.Write(js.Serialize(bl.Query("parentid=@0","px",int.Parse(Request["id"]))));
                break;
            case "sub_order":
                var am = new ActMsg {succe=false,msg="" };
                try
                {
                    var oddtbl = new DS_Orders_Br();
                    oddtbl.Add(ud.ShoppingCart.Orders,ud.ShoppingCart.OrderDetail);

                }
                catch (Exception ex) {
                    am.msg = "抱歉，提交出错。";
                }
                break;
        }
    }

    class ActMsg {
        public bool succe { get; set; }
        public string msg { get; set; }
        
    }
}
