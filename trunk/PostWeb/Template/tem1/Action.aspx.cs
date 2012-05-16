using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
public partial class Template_tem1_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = Request["action"];
        if (!string.IsNullOrEmpty(act))
        {
            var js = new JavaScriptSerializer();
            switch (act)
            {
                case "chkLogin":
                    var ud = Session["UserData"] as UserData;
                    if (UserData.ChkObjNull(UserData.ObjType.会员信息))
                    {
                        Response.Write(js.Serialize(new { succ = true, UserID = ud.Member.UserID }));
                    }
                    else {
                        Response.Write(js.Serialize(new { succ = false }));
                    }
                    break;
                case "chkCart":
                    ud = Session["UserData"] as UserData;
                    if (UserData.ChkObjNull(UserData.ObjType.购物车))
                    {
                        Response.Write(js.Serialize(ud.ShoppingCart.OrderDetail.OrderByDescending(a=>a.CreateDate).Take(3)));
                    }
                    break;
                case "del_od":
                    ud = Session["UserData"] as UserData;
                    if (UserData.ChkObjNull(UserData.ObjType.购物车))
                    {
                        ud.ShoppingCart.Del(int.Parse(Request.Form["pid"]));
                        Response.Write(js.Serialize(new { succ = true }));
                    }
                    else {
                        Response.Write(js.Serialize(new { succ = false }));
                    }
                    break;
                case "cartInfo":
                    ud = Session["UserData"] as UserData;
                    if (UserData.ChkObjNull(UserData.ObjType.购物车))
                    {
                        if (ud.ShoppingCart.OrderDetail.Count()>0)
                            Response.Write(js.Serialize(new { succ = true,ProTypeNum=ud.ShoppingCart.OrderDetail.Count(),ProNum=ud.ShoppingCart.OrderDetail.Sum(a=>a.ProNum),Amount=ud.ShoppingCart.Orders.Sum(a=>a.Amount) }));
                        else
                            Response.Write(js.Serialize(new { succ = false }));
                    }
                    else
                    {
                        Response.Write(js.Serialize(new { succ = false }));
                    }
                    break;
            }
            return;
        }
    }
}
