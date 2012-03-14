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
using Com.DianShi.BusinessRules.Album;
public partial class index_album : ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AspNetPager4.PageChanged+=new EventHandler(AspNetPager4_PageChanged);
        if (IsPostBack) return;
        BindData("memberid=@0 and PictureNum>0 and Permissions!=@1",_vMember.ID, (byte)DS_Album_Br.Permissions.不公开);
        
    }

    private void AspNetPager4_PageChanged(object sender, EventArgs e) {
        BindData(ViewState["sql"].ToString(),(object[])ViewState["param"]);
    }

    private void BindData(string sql, params object[] param)
    {
        ViewState["sql"] = sql;
        ViewState["param"] = param;
        var bl = new DS_Album_Br();
        int rc = 0;
        Repeater1.DataSource = bl.Query(sql, "updatedate desc", (AspNetPager4.CurrentPageIndex - 1) * AspNetPager4.PageSize, AspNetPager4.PageSize, ref rc, param);
        Repeater1.DataBind();

        if (!IsPostBack)
        {
            AspNetPager4.RecordCount = rc;
            AspNetPager4.TextBeforePageIndexBox = "共" + AspNetPager4.PageCount + "页 第";
        }
    }
}
 