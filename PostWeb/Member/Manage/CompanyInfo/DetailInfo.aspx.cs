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
public partial class Member_Manage_CompanyInfo_DetailInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "详细资料");
    }

    private void Button1_Click(object sender, EventArgs e) {
        try {
            var ud = Session["UserData"] as UserData;
            var bl = new DS_CompanyInfo_Br();
            var md = bl.GetSingleByMemberID(ud.Member.ID);
            string LegRep = Request.Form["LegRep"];
            string Bank = Request.Form["Bank"];
            string Account = Request.Form["Account"];
            string StorageArea = Request.Form["StorageArea"];
            byte Employees = byte.Parse(Request.Form["Employees"]);
            byte StudyEmployees = byte.Parse(Request.Form["StudyEmployees"]);
            string BrandName = Request.Form["BrandName"];
            int Monthly =Request.Form["Monthly"].Trim()!=""?int.Parse(Request.Form["Monthly"]):0;
            string unit = Request.Form["unit"];
            int AnnualTurnover = int.Parse(Request.Form["AnnualTurnover"]);
            int AnnualImports = int.Parse(Request.Form["AnnualImports"]);
            int AnnualExport = int.Parse(Request.Form["AnnualExport"]);
            string MSCer = Request.Form["MSCer"];
            string qc = Request.Form["qc"];
            string mainmarket = Request.Form["mainmarket"];
            string MajCust = Request.Form["MajCust"];
            bool oem=Request.Form["oem"].Equals("1")?true:false;
            //md.CompanyName = companyName;
            //md.BusinessType = byte.Parse(BusType);
            //md.BusinessModel = BusModel;
            //md.RegisteredCapital = double.Parse(RegCapital);
            //md.CapitalType = CapitalType;
            //md.YearEstablished = short.Parse(YearEst);
            //md.Province = companyAddress;
            //md.RegistrationArea = regArea;
            //md.BusinessAddress = busArea;
            //md.ZipCode = ZipCode;
            //md.OfferService = oserver;
            //md.BuyService = buypro;
            //md.MainIndustry = MainIndu;
            //md.Profile = profile;
            bl.Update(md);
            Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info, "function(){location='detailinfo.aspx'}");
        }
        catch (Exception ex)
        {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this, "保存出错", Common.MessageBox.InfoType.error, "history.back");
        }
    }
}
