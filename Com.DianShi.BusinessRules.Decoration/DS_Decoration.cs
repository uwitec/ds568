using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Decoration;
using DBUtility;
namespace Com.DianShi.BusinessRules.Decoration
{
    public class DS_Decoration_Br:BllBase
    {
        public void Add(DS_Decoration Decoration)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Decoration.InsertOnSubmit(Decoration);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Decoration Decoration)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Decoration.Attach(Decoration, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                DS_Decoration st = ct.DS_Decoration.Single(a => a.ID == ID);
                ct.DS_Decoration.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Decoration.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_Decoration.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

       

        public DS_Decoration GetSingle(int ID)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Decoration.Single(a => a.ID == ID);
            }
        }

        public DS_Decoration GetSingle(int MemberID,bool IsCache)
        {
            var Decoration = SDG.Cache.CacheUtility.Get("Decoration_"+MemberID) as DS_Decoration;
            if (!IsCache||Decoration == null)
            {
                using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
                {
                    var list = ct.DS_Decoration.Where(a=>a.MemberID==MemberID);
                    if (list.Count() > 0)
                    {
                        return list.Single();
                    }
                    else
                        return null;
                }
            }
            else
                return Decoration;
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Decoration> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Decoration> DecorationList = ct.DS_Decoration;
                if (!string.IsNullOrEmpty(condition))
                    DecorationList = DecorationList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    DecorationList = DecorationList.OrderBy(orderby);
                pageCount = DecorationList.Count();
                return DecorationList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Decoration> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_DecorationDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Decoration> DecorationList = ct.DS_Decoration;
                if (!string.IsNullOrEmpty(condition))
                    DecorationList = DecorationList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    DecorationList = DecorationList.OrderBy(orderby);
                return DecorationList.ToList();
            }
        }

        public Com.DianShi.Model.Decoration.DS_Decoration CreateModel() {
            return new Com.DianShi.Model.Decoration.DS_Decoration();
        }

       
    }
}
