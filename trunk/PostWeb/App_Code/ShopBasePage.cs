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
using Com.DianShi.Model.SiteConfig;
using Com.DianShi.BusinessRules.SiteConfig;
/// <summary>
///商铺基类
/// </summary>
public class ShopBasePage : System.Web.UI.Page
{
    public  View_Members  _vMember = null;
    public DS_SiteConfig _SiteConfig;
   
    protected override void OnPreLoad(EventArgs e)
    {
        var vmbbl = new View_Members_Br();
        _vMember = vmbbl.GetSingle(Request.Url);
        if (_vMember == null)
        {
            Response.Write("<br>   该商铺不存在或已被删除。");
            Response.End();
        }

        //装修数据
        var dcbl = new DS_SiteConfig_Br();
        _SiteConfig = dcbl.GetSingle(_vMember.ID, true);
        if (!object.Equals(_SiteConfig,null)&&!object.Equals(this.Page.Header, null))
        {
            var lctr = new LiteralControl();
            lctr.Text = "<style type=\"text/css\">";
            if (!string.IsNullOrEmpty(_SiteConfig.Sign))
                lctr.Text += ".Head{background-image:url(" + _SiteConfig.Sign + ");}\n";
            if (!string.IsNullOrEmpty(_SiteConfig.MenuBg))
                lctr.Text += ".HeaderMenuBar{background-image:url(" + _SiteConfig.MenuBg + ");}\n";
            if (!string.IsNullOrEmpty(_SiteConfig.NormalMenu))
                lctr.Text += ".HeaderMenuBar ul li{background-image:url(" + _SiteConfig.NormalMenu + ");}\n";
            if (!string.IsNullOrEmpty(_SiteConfig.SelectedMenu))
                lctr.Text += ".HeaderMenuBar ul li:hover{background-image:url(" + _SiteConfig.SelectedMenu + ");}\n";
            if (!string.IsNullOrEmpty(_SiteConfig.SelectedMenu))
                lctr.Text += ".HeaderMenuBar ul li.Check{background-image:url(" + _SiteConfig.SelectedMenu + ");}\n";
            if (!string.IsNullOrEmpty(_SiteConfig.NmColor))
                lctr.Text += ".HeaderMenuBar ul li a:link,.HeaderMenuBar ul li a:visited{color:" + _SiteConfig.NmColor + ";}\n";
            if (!string.IsNullOrEmpty(_SiteConfig.SelmColor))
                lctr.Text += ".HeaderMenuBar ul li:hover a,.HeaderMenuBar ul li a:hover,.HeaderMenuBar ul li.Check a:link,.HeaderMenuBar ul li.Check a:visited{color:" + _SiteConfig.SelmColor + ";}\n";
            lctr.Text += "</style>";
            this.Page.Header.Controls.Add(lctr);
        }
    }
 
}
