using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.News;
using DBUtility;
namespace Com.DianShi.BusinessRules.News
{
    public class DS_ComNews_Br:BllBase
    {
        public void Add(DS_ComNews ComNews)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ComNews.InsertOnSubmit(ComNews);
                ct.SubmitChanges();
            }
        }

        public void Comment(DS_ComNews ComNews)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ComNews.InsertOnSubmit(ComNews);
                var md = ct.DS_ComNews.Single(a=>a.ID==ComNews.ParentID);
                md.Coment++;
                ct.SubmitChanges();
            }
        }

        public void Update(DS_ComNews ComNews)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ComNews.Attach(ComNews, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var con = DbHelperSQL.GetConnection()) {
                var tran = con.BeginTransaction();
                var ct = new DS_ComNewsDataContext(con);
                ct.Transaction = tran;
                var md = ct.DS_ComNews.Single(a => a.ID == ID);
                if (md.ParentID > 0)
                {
                    var parent = ct.DS_ComNews.Single(a => a.ID == md.ParentID);
                    parent.Coment--;
                }
                else {
                    var comlist = ct.DS_ComNews.Where(a=>a.ParentID==md.ID);
                    ct.DS_ComNews.DeleteAllOnSubmit(comlist);
                }
                ct.DS_ComNews.DeleteOnSubmit(md);
                ct.SubmitChanges();

                tran.Commit();
            }
            
        }

       

        public void Delete(string Ids)
        {
            using (var con = DbHelperSQL.GetConnection())
            {
                var tran = con.BeginTransaction();
                var ct = new DS_ComNewsDataContext(con);
                ct.Transaction = tran;
                string[] idarray = Ids.Split(',');
                var list = ct.DS_ComNews.Where(a => idarray.Contains(a.ID.ToString()));
                foreach (var md in list)
                {
                    if (md.ParentID > 0)
                    {
                        var parent = ct.DS_ComNews.Single(a => a.ID == md.ParentID);
                        parent.Coment--;
                    }
                    else
                    {
                        var comlist = ct.DS_ComNews.Where(a => a.ParentID == md.ID);
                        ct.DS_ComNews.DeleteAllOnSubmit(comlist);
                    }
                }
                ct.DS_ComNews.DeleteAllOnSubmit(list);
                ct.SubmitChanges();

                tran.Commit();
            }
        }

       

        public DS_ComNews GetSingle(int ID)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_ComNews.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_ComNews> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ComNews> ComNewsList = ct.DS_ComNews;
                if (!string.IsNullOrEmpty(condition))
                    ComNewsList = ComNewsList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ComNewsList = ComNewsList.OrderBy(orderby);
                pageCount = ComNewsList.Count();
                return ComNewsList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_ComNews> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ComNews> ComNewsList = ct.DS_ComNews;
                if (!string.IsNullOrEmpty(condition))
                    ComNewsList = ComNewsList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ComNewsList = ComNewsList.OrderBy(orderby);
                return ComNewsList.ToList();
            }
        }

        public Com.DianShi.Model.News.DS_ComNews CreateModel() {
            return new Com.DianShi.Model.News.DS_ComNews();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (var ct = new DS_ComNewsDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_ComNews.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_ComNews  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_ComNews where  MemberID={0}) as p2 where id=DS_ComNews.id) where MemberID={0}", md.MemberID);
                if (IsUp)
                {
                    DS_ComNews p = ct.DS_ComNews.Single(a => a.ID == ID);
                    DS_ComNews p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_ComNews.Single(a => a.Px == (p.Px - 1) && a.MemberID == md.MemberID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_ComNews p = ct.DS_ComNews.Single(a => a.ID == ID);
                    DS_ComNews p1;
                    if (p.Px < ct.DS_ComNews.Where(a => a.MemberID == md.MemberID).Count())
                    {
                        p1 = ct.DS_ComNews.Single(a => a.Px == (p.Px + 1) && a.MemberID == md.MemberID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }
    }
}
