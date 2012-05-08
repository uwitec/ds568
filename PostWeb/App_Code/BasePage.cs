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
        if (!UserData.ChkObjNull(UserData.ObjType.会员信息))
        {
            Response.Write("<script>alert('登录超时，请重新登录。');open('"+Resources.Constant.LoginPage+"','_top')</script>");
            Response.End();
        }
        _userData = Session["UserData"] as UserData;
       
    }

 
}
