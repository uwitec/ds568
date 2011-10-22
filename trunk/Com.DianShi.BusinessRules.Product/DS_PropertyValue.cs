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
    public class DS_PropertyValue_Br : DBUtility.BllBase
    {
        public void Add(DS_PropertyValue PropertyValue)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                ct.DS_PropertyValue.InsertOnSubmit(PropertyValue);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_PropertyValue PropertyValue)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                ct.DS_PropertyValue.Attach(PropertyValue, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                var st = ct.DS_PropertyValue.Single(a => a.ID == ID);
                ct.DS_PropertyValue.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                string[] idarray = Ids.Split(',');
                int[] intarray=new int[idarray.Length];
                for (int i = 0; i < idarray.Length; i++)
                {
                    intarray[i] = int.Parse(idarray[i]);
                }
                var list = ct.DS_PropertyValue.Where(a=>intarray.Contains(a.ID));
                ct.DS_PropertyValue.DeleteAllOnSubmit(list);

                ct.SubmitChanges();
            }
        }

        public DS_PropertyValue GetSingle(int ID)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                return ct.DS_PropertyValue.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();//ct.DS_PropertyValue.Where(c=>System.Data.Linq.SqlClient.SqlMethods.Like(字段,"%A%"))
            }
        }

        public List<DS_PropertyValue> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                IQueryable<DS_PropertyValue> PropertyValueList = ct.DS_PropertyValue;
                if (!string.IsNullOrEmpty(condition))
                    PropertyValueList = PropertyValueList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PropertyValueList = PropertyValueList.OrderBy(orderby);
                pageCount = PropertyValueList.Count();
                return PropertyValueList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_PropertyValue> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_PropertyValueDataContext())
            {
                IQueryable<DS_PropertyValue> PropertyValueList = ct.DS_PropertyValue;
                if (!string.IsNullOrEmpty(condition))
                    PropertyValueList = PropertyValueList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PropertyValueList = PropertyValueList.OrderBy(orderby);
                return PropertyValueList.ToList();
            }
        }

        public Com.DianShi.Model.Product.DS_PropertyValue CreateModel() {
            return new Com.DianShi.Model.Product.DS_PropertyValue();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (DS_PropertyValueDataContext ct = new DS_PropertyValueDataContext())
            {
                var md = ct.DS_PropertyValue.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_PropertyValue  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_PropertyValue where PropertyID={0}) as p2 where id=DS_PropertyValue.id) where PropertyID={0}", md.PropertyID);
                if (IsUp)
                {
                    DS_PropertyValue p = ct.DS_PropertyValue.Single(a => a.ID == ID);
                    DS_PropertyValue p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_PropertyValue.Single(a => a.Px == (p.Px - 1) && a.PropertyID == md.PropertyID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_PropertyValue p = ct.DS_PropertyValue.Single(a => a.ID == ID);
                    DS_PropertyValue p1;
                    if (p.Px < ct.DS_PropertyValue.Where(a => a.PropertyID == md.PropertyID).Count())
                    {
                        p1 = ct.DS_PropertyValue.Single(a => a.Px == (p.Px + 1) && a.PropertyID == md.PropertyID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }
 
    }
}
