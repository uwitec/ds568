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
    public class DS_Property_Br : DBUtility.BllBase
    {
        public void Add(DS_Property Property)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                ct.DS_Property.InsertOnSubmit(Property);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Property Property)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                ct.DS_Property.Attach(Property, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                var st = ct.DS_Property.Single(a => a.ID == ID);
                ct.DS_Property.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                string[] idarray = Ids.Split(',');
                int[] intarray=new int[idarray.Length];
                for (int i = 0; i < idarray.Length; i++)
                {
                    intarray[i] = int.Parse(idarray[i]);
                }
                var list = ct.DS_Property.Where(a=>intarray.Contains(a.ID));
                ct.DS_Property.DeleteAllOnSubmit(list);

                ct.SubmitChanges();
            }
        }

        public DS_Property GetSingle(int ID)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                return ct.DS_Property.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();//ct.DS_Property.Where(c=>System.Data.Linq.SqlClient.SqlMethods.Like(字段,"%A%"))
            }
        }

        public List<DS_Property> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                IQueryable<DS_Property> PropertyList = ct.DS_Property;
                if (!string.IsNullOrEmpty(condition))
                    PropertyList = PropertyList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PropertyList = PropertyList.OrderBy(orderby);
                pageCount = PropertyList.Count();
                return PropertyList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Property> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_PropertyDataContext())
            {
                IQueryable<DS_Property> PropertyList = ct.DS_Property;
                if (!string.IsNullOrEmpty(condition))
                    PropertyList = PropertyList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    PropertyList = PropertyList.OrderBy(orderby);
                return PropertyList.ToList();
            }
        }

        public Com.DianShi.Model.Product.DS_Property CreateModel() {
            return new Com.DianShi.Model.Product.DS_Property();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (DS_PropertyDataContext ct = new DS_PropertyDataContext())
            {
                var md = ct.DS_Property.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_Property  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_Property where  SysCatID={0}) as p2 where id=DS_Property.id) where SysCatID={0}", md.SysCatID);
                if (IsUp)
                {
                    DS_Property p = ct.DS_Property.Single(a => a.ID == ID);
                    DS_Property p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_Property.Single(a => a.Px == (p.Px - 1) && a.SysCatID == md.SysCatID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_Property p = ct.DS_Property.Single(a => a.ID == ID);
                    DS_Property p1;
                    if (p.Px < ct.DS_Property.Where(a => a.SysCatID == md.SysCatID).Count())
                    {
                        p1 = ct.DS_Property.Single(a => a.Px == (p.Px + 1) && a.SysCatID == md.SysCatID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }

        public enum ControlType : byte { 
            文本框,
            下拉框
        }
    }
}
