using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.ShopConfig;
public partial class Member_Manage_Decoration_Action : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            var thebl = new DS_ShopTheme_Br();
            var wcfbl = new DS_ShopConfig_Br(); ;
            switch (act) { 
                case "viewThe":
                    var the = thebl.GetSingle(int.Parse(Request["id"]));
                    the.SignImg = DS_ShopTheme_Br.ThemePath(the.ID) + the.SignImg;
                    Response.Write(Common.JSONHelper.ObjectToJSON(the));
                    break;
                case "theSave":
                    the = thebl.GetSingle(int.Parse(Request["theid"]));
                    var shopcf = DS_ShopConfig_Br.GetSingle(_userData.Member.ID, false);
                    if (shopcf == null)
                        shopcf = wcfbl.CreateModel();
                    string thepath=DS_ShopTheme_Br.ThemePath(the.ID);
                    var ty = shopcf.GetType();
                    var prts = the.GetType().GetProperties();
                    foreach (var prt in prts)
                    {
                        if (prt.Name == "ID") continue ;
                        var theitem=prt.GetValue(the, null);
                        if (theitem != null)
                        {
                            var spprt = ty.GetProperty(prt.Name);
                            if (spprt != null) {
                                if (theitem.GetType() == typeof(string))
                                {
                                    string img = (theitem as string).ToLower();
                                    if (img.EndsWith(".jpg") || img.EndsWith(".png") || img.EndsWith(".gif"))
                                    {
                                        spprt.SetValue(shopcf, thepath + theitem, null);
                                        continue;
                                    }
                                }
                               
                                spprt.SetValue(shopcf, theitem, null);
                            }
                        }
                    }

                    //shopcf.SignImg =DS_ShopTheme_Br.ThemePath(the.ID)+ the.SignImg;
                    //shopcf.SignBgColor = the.SignBgColor;
                    //shopcf.ComNameCss = the.ComNameCss;
                    //shopcf.ComNameShow = the.ComNameShow;
                    //shopcf.SignType = the.SignType;
                    if (shopcf.ID == 0)
                    {
                        shopcf.MemberID = _userData.Member.ID;
                        wcfbl.Add(shopcf);
                    }
                    else
                        wcfbl.Update(shopcf);
                    Response.Write(Common.JSONHelper.ObjectToJSON(new {succ=true }));
                    break;
            }
        }
    }
}
