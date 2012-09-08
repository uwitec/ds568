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
    public string phoneqh, phonehm, phonefj, faxqh, faxhm, faxfj;
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
            var mb = _userData.vMember;
            string[] phone = mb.Phone.Split('-');
            if (phone.Length > 2)
            {
                phoneqh = phone[0];
                phonehm = phone[1];
                phonefj = phone[2];
            }
           
            if (!string.IsNullOrEmpty(mb.Fax))
            {
                string[] fax = mb.Fax.Split('-');
                if (fax.Length > 2)
                {
                    faxqh = fax[0];
                    faxhm = fax[1];
                    faxfj = fax[2];
                }
            }
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Page_Load",ex.Message);
            Common.MessageBox.Show(this,"获取数据出错",Common.MessageBox.InfoType.error,"history.back");
        }
    }

    private void save() {
        var bl = new DS_Members_Br();
        var md = _userData.Member;
        md.Email = _userData.vMember.Email=Request["email"];
        md.TrueName = _userData.vMember.TrueName=Request["trueName"];
        md.Gender = _userData.vMember.Gender=Request["sex"];
        md.Position = _userData.vMember.Position=Request["position"];
        md.Phone =_userData.vMember.Phone= Request["phoneqh"] + "-" + Request["phonehm"] + "-" + Request["phonefj"];
        md.Mobile = _userData.vMember.Mobile=Request["mobile"];
        md.Fax =_userData.vMember.Fax= Request["faxqh"] + "-" + Request["faxhm"] + "-" + Request["faxfj"];
        md.HomePage =_userData.vMember.HomePage= Request["webSite"].ToLower().TrimEnd('/');
        md.QQ = _userData.vMember.QQ=Request["qq"];
        bl.Update(md);
        Response.Write(Common.JSONHelper.ObjectToJSON(new {succ=true }));
        Response.End();
    }
}
