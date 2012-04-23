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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new DS_Products_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["pro_id"]));
        ViewState["title"] = md.Title;
        Page.Header.Title = md.Title;
        ViewState["img1"] = md.Img1;
        ViewState["img2"] = md.Img2;
        ViewState["img3"] = md.Img3;
        ViewState["priceRang"] = md.PriceRang;
        ViewState["unit"] = md.Unit;
        Property1.Product=md;
        ViewState["Detail"] = md.Detail;

        var list = bl.Query("ShopCatID=@0","",md.ShopCatID);
        Repeater1.DataSource = list;
        Repeater1.DataBind();

        var catbl = new DS_SysProductCategory_Br();
        ViewState["category"] = catbl.GetCategoryName(md.SysCatID,false).TrimEnd('>').Replace(">"," > ");

        //联系信息
        var mblist = new System.Collections.Generic.List<Com.DianShi.Model.Member.View_Members>();
        mblist.Add(_vMember);
        Repeater2.DataSource = mblist;
        Repeater2.DataBind();

    }
}
