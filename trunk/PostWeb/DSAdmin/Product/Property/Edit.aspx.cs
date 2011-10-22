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

public partial class DSAdmin_Product_Property_Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Request.QueryString["ID"]))
        {
            Common.MessageBox.Show(this, "缺少参数", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        int sid = 0;
        if (!int.TryParse(Request.QueryString["ID"], out sid))
        {
            Common.MessageBox.Show(this, "参数无效", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        DropDownList1.DataSource = Enum.GetNames(typeof(DS_Property_Br.ControlType));
        DropDownList1.DataBind();

        var bl = new DS_Property_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["ID"]));
        cname.Value = md.ProName;
        DropDownList1.Items[md.ControlType].Selected = true;
        unit.Value = md.Unit;
        ViewState["MapID"] = md.MapID;
        ViewState["SysCatID"] = md.SysCatID;
        CheckBox1.Checked = md.Request;
        ViewState["categoryName"] = new DS_SysProductCategory_Br().GetCategoryName(md.SysCatID,false).TrimEnd('>');
    }

    private void Button1_Click(object sender, EventArgs e) {
        try {
            string pname = cname.Value.Trim();
            if (string.IsNullOrEmpty(pname)) {
                Common.MessageBox.Show(this,"属性名称不能为空",Common.MessageBox.InfoType.warning);
                return;
            }
            var bl = new DS_Property_Br();
            var md = bl.GetSingle(int.Parse(Request.QueryString["ID"]));
            md.ProName = pname;
            md.ControlType =byte.Parse(DropDownList1.SelectedIndex.ToString());
            md.Unit = unit.Value.Trim();
            md.Request = CheckBox1.Checked;
            bl.Update(md);
            Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info, "function(){location='list.aspx?SysCatID="+md.SysCatID+"'}");
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            if (ex.Message.Contains("IX_DS_Property")) {
                Common.MessageBox.Show(this, "已存在相同的分类名称", Common.MessageBox.InfoType.error);
                return;
            }
            Common.MessageBox.Show(this, "保存发生意外，请联系管理人员解决。"+ex.Message, Common.MessageBox.InfoType.error);
        }
    }
}
