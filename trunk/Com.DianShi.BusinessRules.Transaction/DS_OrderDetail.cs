using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Transaction;
using DBUtility;
namespace Com.DianShi.BusinessRules.Transaction
{
    public class DS_OrderDetail_Br:BllBase
    {
        public void Add(DS_OrderDetail OrderDetail)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                ct.DS_OrderDetail.InsertOnSubmit(OrderDetail);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_OrderDetail OrderDetail)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                ct.DS_OrderDetail.Attach(OrderDetail, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                DS_OrderDetail st = ct.DS_OrderDetail.Single(a => a.ID == ID);
                ct.DS_OrderDetail.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_OrderDetail GetSingle(int ID)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_OrderDetail.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_OrderDetail> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_OrderDetail> OrderDetailList = ct.DS_OrderDetail;
                if (!string.IsNullOrEmpty(condition))
                    OrderDetailList = OrderDetailList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    OrderDetailList = OrderDetailList.OrderBy(orderby);
                pageCount = OrderDetailList.Count();
                return OrderDetailList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_OrderDetail> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_OrderDetailDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_OrderDetail> OrderDetailList = ct.DS_OrderDetail;
                if (!string.IsNullOrEmpty(condition))
                    OrderDetailList = OrderDetailList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    OrderDetailList = OrderDetailList.OrderBy(orderby);
                return OrderDetailList.ToList();
            }
        }

        public Com.DianShi.Model.Transaction.DS_OrderDetail CreateModel() {
            return new Com.DianShi.Model.Transaction.DS_OrderDetail();
        }

       
    }
}
