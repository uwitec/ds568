using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
using DBUtility;
namespace Com.DianShi.BusinessRules.Member
{
    public class View_Members_Br:BllBase
    {
        

        public View_Members GetSingle(int ID)
        {
            using (var ct = new View_MembersDataContext(DbHelperSQL.Connection))
            {
                return ct.View_Members.Single(a => a.ID == ID);
            }
        }


        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new View_MembersDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<View_Members> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new View_MembersDataContext(DbHelperSQL.Connection))
            {
                IQueryable<View_Members> MembersList = ct.View_Members;
                if (!string.IsNullOrEmpty(condition))
                    MembersList = MembersList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    MembersList = MembersList.OrderBy(orderby);
                pageCount = MembersList.Count();
                return MembersList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<View_Members> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new View_MembersDataContext(DbHelperSQL.Connection))
            {
                IQueryable<View_Members> MembersList = ct.View_Members;
                if (!string.IsNullOrEmpty(condition))
                    MembersList = MembersList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    MembersList = MembersList.OrderBy(orderby);
                return MembersList.ToList();
            }
        }

        public Com.DianShi.Model.Member.View_Members CreateModel() {
            return new Com.DianShi.Model.Member.View_Members();
        }

        
    }
}
