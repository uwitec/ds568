using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Transaction;
using DBUtility;
namespace Com.DianShi.BusinessRules.Transaction
{
    public class DS_Orders_Br:BllBase
    {
        public void Add(DS_Orders Orders)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Orders.InsertOnSubmit(Orders);
                ct.SubmitChanges();
            }
        }

        public void Add(List<DS_Orders> Orders,List<DS_OrderDetail> OrderDetail)
        {
            using (var con = DbHelperSQL.GetConnection()) {
                var tran = con.BeginTransaction();
                var ct = new DS_OrdersDataContext(con);
                ct.Transaction = tran;
                var ct2 = new DS_OrderDetailDataContext(con);
                ct2.Transaction = tran;
                foreach (var item in Orders)
                {
                    ct.DS_Orders.InsertOnSubmit(item);
                    ct.SubmitChanges();
                    var list = OrderDetail.Where(a => a.OrderID.Equals(item.ID));
                    foreach (var odd in list)
                    {
                        odd.OrderID = item.ID;
                    }
                    ct2.DS_OrderDetail.InsertAllOnSubmit(list);
                    ct2.SubmitChanges();
                }
                tran.Commit();
            }
           
        }

        public void Update(DS_Orders Orders)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Orders.Attach(Orders, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                DS_Orders st = ct.DS_Orders.Single(a => a.ID == ID);
                ct.DS_Orders.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Orders GetSingle(int ID)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Orders.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Orders> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Orders> OrdersList = ct.DS_Orders;
                if (!string.IsNullOrEmpty(condition))
                    OrdersList = OrdersList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    OrdersList = OrdersList.OrderBy(orderby);
                pageCount = OrdersList.Count();
                return OrdersList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Orders> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_OrdersDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Orders> OrdersList = ct.DS_Orders;
                if (!string.IsNullOrEmpty(condition))
                    OrdersList = OrdersList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    OrdersList = OrdersList.OrderBy(orderby);
                return OrdersList.ToList();
            }
        }

        public Com.DianShi.Model.Transaction.DS_Orders CreateModel() {
            return new Com.DianShi.Model.Transaction.DS_Orders();
        }

        
    }
}
