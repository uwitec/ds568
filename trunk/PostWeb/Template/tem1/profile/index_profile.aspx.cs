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
public partial class Template_tem1_profile_index_profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new View_Members_Br();
        var list = bl.Query("id=@0","",int.Parse(Request.QueryString["member_id"]));
        Repeater1.DataSource = list;
        Repeater1.DataBind();
        var md = list.Single();
        ViewState["ct"] = md.Profile;
        ViewState["imgurl"] = md.ComImg;
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
