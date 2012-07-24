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
        var od = context.Session["UserData"] as UserData;
        if (od == null || od.Member == null)
        {
            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, lgout = true, msg = "抱歉，操作超时，需重新登录。" }));
            return;
        }

        //ajax事件
        string act = context.Request["myaction"];
        if (!string.IsNullOrEmpty(act))
        {
            var bl = new DS_Certificate_Br();
            switch (act)
            {
                case "addctf":
                    try
                    {
                        var mbbl = new DS_Members_Br();
                        string tempPath = "/Resource/" + DS_Members_Br.GetMemberDir(od.Member.ID) + "/Certificate/";
                        HttpPostedFile file = context.Request.Files[0];
                        string ext = Path.GetExtension(file.FileName).ToLower();
                        if (ext != ".jpg" && ext != ".gif")
                        {
                            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg = "请您上传jpg、gif、png图片" }));
                        }
                        else if (file.ContentLength > 1024 * 1024)
                        {
                            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg = "请您上传1M(1024KB)内的图片" }));
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
                            
                            //保存数据
                            var md = bl.CreateModel();
                            md.CtfImg = newName + ext;
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
                            bl.Add(md);
                            
                            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = true, fileName = newName + ext }));
                        }
                    }
                    catch (Exception ex) { context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg = ex.Message })); }
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