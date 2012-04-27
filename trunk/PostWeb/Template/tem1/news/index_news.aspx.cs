using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Com.DianShi.BusinessRules.News;
public partial class Template_tem1_news_index_news : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_ComNews_Br();
        string act = Request["action"];
        if (!string.IsNullOrEmpty(act))
        {
            switch (act)
            {
                case "pager":
                    int pageIndex = int.Parse(Request.Form["pageIndex"]), pageSize = int.Parse(Request.Form["pageSize"]), rc = 0;
                    Repeater1.DataSource = bl.Query("memberid=@0 and parentid=0", "px", (pageIndex - 1) * pageSize, pageSize, ref rc,_vMember.ID);
                    Repeater1.DataBind();
                    ViewState["rc"] = rc;
                    
                    break;
                case "del":
                    bl.Delete(int.Parse(Request.Form["id"]));
                    break;
            }
            return;
        }
    }
}
