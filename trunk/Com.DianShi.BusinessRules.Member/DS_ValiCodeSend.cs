using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Member;
using DBUtility;
namespace Com.DianShi.BusinessRules.Member
{
    public class DS_ValiCodeSend_Br:BllBase
    {
        public void Add(DS_ValiCodeSend ValiCodeSend)
        {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ValiCodeSend.InsertOnSubmit(ValiCodeSend);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_ValiCodeSend ValiCodeSend)
        {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ValiCodeSend.Attach(ValiCodeSend, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
            {
                DS_ValiCodeSend st = ct.DS_ValiCodeSend.Single(a => a.ID == ID);
                ct.DS_ValiCodeSend.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public DS_ValiCodeSend GetSingle(int ID)
        {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_ValiCodeSend.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_ValiCodeSend> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
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
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
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

        /// <summary>
        /// 判断当天发送手机验证码是否超过了三次
        /// </summary>
        /// <param name="MemberID">会员ID</param>
        /// <returns></returns>
        public bool SendEnable(int MemberID) {
            using (var ct = new DS_ValiCodeSendDataContext(DbHelperSQL.Connection))
            {
                var md=ct.DS_ValiCodeSend.SingleOrDefault(a=>a.MemberID.Equals(MemberID));
                if (!object.Equals(md, null))
                {
                    bool b=md.LastTime.ToShortDateString().Equals(DateTime.Now.ToShortDateString());
                    md.LastTime = DateTime.Now;
                    if (b)
                    {
                        if (md.Frequency > 2)
                            return false;
                        else
                        {
                            md.Frequency++;
                            Update(md);
                            return true;
                        }
                    }
                    else {
                        md.Frequency = 1;
                        Update(md);
                        return true;
                    }
                }
                else {
                    md = CreateModel();
                    md.MemberID = MemberID;
                    md.LastTime = DateTime.Now;
                    md.Frequency = 1;
                    Add(md);
                    return true;
                }
            }
        }
    }
}
