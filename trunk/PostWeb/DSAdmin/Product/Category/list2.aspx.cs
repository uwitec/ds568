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

public partial class DSAdmin_Product_Category_list2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ToolBar1.AddBtn("三级类别", new EventHandler(Add));
        ToolBar1.AddBtn("刷新", new EventHandler(Reflesh));
        ToolBar1.AddBtn("删除", new EventHandler(Delete));
        ToolBar1.AddBtn("修改", new EventHandler(Edit));
        ToolBar1.AddBtn("添加", new EventHandler(Add));
        ToolBar1.AspNetPager.PageChanged += new EventHandler(AspNetPager_PageChanged);
        
        if (IsPostBack) return;
        BindDate("parentid="+Request.QueryString["id"]);

    }
    private void AspNetPager_PageChanged(object ob, object ob1)
    {
        BindDate(ViewState["sql"].ToString());
    }

    private void BindDate(string sql, params object[] param)
    {
        ViewState["sql"] = sql;
        int pageCount = 0;
        var bl = new DS_SysProductCategory_Br();
        var list = bl.Query(sql,"px", (ToolBar1.AspNetPager.CurrentPageIndex - 1) * ToolBar1.AspNetPager.PageSize, ToolBar1.AspNetPager.PageSize, ref pageCount, param);
        ToolBar1.AspNetPager.RecordCount = pageCount;
        Repeater1.DataSource =list;
        Repeater1.DataBind();
    }

    private void Add(object sender,EventArgs e) {
        Response.Redirect("add2.aspx?pid=" + Request.QueryString["id"]);
    }
    private void Edit(object sender, EventArgs e)
    {
        string ids = Request.Form["checkboxid"];
        if (string.IsNullOrEmpty(ids))
        {
            Common.MessageBox.Show(this, "请选中要修改的记录", Common.MessageBox.InfoType.warning,"history.back");
            return;
        }
        if (!ids.Contains(",")) {
            Response.Redirect("edit.aspx?id="+ids);
        }else
            Common.MessageBox.Show(this, "不能同时选中多条记录进行修改", Common.MessageBox.InfoType.warning,"history.back");
    }

    private void Reflesh(object sender, EventArgs e)
    {
        Response.Redirect("list2.aspx?id="+Request.QueryString["id"]);
    }

    private void Delete(object sender, EventArgs e)
    {
        try
        {
            string ids = Request.Form["checkboxid"];
            if (string.IsNullOrEmpty(ids)) {
                Common.MessageBox.Show(this, "请选中要删除的记录", Common.MessageBox.InfoType.warning);
                return;
            }
            var bl = new DS_SysProductCategory_Br();
            bl.Delete(ids);
            Common.MessageBox.Show(this, "删除成功", Common.MessageBox.InfoType.info);
            AspNetPager_PageChanged(null, null);
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Delete", ex.Message);
            Common.MessageBox.Show(this, "删除发生意外，请联系管理人员解决。" + ex.Message, Common.MessageBox.InfoType.error);
        }
    }

    protected void LinkButtonPx_Click(object sender, EventArgs e)
    {
        var lb = (LinkButton)sender;
        var bl = new DS_SysProductCategory_Br();
        bl.Sort(int.Parse(lb.Attributes["pid"]), bool.Parse(lb.Attributes["cn"]));
        AspNetPager_PageChanged(null, null);
    }
}
