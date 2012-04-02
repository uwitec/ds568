using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Com.DianShi.Model.Transaction;
using Com.DianShi.Model.Member;
using Com.DianShi.Model.Product;
namespace Com.DianShi.BusinessRules.Transaction
{
    public class DS_Cart
    {
        public DS_Purchase Purchase;
        public List<DS_Orders> Orders;
        public List<DS_OrderDetail> OrderDetail;
        private int id = 1;
        
        public DS_Cart()
        {
            Purchase = new DS_Purchase();
            Purchase.MemberID = 0;
            Purchase.CreateDate = DateTime.Now;
            Orders = new List<DS_Orders>();
            OrderDetail = new List<DS_OrderDetail>();
        }

        public void Add(DS_Orders order)
        {
            Orders.Add(order);
        }

        public void Add(DS_OrderDetail orderDetail)
        {
            var productbl = new DS_ProductsDataContext(DBUtility.DbHelperSQL.Connection);
            var product = productbl.DS_Products.Single(a=>a.ID.Equals(orderDetail.ProductID));
            //var memberbl = new DS_MembersDataContext(DBUtility.DbHelperSQL.Connection);
            //var member = memberbl.DS_Members.Single(a=>a.ID.Equals(product.MemberID));
            var existod=Orders.Where(a=>a.MemberID.Equals(product.MemberID));
            if (existod.Count().Equals(0))//如果订单列表中不存在当前产品所属公司
            {
                var order = new DS_Orders();
                order.MemberID = product.MemberID;
                order.ProNum = 1;
                order.PurchaseID = 0;
                order.Amount = orderDetail.Amount;
                order.CreateDate = DateTime.Now;
                order.OrderNum = "";
                order.ID = id++;
                Orders.Add(order);
                orderDetail.OrderID = order.ID;
            }
            else {
                var order = existod.Single();
                orderDetail.OrderID = order.ID;
            }
            OrderDetail.Add(orderDetail);
            
        }
    }
}
