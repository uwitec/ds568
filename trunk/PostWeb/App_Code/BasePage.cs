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
        //OA_User_Bll ubl = new OA_User_Bll();
        //OA_User u=new OA_User{ UserID="admin",UserPassword="abc123"};
        //ubl.Login(ref u);
        //Session["UserData"] = new UserData{ OaUser=u};

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
