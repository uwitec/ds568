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
using Com.DianShi.BusinessRules.Member;
public partial class index_product : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.Title = "供应产品";
        AspNetPager4.PageChanged+=new EventHandler(AspNetPager4_PageChanged);
        if (IsPostBack) return;
        
        //分类
        var bl = new DS_DiyProCategory_Br();
        var list = bl.Query<temClass>("select id,categoryname,(select count(id) from ds_products where shopcatid=ds_DiyProCategory.id) as pcount from ds_DiyProCategory where memberid={0}", _vMember.ID);
        Repeater1.DataSource = list;
        Repeater1.DataBind();

        //产品
        string cat_id=Request.QueryString["cat_id"],proname=Request.QueryString["pro_name"],low_price=Request.QueryString["low_price"],height_price=Request.QueryString["height_price"];
        if (!string.IsNullOrEmpty(cat_id))
        {
            BindDate("ShopCatID=@0", int.Parse(cat_id));
        }
        else if (!string.IsNullOrEmpty(proname) || !string.IsNullOrEmpty(low_price) || !string.IsNullOrEmpty(height_price))
        {
            object[] param = { _vMember.ID, 0.0, 0.0, "" };
            string sql = "memberid=@0";
            if (!string.IsNullOrEmpty(low_price)) {
                sql = " and lowprice>@1";
                param[1] = double.Parse(low_price) - 0.01;
            }
            if (!string.IsNullOrEmpty(height_price))
            {
                sql = " and heightprice<@2";
                param[2] = double.Parse(height_price) + 0.01;
            }
            if (!string.IsNullOrEmpty(proname)) {
                sql = " and Title.Contains(@3)";
                param[3] = proname;
            }
            sql = sql.Trim().TrimStart('a','n','d');
            BindDate(sql,param);
        }
        else {
            BindDate("memberid=@0", _vMember.ID);
        }
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
 