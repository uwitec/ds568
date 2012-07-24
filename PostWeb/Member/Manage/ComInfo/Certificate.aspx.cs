using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Member;
public partial class Member_Manage_ComInfo_Certificate : BasePage
{
    public string tempPath;
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "公司证书");

        bindMenu();
    }

    private void bindMenu()
    {
        var vs = Enum.GetValues(typeof(DS_Certificate_Br.CtfType));
        Repeater1.DataSource = vs;
        Repeater1.DataBind();

        if (string.IsNullOrEmpty(Request["show_type"]) || vs.Cast<DS_Certificate_Br.CtfType>().Where(a => ((byte)a).ToString().Equals(Request["show_type"])).Count().Equals(0))
        {
            Response.Redirect("Certificate.aspx?show_type=" + (byte)DS_Certificate_Br.CtfType.税务登记证);
        }
        else {
            tempPath = "/Resource/" + DS_Members_Br.GetMemberDir(_userData.Member.ID) + "/Certificate/";
            Repeater2.DataSource = new DS_Certificate_Br().Query("CtfType=@0","id desc",byte.Parse(Request["show_type"]));
            Repeater2.DataBind();
        }
    }
}
