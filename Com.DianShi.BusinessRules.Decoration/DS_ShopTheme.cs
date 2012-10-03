using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using Com.DianShi.Model.ShopConfig;
using DBUtility;
using System.Web;
using System.IO;
namespace Com.DianShi.BusinessRules.ShopConfig
{
    public class DS_ShopTheme_Br:BllBase
    {
        public void Add(DS_ShopTheme ShopTheme)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopTheme.InsertOnSubmit(ShopTheme);
                ct.SubmitChanges();
            }
        }


        public Object SignSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                    string themePath = "";
                    string id = request["id"];
                    bool isEdit = !string.IsNullOrEmpty(id);
                    var md = CreateModel();
                    if (isEdit)
                    {
                        md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(id)));
                        themePath = ThemePath(md.ID);
                    }
                    else
                    {
                        var indent = ct.ExecuteQuery<decimal>("select IDENT_CURRENT('DS_ShopTheme')+1");
                        themePath = ThemePath(int.Parse(indent.Single().ToString()));
                    }
                    md.ThemeName = request["themeName"];
                    md.SignType = byte.Parse(request["signType"]);
                    md.SignBgColor = request["signBgColor"];
                    md.ComNameShow = bool.Parse(request["comNameShow"]);
                    md.ComNameCss = request["signStyle"];
                    if (request.Files[0].ContentLength > 0)
                    {
                        HttpPostedFile file = request.Files[0];
                        string ext = System.IO.Path.GetExtension(file.FileName).ToLower();
                        if (ext != ".jpg" && ext != ".gif")
                        {
                            return new { Succ = false, Msg = "请您上传jpg、gif、png图片" };

                        }
                        else if (file.ContentLength > 1024 * 300)
                        {
                            return new { Succ = false, Msg = "请您上传1M(1024KB)内的图片" };
                        }
                        else
                        {
                            if (isEdit)
                            {
                                var files = Directory.GetFiles(HttpContext.Current.Server.MapPath(themePath), "sign_*");
                                foreach (var imgpath in files)
                                    File.Delete(imgpath);
                            }

                            if(string.IsNullOrEmpty(md.SignImg))
                            {
                                string newName = Guid.NewGuid().ToString();
                                md.SignImg = "sign_" + newName + ext;
                            }

                            string img = themePath + md.SignImg;
                            string filePath = HttpContext.Current.Server.MapPath(img);
                            themePath = HttpContext.Current.Server.MapPath(themePath);
                            if (!Directory.Exists(themePath))
                            {
                                Directory.CreateDirectory(themePath);
                            }
                            file.SaveAs(filePath);//保存图
                        }
                    }

                    if (!isEdit)
                    {
                        ct.DS_ShopTheme.InsertOnSubmit(md);
                    }
                    ct.SubmitChanges();
                    return new { Succ = true,md.SignImg };
                //}
                //catch (Exception ex) { return new ApiRunInfo { Succ = false, Msg = ex.Message }; }
            }
        }

        public Object ThumeSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                    string themePath = Common.Constant.WebConfig("ThemeRootPath") + "the";
                    string id = request["id"];
                    bool isEdit = !string.IsNullOrEmpty(id);
                    var md = CreateModel();
                    if (isEdit)
                    {
                        md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(id)));
                        themePath = ThemePath(md.ID);
                    }
                    else
                    {
                        var indent = ct.ExecuteQuery<decimal>("select IDENT_CURRENT('DS_ShopTheme')+1");
                        themePath = ThemePath(int.Parse(indent.Single().ToString()));
                    }
                    md.ThemeName = request["themeName"];
                 
                    if (request.Files[0].ContentLength > 0)
                    {
                        HttpPostedFile file = request.Files[0];
                        string ext = System.IO.Path.GetExtension(file.FileName).ToLower();
                        if (ext != ".jpg" && ext != ".gif")
                        {
                            return new { Succ = false, Msg = "请您上传jpg、gif、png图片" };

                        }
                        else if (file.ContentLength > 1024 * 300)
                        {
                            return new { Succ = false, Msg = "请您上传1M(1024KB)内的图片" };
                        }
                        else
                        {
                            themePath = HttpContext.Current.Server.MapPath(themePath);
                            if (!Directory.Exists(themePath))
                            {
                                Directory.CreateDirectory(themePath);
                            }
                            if (isEdit)
                            {
                                var files = Directory.GetFiles(themePath, "thume_*");
                                foreach (var imgpath in files)
                                    File.Delete(imgpath);
                            }

                            if(string.IsNullOrEmpty(md.Thume))
                            {
                                string newName = Guid.NewGuid().ToString();
                                md.Thume = "thume_" + newName + ext;
                            }

                            string img = themePath + md.Thume;
                           
                            file.SaveAs(img);//保存图
                        }
                    }

                    if (!isEdit)
                    {
                        ct.DS_ShopTheme.InsertOnSubmit(md);
                    }
                    ct.SubmitChanges();
                    return new { Succ = true,md.Thume };
                //}
                //catch (Exception ex) { return new { Succ = false, Msg = ex.Message }; }
            }
        }

        public void Update(DS_ShopTheme ShopTheme)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopTheme.Attach(ShopTheme, true);
                ct.SubmitChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                DS_ShopTheme st = ct.DS_ShopTheme.Single(a => a.ID == ID);
                ct.DS_ShopTheme.DeleteOnSubmit(st);
                ct.SubmitChanges();
            }
        }

        public void Delete(string Ids)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                string[] idarray = Ids.Split(',');
                var list = ct.DS_ShopTheme.Where(a => idarray.Contains(a.ID.ToString()));
                ct.DS_ShopTheme.DeleteAllOnSubmit(list);
                ct.SubmitChanges();
            }
        }

       

        public DS_ShopTheme GetSingle(int ID)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                return ct.DS_ShopTheme.Single(a => a.ID == ID);
            }
        }

       
        public List<T> Query<T>(string sql, params object[] parameterValues)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                return ct.ExecuteQuery<T>(sql, parameterValues).ToList();
            }
        }

        public List<DS_ShopTheme> Query(string condition, string orderby, int startIndex, int pageSize, ref int pageCount, params object[] param)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ShopTheme> ShopThemeList = ct.DS_ShopTheme;
                if (!string.IsNullOrEmpty(condition))
                    ShopThemeList = ShopThemeList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ShopThemeList = ShopThemeList.OrderBy(orderby);
                pageCount = ShopThemeList.Count();
                return ShopThemeList.Skip(startIndex).Take(pageSize).ToList();
            }
        }

        public List<DS_ShopTheme> Query(string condition, string orderby, params object[] param)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                IQueryable<DS_ShopTheme> ShopThemeList = ct.DS_ShopTheme;
                if (!string.IsNullOrEmpty(condition))
                    ShopThemeList = ShopThemeList.Where(condition, param);
                if (!string.IsNullOrEmpty(orderby))
                    ShopThemeList = ShopThemeList.OrderBy(orderby);
                return ShopThemeList.ToList();
            }
        }

        public  DS_ShopTheme CreateModel() {
            return new DS_ShopTheme();
        }

        public enum SignType : byte { 
            背景图,
            背景色
        }

        /// <summary>
        /// 返回主题文件夹路径
        /// </summary>
        /// <param name="ID">主题ID</param>
        /// <returns></returns>
        public static string ThemePath(int ID) {
            return Common.Constant.WebConfig("ThemeRootPath") + "the" + ID.ToString().PadLeft(3, '0')+"/";
        }
    }
}
