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
using Com.DianShi.BusinessRules.Product;
public partial class Member_Manage_Offer_List : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        btnDel.Click+=new EventHandler(btnDel_Click);

        if (!string.IsNullOrEmpty(Request["action"]))//处理Ajax动作
        {
            switch (Request["action"]) { 
                case "del":
                    btnDel_Click(null, null);
                    break;
            }
        }

        if (IsPostBack) return;

        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("供应管理", "管理供应信息");
        
        var vs = Enum.GetValues(typeof(DS_Products_Br.State));
        Repeater1.DataSource = vs;
        Repeater1.DataBind();
        if (string.IsNullOrEmpty(Request.QueryString["show_type"]) || vs.Cast<DS_Products_Br.State>().Where(a=>((byte)a).ToString().Equals(Request.QueryString["show_type"])).Count().Equals(0))
        {
            Response.Redirect("list.aspx?show_type="+(byte)DS_Products_Br.State.销售中);
            return;
        }
        
        BindDate("state=@0", byte.Parse(Request.QueryString["show_type"]));
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
        var bl = new DS_Products_Br();
        var list = bl.Query(sql, "createdate desc", (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize, AspNetPager1.PageSize, ref pageCount, param);
        AspNetPager1.RecordCount = pageCount;
        Repeater2.DataSource = list;
        Repeater2.DataBind();
    } 

    public int GetProCount(byte state) {
        var bl = new DS_Products_Br();
        var ud = Session["UserData"] as UserData;
        return bl.Query("MemberID=@0 and state=@1","",ud.Member.ID,state).Count();
    }

    public void btnDel_Click(object sender, EventArgs e) {

        string ids = Request.Form["chb_pro"];
        if (string.IsNullOrEmpty(ids)) {
            Common.MessageBox.Show(this, "请选中要删除的记录", Common.MessageBox.InfoType.warning);
            return;
        }
        var bl = new DS_Products_Br();
        bl.Delete(ids);
        Common.MessageBox.Show(this, "删除成功", Common.MessageBox.InfoType.info);
        AspNetPager_PageChanged(null, null);
        
    }
}
