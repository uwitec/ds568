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
using Com.DianShi.BusinessRules.Community;
public partial class Member_Login_login : BasePage
{
    public int msgCount;//未读消息数
    protected void Page_Load(object sender, EventArgs e)
    {
        var cmbl = new DS_Message_Br();
        msgCount= cmbl.Query<int>("select count(id) from ds_message where isview=0").Single();
    }
}
