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
public partial class Member_Manage_News_Edit :  BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司动态", "发布公司动态");
        
        var bl = new DS_ComNews_Br();
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            
            switch (act) { 
                case "edit":
                    var md = bl.GetSingle(int.Parse(Request.Form["id"]));
                    md.Title=Request.Form["title"];
                    md.Content = Request.Form["content"];
                    md.UpdateDate = DateTime.Now;
                    bl.Update(md);
                    break;
            }
        }

        if (IsPostBack) return;
        var news = bl.GetSingle(int.Parse(Request.QueryString["id"]));
        ViewState["title"] = news.Title;
        ViewState["content"] =Server.UrlDecode(news.Content);
    }
}
