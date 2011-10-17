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

public partial class DSAdmin_Product_Category_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        var bl = new DS_SysProductCategory_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["id"]));
        cname.Value = md.CategoryName;
        ProCat1.CurrentCategoryID = md.ID;
        ProCat1.ShowLevel = 2;
        ProCat1.Dropdown_2.AutoPostBack = false;
    }

    private void Button1_Click(object sender, EventArgs e) {
        try {
            var bl = new DS_SysProductCategory_Br();
            var md = bl.GetSingle(int.Parse(Request.QueryString["id"]));

            string cname = Request.Form["cname"];
            if (string.IsNullOrEmpty(cname)) {
                Common.MessageBox.Show(this,"分类名称不能为空",Common.MessageBox.InfoType.warning,"history.back");
                return;
            }
            if (md.ParentID.Equals(ProCat1.CurrentCategoryID))
            {
                Common.MessageBox.Show(this, "不能选择自己作为父类", Common.MessageBox.InfoType.warning, "history.back");
                return;
            }
           
            md.CategoryName = cname.Trim();
            md.ParentID = ProCat1.CurrentCategoryID;
            bl.Update(md);
            Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info,"function(){location='list.aspx'}");
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            if (ex.Message.Contains("IX_DS_SysProductCategory")) {
                Common.MessageBox.Show(this, "已存在相同的分类名称", Common.MessageBox.InfoType.error, "history.back");
                return;
            }
            Common.MessageBox.Show(this, "保存发生意外，请联系管理人员解决。" + ex.Message, Common.MessageBox.InfoType.error, "history.back");
        }
    }
}
