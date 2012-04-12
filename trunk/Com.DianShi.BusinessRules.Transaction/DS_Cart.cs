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
            OrderDetail.Amount = Math.Round(double.Parse(ProNum.ToString()) * OrderDetail.Price);
            OrderDetail.PriceRang = GetPriceRang(product.PriceRang, ProNum);
            return OrderDetail;
        }

        /// <summary>
        /// 加入进货单
        /// </summary>
        /// <param name="ProductID">产品ID</param>
        /// <param name="ProNum">产品数量</param>
        /// <param name="ProTotalCount">添加商品后反回进货单中的总商品数</param>
        /// <param name="ProTotalAmount">添加商品后反回进货单中的总金额</param>
        /// <param name="CurrentProAmount">当前产品ID的总金额</param>
        public OrderInfo Add(int ProductID, int ProNum)
        {
            var odinfo = new OrderInfo();
            var orderDetail = CreateOrderDetail(ProductID,ProNum);
            odinfo.CrtPriceRang=orderDetail.PriceRang;
            var productbl = new DS_ProductsDataContext(DBUtility.DbHelperSQL.Connection);
            var memberbl = new DS_CompanyInfoDataContext(DBUtility.DbHelperSQL.Connection);
            var product = productbl.DS_Products.Single(a=>a.ID.Equals(orderDetail.ProductID));
            var existod=Orders.Where(a=>a.MemberID.Equals(product.MemberID));
            if (existod.Count().Equals(0))//检查订单中是否存在相同公司
            {
                var order = new DS_Orders();
                order.MemberID = product.MemberID;
                order.CompanyName = memberbl.DS_CompanyInfo.Single(a=>a.MenberID.Equals(product.MemberID)).CompanyName;
                order.ProNum = orderDetail.ProNum;
                order.PurchaseID = 0;
                order.Amount = orderDetail.Amount;
                order.CreateDate = DateTime.Now;
                order.OrderNum = string.Empty;
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
                    order.Amount -= Math.Round(double.Parse(oddt.ProNum.ToString()) * oddt.Price);
                    oddt.ProNum += orderDetail.ProNum;
                    oddt.Price = GetPrice(product.PriceRang,oddt.ProNum);
                    oddt.PriceRang = GetPriceRang(product.PriceRang,oddt.ProNum);
                    odinfo.CrtPriceRang=oddt.PriceRang;
                    oddt.Amount = Math.Round(double.Parse(oddt.ProNum.ToString()) * oddt.Price);
                    order.Amount += oddt.Amount;
                    order.ProNum += orderDetail.ProNum;
                }
            }
             
            odinfo.PurTotalCount = Orders.Sum(a=>a.ProNum);
            odinfo.CrtProAmount= OrderDetail.Where(a=>a.ProductID.Equals(ProductID)).Sum(a=>a.Amount);
            odinfo.PurTotalAmount = Orders.Sum(a=>a.Amount);
            odinfo.CrtOrderAmount = Orders.Where(a=>a.ID.Equals(orderDetail.OrderID)).Sum(a=>a.Amount);
            return odinfo;
        }

        public OrderInfo Del(int ProductID) {
            var oddt= OrderDetail.Single(a => a.ProductID.Equals(ProductID));
            int odid = oddt.OrderID;
            var od=Orders.Single(a=>a.ID.Equals(oddt.OrderID));
            od.ProNum-=oddt.ProNum;
            od.Amount -= oddt.Amount;
            OrderDetail.RemoveAll(a=>a.ProductID.Equals(ProductID));
            Orders.RemoveAll(a=>a.ProNum.Equals(0));
            var odif= new OrderInfo { 
                PurTotalCount = Orders.Sum(a=>a.ProNum),
                PurTotalAmount = Orders.Sum(a=>a.Amount),
                CrtOrderAmount=0
            };
            var odlist=Orders.Where(a => a.ID.Equals(odid));
            if (odlist.Count() > 0) {
                odif.CrtOrderAmount = odlist.Sum(a => a.Amount);
            }
            return odif;
        }

        public OrderInfo Del(string ids) {
            OrderInfo odif;
            foreach (var item in ids.Split(','))
            {
                odif = Del(int.Parse(item));
            }
            return odif;
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

        /// <summary>
        /// 获取当前价格的价格区间显示字符串
        /// </summary>
        /// <param name="PriceRang"></param>
        /// <param name="ProductNum"></param>
        /// <returns></returns>
        public string GetPriceRang(string PriceRang, int ProductNum)
        {
            string[] pr = PriceRang.Split('|');
            string proNum = "", prices = "",str = "";
            foreach (var item in pr)
            {
                proNum += item.Split(',')[0] + ",";
                prices += item.Split(',')[1] + ",";
            }
            string[] pns = proNum.TrimEnd(',').Split(','), prs = prices.TrimEnd(',').Split(',');
  
            for (int i = 0; i < pns.Length; i++)
            {
                if (i + 1 < pns.Length)
                {
                    if (ProductNum >= int.Parse(pns[i]) && ProductNum < int.Parse(pns[i + 1]))
                    {
                        str += "<p>" + pns[i] + "-" + (int.Parse(pns[i + 1]) - 1) + "：" + prs[i] + "</p>";
                    }
                    else {
                        str += "<p class='gray'>" + pns[i] + "-" + (int.Parse(pns[i + 1]) - 1) + "：" + prs[i] + "</p>";
                    }
                }
                else
                {
                    if(ProductNum>=int.Parse(pns[i]))
                        str += "<p>≥" + pns[i]  + "：" + prs[i] + "</p>";
                    else
                        str += "<p class='gray'>≥" + pns[i] + "：" + prs[i] + "</p>";
                }
            }
            return str;
        }

       public class OrderInfo {
            /// <summary>
            /// 进货单总产品数
            /// </summary>
            public int PurTotalCount { get; set; }

            /// <summary>
            /// 当前产品ID所对应的总金额
            /// </summary>
            public double CrtProAmount { get; set; }

            /// <summary>
            /// 进货单总金额
            /// </summary>
            public double PurTotalAmount { get; set; }

            /// <summary>
            /// 当前订单总金额
            /// </summary>
            public double CrtOrderAmount { get; set; }

            /// <summary>
            /// 当前订单价格区间字符串
            /// </summary>
            public string CrtPriceRang { get; set; }
        } 
    }


}
