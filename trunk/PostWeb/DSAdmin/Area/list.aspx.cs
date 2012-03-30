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
using Com.DianShi.BusinessRules.Area;
public partial class DSAdmin_Area_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        ToolBar1.AddBtn("刷新", new EventHandler(Reflesh));
        ToolBar1.AddBtn("删除", new EventHandler(Delete),"onclick","return confirm('确认删除所选记录吗？');");
       
        ToolBar1.AddBtn("修改", new EventHandler(Edit));
        ToolBar1.AddBtn("添加", new EventHandler(Add));
        
        if (IsPostBack) return;
        BindDate("");
       
    }
     
    private void BindDate(string sql, params object[] param)
    {
        
    } 

    private void Add(object sender,EventArgs e) {
        Response.Redirect("add.aspx?id=0");
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
            var bl = new DS_Area_Br();
            bl.Delete(ids);
            Common.MessageBox.Show(this, "删除成功", Common.MessageBox.InfoType.info);
           
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Delete", ex.Message);
            Common.MessageBox.Show(this, "删除发生意外，请联系管理人员解决。" + ex.Message, Common.MessageBox.InfoType.error);
        }
    }

  
    

    

}
