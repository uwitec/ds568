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

public partial class DSAdmin_UserControl_ToolBar : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    public void AddBtn(string btnName,EventHandler eh) {
        var btn=new LinkButton();
        btn.Text = "<div class='btnright'><div>&nbsp;</div>"+btnName + "</div>";
        btn.Click+=new EventHandler(eh);
        var li=new HtmlGenericControl("li");
        li.Controls.Add(btn);
        TbCtn.Controls.AddAt(0,li);
    }

    public Wuqi.Webdiyer.AspNetPager AspNetPager { get { return paper; } }
   
}
