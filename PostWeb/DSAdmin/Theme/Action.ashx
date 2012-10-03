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
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.SignSave(context.Request)));
                    break;
                case "thumeSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.ThumeSave(context.Request)));
                    break;
                case "getmd":
                    var the=bl.GetSingle(int.Parse(context.Request["id"]));
                    string thepath = DS_ShopTheme_Br.ThemePath(the.ID);
                    the.SignImg = thepath + the.SignImg;
                    the.Thume = thepath + the.Thume;
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