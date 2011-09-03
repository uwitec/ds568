using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.DianShi.Model.Member;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_Members:DBUtility.BllBase
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
    }
}
