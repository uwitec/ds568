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
    public class DS_SafeQuestion_Br:BllBase
    {
        public void Add(DS_SafeQuestion SafeQuestion)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                ct.DS_SafeQuestion.InsertOnSubmit(SafeQuestion);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_SafeQuestion SafeQuestion)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                ct.DS_SafeQuestion.Attach(SafeQuestion, true);
                ct.SubmitChanges();
            }
        }

        public void InsertOrUpdate(DS_SafeQuestion SafeQuestion)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_SafeQuestion.SingleOrDefault(a => a.MemberID.Equals(SafeQuestion.MemberID));
                if (object.Equals(md, null))
                    ct.DS_SafeQuestion.InsertOnSubmit(SafeQuestion);
                else
                {
                    md.Question1 = SafeQuestion.Question1;
                    md.Answer1 = SafeQuestion.Answer1;
                }
                ct.SubmitChanges();
            }
        }

        public bool Exists(int MemberID) {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_SafeQuestion.SingleOrDefault(a => a.MemberID.Equals(MemberID));
                return !object.Equals(md, null);
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                DS_SafeQuestion st = ct.DS_SafeQuestion.Single(a => a.ID == ID);
                ct.DS_SafeQuestion.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_SafeQuestion GetSingle(int ID)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_SafeQuestion.Single(a => a.ID == ID);
            }
        }
        public DS_SafeQuestion GetSingleByMemberID(int MemberID)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_SafeQuestion.Single(a => a.MemberID ==MemberID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_SafeQuestion> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_SafeQuestion> SafeQuestionList = ct.DS_SafeQuestion;
                if (!string.IsNullOrEmpty(condition))
                    SafeQuestionList = SafeQuestionList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    SafeQuestionList = SafeQuestionList.OrderBy(orderby);
                pageCount = SafeQuestionList.Count();
                return SafeQuestionList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_SafeQuestion> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_SafeQuestionDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_SafeQuestion> SafeQuestionList = ct.DS_SafeQuestion;
                if (!string.IsNullOrEmpty(condition))
                    SafeQuestionList = SafeQuestionList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    SafeQuestionList = SafeQuestionList.OrderBy(orderby);
                return SafeQuestionList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_SafeQuestion CreateModel() {
            return new Com.DianShi.Model.Member.DS_SafeQuestion();
        }

         
    }
}
