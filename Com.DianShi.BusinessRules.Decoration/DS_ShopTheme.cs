using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.ShopConfig;
using DBUtility;
namespace Com.DianShi.BusinessRules.ShopConfig
{
    public class DS_ShopTheme_Br:BllBase
    {
        public void Add(DS_ShopTheme ShopTheme)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopTheme.InsertOnSubmit(ShopTheme);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_ShopTheme ShopTheme)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopTheme.Attach(ShopTheme, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                DS_ShopTheme st = ct.DS_ShopTheme.Single(a => a.ID == ID);
                ct.DS_ShopTheme.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_ShopTheme.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_ShopTheme.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

       

        public DS_ShopTheme GetSingle(int ID)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_ShopTheme.Single(a => a.ID == ID);
            }
        }

       
        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_ShopTheme> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ShopTheme> ShopThemeList = ct.DS_ShopTheme;
                if (!string.IsNullOrEmpty(condition))
                    ShopThemeList = ShopThemeList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ShopThemeList = ShopThemeList.OrderBy(orderby);
                pageCount = ShopThemeList.Count();
                return ShopThemeList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_ShopTheme> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ShopTheme> ShopThemeList = ct.DS_ShopTheme;
                if (!string.IsNullOrEmpty(condition))
                    ShopThemeList = ShopThemeList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ShopThemeList = ShopThemeList.OrderBy(orderby);
                return ShopThemeList.ToList();
            }
        }

        public  DS_ShopTheme CreateModel() {
            return new DS_ShopTheme();
        }

        public enum SignType : byte { 
            背景图,
            背景色
        }
    }
}
