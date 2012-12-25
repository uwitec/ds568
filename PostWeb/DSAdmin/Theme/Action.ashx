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
            var the = bl.CreateModel();
            switch (act)
            {
                case "signSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.SignSave(context.Request)));
                    break;
                case "thumeSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.ThumeSave(context.Request)));
                    break;
                case "getmd":
                    the=bl.GetSingle(int.Parse(context.Request["id"]));
                    string thepath = DS_ShopTheme_Br.ThemePath(the.ID);
                    the.SignImg = thepath + the.SignImg;
                    the.AdSigleImg = thepath + the.AdSigleImg;
                    the.Thume = thepath + the.Thume;
                    the.AdMutiImg1 = thepath + the.AdMutiImg1;
                    the.AdMutiImg2 = thepath + the.AdMutiImg2;
                    the.AdMutiImg3 = thepath + the.AdMutiImg3;
                    the.AdMutiImg4 = thepath + the.AdMutiImg4;
                    the.InnerBg = thepath + the.InnerBg;
                    the.OuterBg = thepath + the.OuterBg;
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(the));
                    break;
                case "del":
                    bl.Delete(int.Parse(context.Request["id"]));
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = true }));
                    break;
                case "adSigleSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.AdSigleSave(context.Request)));
                    break;
                case "adMutiSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.AdMutiSave(context.Request)));
                    break;
                case "bgSave":
                    context.Response.Write(Common.JSONHelper.ObjectToJSON(bl.BgSave(context.Request)));
                    break;  
                case "savethename":
                    try
                    {
                        bool isedit=!string.IsNullOrEmpty(context.Request["id"]);
                        if (isedit) {
                            the = bl.GetSingle(int.Parse(context.Request["id"]));
                        }
                        the.ThemeName = context.Request["thename"];
                        if (isedit)
                            bl.Update(the);
                        else
                            bl.Add(the);
                        context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = true, id = the.ID }));
                    }
                    catch (Exception ex) {
                        if (ex.Message.Contains("IX_DS_ShopTheme"))
                        {
                            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false,msg="已存在相同主题名称" }));
                        }
                        else {
                            context.Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false, msg=ex.Message }));
                        }
                    }
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