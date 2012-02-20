using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
using DBUtility;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_Turnover_Br:BllBase
    {
        public void Add(DS_Turnover Turnover)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Turnover.InsertOnSubmit(Turnover);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Turnover Turnover)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Turnover.Attach(Turnover, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                DS_Turnover st = ct.DS_Turnover.Single(a => a.ID == ID);
                ct.DS_Turnover.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Turnover GetSingle(int ID)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Turnover.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Turnover> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Turnover> TurnoverList = ct.DS_Turnover;
                if (!string.IsNullOrEmpty(condition))
                    TurnoverList = TurnoverList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    TurnoverList = TurnoverList.OrderBy(orderby);
                pageCount = TurnoverList.Count();
                return TurnoverList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Turnover> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_TurnoverDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Turnover> TurnoverList = ct.DS_Turnover;
                if (!string.IsNullOrEmpty(condition))
                    TurnoverList = TurnoverList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    TurnoverList = TurnoverList.OrderBy(orderby);
                return TurnoverList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_Turnover CreateModel() {
            return new Com.DianShi.Model.Member.DS_Turnover();
        }

       
    }
}
