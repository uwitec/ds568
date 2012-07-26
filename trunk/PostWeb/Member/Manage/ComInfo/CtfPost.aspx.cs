using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Member;
public partial class Member_Manage_ComInfo_CtfPost : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        


        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "公司证书");

        var vs = Enum.GetValues(typeof(DS_Certificate_Br.CtfType));
        Repeater1.DataSource = vs;
        Repeater1.DataBind();

    }
}
