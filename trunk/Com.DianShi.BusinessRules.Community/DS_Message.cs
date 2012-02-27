using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.Community;
using DBUtility;
namespace Com.DianShi.BusinessRules.Community
{
    public class DS_Message_Br:BllBase
    {
        
        public void Add(DS_Message Message)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Message.InsertOnSubmit(Message);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Message Message)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                ct.DS_Message.Attach(Message, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                DS_Message st = ct.DS_Message.Single(a => a.ID == ID);
                ct.DS_Message.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Message.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_Message.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_Message GetSingle(int ID)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_Message.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Message> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Message> MessageList = ct.DS_Message;
                if (!string.IsNullOrEmpty(condition))
                    MessageList = MessageList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    MessageList = MessageList.OrderBy(orderby);
                pageCount = MessageList.Count();
                return MessageList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Message> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_MessageDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_Message> MessageList = ct.DS_Message;
                if (!string.IsNullOrEmpty(condition))
                    MessageList = MessageList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    MessageList = MessageList.OrderBy(orderby);
                return MessageList.ToList();
            }
        }

        public Com.DianShi.Model.Community.DS_Message CreateModel() {
            return new Com.DianShi.Model.Community.DS_Message();
        }

        public enum MsgType : byte { 
            留言互动,
            系统消息
        }
    }
}
