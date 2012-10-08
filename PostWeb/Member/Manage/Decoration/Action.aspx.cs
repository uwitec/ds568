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
                    var shopcf = wcfbl.GetSingle(_userData.Member.ID,false);
                    shopcf.SignImg =DS_ShopTheme_Br.ThemePath(the.ID)+ the.SignImg;
                    shopcf.SignBgColor = the.SignBgColor;
                    shopcf.ComNameCss = the.ComNameCss;
                    shopcf.ComNameShow = the.ComNameShow;
                    shopcf.SignType = the.SignType;
                    wcfbl.Update(shopcf);
                    Response.Write(Common.JSONHelper.ObjectToJSON(new {succ=true }));
                    break;
            }
        }
    }
}
