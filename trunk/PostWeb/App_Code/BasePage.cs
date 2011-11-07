using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
/// <summary>
///BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
    protected UserData _userData = null;

    protected override void InitializeCulture()
    {
        //测试登陆
        var mb = new Com.DianShi.Model.Member.DS_Members();
        Session["UserData"] = new UserData { Member=mb };

        _userData = Session["UserData"] as UserData;
        if (_userData == null)
        {
            Response.Write("<script>open('"+Resources.Constant.LoginPage+"','_top')</script>");
            Response.End();
            //Response.Redirect(Resources.PageConstant.LoginPage);
        }

        //this.Page.Theme = System.Configuration.ConfigurationManager.AppSettings["Theme"].ToString();
        //CultureInfo culture = new CultureInfo(_userData.Language != null ? _userData.Language : System.Configuration.ConfigurationManager.AppSettings["Langue"].ToString());

        //System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        //this.Theme = System.Configuration.ConfigurationManager.AppSettings["Theme"].ToString();
        //this.Culture = System.Configuration.ConfigurationManager.AppSettings["Langue"];
        //this.UICulture = System.Configuration.ConfigurationManager.AppSettings["Langue"];
        //this.UICulture = HttpContext.Current.Profile.GetPropertyValue("UICulture").ToString();
        //this.Culture = HttpContext.Current.Profile.GetPropertyValue("Culture").ToString();
        //Thread.CurrentThread.CurrentCulture =
        //CultureInfo.CreateSpecificCulture(System.Configuration.ConfigurationManager.AppSettings["Langue"].ToString());
        //base.InitializeCulture();
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {

        //Page.Theme = HttpContext.Current.Profile.GetPropertyValue("theme").ToString();
        //this.Culture = "zh-cn";            
    }
}
