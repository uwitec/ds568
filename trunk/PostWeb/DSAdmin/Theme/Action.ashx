<%@ WebHandler Language="C#" Class="Action" %>

using System;
using System.Web;
using Com.DianShi.BusinessRules.ShopConfig;
using System.IO;
using System.Web.SessionState;
public class Action : IHttpHandler, IRequiresSessionState
{
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //var ud = context.Session["UserData"] as UserData;
        //if (ud == null || ud.Member == null)
        //{
        //    context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, lgout = true, msg = "抱歉，操作超时，需重新登录。" }));
        //    return;
        //}

        //ajax事件
        string act = context.Request["myaction"];
        if (!string.IsNullOrEmpty(act))
        {
            var bl = new DS_ShopTheme_Br();
            switch (act)
            {
                case "signSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.Save(context.Request)));
                    break;
                case "getmd":
                    var ctf=bl.GetSingle(int.Parse(context.Request["id"]));
                    //ctf.CtfImg = tempPath + ctf.CtfImg;
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