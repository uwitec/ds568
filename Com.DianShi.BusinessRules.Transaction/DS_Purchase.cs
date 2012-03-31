using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Transaction;
using DBUtility;
namespace Com.DianShi.BusinessRules.Transaction
{
    public class DS_Purchase_Br:BllBase
    {
        public void Add(DS_Purchase Purchase)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Purchase.InsertOnSubmit(Purchase);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Purchase Purchase)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Purchase.Attach(Purchase, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                DS_Purchase st = ct.DS_Purchase.Single(a => a.ID == ID);
                ct.DS_Purchase.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Purchase GetSingle(int ID)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Purchase.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Purchase> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Purchase> PurchaseList = ct.DS_Purchase;
                if (!string.IsNullOrEmpty(condition))
                    PurchaseList = PurchaseList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PurchaseList = PurchaseList.OrderBy(orderby);
                pageCount = PurchaseList.Count();
                return PurchaseList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Purchase> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_PurchaseDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Purchase> PurchaseList = ct.DS_Purchase;
                if (!string.IsNullOrEmpty(condition))
                    PurchaseList = PurchaseList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PurchaseList = PurchaseList.OrderBy(orderby);
                return PurchaseList.ToList();
            }
        }

        public Com.DianShi.Model.Transaction.DS_Purchase CreateModel() {
            return new Com.DianShi.Model.Transaction.DS_Purchase();
        }

       
    }
}
