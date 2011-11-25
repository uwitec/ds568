using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Product;
namespace Com.DianShi.BusinessRules.Product
{
    public class DS_DiyProCategory_Br : DBUtility.BllBase
    {
        public void Add(DS_DiyProCategory DiyProCategory)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                ct.DS_DiyProCategory.InsertOnSubmit(DiyProCategory);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_DiyProCategory DiyProCategory)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                ct.DS_DiyProCategory.Attach(DiyProCategory, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                var st = ct.DS_DiyProCategory.Single(a => a.ID == ID);
                ct.DS_DiyProCategory.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_DiyProCategory.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_DiyProCategory.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_DiyProCategory GetSingle(int ID)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                return ct.DS_DiyProCategory.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_DiyProCategory> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                IQueryable<DS_DiyProCategory> DiyProCategoryList = ct.DS_DiyProCategory;
                if (!string.IsNullOrEmpty(condition))
                    DiyProCategoryList = DiyProCategoryList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    DiyProCategoryList = DiyProCategoryList.OrderBy(orderby);
                pageCount = DiyProCategoryList.Count();
                return DiyProCategoryList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_DiyProCategory> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_DiyProCategoryDataContext())
            {
                IQueryable<DS_DiyProCategory> DiyProCategoryList = ct.DS_DiyProCategory;
                if (!string.IsNullOrEmpty(condition))
                    DiyProCategoryList = DiyProCategoryList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    DiyProCategoryList = DiyProCategoryList.OrderBy(orderby);
                return DiyProCategoryList.ToList();
            }
        }

        public Com.DianShi.Model.Product.DS_DiyProCategory CreateModel() {
            return new Com.DianShi.Model.Product.DS_DiyProCategory();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (DS_DiyProCategoryDataContext ct = new DS_DiyProCategoryDataContext())
            {
                var md = ct.DS_DiyProCategory.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_DiyProCategory  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_DiyProCategory where  MemberID={0}) as p2 where id=DS_DiyProCategory.id) where MemberID={0}", md.MemberID);
                if (IsUp)
                {
                    DS_DiyProCategory p = ct.DS_DiyProCategory.Single(a => a.ID == ID);
                    DS_DiyProCategory p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_DiyProCategory.Single(a => a.Px == (p.Px - 1) && a.MemberID == md.MemberID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_DiyProCategory p = ct.DS_DiyProCategory.Single(a => a.ID == ID);
                    DS_DiyProCategory p1;
                    if (p.Px < ct.DS_DiyProCategory.Where(a => a.MemberID == md.MemberID).Count())
                    {
                        p1 = ct.DS_DiyProCategory.Single(a => a.Px == (p.Px + 1) && a.MemberID == md.MemberID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }

       
         
    }
}
