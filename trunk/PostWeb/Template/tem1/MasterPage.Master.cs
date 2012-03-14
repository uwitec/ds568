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
using Com.DianShi.BusinessRules.Decoration;
//[PartialCaching(1800,null,null,null)]
public partial class MasterPage : System.Web.UI.MasterPage
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        var vmbbl = new View_Members_Br();
        var md = vmbbl.GetSingle(Request.Url);

        var bl = new DS_DiyProCategory_Br();
        int rc = 0;
        Repeater1.DataSource = bl.Query("memberid=@0","px",0,10,ref rc,md.ID);
        Repeater1.DataBind();

        var dcbl = new DS_Decoration_Br();
        var dcrt = dcbl.GetSingle(md.ID,true);
        if (dcrt != null) {
            ViewState["Sign"] = dcrt.Sign;
            ViewState["MenuBg"] = dcrt.MenuBg;
            ViewState["SelectedMenu"] = dcrt.SelectedMenu;
            ViewState["NormalMenu"] = dcrt.NormalMenu;
            ViewState["NmColor"] = dcrt.NmColor;
            ViewState["SelmColor"] = dcrt.SelmColor;
        }

        //联系信息
        var list = new System.Collections.Generic.List<Com.DianShi.Model.Member.View_Members>();
        list.Add(md);
        Repeater2.DataSource = list;
        Repeater2.DataBind();
        ViewState["comName"] = md.CompanyName;
        ViewState["address"]=md.BusinessAddress;
        ViewState["TrueName"] = md.TrueName;
        ViewState["Gender"] = md.Gender;
        ViewState["bsmd"] = md.BusinessModel;
        ViewState["area"] = md.Province;
        ViewState["member_id"] = md.ID;
    }

   

}

