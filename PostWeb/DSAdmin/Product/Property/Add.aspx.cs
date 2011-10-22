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

public partial class DSAdmin_Product_Property_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Request.QueryString["SysCatID"]))
        {
            Common.MessageBox.Show(this, "缺少参数", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        int sid = 0;
        if (!int.TryParse(Request.QueryString["SysCatID"], out sid))
        {
            Common.MessageBox.Show(this, "参数无效", Common.MessageBox.InfoType.warning, "history.back");
            return;
        }
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        DropDownList1.DataSource = Enum.GetNames(typeof(DS_Property_Br.ControlType));
        DropDownList1.DataBind();

        var bl = new DS_Property_Br();
        var list = bl.Query<byte>("select mapid from DS_Property where SysCatID=" + Request.QueryString["SysCatID"]);
        byte[] mapid={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24};
        DropDownList2.DataSource = mapid.Where(a => !list.Contains(a));
        DropDownList2.DataBind();
    }

    private void Button1_Click(object sender, EventArgs e) {
        try {
            string pname = cname.Value.Trim();
            if (string.IsNullOrEmpty(pname)) {
                Common.MessageBox.Show(this,"属性名称不能为空",Common.MessageBox.InfoType.warning);
                return;
            }
            if (DropDownList2.Items.Count.Equals(0))
            {
                Common.MessageBox.Show(this, "映射序号已用完，不能继续添加", Common.MessageBox.InfoType.warning);
                return;
            }
            var bl = new DS_Property_Br();
            var md = bl.CreateModel();
            md.ProName = pname;
            md.SysCatID = int.Parse(Request.QueryString["SysCatID"]);
            md.ControlType =byte.Parse(DropDownList1.SelectedIndex.ToString());
            md.Unit = unit.Value.Trim();
            md.MapID =byte.Parse(DropDownList2.SelectedValue);
            md.Request = CheckBox1.Checked;
            md.Px = 0;
            bl.Add(md);
            bl.Sort(md.ID,true);
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
