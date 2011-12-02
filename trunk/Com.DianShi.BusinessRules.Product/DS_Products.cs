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
    public class DS_Products_Br : DBUtility.BllBase
    {
        public void Add(DS_Products Products)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                ct.DS_Products.InsertOnSubmit(Products);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Products Products)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                ct.DS_Products.Attach(Products, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                var st = ct.DS_Products.Single(a => a.ID == ID);
                ct.DS_Products.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Products.Where(a=>idarray.Contains(a.ID.ToString()));
                ct.DS_Products.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_Products GetSingle(int ID)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                return ct.DS_Products.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();//ct.DS_Products.Where(c=>System.Data.Linq.SqlClient.SqlMethods.Like(字段,"%A%"))
            }
        }

        public List<DS_Products> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                IQueryable<DS_Products> ProductsList = ct.DS_Products;
                if (!string.IsNullOrEmpty(condition))
                    ProductsList = ProductsList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ProductsList = ProductsList.OrderBy(orderby);
                pageCount = ProductsList.Count();
                return ProductsList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Products> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_ProductsDataContext())
            {
                IQueryable<DS_Products> ProductsList = ct.DS_Products;
                if (!string.IsNullOrEmpty(condition))
                    ProductsList = ProductsList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ProductsList = ProductsList.OrderBy(orderby);
                return ProductsList.ToList();
            }
        }

        public Com.DianShi.Model.Product.DS_Products CreateModel() {
            return new Com.DianShi.Model.Product.DS_Products();
        }

        public enum State : byte { 
            销售中,
            待审中,
            审核未过,
            已过期
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        //public void Sort(int ID, bool IsUp)
        //{
        //    using (DS_ProductsDataContext ct = new DS_ProductsDataContext())
        //    {
        //        var md = ct.DS_Products.Single(a => a.ID == ID);
        //        ct.ExecuteCommand("update DS_Products  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_Products where  MemberID={0}) as p2 where id=DS_Products.id) where MemberID={0}", md.MemberID);
        //        if (IsUp)
        //        {
        //            DS_Products p = ct.DS_Products.Single(a => a.ID == ID);
        //            DS_Products p1;
        //            if (p.Px > 1)
        //            {
        //                p1 = ct.DS_Products.Single(a => a.Px == (p.Px - 1) && a.MemberID == md.MemberID);
        //                p.Px--;
        //                p1.Px++;
        //            }

        //        }
        //        else
        //        {
        //            DS_Products p = ct.DS_Products.Single(a => a.ID == ID);
        //            DS_Products p1;
        //            if (p.Px < ct.DS_Products.Where(a => a.MemberID == md.MemberID).Count())
        //            {
        //                p1 = ct.DS_Products.Single(a => a.Px == (p.Px + 1) && a.MemberID == md.MemberID);
        //                p.Px++;
        //                p1.Px--;
        //            }
        //        }
        //        ct.SubmitChanges();
        //    }
        //}

         
    }
}
