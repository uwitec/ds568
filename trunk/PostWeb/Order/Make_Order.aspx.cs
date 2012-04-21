using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Sys;
public partial class Order_Make_Order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
            Page.Header.Title = "确认订单";
            
            if (UserData.ChkObjNull(UserData.ObjType.购物车))
            {
                var ud = Session["UserData"] as UserData;
                Repeater1.DataSource = ud.ShoppingCart.OrderDetail.Where(a => a.OrderID.Equals(int.Parse(Request.QueryString["oid"])));
                Repeater1.DataBind();
                var order = ud.ShoppingCart.Orders.Single(a=>a.ID.Equals(int.Parse(Request.QueryString["oid"])));
                ViewState["comName"] = order.CompanyName;
                ViewState["amount"] = order.Amount;
                ViewState["memberid"] = order.MemberID;
                ViewState["qq"] = order.QQ;
            }

            if (IsPostBack) return;
            var bl =new DS_Area_Br();
            Repeater2.DataSource = bl.Query("parentid=0","px");
            Repeater2.DataBind();
        //}
        //catch {
        //    Response.Write("<script>history.back();</script>"); 
        //    Response.End(); 
        //}
    }
}
