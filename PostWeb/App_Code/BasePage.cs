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
        _userData=Session["UserData"] as UserData;
        if (_userData == null)
        {
            Session["UserData"] = _userData = new UserData();
        }
       
        if (_userData.Member==null)
        {
            string url = Resources.Constant.LoginPage+"?return_url="+HttpUtility.UrlEncode(Request.Url.ToString());
           
                
            Response.Write("<script>alert('登录超时，请重新登录。');open('"+url+"','_top')</script>");
            Response.End();
        }
        
       
    }

 
}
