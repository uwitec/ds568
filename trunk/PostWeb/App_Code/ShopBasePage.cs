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
using Com.DianShi.Model.Decoration;
using Com.DianShi.BusinessRules.Decoration;
/// <summary>
///商铺基类
/// </summary>
public class ShopBasePage : System.Web.UI.Page
{
    public  View_Members  _vMember = null;
    public DS_Decoration _Decoration;
   
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
        var dcbl = new DS_Decoration_Br();
        _Decoration = dcbl.GetSingle(_vMember.ID, true);
        if (!object.Equals(_Decoration,null)&&!object.Equals(this.Page.Header, null))
        {
            var lctr = new LiteralControl();
            lctr.Text = "<style type=\"text/css\">";
            if (!string.IsNullOrEmpty(_Decoration.Sign))
                lctr.Text += ".Head{background-image:url(" + _Decoration.Sign + ");}\n";
            if (!string.IsNullOrEmpty(_Decoration.MenuBg))
                lctr.Text += ".HeaderMenuBar{background-image:url(" + _Decoration.MenuBg + ");}\n";
            if (!string.IsNullOrEmpty(_Decoration.NormalMenu))
                lctr.Text += ".HeaderMenuBar ul li{background-image:url(" + _Decoration.NormalMenu + ");}\n";
            if (!string.IsNullOrEmpty(_Decoration.SelectedMenu))
                lctr.Text += ".HeaderMenuBar ul li:hover{background-image:url(" + _Decoration.SelectedMenu + ");}\n";
            if (!string.IsNullOrEmpty(_Decoration.SelectedMenu))
                lctr.Text += ".HeaderMenuBar ul li.Check{background-image:url(" + _Decoration.SelectedMenu + ");}\n";
            if (!string.IsNullOrEmpty(_Decoration.NmColor))
                lctr.Text += ".HeaderMenuBar ul li a:link,.HeaderMenuBar ul li a:visited{color:" + _Decoration.NmColor + ";}\n";
            if (!string.IsNullOrEmpty(_Decoration.SelmColor))
                lctr.Text += ".HeaderMenuBar ul li:hover a,.HeaderMenuBar ul li a:hover,.HeaderMenuBar ul li.Check a:link,.HeaderMenuBar ul li.Check a:visited{color:" + _Decoration.SelmColor + ";}\n";
            lctr.Text += "</style>";
            this.Page.Header.Controls.Add(lctr);
        }
    }
 
}
