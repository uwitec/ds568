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
        
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act))
        {
            switch (act)
            {
                case "pager":
                    BindData();
                    break;
                case "od_det":
                    var bl = new DS_Orders_Br();
                    var js = new System.Web.Script.Serialization.JavaScriptSerializer();
                    var md = bl.GetSingle(int.Parse(Request["id"]));
                    Response.Write(js.Serialize(md));
                    Response.End();
                    break;
                case "del":
                    var oddbl = new DS_OrderDetail_Br();
                    oddbl.Delete(int.Parse(Request.Form["id"]));
                    Response.End();
                    break;
            }
            return;
        }
        if (IsPostBack) return;
        BindData();
    }

    private void BindData()
    {
        string orderNum = Request["orderNum"], startDate = Request["startDate"], endDate = Request["endDate"], orderState = Request["orderState"], proName = Request["proName"],pageIndex=Request["pageIndex"],pageSize=Request["pageSize"];
        var bl = new DS_OrderDetail_Br();
        var sql = new System.Text.StringBuilder();
        var param=new object[6];
        sql.Append("memberid=@0");
        param[0] = _userData.Member.ID;
        if (!string.IsNullOrEmpty(orderNum))
        {
            sql.Append(" and OrderNum=@1");
            param[1] = orderNum.Trim();
        }
        else
        {
            if (!string.IsNullOrEmpty(startDate))
            {
                sql.Append(" and CreateDate>=@2");
                param[2] = DateTime.Parse(startDate);
            }
            if (!string.IsNullOrEmpty(endDate))
            {
                sql.Append(" and CreateDate<@3");
                param[3] = DateTime.Parse(endDate).AddDays(1);
            }
            if (!string.IsNullOrEmpty(orderState))
            {
                sql.Append(" and State=@4");
                param[4] = byte.Parse(orderState);
            }
            if (!string.IsNullOrEmpty(proName))
            {
                sql.Append(" and ProName.Contains(@5)");
                param[5] = proName.Trim();
            }
        }
        int recordCount = 0, _pageIndex = string.IsNullOrEmpty(pageIndex) ? 1 : int.Parse(pageIndex), _pageSize = string.IsNullOrEmpty(pageSize) ? 3 : int.Parse(pageSize);
        Repeater1.DataSource = bl.Query(sql.ToString(), "id desc", (_pageIndex - 1) * _pageSize, _pageSize, ref recordCount, param);
        Repeater1.DataBind();
        ViewState["rc"] = recordCount;
    }

}
