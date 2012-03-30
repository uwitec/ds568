using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Sys;
using DBUtility;
namespace Com.DianShi.BusinessRules.Area
{
    public class DS_Area_Br :BllBase
    {
        public void Add(DS_Area Area)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Area.InsertOnSubmit(Area);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Area Area)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Area.Attach(Area, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                var st = ct.DS_Area.Single(a => a.ID == ID);
                ct.DS_Area.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Area.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_Area.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_Area GetSingle(int ID)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Area.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Area> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Area> AreaList = ct.DS_Area;
                if (!string.IsNullOrEmpty(condition))
                    AreaList = AreaList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    AreaList = AreaList.OrderBy(orderby);
                pageCount = AreaList.Count();
                return AreaList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Area> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_AreaDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Area> AreaList = ct.DS_Area;
                if (!string.IsNullOrEmpty(condition))
                    AreaList = AreaList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    AreaList = AreaList.OrderBy(orderby);
                return AreaList.ToList();
            }
        }

        public Com.DianShi.Model.Sys.DS_Area CreateModel()
        {
            return new Com.DianShi.Model.Sys.DS_Area();
        }

        /// <summary>
        /// 获取当前类别及其父类别的路径
        /// </summary>
        /// <param name="CatID">当前类别ID</param>
        /// <param name="IsFirst">路径是否包含当前类别名称</param>
        /// <returns></returns>
        public string GetAreaName(int ID, bool IsFirst)
        {
            var md = GetSingle(ID);
            string AreaName = IsFirst ? "" : md.AreaName + ">";
            if (!md.ParentID.Equals(0))
            {
                return GetAreaName(md.ParentID, false) + AreaName;
            }
            else
                return AreaName;
        }
     
    }
}
