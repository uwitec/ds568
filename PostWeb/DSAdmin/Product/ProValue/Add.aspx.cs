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

public partial class DSAdmin_Product_ProValue_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Request.QueryString["ProID"]))
        {
            Common.MessageBox.Show(this, "缺少参数", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        int sid = 0;
        if (!int.TryParse(Request.QueryString["ProID"], out sid))
        {
            Common.MessageBox.Show(this, "参数无效", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        var bl = new DS_Property_Br();
        var md = bl.GetSingle(int.Parse(Request.QueryString["ProID"]));
        ViewState["proName"] = md.ProName;
        
    }

    private void Button1_Click(object sender, EventArgs e) {
        try {
            string pname = proVal.Value.Trim();
            if (string.IsNullOrEmpty(pname)) {
                Common.MessageBox.Show(this,"属性值不能为空",Common.MessageBox.InfoType.warning);
                return;
            }
           
            var bl = new DS_PropertyValue_Br();
            var md = bl.CreateModel();
            md.PropertyValue = pname;
            md.PropertyID = int.Parse(Request.QueryString["ProID"]);
            md.Px = 0;
            bl.Add(md);
            bl.Sort(md.ID,true);
            Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info, "function(){location='list.aspx?ProID="+md.PropertyID+"'}");
        }catch(Exception ex){
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            if (ex.Message.Contains("IX_DS_PropertyValue")) {
                Common.MessageBox.Show(this, "已存在相同的值", Common.MessageBox.InfoType.error);
                return;
            }
            Common.MessageBox.Show(this, "保存发生意外，请联系管理人员解决。"+ex.Message, Common.MessageBox.InfoType.error);
        }
    }
}
