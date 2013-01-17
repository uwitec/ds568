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

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="file">图片文件流</param>
        /// <param name="thumeid">主题ID</param>
        /// <param name="startTag">图片标识，用于区分对应主题的某一位置，如店招“sign_”、单图广告“adsigle_”等</param>
        /// <param name="imgname">图片名称，为空时则创建新文件，否则覆盖原有图片</param>
        /// <param name="filesize">文件大小限制,以KB为单位</param>
        /// <returns>返回MetheInfo对象</returns>
        private MethoInfo SaveImg(HttpPostedFile file,int thumeid,string startTag,string imgname,int filesize)
        {
            string themePath = ThemePath(thumeid);
            string ext = System.IO.Path.GetExtension(file.FileName).ToLower();
            if (!".jpg|.gif|.png".Contains(ext))
            {
                return new MethoInfo{ Succ = false, Msg = "请您上传jpg、gif、png图片" };
            }
            else if (file.ContentLength >1024*filesize)
            {
                return new MethoInfo{ Succ = false, Msg = "请您上传"+(filesize>1024?(Math.Round(filesize/1024.0,2).ToString()+"M"):filesize.ToString()+"KB")+"内的图片" };
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

        /// <summary>
        /// 保存店招
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object SignSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                    var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                    md.SignType = byte.Parse(request["signType"]);
                    md.SignBgColor = request["signBgColor"];
                    md.ComNameShow = bool.Parse(request["comNameShow"]);
                    md.ComNameCss = request["signStyle"];

                    if (request.Files.Count > 0 && request.Files[0].ContentLength > 0)
                    {
                        var rtobj = SaveImg(request.Files[0], md.ID, "sign_", md.SignImg,300);
                        if (rtobj.Succ)
                        {
                            md.SignImg = rtobj.ReturnValue;
                        }
                        else
                        {
                            return new { Succ = false, Msg = rtobj.Msg };
                        }
                    }
                    ct.SubmitChanges();
                    return new { Succ = true, imgUrl = ThemePath(md.ID) + md.SignImg, md.ID };
                //}
                //catch (Exception ex) { return new ApiRunInfo { Succ = false, Msg = ex.Message }; }
            }
        }

        /// <summary>
        /// 保存导航
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object NavSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                string navtype = request["navtype"];
                md.NavMargin = request["navmargin"];
                if (!string.IsNullOrEmpty(request["comfontName"]))
                {
                    string cssstr = Common.JSONHelper.ObjectToJSON(new { family = request["comfontName"], size = request["comfontSize"], weight = request["navfb"], style = request["navft"], color = request["navfc"] });
                    if (navtype == "NavBgSel")
                    {
                        md.NavSelCss = cssstr;
                    }
                    else if (navtype == "NavBgNormal")
                    {
                        md.NavNormalCss = cssstr;
                    }
                }
                var prt = md.GetType().GetProperty(navtype);
                if (request.Files.Count > 0 && request.Files[0].ContentLength > 0)
                {

                    var rtobj = SaveImg(request.Files[0], md.ID, navtype + "_", prt.GetValue(md, null) as string, 100);
                    if (rtobj.Succ)
                    {
                        prt.SetValue(md,rtobj.ReturnValue,null);
                    }
                    else
                    {
                        return new { Succ = false, Msg = rtobj.Msg };
                    }
                }
                ct.SubmitChanges();
                return new { Succ = true, imgUrl = ThemePath(md.ID) + prt.GetValue(md, null) as string, md.ID };
                //}
                //catch (Exception ex) { return new ApiRunInfo { Succ = false, Msg = ex.Message }; }
            }
        }

        /// <summary>
        /// 保存模块标题样式和背景图
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object MdTlSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                md.MdHeadCss = Common.JSONHelper.ObjectToJSON(new { fontFamily = request["mdfontName"], fontSize = request["mdfontSize"], fontWeight = request["mdtlfb"], fontStyle = request["mdtlft"], fontColor = request["mdtlfc"], borderColor = request["mdbdfc"], borderStyle = request["border"] });
                if (request.Files.Count > 0 && request.Files[0].ContentLength > 0)
                {
                    var rtobj = SaveImg(request.Files[0], md.ID, "mdhdbg_",md.MdHeadBg , 100);
                    if (rtobj.Succ)
                    {
                        md.MdHeadBg = rtobj.ReturnValue;
                    }
                    else
                    {
                        return new { Succ = false, Msg = rtobj.Msg };
                    }
                }
                ct.SubmitChanges();
                return new { Succ = true, imgUrl = ThemePath(md.ID) + md.MdHeadBg, md.ID };
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
                    var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                    var list=new List<object>();
                    list.Add(new { title = request["adsigletxt1"], fontWeight = request["fb1"], fontType = request["ft1"], fontColor = request["fc1"] });
                    list.Add(new { title = request["adsigletxt2"], fontWeight = request["fb2"], fontType = request["ft2"], fontColor = request["fc2"] });
                    list.Add(new { title = request["adsigletxt3"], fontWeight = request["fb3"], fontType = request["ft3"], fontColor = request["fc3"] });
                    md.AdSigleTxt = Common.JSONHelper.ObjectToJSON(list); ;//以json字符串的型形保存，方便前端用js获取显示。
                    if (request.Files.Count > 0 && request.Files[0].ContentLength>0)
                    {
                        var rtobj=SaveImg(request.Files[0],md.ID,"adsigle_",md.AdSigleImg,300);
                        if (rtobj.Succ)
                        {
                            md.AdSigleImg = rtobj.ReturnValue;
                        }
                        else {
                            return new { Succ = false, Msg =rtobj.Msg };
                        }
                    }
                    ct.SubmitChanges();
                    return new { Succ = true, imgUrl = ThemePath(md.ID) + md.AdSigleImg, md.ID };
                //}
                //catch (Exception ex) { return new { Succ = false, Msg = ex.Message }; }
            }
        }

        /// <summary>
        /// 保存多图广告
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object AdMutiSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{
                var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                var list = new List<object>();
                list.Add(new { title = request["admutitext1"], fontWeight = request["admtfb1"], fontType = request["admtft1"], fontColor = request["admtfc1"] });
                list.Add(new { title = request["admutitext2"], fontWeight = request["admtfb2"], fontType = request["admtft2"], fontColor = request["admtfc2"] });
                list.Add(new { title = request["admutitext3"], fontWeight = request["admtfb3"], fontType = request["admtft3"], fontColor = request["admtfc3"] });
                string jsonstr = Common.JSONHelper.ObjectToJSON(list); ;//以json字符串的型形保存，方便前端用js获取显示。
                string itemind = request["admutiind"];
                var prttxt = md.GetType().GetProperty("AdMutiTxt"+itemind);
                prttxt.SetValue(md,jsonstr,null);
                var prtimg = md.GetType().GetProperty("AdMutiImg"+itemind);
                if (request.Files.Count > 0 && request.Files[0].ContentLength > 0)
                {
                    var rtobj = SaveImg(request.Files[0], md.ID, "admuti"+itemind+"_", prtimg.GetValue(md,null) as string, 300);
                    if (rtobj.Succ)
                    {
                        prtimg.SetValue(md,rtobj.ReturnValue,null);
                    }
                    else
                    {
                        return new { Succ = false, Msg = rtobj.Msg };
                    }
                }
                ct.SubmitChanges();
                return new { Succ = true, imgUrl = ThemePath(md.ID) + prtimg.GetValue(md, null) as string, md.ID };
                //}
                //catch (Exception ex) { return new { Succ = false, Msg = ex.Message }; }
            }
        }

        /// <summary>
        /// 保存内外背景
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object BgSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                var prt = md.GetType().GetProperty(request["fileid"]);
                if (request.Files.Count > 0 && request.Files[0].ContentLength > 0)
                {
                    var rtobj = SaveImg(request.Files[0], md.ID, request["fileid"]+"_", prt.GetValue(md,null) as string, 500);
                    if (rtobj.Succ)
                    {
                        prt.SetValue(md,rtobj.ReturnValue,null);
                    }
                    else
                    {
                        return new { Succ = false, Msg = rtobj.Msg };
                    }
                }
                ct.SubmitChanges();
                return new { Succ = true, imgUrl = ThemePath(md.ID) + prt.GetValue(md, null) as string, md.ID };
            }
        }



        /// <summary>
        /// 保存预览图
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Object ThumeSave(HttpRequest request)
        {
            using (var ct = new DS_ShopThemeDataContext(DbHelperSQL.Connection))
            {
                //try
                //{

                var md = ct.DS_ShopTheme.Single(a => a.ID.Equals(int.Parse(request["id"])));
                if (request.Files.Count > 0 && request.Files[0].ContentLength > 0)
                {
                    var rtobj = SaveImg(request.Files[0], md.ID, "thume_", md.Thume,200);
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
                return new { Succ = true, imgUrl = ThemePath(md.ID) + md.Thume, md.ID };
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
