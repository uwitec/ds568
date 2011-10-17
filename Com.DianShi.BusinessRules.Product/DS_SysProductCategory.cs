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
    public class DS_SysProductCategory_Br : DBUtility.BllBase
    {
        public void Add(DS_SysProductCategory SysProductCategory)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                ct.DS_SysProductCategory.InsertOnSubmit(SysProductCategory);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_SysProductCategory SysProductCategory)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                ct.DS_SysProductCategory.Attach(SysProductCategory, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                var st = ct.DS_SysProductCategory.Single(a => a.ID == ID);
                ct.DS_SysProductCategory.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                string[] idarray = Ids.Split(',');
                int[] intarray=new int[idarray.Length];
                for (int i = 0; i < idarray.Length; i++)
                {
                    intarray[i] = int.Parse(idarray[i]);
                    var list1 = ct.DS_SysProductCategory.Where(a=>a.ParentID==intarray[i]);
                    foreach (var item in list1)
                    {
                        ct.DS_SysProductCategory.DeleteAllOnSubmit(ct.DS_SysProductCategory.Where(a=>a.ParentID==item.ID));
                    }
                    ct.DS_SysProductCategory.DeleteAllOnSubmit(list1);
                }
                var list = ct.DS_SysProductCategory.Where(a=>intarray.Contains(a.ID));
                ct.DS_SysProductCategory.DeleteAllOnSubmit(list);

                ct.SubmitChanges();
            }
        }

        public DS_SysProductCategory GetSingle(int ID)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                return ct.DS_SysProductCategory.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();ct.DS_SysProductCategory.Where(c=>System.Data.Linq.SqlClient.SqlMethods.Like())
            }
        }

        public List<DS_SysProductCategory> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                IQueryable<DS_SysProductCategory> SysProductCategoryList = ct.DS_SysProductCategory;
                if (!string.IsNullOrEmpty(condition))
                    SysProductCategoryList = SysProductCategoryList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    SysProductCategoryList = SysProductCategoryList.OrderBy(orderby);
                pageCount = SysProductCategoryList.Count();
                return SysProductCategoryList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_SysProductCategory> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_SysProductCategoryDataContext())
            {
                IQueryable<DS_SysProductCategory> SysProductCategoryList = ct.DS_SysProductCategory;
                if (!string.IsNullOrEmpty(condition))
                    SysProductCategoryList = SysProductCategoryList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    SysProductCategoryList = SysProductCategoryList.OrderBy(orderby);
                return SysProductCategoryList.ToList();
            }
        }

        public Com.DianShi.Model.Product.DS_SysProductCategory CreateModel() {
            return new Com.DianShi.Model.Product.DS_SysProductCategory();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (DS_SysProductCategoryDataContext ct = new DS_SysProductCategoryDataContext())
            {
                var md = ct.DS_SysProductCategory.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_SysProductCategory  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_SysProductCategory where  parentid={0}) as p2 where id=DS_SysProductCategory.id) where parentid={0}", md.ParentID);
                if (IsUp)
                {
                    DS_SysProductCategory p = ct.DS_SysProductCategory.Single(a => a.ID == ID);
                    DS_SysProductCategory p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_SysProductCategory.Single(a => a.Px == (p.Px - 1) && a.ParentID == md.ParentID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_SysProductCategory p = ct.DS_SysProductCategory.Single(a => a.ID == ID);
                    DS_SysProductCategory p1;
                    if (p.Px < ct.DS_SysProductCategory.Where(a => a.ParentID == md.ParentID).Count())
                    {
                        p1 = ct.DS_SysProductCategory.Single(a => a.Px == (p.Px + 1) && a.ParentID == md.ParentID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }

        /// <summary>
        /// 获取当前类别及其父类别的路径
        /// </summary>
        /// <param name="CatID">当前类别ID</param>
        /// <param name="IsFirst">路径是否包含当前类别名称</param>
        /// <returns></returns>
        public  string GetCategoryName(int CatID,bool IsFirst) {
            var md=GetSingle(CatID);
            string CatName=IsFirst?"":md.CategoryName+">";
            if (!md.ParentID.Equals(0))
            {
                return  GetCategoryName(md.ParentID,false)+CatName;
            }
            else
                return CatName;
        }
         
    }
}
