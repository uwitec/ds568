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
using Com.DianShi.BusinessRules.Album;
public partial class Member_Manage_Album_Image_Upload : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("图片管家", "相册管理");

        var bl = new DS_Album_Br();
        Repeater1.DataSource = bl.Query("memberid=@0","createdate desc", _userData.Member.ID);
        Repeater1.DataBind();
      

        //绑定访问权限
        Repeater2.DataSource = Enum.GetValues(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions));
        Repeater2.DataBind();
    }
}
