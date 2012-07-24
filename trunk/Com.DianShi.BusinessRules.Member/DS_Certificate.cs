using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
using DBUtility;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_Certificate_Br:BllBase
    {
        public void Add(DS_Certificate Certificate)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Certificate.InsertOnSubmit(Certificate);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Certificate Certificate)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Certificate.Attach(Certificate, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                DS_Certificate st = ct.DS_Certificate.Single(a => a.ID == ID);
                ct.DS_Certificate.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Certificate GetSingle(int ID)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Certificate.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Certificate> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Certificate> CertificateList = ct.DS_Certificate;
                if (!string.IsNullOrEmpty(condition))
                    CertificateList = CertificateList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    CertificateList = CertificateList.OrderBy(orderby);
                pageCount = CertificateList.Count();
                return CertificateList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Certificate> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Certificate> CertificateList = ct.DS_Certificate;
                if (!string.IsNullOrEmpty(condition))
                    CertificateList = CertificateList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    CertificateList = CertificateList.OrderBy(orderby);
                return CertificateList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_Certificate CreateModel() {
            return new Com.DianShi.Model.Member.DS_Certificate();
        }

        public  enum CtfType : byte {
            税务登记证,
            经营许可类证书,
            产品类证书,
            其他
        }

        public enum CtfState : byte { 
            审核中,
            审核不通过,
            已上网
        }

       
    }
}
