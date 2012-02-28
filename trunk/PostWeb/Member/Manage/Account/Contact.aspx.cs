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
using Com.DianShi.BusinessRules.Member;
public partial class Member_Manage_Account_Contact :BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("帐号管理", "修改联系信息");

        //保存事件
        Button1.Click+=new EventHandler(Button1_Click);

        if (IsPostBack) return;
        try
        {
            var ud = Session["UserData"] as UserData;
            var bl = new DS_Members_Br();
            var md = bl.GetSingle(ud.Member.ID);
            ViewState["Email"] = md.Email;
            ViewState["TrueName"] = md.TrueName;
            ViewState["Gender"] = string.IsNullOrEmpty(md.Gender) ? "" : md.Gender;
            ViewState["Position"] = md.Position;
            string[] phone = md.Phone.Split('-');
            if (phone.Length > 2)
            {
                ViewState["Phoneqh"] = phone[0];
                ViewState["Phonehm"] = phone[1];
                ViewState["Phonefj"] = phone[2];
            }
            ViewState["Mobile"] = md.Mobile;
            if (!string.IsNullOrEmpty(md.Fax))
            {
                string[] fax = md.Fax.Split('-');
                if (fax.Length > 2)
                {
                    ViewState["Faxqh"] = fax[0];
                    ViewState["Faxhm"] = fax[1];
                    ViewState["Faxfj"] = fax[2];
                }
            }

            ViewState["HomePage"] = md.HomePage;
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Page_Load",ex.Message);
            Common.MessageBox.Show(this,"获取数据出错",Common.MessageBox.InfoType.error,"history.back");
        }
    }

    private void Button1_Click(object sender, EventArgs e) {
        try
        {
            var ud = Session["UserData"] as UserData;
            var bl = new DS_Members_Br();
            var md = bl.GetSingle(ud.Member.ID);
            md.Email=Request.Form["email"];
            md.TrueName=Request.Form["trueName"];
            md.Gender=Request.Form["sex"];
            md.Position=Request.Form["position"];
            md.Phone = Request.Form["phoneqh"] + "-" + Request.Form["phonehm"] + "-" + Request.Form["phonefj"];
            md.Mobile=Request.Form["mobile"];
            md.Fax = Request.Form["faxqh"] + "-" + Request.Form["faxhm"] + "-" + Request.Form["faxfj"];
            md.HomePage = Request.Form["webSite"].ToLower();
            bl.Update(md);
            Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info, "function(){location='Contact.aspx'}");
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this, "保存出错", Common.MessageBox.InfoType.error, "history.back");
        }
    }
}
