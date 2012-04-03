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

        private DS_OrderDetail CreateOrderDetail(int ProductID,int ProNum)
        {
            var productbl = new DS_ProductsDataContext(DBUtility.DbHelperSQL.Connection);
            var product = productbl.DS_Products.Single(a=>a.ID.Equals(ProductID));
            var OrderDetail = new DS_OrderDetail();
            OrderDetail.ProNum = ProNum;
            OrderDetail.ProductID = ProductID;
            OrderDetail.Price = GetPrice(product.PriceRang,ProNum);
            OrderDetail.ProName = product.Title;
            OrderDetail.Amount = ProNum * OrderDetail.Price;
            return OrderDetail;
        }

        /// <summary>
        /// 加入进货单
        /// </summary>
        /// <param name="ProductID">产品ID</param>
        /// <param name="ProNum">产品数量</param>
        public void Add(int ProductID, int ProNum)
        {
            var orderDetail = CreateOrderDetail(ProductID,ProNum);
            var productbl = new DS_ProductsDataContext(DBUtility.DbHelperSQL.Connection);
            var product = productbl.DS_Products.Single(a=>a.ID.Equals(orderDetail.ProductID));
            var existod=Orders.Where(a=>a.MemberID.Equals(product.MemberID));
            if (existod.Count().Equals(0))//检查订单中是否存在相同公司
            {
                var order = new DS_Orders();
                order.MemberID = product.MemberID;
                order.ProNum = orderDetail.ProNum;
                order.PurchaseID = 0;
                order.Amount = orderDetail.Amount;
                order.CreateDate = DateTime.Now;
                order.OrderNum = "";
                order.ID = id++;
                Orders.Add(order);
                orderDetail.OrderID = order.ID;
                OrderDetail.Add(orderDetail);
            }
            else {
                var order = existod.Single();
                orderDetail.OrderID = order.ID;
                //检查购物车中是否已存在相同商品
                var existoddt = OrderDetail.Where(a=>a.ProductID.Equals(orderDetail.ProductID));
                if (existoddt.Count().Equals(0))
                {
                    order.Amount += orderDetail.Amount;
                    order.ProNum += orderDetail.ProNum;
                    OrderDetail.Add(orderDetail);
                }
                else {
                    var oddt = existoddt.Single();
                    oddt.ProNum += orderDetail.ProNum;
                    oddt.Price = GetPrice(product.PriceRang,oddt.ProNum);
                    oddt.Amount =Math.Round(oddt.ProNum*oddt.Price);
                    order.Amount += oddt.Amount;
                    order.ProNum += oddt.ProNum;
                }
            }
        }

        /// <summary>
        /// 根据产品数据获取对应的价格，因为不同数量价格区间不同                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        /// </summary>
        /// <param name="PriceRang">价格区间字符串</param>
        /// <param name="ProductNum">产品数量</param>
        /// <returns>double</returns>
        public double GetPrice(string PriceRang,int ProductNum) {
            string[] pr = PriceRang.Split('|');
            string proNum="",prices="";
            foreach (var item in pr)
            {
                proNum += item.Split(',')[0]+",";
                prices += item.Split(',')[1] + ",";
            }
            string[] pns = proNum.TrimEnd(',').Split(','), prs = prices.TrimEnd(',').Split(',');
            for (int i = 0; i < pns.Length; i++)
            {
                if (i + 1 < pns.Length)
                {
                    if (ProductNum >= int.Parse(pns[i]) && ProductNum < int.Parse(pns[i+1])) {
                        return double.Parse(prs[i]);
                    }
                }
                else {
                    return double.Parse(prs[i]);
                }
            }
            return 0;
        }
    }
}
