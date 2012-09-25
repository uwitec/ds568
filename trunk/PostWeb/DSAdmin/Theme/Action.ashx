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
                    var the=bl.GetSingle(int.Parse(context.Request["id"]));
                    the.SignImg = Common.Constant.WebConfig("ThemeRootPath")+"the"+the.ID.ToString().PadLeft(3,'0')+"/" + the.SignImg;
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(the));
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