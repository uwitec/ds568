using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Transaction;
using Com.DianShi.BusinessRules.Product;
public partial class Template_tem1_product_Action : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
         
            string act = Request["action"];
            if (!string.IsNullOrEmpty(act))
            {
                UserData ud = Session["UserData"] as UserData;
                var js = new System.Web.Script.Serialization.JavaScriptSerializer();
                switch (act)
                {
                    case "add_pur":
                        if (!UserData.ChkObjNull(UserData.ObjType.购物车))
                        {
                            ud = Session["UserData"] as UserData;
                            ud.ShoppingCart = new DS_Cart();
                        }
                        var odinfo =ud.ShoppingCart.Add(int.Parse(Request.Form["id"]), int.Parse(Request.Form["num"]));
                        Response.Write(js.Serialize(odinfo));
                        break;
                    case "send_msg":
                        var email = new Common.EmailUitility();
                        email.AddEmailAddress(_vMember.QQ+"@qq.com");
                        email.Title = "客户留言--点石网";
                        email.Content=Request.Form["content"];
                        email.SendEmail();
                        break;
                }
            }
         
    }
}
