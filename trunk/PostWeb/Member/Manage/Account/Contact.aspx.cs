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

public partial class Member_Manage_Account_Contact :BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("帐号管理", "修改联系信息");
    }
}
