using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_BusType_Br:DBUtility.BllBase
    {
        public void Add(DS_BusType BusType)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                ct.DS_BusType.InsertOnSubmit(BusType);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_BusType BusType)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                ct.DS_BusType.Attach(BusType, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                DS_BusType st = ct.DS_BusType.Single(a => a.ID == ID);
                ct.DS_BusType.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_BusType GetSingle(int ID)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                return ct.DS_BusType.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_BusType> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                IQueryable<DS_BusType> BusTypeList = ct.DS_BusType;
                if (!string.IsNullOrEmpty(condition))
                    BusTypeList = BusTypeList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    BusTypeList = BusTypeList.OrderBy(orderby);
                pageCount = BusTypeList.Count();
                return BusTypeList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_BusType> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_BusTypeDataContext())
            {
                IQueryable<DS_BusType> BusTypeList = ct.DS_BusType;
                if (!string.IsNullOrEmpty(condition))
                    BusTypeList = BusTypeList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    BusTypeList = BusTypeList.OrderBy(orderby);
                return BusTypeList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_BusType CreateModel() {
            return new Com.DianShi.Model.Member.DS_BusType();
        }

       
    }
}
