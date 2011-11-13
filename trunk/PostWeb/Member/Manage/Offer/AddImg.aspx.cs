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
public partial class Member_Manage_Offer_AddImg : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        AspNetPager4.PageChanged += new EventHandler(AspNetPager_PageChanged);
        selAlbum.SelectedIndexChanged+=new EventHandler(selAlbum_ServerChange);
        if (IsPostBack) return;
        var ud = Session["UserData"] as UserData;
        var bl = new DS_Album_Br();
        var list = bl.Query("memberID=@0","px",ud.Member.ID);
        selAlbum2.DataSource = selAlbum.DataSource = list;
        selAlbum2.DataBind();
        selAlbum.DataBind();
        BindDate("albumid=@0",int.Parse(selAlbum.SelectedValue));
    }

    private void AspNetPager_PageChanged(object ob, object ob1)
    {
        BindDate(ViewState["sql"].ToString(), (object[])ViewState["param"]);
    }

    private void BindDate(string sql, params object[] param)
    {
        ViewState["sql"] = sql;
        ViewState["param"] = param;
        int pageCount = 0;
        var bl = new DS_AlbumImg_Br();
        var list = bl.Query(sql, "", (AspNetPager4.CurrentPageIndex - 1) * AspNetPager4.PageSize, AspNetPager4.PageSize, ref pageCount, param);
        AspNetPager4.RecordCount = pageCount;
        Repeater1.DataSource = list;
        Repeater1.DataBind();
    }

    private void selAlbum_ServerChange(object sender, EventArgs e) {
        BindDate("albumid=@0", int.Parse(selAlbum.SelectedValue));
        AspNetPager4.CurrentPageIndex = 1;
    }
}
