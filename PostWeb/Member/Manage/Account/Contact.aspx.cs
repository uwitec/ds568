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

        //ajax事件
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "save":
                    save();
                    break;
            }
        }

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
            ViewState["qq"] = md.QQ;
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

    private void save() {
        var bl = new DS_Members_Br();
        var md = bl.GetSingle(_userData.Member.ID);
        md.Email=Request.QueryString["email"];
        md.TrueName=Request.QueryString["trueName"];
        md.Gender=Request.QueryString["sex"];
        md.Position=Request.QueryString["position"];
        md.Phone = Request.QueryString["phoneqh"] + "-" + Request.QueryString["phonehm"] + "-" + Request.QueryString["phonefj"];
        md.Mobile=Request.QueryString["mobile"];
        md.Fax = Request.QueryString["faxqh"] + "-" + Request.QueryString["faxhm"] + "-" + Request.QueryString["faxfj"];
        md.HomePage = Request.QueryString["webSite"].ToLower().TrimEnd('/');
        md.QQ=Request.QueryString["qq"];
        bl.Update(md);
        Response.Write("<script>alert('保存成功。')</script>");
        Response.End();
    }
}
