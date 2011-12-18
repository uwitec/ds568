using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Album;
namespace Com.DianShi.BusinessRules.Album
{
    public class DS_Album_Br : DBUtility.BllBase
    {
        public void Add(DS_Album Album)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                ct.DS_Album.InsertOnSubmit(Album);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_Album Album)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                ct.DS_Album.Attach(Album, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                var st = ct.DS_Album.Single(a => a.ID == ID);
                ct.DS_Album.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_Album.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_Album.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

        public DS_Album GetSingle(int ID)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                return ct.DS_Album.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_Album> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                IQueryable<DS_Album> AlbumList = ct.DS_Album;
                if (!string.IsNullOrEmpty(condition))
                    AlbumList = AlbumList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    AlbumList = AlbumList.OrderBy(orderby);
                pageCount = AlbumList.Count();
                return AlbumList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_Album> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                IQueryable<DS_Album> AlbumList = ct.DS_Album;
                if (!string.IsNullOrEmpty(condition))
                    AlbumList = AlbumList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    AlbumList = AlbumList.OrderBy(orderby);
                return AlbumList.ToList();
            }
        }

        public Com.DianShi.Model.Album.DS_Album CreateModel()
        {
            return new Com.DianShi.Model.Album.DS_Album();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (var ct = new DS_AlbumDataContext())
            {
                var md = ct.DS_Album.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_Album  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_Album where  memberid={0}) as p2 where id=DS_Album.id) where memberid={0}", md.MemberID);
                if (IsUp)
                {
                    DS_Album p = ct.DS_Album.Single(a => a.ID == ID);
                    DS_Album p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_Album.Single(a => a.Px == (p.Px - 1) && a.MemberID == md.MemberID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_Album p = ct.DS_Album.Single(a => a.ID == ID);
                    DS_Album p1;
                    if (p.Px < ct.DS_Album.Where(a => a.MemberID == md.MemberID).Count())
                    {
                        p1 = ct.DS_Album.Single(a => a.Px == (p.Px + 1) && a.MemberID == md.MemberID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }

        public string GetDirByID(int MemberID, int AlbumID) {
            int md = MemberID / 5001+1;
            return "S" + md.ToString().PadLeft(3, '0')+"/U"+MemberID+"/Album/A"+AlbumID;

        }

    }
}
