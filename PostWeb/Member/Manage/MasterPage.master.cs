using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class Member_Manage_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// 设置当前页面所属模块和名称
    /// </summary>
    /// <param name="ModleName">所属模块</param>
    /// <param name="MenuName">名称</param>
    public void SetMenuTitle(string ModleName,string MenuName)
    {
        LeftMenu1.ModleName = ModleName;
        LeftMenu1.MenuName = MenuName;
    }
}
