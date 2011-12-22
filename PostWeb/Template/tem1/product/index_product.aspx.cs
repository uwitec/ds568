using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Com.DianShi.BusinessRules.Product;
public partial class index_product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AspNetPager4.PageChanged+=new EventHandler(AspNetPager4_PageChanged);
        if (IsPostBack) return;
        //分类
        var bl = new DS_DiyProCategory_Br();
        var list = bl.Query<temClass>("select id,categoryname,(select count(id) from ds_products where shopcatid=ds_DiyProCategory.id) as pcount from ds_DiyProCategory where memberid={0}",int.Parse(Request.QueryString["member_id"]));
        Repeater1.DataSource = list;
        Repeater1.DataBind();

        //产品
        BindDate("memberid=@0",int.Parse(Request.QueryString["member_id"]));
    }

    private void AspNetPager4_PageChanged(object ob, object ob1)
    {
        BindDate(ViewState["sql"].ToString(), (object[])ViewState["param"]);
    }

    private void BindDate(string sql, params object[] param)
    {
        ViewState["sql"] = sql;
        ViewState["param"] = param;
        int pageCount = 0;
        var bl = new DS_Products_Br();
        var list = bl.Query(sql, "createdate desc", (AspNetPager4.CurrentPageIndex - 1) *AspNetPager4.PageSize, AspNetPager4.PageSize, ref pageCount, param);
        AspNetPager4.RecordCount = pageCount;
        AspNetPager4.TextBeforePageIndexBox = "共" + AspNetPager4.PageCount + "页/"+AspNetPager4.RecordCount+"条 到";
        Repeater2.DataSource = list;
        Repeater2.DataBind();
    } 


    class temClass {
        public string categoryname { get; set; }
        public int pcount { get; set; }
        public int id { get; set; }
    }
}
 