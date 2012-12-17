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

        private class MethoInfo { public bool Succ { get; set; } public string Msg { get; set; } public string ReturnValue { get; set; } }

        public void Add(DS_ShopTheme ShopTheme)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                ct.DS_ShopTheme.InsertOnSubmit(ShopTheme);
                ct.SubmitChanges();
            }
        }


        private MethoInfo SaveImg(HttpPostedFile file,int thumeid,string startTag,string imgname)
        {
            string themePath = ThemePath(thumeid);
            string ext = System.IO.Path.GetExtension(file.FileName).ToLower();
            if (!".jpg|.gif|.png".Contains(ext))
            {
                return new MethoInfo{ Succ = false, Msg = "请您上传jpg、gif、png图片" };
            }
            else if (file.ContentLength > 1024 * 300)
            {
                return new MethoInfo{ Succ = false, Msg = "请您上传1M(1024KB)内的图片" };
            }
            else
            {
                var files = Directory.GetFiles(HttpContext.Current.Server.MapPath(themePath), startTag+"*");
                foreach (var imgpath in files)
                    File.Delete(imgpath);

                if (string.IsNullOrEmpty(imgname))
                {
                    string newName = Guid.NewGuid().ToString();
                    imgname = startTag + newName + ext;
                }

                string img = themePath + imgname;
                string filePath = HttpContext.Current.Server.MapPath(img);
                themePath = HttpContext.Current.Server.MapPath(themePath);
                if (!Directory.Exists(themePath))
                {
                    Directory.CreateDirectory(themePath);
                }
                file.SaveAs(filePath);//保存图
            }

            return new MethoInfo{Succ=true,ReturnValue =imgname };
            
        }

        public Object SignSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                   
                    string id = request["id"];
                    var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(id)));
                   
                    md.SignType = byte.Parse(request["signType"]);
                    md.SignBgColor = request["signBgColor"];
                    md.ComNameShow = bool.Parse(request["comNameShow"]);
                    md.ComNameCss = request["signStyle"];

                    if (request.Files[0].ContentLength > 0)
                    {
                        var rtobj = SaveImg(request.Files[0], md.ID, "sign_", md.SignImg);
                        if (rtobj.Succ)
                        {
                            md.AdSigleImg = rtobj.ReturnValue;
                        }
                        else
                        {
                            return new { Succ = false, Msg = rtobj.Msg };
                        }

                    }
                 
                    ct.SubmitChanges();
                    return new { Succ = true,md.SignImg,md.ID };
                //}
                //catch (Exception ex) { return new ApiRunInfo { Succ = false, Msg = ex.Message }; }
            }
        }

        /// <summary>
        /// 保存单图广告
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object AdSigleSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                     
                    string id = request["id"];
                    var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(id)));
                    md.AdSigleTxt=request["adsigletxt"];
                    
                    if(request.Files[0].ContentLength > 0){
                        var rtobj=SaveImg(request.Files[0],md.ID,"adsigle_",md.AdSigleImg);
                        if (rtobj.Succ)
                        {
                            md.AdSigleImg = rtobj.ReturnValue;
                        }
                        else {
                            return new { Succ = false, Msg =rtobj.Msg };
                        }
                        
                    }

                    ct.SubmitChanges();
                    return new { Succ = true, md.AdSigleImg, md.ID };
                //}
                //catch (Exception ex) { return new { Succ = false, Msg = ex.Message }; }
            }
        }

        public Object ThumeSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                
                string id = request["id"];
                var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(id)));
                if (request.Files[0].ContentLength > 0)
                {
                    var rtobj = SaveImg(request.Files[0], md.ID, "thume_", md.Thume);
                    if (rtobj.Succ)
                    {
                        md.Thume = rtobj.ReturnValue;
                    }
                    else
                    {
                        return new { Succ = false, Msg = rtobj.Msg };
                    }

                }
                 
               
                ct.SubmitChanges();
                return new { Succ = true, md.Thume, md.ID };
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
                var path=HttpContext.Current.Server.MapPath(ThemePath(ID));
                if(Directory.Exists(path))
                    Directory.Delete(path,true);
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
