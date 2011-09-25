using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_ValiCodeSend_Br:DBUtility.BllBase
    {
        public void Add(DS_ValiCodeSend ValiCodeSend)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                ct.DS_ValiCodeSend.InsertOnSubmit(ValiCodeSend);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_ValiCodeSend ValiCodeSend)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                ct.DS_ValiCodeSend.Attach(ValiCodeSend, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                DS_ValiCodeSend st = ct.DS_ValiCodeSend.Single(a => a.ID == ID);
                ct.DS_ValiCodeSend.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_ValiCodeSend GetSingle(int ID)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                return ct.DS_ValiCodeSend.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_ValiCodeSend> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                IQueryable<DS_ValiCodeSend> ValiCodeSendList = ct.DS_ValiCodeSend;
                if (!string.IsNullOrEmpty(condition))
                    ValiCodeSendList = ValiCodeSendList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ValiCodeSendList = ValiCodeSendList.OrderBy(orderby);
                pageCount = ValiCodeSendList.Count();
                return ValiCodeSendList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_ValiCodeSend> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_ValiCodeSendDataContext())
            {
                IQueryable<DS_ValiCodeSend> ValiCodeSendList = ct.DS_ValiCodeSend;
                if (!string.IsNullOrEmpty(condition))
                    ValiCodeSendList = ValiCodeSendList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ValiCodeSendList = ValiCodeSendList.OrderBy(orderby);
                return ValiCodeSendList.ToList();
            }
        }

        public Com.DianShi.Model.Member.DS_ValiCodeSend CreateModel() {
            return new Com.DianShi.Model.Member.DS_ValiCodeSend();
        }
    }
}
