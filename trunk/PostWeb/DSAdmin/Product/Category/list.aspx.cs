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

public partial class DSAdmin_Product_Category_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ToolBar1.AddBtn("二级类别", new EventHandler(SubCategory));
        ToolBar1.AddBtn("刷新", new EventHandler(Reflesh));
        ToolBar1.AddBtn("删除", new EventHandler(Delete),"onclick","return confirm('确认删除所选记录吗？');");
        ToolBar1.AddBtn("修改", new EventHandler(Edit));
        ToolBar1.AddBtn("添加", new EventHandler(Add));
        ToolBar1.AspNetPager.PageChanged += new EventHandler(AspNetPager_PageChanged);
        ProCat1.BindEvent(new EventHandler(DropDownList1_SelectedIndexChanged),1);
        ProCat1.BindEvent(new EventHandler(DropDownList2_SelectedIndexChanged), 2);
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        BindDate("parentid=0");
        ProCat1.ShowLevel = 2;
         
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
        Response.Redirect("add.aspx");
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

    private void SubCategory(object sender, EventArgs e)
    {
        string ids = Request.Form["checkboxid"];
        if (string.IsNullOrEmpty(ids))
        {
            Common.MessageBox.Show(this, "请选中要查看二级分类的记录", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        if (!ids.Contains(","))
        {
            Response.Redirect("list2.aspx?id=" + ids);
        }
        else
            Common.MessageBox.Show(this, "不能同时选中多条记录进行操作", Common.MessageBox.InfoType.warning, "history.back");
    }

    private void Reflesh(object sender, EventArgs e)
    {
        Response.Redirect("list.aspx");
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

    private void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToolBar1.AspNetPager.PageChanged -= new EventHandler(AspNetPager_PageChanged);
        ToolBar1.AspNetPager.CurrentPageIndex = 1;
        var bl = new DS_SysProductCategory_Br();
        BindDate("parentid=" +ProCat1.CategoryID_1);
       
    }

    private void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ToolBar1.AspNetPager.PageChanged -= new EventHandler(AspNetPager_PageChanged);
        ToolBar1.AspNetPager.CurrentPageIndex = 1;
        var bl = new DS_SysProductCategory_Br();
        if (ProCat1.CategoryID_2.Equals(0))
        {
            BindDate("parentid=" + ProCat1.CategoryID_1);
        }
        else
        {
            BindDate("parentid=" + ProCat1.CategoryID_2);
        }
 
    }

    private void Button1_Click(object sender, EventArgs e) {
        try {
            var bl = new DS_SysProductCategory_Br();
            string kw=Request.Form["keyword"].Trim();
            string sql = "";
            object[] param=new object[1];
            if (!string.IsNullOrEmpty(kw)) {
                sql = " categoryName.Contains(@0)";
                param[0] = kw;
            }
            if (!ProCat1.CurrentCategoryID.Equals(0))
            {
                sql += " and parentID="+ProCat1.CurrentCategoryID;
            }
            
            BindDate(sql,param);
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this,"搜索发生意外。"+ex.Message);
        }
    }

}
