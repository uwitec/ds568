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

public partial class Member_Manage_Top : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        if (!string.IsNullOrEmpty(Request.QueryString["action"])) { 
            string act=Request.QueryString["action"];
            switch (act) { 
                case "out":
                    Session.Abandon();
                    Response.Redirect("top.aspx");
                    break;
            }
        }
    }
}
