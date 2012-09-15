using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.ShopConfig;
using DBUtility;
namespace Com.DianShi.BusinessRules.ShopConfig
{
    public class DS_ShopConfig_Br:BllBase
    {
        public void Add(DS_ShopConfig ShopConfig)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopConfig.InsertOnSubmit(ShopConfig);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_ShopConfig ShopConfig)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopConfig.Attach(ShopConfig, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                DS_ShopConfig st = ct.DS_ShopConfig.Single(a => a.ID == ID);
                ct.DS_ShopConfig.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_ShopConfig.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_ShopConfig.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

       

        public DS_ShopConfig GetSingle(int ID)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_ShopConfig.Single(a => a.ID == ID);
            }
        }

        public DS_ShopConfig GetSingle(int MemberID,bool IsCache)
        {
            var ShopConfig = SDG.Cache.CacheUtility.Get("ShopConfig_"+MemberID) as DS_ShopConfig;
            if (!IsCache||ShopConfig == null)
            {
                using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
                {
                    var list = ct.DS_ShopConfig.Where(a=>a.MemberID==MemberID);
                    if (list.Count() > 0)
                    {
                        return list.Single();
                    }
                    else
                        return null;
                }
            }
            else
                return ShopConfig;
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_ShopConfig> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ShopConfig> ShopConfigList = ct.DS_ShopConfig;
                if (!string.IsNullOrEmpty(condition))
                    ShopConfigList = ShopConfigList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ShopConfigList = ShopConfigList.OrderBy(orderby);
                pageCount = ShopConfigList.Count();
                return ShopConfigList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_ShopConfig> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_ShopConfigDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ShopConfig> ShopConfigList = ct.DS_ShopConfig;
                if (!string.IsNullOrEmpty(condition))
                    ShopConfigList = ShopConfigList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ShopConfigList = ShopConfigList.OrderBy(orderby);
                return ShopConfigList.ToList();
            }
        }

        public DS_ShopConfig CreateModel() {
            return new DS_ShopConfig();
        }

        
    }
}
