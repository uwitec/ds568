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
using Com.DianShi.BusinessRules.Product;
using Com.DianShi.BusinessRules.Member;
public partial class Template_tem1_product_product_show :ShopBasePage
{
    public Com.DianShi.Model.Product.DS_Products product;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new DS_Products_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["pro_id"]));
        Property1.Product=md;
        var list = bl.Query("ShopCatID=@0","",md.ShopCatID);
        Repeater1.DataSource = list;
        Repeater1.DataBind();

        var catbl = new DS_SysProductCategory_Br();
        ViewState["category"] = catbl.GetCategoryName(md.SysCatID,false).TrimEnd('>').Replace(">"," > ");

    }
}
