using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_CompanyInfo_Br:DBUtility.BllBase
    {
        public void Add(DS_CompanyInfo CompanyInfo)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                ct.DS_CompanyInfo.InsertOnSubmit(CompanyInfo);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_CompanyInfo CompanyInfo)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                ct.DS_CompanyInfo.Attach(CompanyInfo, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                DS_CompanyInfo st = ct.DS_CompanyInfo.Single(a => a.ID == ID);
                ct.DS_CompanyInfo.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_CompanyInfo GetSingle(int ID)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                return ct.DS_CompanyInfo.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_CompanyInfo> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                IQueryable<DS_CompanyInfo> CompanyInfoList = ct.DS_CompanyInfo;
                if (!string.IsNullOrEmpty(condition))
                    CompanyInfoList = CompanyInfoList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    CompanyInfoList = CompanyInfoList.OrderBy(orderby);
                pageCount = CompanyInfoList.Count();
                return CompanyInfoList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_CompanyInfo> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_CompanyInfoDataContext())
            {
                IQueryable<DS_CompanyInfo> CompanyInfoList = ct.DS_CompanyInfo;
                if (!string.IsNullOrEmpty(condition))
                    CompanyInfoList = CompanyInfoList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    CompanyInfoList = CompanyInfoList.OrderBy(orderby);
                return CompanyInfoList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_CompanyInfo CreateModel() {
            return new Com.DianShi.Model.Member.DS_CompanyInfo();
        }
    }
}
