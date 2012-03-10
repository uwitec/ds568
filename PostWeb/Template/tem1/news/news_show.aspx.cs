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
public partial class Template_tem1_news_news_show : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            var bl=new DS_ComNews_Br();
            Repeater1.DataSource = bl.Query("id=@0","",int.Parse(Request.QueryString["news_id"]));
            Repeater1.DataBind();
        }
        catch {
            Response.End();
        }
    }
}
