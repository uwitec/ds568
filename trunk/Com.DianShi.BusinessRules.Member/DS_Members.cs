using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_Members_Br:DBUtility.BllBase
    {
        public void Add(DS_Members Members)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                ct.DS_Members.InsertOnSubmit(Members);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Members Members)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                ct.DS_Members.Attach(Members, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                DS_Members st = ct.DS_Members.Single(a => a.ID == ID);
                ct.DS_Members.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Members GetSingle(int ID)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                return ct.DS_Members.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Members> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                IQueryable<DS_Members> MembersList = ct.DS_Members;
                if (!string.IsNullOrEmpty(condition))
                    MembersList = MembersList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    MembersList = MembersList.OrderBy(orderby);
                pageCount = MembersList.Count();
                return MembersList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Members> Query(string condition, string orderby, params object[] param)
        {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                IQueryable<DS_Members> MembersList = ct.DS_Members;
                if (!string.IsNullOrEmpty(condition))
                    MembersList = MembersList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    MembersList = MembersList.OrderBy(orderby);
                return MembersList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_Members CreateModel() {
            return new Com.DianShi.Model.Member.DS_Members();
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="Member"></param>
        /// <param name="Company"></param>
        public void Register(DS_Members Member,DS_CompanyInfo Company) {
            using (DbConnection con=DBUtility.DbHelperSQL.GetConnection())
            {
                var tran = con.BeginTransaction();
                var mbct = new DS_MembersDataContext(con);
                mbct.Transaction = tran;
                Member.Password = DBUtility.DESEncrypt.SymmetricEncrypts(Member.Password, Common.Constant.WebConfig("EcptKey"));
                mbct.DS_Members.InsertOnSubmit(Member);
                mbct.SubmitChanges();
                var comct = new DS_CompanyInfoDataContext(con);
                comct.Transaction = tran;
                Company.MenberID = Member.ID;
                comct.DS_CompanyInfo.InsertOnSubmit(Company);
                comct.SubmitChanges();
                tran.Commit();
            }
        }

        public bool Exits(string uid) {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                var md=ct.DS_Members.Where(a=>a.UserID.ToLower().Equals(uid.Trim().ToLower()));
                return md.Count() > 0;
            }
        }

        public bool Login(ref DS_Members Member) {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                string uid = Member.UserID.Trim(), pwd = DBUtility.DESEncrypt.SymmetricEncrypts(Member.Password.Trim(), Common.Constant.WebConfig("EcptKey"));
                Member = ct.DS_Members.SingleOrDefault(a => a.UserID==uid&& a.Password==pwd);
                return !object.Equals(Member,null);
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <param name="oldPwd">旧密码</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="msg">验证过程返回的消息</param>
        /// <returns>bool</returns>
        public bool ChangePwd(int ID,string oldPwd,string newPwd,ref string msg) {
            using (DS_MembersDataContext ct = new DS_MembersDataContext())
            {
                newPwd = newPwd.Trim();
                var md = GetSingle(ID);
                if (md.Password ==DBUtility.DESEncrypt.SymmetricEncrypts(oldPwd.Trim(), Common.Constant.WebConfig("EcptKey")))
                {
                    if (Common.Validate.RegPwd(newPwd))
                    {
                        md.Password = DBUtility.DESEncrypt.SymmetricEncrypts(newPwd, Common.Constant.WebConfig("EcptKey"));
                        Update(md);
                        return true;
                    }
                    else
                        msg = "密码格式不正确，请输入6-20数字或字母组合";
                }
                else
                    msg = "旧密码输入不正确";
                return false;
            }
        }
    }
}
