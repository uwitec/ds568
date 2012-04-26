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
                    var od=ud.ShoppingCart.Orders.Single(a=>a.ID.Equals(int.Parse(Request.QueryString["oid"])));
                    od.ClientArea = Request["province"].Split(',')[0] + " " + Request["city"].Split(',')[0] + " " + Request["town"].Split(',')[0];
                    od.ClientZipCode=Request["zipcode"];
                    od.ClientStreet = Request["street"];
                    od.ClientName = Request["username"];
                    od.ClientPhone = Request["phone"].Replace("区号-电话号码-分机","");
                    od.ClientMobile=Request["mobile"];
                    od.ClientRemark = Request["remark"].Replace("请输入您对该笔交易或货品的特殊要求以提醒供应商，字数不超过500字", "").Trim();
                    var list=ud.ShoppingCart.OrderDetail.Where(a=>a.OrderID.Equals(od.ID)).ToList();
                    oddtbl.Add(od,list);
                    ud.ShoppingCart.OrderDetail.RemoveAll(a=>a.OrderID.Equals(od.ID));
                    ud.ShoppingCart.Orders.Remove(od);
                    am.succe = true;
                    am.msg = "提交订单成功。";
                }
                catch (Exception ex) {
                    am.msg = "抱歉，提交出错。";
                }
                Response.Write(js.Serialize(am));
                break;
        }
    }

    class ActMsg {
        public bool succe { get; set; }
        public string msg { get; set; }
        
    }
}
