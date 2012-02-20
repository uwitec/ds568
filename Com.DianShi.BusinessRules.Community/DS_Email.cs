using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Community;
using DBUtility;
namespace Com.DianShi.BusinessRules.Community
{
    public class DS_Email_Br:BllBase
    {
        
        public void Add(DS_Email Email)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Email.InsertOnSubmit(Email);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Email Email)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Email.Attach(Email, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                DS_Email st = ct.DS_Email.Single(a => a.ID == ID);
                ct.DS_Email.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_Email GetSingle(int ID)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Email.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Email> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Email> EmailList = ct.DS_Email;
                if (!string.IsNullOrEmpty(condition))
                    EmailList = EmailList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    EmailList = EmailList.OrderBy(orderby);
                pageCount = EmailList.Count();
                return EmailList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Email> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_EmailDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Email> EmailList = ct.DS_Email;
                if (!string.IsNullOrEmpty(condition))
                    EmailList = EmailList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    EmailList = EmailList.OrderBy(orderby);
                return EmailList.ToList();
            }
        }

        public Com.DianShi.Model.Community.DS_Email CreateModel() {
            return new Com.DianShi.Model.Community.DS_Email();
        }

       
    }
}
