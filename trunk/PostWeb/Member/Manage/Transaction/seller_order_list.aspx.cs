using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Transaction;
public partial class Member_Manage_Transaction_seller_order_list : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("交易管理", "已卖出的货品");
        var bl = new DS_OrderDetail_Br();
        //string act = Request["action"];
        //if (!string.IsNullOrEmpty(act))
        //{
        //    switch (act)
        //    {
        //        case "pager":
        //            int pageIndex = int.Parse(Request.Form["pageIndex"]), pageSize = int.Parse(Request.Form["pageSize"]), rc = 0;
        //            Repeater1.DataSource = bl.Query("memberid=@0 and parentid=0", "px", (pageIndex - 1) * pageSize, pageSize, ref rc, _userData.Member.ID);
        //            Repeater1.DataBind();
        //            ViewState["rc"] = rc;
        //            break;
        //        case "del":
        //            bl.Delete(int.Parse(Request.Form["id"]));
        //            break;
        //    }
        //    return;
        //}
        
        if (IsPostBack) return;
    }

}
