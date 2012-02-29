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
using Com.DianShi.BusinessRules.Member;
using Com.DianShi.Model.Member;
/// <summary>
///BasePage 的摘要说明
/// </summary>
public class ShopBasePage : System.Web.UI.Page
{
    protected  View_Members  _vMember = null;

    protected override void InitializeCulture()
    {
        var vmbbl = new View_Members_Br();
        _vMember = vmbbl.GetSingle(Request.Url);
        if (_vMember == null)
        {
            Response.Write("<br>   该商铺不存在或已被删除。");
            Response.End();
        }

       
    }
 
}
