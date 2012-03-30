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
public partial class DSAdmin_Area_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button1.Click+=new EventHandler(Button1_Click);
    }

    private void Button1_Click(object sender, EventArgs e) {
        var bl = new DS_Area_Br();
        var md = bl.CreateModel();
        md.AreaName = TextBox1.Text;
        md.ParentID = int.Parse(Request["id"]);
        bl.Add(md);
        Common.MessageBox.Show(this,"保存成功",Common.MessageBox.InfoType.info,"function(){location='list.aspx'}");
    }
}
