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
public partial class Member_Manage_CompanyInfo_DetailInfo : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "详细资料");

        var ud = Session["UserData"] as UserData;
        var bl = new DS_CompanyInfo_Br();
        var md = bl.GetSingleByMemberID(ud.Member.ID);
        ViewState["LegRep"] = md.LegalRepresentative;
        ViewState["Bank"] = md.Bank;
        ViewState["Account"] = md.Account;
        ViewState["StorageArea"] = md.StorageArea;
        ViewState["Employees"] = md.Employees;
        ViewState["StudyEmployees"] = md.StudyEmployees;
        ViewState["BrandName"] = md.BrandName;
        ViewState["Monthly"] = md.Monthly;
        ViewState["unit"] = md.MonthlyUnit;
        ViewState["AnnualTurnover"] = md.AnnualTurnover;
        ViewState["AnnualImports"] = md.AnnualImports;
        ViewState["AnnualExport"] = md.AnnualExport;
        ViewState["MSCer"] =string.IsNullOrEmpty(md.MSCer)?"":md.MSCer.TrimEnd(',');
        ViewState["qc"] = md.QualityControl;
        ViewState["mainmarket"] = md.MainMarket;
        ViewState["MajorCustomers"] = md.MajorCustomers;
        ViewState["oem"] = md.OEM;
        ViewState["ComImg"] = md.ComImg;

        //员工人数
        var embl = new DS_Employees_Br();
        Repeater1.DataSource = Repeater2.DataSource = embl.Query("", "px");
        Repeater1.DataBind();
        Repeater2.DataBind();

        //营业额
        var tubl = new DS_Turnover_Br();
        Repeater3.DataSource = Repeater4.DataSource = Repeater5.DataSource = tubl.Query("", "px");
        Repeater3.DataBind();
        Repeater4.DataBind();
        Repeater5.DataBind();
    }

    private void Button1_Click(object sender, EventArgs e) {
        //try {
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
            byte AnnualTurnover = byte.Parse(Request.Form["AnnualTurnover"]);
            byte AnnualImports = byte.Parse(Request.Form["AnnualImports"]);
            byte AnnualExport = byte.Parse(Request.Form["AnnualExport"]);
            string MSCer = Request.Form["MSCer"];
            string qc = Request.Form["qc"];
            string mainmarket = Request.Form["mainmarket"];
            string MajCust = Request.Form["MajCust"];
            bool oem = string.IsNullOrEmpty(Request.Form["oem"]) ? false : bool.Parse(Request.Form["oem"]);
            string ComImg = Request.Form["comimg"];
            md.LegalRepresentative = LegRep;
            md.Bank = Bank;
            md.Account = Account;
            md.StorageArea = StorageArea;
            md.Employees = Employees;
            md.StudyEmployees = StudyEmployees;
            md.BrandName = BrandName;
            md.Monthly = Monthly;
            md.MonthlyUnit = unit;
            md.AnnualTurnover = AnnualTurnover;
            md.AnnualImports = AnnualImports;
            md.AnnualExport = AnnualExport;
            md.MSCer = MSCer;
            md.QualityControl = qc;
            md.MainMarket = mainmarket;
            md.MajorCustomers = MajCust;
            md.OEM = oem;
            md.ComImg = ComImg;

            bl.Update(md);
            Common.MessageBox.ShowAndRedirect(this, "保存成功", "DetailInfo.aspx");
        //}
        //catch (Exception ex)
        //{
        //    Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
        //    Common.MessageBox.ResponseScript(this, "alert('保存出错');history.back();");
        //}
    }
}
