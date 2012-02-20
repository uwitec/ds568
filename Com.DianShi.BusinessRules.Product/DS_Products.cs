using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Product;
using DBUtility;
namespace Com.DianShi.BusinessRules.Product
{
    public class DS_Products_Br : BllBase
    {
        public void Add(DS_Products Products)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Products.InsertOnSubmit(Products);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Products Products)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Products.Attach(Products, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                var st = ct.DS_Products.Single(a => a.ID == ID);
                ct.DS_Products.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Products.Where(a=>idarray.Contains(a.ID.ToString()));
                ct.DS_Products.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_Products GetSingle(int ID)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Products.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();//ct.DS_Products.Where(c=>System.Data.Linq.SqlClient.SqlMethods.Like(字段,"%A%"))
            }
        }

        public List<DS_Products> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
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
            using (var ct = new DS_ProductsDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Products> ProductsList = ct.DS_Products;
                if (!string.IsNullOrEmpty(condition))
                    ProductsList = ProductsList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ProductsList = ProductsList.OrderBy(orderby);
                return ProductsList.ToList();
            }
        }

        public List<View_Products> QueryView(string condition, string orderby, params object[] param)
        {
            using (var ct = new View_ProductsDataContext(DbHelperSQL.Connection))
            {
                IQueryable<View_Products> ProductsList = ct.View_Products;
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

        

         
    }
}
