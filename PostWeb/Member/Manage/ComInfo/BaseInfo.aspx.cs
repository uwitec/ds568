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
using Com.DianShi.BusinessRules.Member;
public partial class Member_Manage_CompanyInfo_BaseInfo : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "基本资料");

        //保存事件
        Button1.Click+=new EventHandler(Button1_Click);

        if (IsPostBack) return;
        var btbl = new DS_BusType_Br();
        Repeater1.DataSource = btbl.Query("","px");//企业类型
        Repeater1.DataBind();

        ViewState["yearest"] = "<option value=''>-请选择-</option>";
        for (int i = 1970; i <= 2012; i++)
        {
            ViewState["yearest"] = ViewState["yearest"].ToString() + "<option value='" + i + "'>" + i + "</option>";
        }
        var ud = _userData;
        var bl = new View_Members_Br();
        var md = bl.GetSingle(ud.Member.ID);
        bool b = false;
        ViewState["companyName"] = md.CompanyName;
        ViewState["BusType"] = md.BusinessType;
        ViewState["BusModel"] = md.BusinessModel;
        ViewState["RegCapital"] = md.RegisteredCapital;
        ViewState["CapitalType"] = md.CapitalType;
        ViewState["YearEst"] = md.YearEstablished;
        ViewState["regArea"] = md.RegistrationArea;
        ViewState["busArea"] = md.BusinessAddress;
        ViewState["companyAddress"] = md.Province;
        ViewState["ZipCode"] = md.ZipCode;
        ViewState["phone"] = md.Phone.TrimEnd('-');
        ViewState["mapNid"] = md.MapNid;
        if (!string.IsNullOrEmpty(md.OfferService)) {
            int i=0;
            foreach (string  s in md.OfferService.Split(','))
            {
                if (i > 4&&!string.IsNullOrEmpty(s)) {
                    ViewState["os"] = true;
                }
                ViewState["oserver" + i++] = s;
            }
        }
        if (!string.IsNullOrEmpty(md.BuyService))
        {
            int i = 0;
            foreach (string s in md.BuyService.Split(','))
            {
                if (i > 4 && !string.IsNullOrEmpty(s))
                {
                    ViewState["ob"] = true;
                }
                ViewState["buypro" + i++] = s;
            }
        }
        ViewState["buypro"] = md.BuyService;
        ViewState["MainIndu"] = md.MainIndustry;
        ViewState["profile"] = md.Profile;
    }

    private void Button1_Click(object sender, EventArgs e) {
        try
        {
            var ud = Session["UserData"] as UserData;
            var bl = new DS_CompanyInfo_Br();
            var md = bl.GetSingleByMemberID(ud.Member.ID);
            string companyName=Request.Form["companyName"];
            string BusType = Request.Form["BusType"];
            string BusModel = Request.Form["BusModel"];
            string RegCapital = Request.Form["RegCapital"];
            string CapitalType = Request.Form["CapitalType"];
            string YearEst = Request.Form["YearEst"];
            string companyAddress = Request.Form["companyAddress"];
            string regArea = Request.Form["regArea"];
            string busArea = Request.Form["busArea"];
            string ZipCode = Request.Form["ZipCode"];
            string oserver = Request.Form["oserver"];
            string buypro = Request.Form["buypro"];
            string MainIndu = Request.Form["MainIndu"];
            string profile = Request.Form["profile"];
            md.CompanyName = companyName;
            md.BusinessType = byte.Parse(BusType);
            md.BusinessModel = BusModel;
            md.RegisteredCapital = double.Parse(RegCapital);
            md.CapitalType = CapitalType;
            md.YearEstablished =short.Parse(YearEst);
            md.Province = companyAddress;
            md.RegistrationArea = regArea;
            md.BusinessAddress = busArea;
            md.ZipCode = ZipCode;
            md.OfferService = oserver;
            md.BuyService = buypro;
            md.MainIndustry = MainIndu;
            md.Profile = profile;
            bl.Update(md);
            Common.MessageBox.ShowAndRedirect(this, "保存成功", "baseinfo.aspx");
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.ResponseScript(this, "alert('保存出错');history.back();");
        }
    }
}
