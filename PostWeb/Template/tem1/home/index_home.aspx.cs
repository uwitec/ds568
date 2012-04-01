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
using Com.DianShi.BusinessRules.Member;
using Com.DianShi.BusinessRules.Product;
public partial class index_home :  ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.Title = "商铺首页,"+_vMember.CompanyName;
        if (IsPostBack) return;

        var pbl = new DS_Products_Br();
        //最新产品
        int rc = 0;
        var list = pbl.Query("memberid=@0", "createdate desc", 0, 8, ref rc, _vMember.ID);
        Repeater1.DataSource = list;
        Repeater1.DataBind();

        //精品推荐
        Repeater2.DataSource = list.Take(4);
        Repeater2.DataBind();

        //联系我们
        
        var list2 = new System.Collections.Generic.List<Com.DianShi.Model.Member.View_Members>();
        list2.Add(_vMember);
        Repeater3.DataSource = list2;
        Repeater3.DataBind();
      
        
    }
}

