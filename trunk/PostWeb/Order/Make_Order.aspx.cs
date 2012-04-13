using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order_Make_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.Title = "确认订单";
        if (UserData.ChkObjNull(UserData.ObjType.购物车))
        {
            var ud = Session["UserData"] as UserData;
            Repeater1.DataSource = ud.ShoppingCart.OrderDetail;
            Repeater1.DataBind();
        }
    }
}
