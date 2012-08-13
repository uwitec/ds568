using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
using DBUtility;
using System.IO;
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
                string imgpath = System.Web.HttpContext.Current.Server.MapPath(Common.Constant.WebConfig("AlbumRootPath") + DS_Members_Br.GetMemberDir(st.MemberID) + "/Certificate/");
                if (File.Exists(imgpath += st.CtfImg))
                {
                    File.Delete(imgpath);
                }
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

        /// <summary>
        /// 获取指定会员已上网证书数量
        /// </summary>
        /// <param name="MemberID">会员ID</param>
        /// <param name="IsCache">是否缓存</param>
        /// <returns></returns>
        public static int CtfCount(int MemberID, bool IsCache)
        {

            string che_key = "che_ctf_count_" + MemberID;
            var ch = SDG.Cache.CacheUtility.Get(che_key);
            if (ch == null||!IsCache)
            {
                using (var ct = new DS_CertificateDataContext(DbHelperSQL.Connection))
                {
                    int cc = ct.DS_Certificate.Where(a => a.MemberID.Equals(MemberID) && a.CtfState.Equals(CtfState.已上网)).Count();
                    if(IsCache)
                        SDG.Cache.CacheUtility.Insert(che_key, cc, null, 20.0,SDG.Cache.CacheUtility.ExpiType.绝对过期);
                    return cc;
                }
            }
            else
            {
                return (int)ch;
            }

        }
       
    }
}
