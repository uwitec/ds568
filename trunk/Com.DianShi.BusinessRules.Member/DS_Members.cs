using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using DBUtility;
using Com.DianShi.Model.Member;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_Members_Br:BllBase
    {
        public void Add(DS_Members Members)
        {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Members.InsertOnSubmit(Members);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Members Members)
        {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Members.Attach(Members, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                DS_Members st = ct.DS_Members.Single(a => a.ID == ID);
                ct.DS_Members.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Members GetSingle(int ID)
        {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Members.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Members> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
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
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
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
            using (DbConnection con=DbHelperSQL.GetConnection())
            {
                var tran = con.BeginTransaction();
                var mbct = new DS_MembersDataContext(con);
                mbct.Transaction = tran;
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
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                var md=ct.DS_Members.Where(a=>a.UserID.ToLower().Equals(uid.Trim().ToLower()));
                return md.Count() > 0;
            }
        }

        public bool Login(ref DS_Members Member) {
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                string uid = Member.UserID.Trim(), pwd = Member.Password.Trim();
                Member = ct.DS_Members.SingleOrDefault(a => a.UserID == uid&& a.Password==pwd);
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
            using (var ct = new DS_MembersDataContext(DbHelperSQL.Connection))
            {
                newPwd = newPwd.Trim();
                var md = GetSingle(ID);
                if (md.Password ==oldPwd.Trim())
                {
                    if (Common.Validate.RegPwd(newPwd))
                    {
                        md.Password = newPwd;
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

        /// <summary>
        /// 获取会员资源文件夹路径,路径开头和结尾没有"/"
        /// </summary>
        /// <param name="MemberID"></param>
        /// <returns></returns>
        public string GetMemberDir(int MemberID) {
            int md = MemberID / 5001 + 1;
            return "S" + md.ToString().PadLeft(3, '0') + "/U" + MemberID;
        }
    }
}
