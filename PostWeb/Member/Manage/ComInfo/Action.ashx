<%@ WebHandler Language="C#" Class="Action" %>

using System;
using System.Web;
using Com.DianShi.BusinessRules.Member;
using System.IO;
using System.Web.SessionState;
public class Action : IHttpHandler, IRequiresSessionState
{
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        var ud = context.Session["UserData"] as UserData;
        if (ud == null || ud.Member == null)
        {
            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, lgout = true, msg = "抱歉，操作超时，需重新登录。" }));
            return;
        }

        //ajax事件
        string act = context.Request["myaction"];
        if (!string.IsNullOrEmpty(act))
        {
            var bl = new DS_Certificate_Br();
            string tempPath = Common.Constant.WebConfig("AlbumRootPath") + DS_Members_Br.GetMemberDir(ud.Member.ID) + "/Certificate/";
            switch (act)
            {
                case "ctf":
                    try
                    {
                        var mbbl = new DS_Members_Br();
                        string id = context.Request["id"];
                        bool isEdit=!string.IsNullOrEmpty(id);
                        var md = bl.CreateModel();
                        if (isEdit) {
                            md = bl.GetSingle(int.Parse(id));
                        }
                        md.MemberID = ud.Member.ID;
                        md.CtfName = context.Request["ctfname"];
                        md.CtfNumber = context.Request["ctfnumber"];
                        md.CtfProfile = context.Request["ctfprofile"];
                        md.CtfType = byte.Parse(context.Request["ctftype"]);
                        if (!string.IsNullOrEmpty(context.Request["enddate"]))
                            md.EndDate = DateTime.Parse(context.Request["enddate"]);
                        md.IssPhone = context.Request["issphone"];
                        md.IssuingAgency = context.Request["issag"];
                        md.IssWebSite = context.Request["isswebsite"];
                        md.StartDate = DateTime.Parse(context.Request["startdate"]);
                        md.CtfState = (byte)DS_Certificate_Br.CtfState.审核中;
                        if (context.Request.Files[0].ContentLength > 0)
                        {
                            HttpPostedFile file = context.Request.Files[0];
                            string ext = Path.GetExtension(file.FileName).ToLower();
                            if (ext != ".jpg" && ext != ".gif")
                            {
                                context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg = "请您上传jpg、gif、png图片" }));
                                return;
                            }
                            else if (file.ContentLength > 1024 * 1024)
                            {
                                context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg = "请您上传1M(1024KB)内的图片" }));
                                return;
                            }
                            else
                            {
                                string newName = Guid.NewGuid().ToString();
                                string img = tempPath + newName + ext;
                                string filePath = context.Server.MapPath(img);
                                tempPath = context.Server.MapPath(tempPath);
                                if (!Directory.Exists(tempPath))
                                {
                                    Directory.CreateDirectory(tempPath);
                                }
                                file.SaveAs(filePath);//保存图

                                //如果是修改，则先删除原图片
                                if (isEdit) {
                                    //try
                                    //{
                                        File.Delete(tempPath+ md.CtfImg);
                                    //}
                                    //catch { }
                                }
                                md.CtfImg = newName + ext;
                            }
                        }
                        
                        if (isEdit)
                            bl.Update(md);
                        else
                        {
                            bl.Add(md);
                        }
                        context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = true}));
                    }
                    catch (Exception ex) { context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg = ex.Message })); }
                    break;
              
                case "getmd":
                    var ctf=bl.GetSingle(int.Parse(context.Request["id"]));
                    ctf.CtfImg = tempPath + ctf.CtfImg;
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(ctf));
                    break;
                case "del":
                    bl.Delete(int.Parse(context.Request["id"]));
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = true }));
                    break;
            
            }
        }
    }
    
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
    

}