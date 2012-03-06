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

public partial class Member_Manage_News_Add :  BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司动态", "发布公司动态");
    }
}
