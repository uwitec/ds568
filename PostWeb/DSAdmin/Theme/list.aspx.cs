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
using Com.DianShi.BusinessRules.Sys;
public partial class DSAdmin_Area_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        ToolBar1.AddBtn("刷新", new EventHandler(Reflesh));
        ToolBar1.AddBtn("删除", new EventHandler(Delete),"onclick","return confirm('确认删除所选记录吗？');");
       
       
        ToolBar1.AddBtn("添加", new EventHandler(Add));
        
        if (IsPostBack) return;
        int pid = 0;
        if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            pid = int.Parse(Request.QueryString["id"]);
        ViewState["pid"] = pid;
        BindDate("parentid=@0", pid);
    }
     
    private void BindDate(string sql, params object[] param)
    {
        var bl=new DS_Area_Br();
        Repeater1.DataSource = bl.Query(sql,"px",param);
        Repeater1.DataBind();
        ViewState["sql"] = sql;
        ViewState["param"] = param;
        int pid=(int)ViewState["pid"];
        ViewState["area"] = "<a href=\"?id=0\">全部</a> > ";
        if (!pid.Equals(0))
        {
            ViewState["area"] = ViewState["area"].ToString()+bl.GetAreaName(pid, false);
        }
        ViewState["area"] = ViewState["area"].ToString().TrimEnd('>', ' ');
    } 

    private void Add(object sender,EventArgs e) {
       
    }
    private void Edit(object sender, EventArgs e)
    {
        string ids = Request.Form["checkboxid"];
        if (string.IsNullOrEmpty(ids))
        {
            Common.MessageBox.ResponseScript(this, "alert('请选中要修改的记录');history.back();");
            return;
        }
        if (!ids.Contains(",")) {
            Response.Redirect("edit.aspx?id="+ids);
        }else
            Common.MessageBox.ResponseScript(this, "alert('不能同时选中多条记录进行修改');history.back();");
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
                Common.MessageBox.Show(this, "请选中要删除的记录");
                return;
            }
            var bl = new DS_Area_Br();
            bl.Delete(ids);
            BindDate(ViewState["sql"].ToString(), (object[])ViewState["param"]);
            Common.MessageBox.Show(this, "删除成功");
           
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Delete", ex.Message);
            Common.MessageBox.Show(this, "删除发生意外，请联系管理人员解决。" + ex.Message);
        }
    }


    protected void LinkButtonPx_Click(object sender, EventArgs e)
    {
        var lb = (LinkButton)sender;
        var bl = new DS_Area_Br();
        bl.Sort(int.Parse(lb.Attributes["pid"]), bool.Parse(lb.Attributes["cn"]));
        BindDate(ViewState["sql"].ToString(),(object[])ViewState["param"]);
    }

    

}
