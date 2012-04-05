using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.Model.Transaction;
public partial class Order_Purchase_purchaseList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (UserData.ChkObjNull(UserData.ObjType.购物车)) {
            Repeater1.ItemDataBound += new RepeaterItemEventHandler(Repeater1_ItemDataBound);
            var ud = Session["UserData"] as UserData;
            Repeater1.DataSource = ud.ShoppingCart.Orders;
            Repeater1.DataBind();
        }
    }

    private void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e) {
        var rp = e.Item.FindControl("Repeater2") as Repeater;
        var ud = Session["UserData"] as UserData;
        rp.DataSource = ud.ShoppingCart.OrderDetail.Where(a=>a.OrderID.Equals((e.Item.DataItem as DS_Orders).ID));
        rp.DataBind();
    }
}
