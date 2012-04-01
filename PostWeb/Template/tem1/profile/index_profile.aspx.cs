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
public partial class Template_tem1_profile_index_profile : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Header.Title = "公司简价," + _vMember.CompanyName;
        if (IsPostBack) return;
        var mblist = new System.Collections.Generic.List<Com.DianShi.Model.Member.View_Members>();
        mblist.Add(_vMember);
        Repeater1.DataSource = mblist;
        Repeater1.DataBind();
        ViewState["ct"] = _vMember.Profile;
        ViewState["imgurl"] = _vMember.ComImg;
    }
    
    public string GetBt(object id) {//企业类型
        try
        {
            var bl = new DS_BusType_Br();
            return bl.GetSingle(int.Parse(id.ToString())).BusType;
        }
        catch { return ""; }
    }
    
    //员工人数
    public string GetStaffNum(object id)
    {
        try
        {
            var bl = new DS_Employees_Br();
            return bl.GetSingle(int.Parse(id.ToString())).Employees;
        }
        catch { return ""; }
    }

    //营业额
    public string GetTu(object id)
    {
        try
        {
            var bl = new DS_Turnover_Br();
            return bl.GetSingle(int.Parse(id.ToString())).Amount;
        }
        catch { return ""; }
    }
}
