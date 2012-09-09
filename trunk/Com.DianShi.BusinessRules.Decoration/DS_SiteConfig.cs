using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.SiteConfig;
using DBUtility;
namespace Com.DianShi.BusinessRules.SiteConfig
{
    public class DS_SiteConfig_Br:BllBase
    {
        public void Add(DS_SiteConfig SiteConfig)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                ct.DS_SiteConfig.InsertOnSubmit(SiteConfig);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_SiteConfig SiteConfig)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                ct.DS_SiteConfig.Attach(SiteConfig, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                DS_SiteConfig st = ct.DS_SiteConfig.Single(a => a.ID == ID);
                ct.DS_SiteConfig.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_SiteConfig.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_SiteConfig.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

       

        public DS_SiteConfig GetSingle(int ID)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_SiteConfig.Single(a => a.ID == ID);
            }
        }

        public DS_SiteConfig GetSingle(int MemberID,bool IsCache)
        {
            var SiteConfig = SDG.Cache.CacheUtility.Get("SiteConfig_"+MemberID) as DS_SiteConfig;
            if (!IsCache||SiteConfig == null)
            {
                using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
                {
                    var list = ct.DS_SiteConfig.Where(a=>a.MemberID==MemberID);
                    if (list.Count() > 0)
                    {
                        return list.Single();
                    }
                    else
                        return null;
                }
            }
            else
                return SiteConfig;
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_SiteConfig> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_SiteConfig> SiteConfigList = ct.DS_SiteConfig;
                if (!string.IsNullOrEmpty(condition))
                    SiteConfigList = SiteConfigList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    SiteConfigList = SiteConfigList.OrderBy(orderby);
                pageCount = SiteConfigList.Count();
                return SiteConfigList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_SiteConfig> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_SiteConfigDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_SiteConfig> SiteConfigList = ct.DS_SiteConfig;
                if (!string.IsNullOrEmpty(condition))
                    SiteConfigList = SiteConfigList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    SiteConfigList = SiteConfigList.OrderBy(orderby);
                return SiteConfigList.ToList();
            }
        }

        public Com.DianShi.Model.SiteConfig.DS_SiteConfig CreateModel() {
            return new Com.DianShi.Model.SiteConfig.DS_SiteConfig();
        }

        
    }
}
