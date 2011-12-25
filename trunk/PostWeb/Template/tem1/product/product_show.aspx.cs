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
[PartialCaching(1800, "pro_id", null, null)]
public partial class Template_tem1_product_product_show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new DS_Products_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["pro_id"]));
        ViewState["title"] = md.Title;
        ViewState["img1"] = md.Img1;
        ViewState["img2"] = md.Img2;
        ViewState["img3"] = md.Img3;
        ViewState["priceRang"] = md.PriceRang;
        ViewState["unit"] = md.Unit;
        Property1.Product=md;
        ViewState["Detail"] = md.Detail;

    }
}
