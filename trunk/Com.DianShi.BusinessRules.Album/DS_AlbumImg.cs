using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq.Dynamic;
using Com.DianShi.Model.Album;
using DBUtility;
using System.IO;
namespace Com.DianShi.BusinessRules.Album
{
    public class DS_AlbumImg_Br : BllBase
    {
        public void Add(DS_AlbumImg AlbumImg)
        {
            using (var con = DbHelperSQL.Connection) {
                var tran = con.BeginTransaction();
                var ct = new DS_AlbumImgDataContext(con);
                ct.Transaction=tran;
                ct.DS_AlbumImg.InsertOnSubmit(AlbumImg);
                ct.SubmitChanges();

                var ct2 = new DS_AlbumDataContext(con);
                ct2.Transaction = tran;
                var album=ct2.DS_Album.Single(a=>a.ID==AlbumImg.AlbumID);
                album.PictureNum = ct.DS_AlbumImg.Where(a => a.AlbumID == AlbumImg.AlbumID).Count();
                ct2.SubmitChanges();

                tran.Commit();
            }
           
        }

        public void Update(DS_AlbumImg AlbumImg)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                ct.DS_AlbumImg.Attach(AlbumImg, true);
                ct.SubmitChanges();
            }
        }

        public void Update(DS_AlbumImg AlbumImg, bool FrontCover)
        {
            using (var con = DbHelperSQL.Connection)
            {
                var tran = con.BeginTransaction();

                var ct = new DS_AlbumImgDataContext(con);
                ct.Transaction = tran;
                ct.DS_AlbumImg.Attach(AlbumImg, true);
                ct.SubmitChanges();

                var ct2 = new DS_AlbumDataContext(con);
                ct2.Transaction = tran;
                var album = ct2.DS_Album.Single(a=>a.ID==AlbumImg.AlbumID);
                album.UpdateDate = DateTime.Now;
                if (FrontCover) {
                    album.FrontCover = "/Resource/" + AlbumImg.ImgUrl + "/" + AlbumImg.ImgName;
                }
                ct2.SubmitChanges();

                tran.Commit();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                var st = ct.DS_AlbumImg.Single(a => a.ID == ID);
                ct.DS_AlbumImg.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var con = DbHelperSQL.Connection)
            {
                var tran = con.BeginTransaction();
                var ct = new DS_AlbumImgDataContext(con);
                ct.Transaction = tran;
                string[] idarray = Ids.Split(',');
                var list = ct.DS_AlbumImg.Where(a => idarray.Contains(a.ID.ToString()));
                var list2 = list.ToList();
                ct.DS_AlbumImg.DeleteAllOnSubmit(list);
                ct.SubmitChanges();

                var ct2 = new DS_AlbumDataContext(con);
                ct2.Transaction = tran;
                var album = ct2.DS_Album.Single(a => a.ID == list2.First().AlbumID);
                album.PictureNum = ct.DS_AlbumImg.Where(a => a.AlbumID == list2.First().AlbumID).Count();
                ct2.SubmitChanges();

                foreach (var item in list2)
                {
                    string p = System.Web.HttpContext.Current.Server.MapPath(Common.Constant.WebConfig("AlbumRootPath") + item.ImgUrl + "/" + item.ImgName);
                    if (File.Exists(p))
                    {
                        File.Delete(p);
                    }
                }

                tran.Commit();
            }
          
        }

        public DS_AlbumImg GetSingle(int ID)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_AlbumImg.Single(a => a.ID == ID);
            }
        }

        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_AlbumImg> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_AlbumImg> AlbumImgList = ct.DS_AlbumImg;
                if (!string.IsNullOrEmpty(condition))
                    AlbumImgList = AlbumImgList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    AlbumImgList = AlbumImgList.OrderBy(orderby);
                pageCount = AlbumImgList.Count();
                return AlbumImgList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_AlbumImg> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_AlbumImg> AlbumImgList = ct.DS_AlbumImg;
                if (!string.IsNullOrEmpty(condition))
                    AlbumImgList = AlbumImgList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    AlbumImgList = AlbumImgList.OrderBy(orderby);
                return AlbumImgList.ToList();
            }
        }

        public Com.DianShi.Model.Album.DS_AlbumImg CreateModel()
        {
            return new Com.DianShi.Model.Album.DS_AlbumImg();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsUp"></param>
        public void Sort(int ID, bool IsUp)
        {
            using (var ct = new DS_AlbumImgDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_AlbumImg.Single(a => a.ID == ID);
                ct.ExecuteCommand("update DS_AlbumImg  set px=(select RowNumber from (select (ROW_NUMBER() OVER (ORDER BY px)) AS RowNumber,id from DS_AlbumImg where  AlbumID={0}) as p2 where id=DS_AlbumImg.AlbumID) where memberid={0}", md.AlbumID);
                if (IsUp)
                {
                    DS_AlbumImg p = ct.DS_AlbumImg.Single(a => a.ID == ID);
                    DS_AlbumImg p1;
                    if (p.Px > 1)
                    {
                        p1 = ct.DS_AlbumImg.Single(a => a.Px == (p.Px - 1) && a.AlbumID == md.AlbumID);
                        p.Px--;
                        p1.Px++;
                    }

                }
                else
                {
                    DS_AlbumImg p = ct.DS_AlbumImg.Single(a => a.ID == ID);
                    DS_AlbumImg p1;
                    if (p.Px < ct.DS_AlbumImg.Where(a => a.AlbumID == md.AlbumID).Count())
                    {
                        p1 = ct.DS_AlbumImg.Single(a => a.Px == (p.Px + 1) && a.AlbumID == md.AlbumID);
                        p.Px++;
                        p1.Px--;
                    }
                }
                ct.SubmitChanges();
            }
        }

      

    }
}
