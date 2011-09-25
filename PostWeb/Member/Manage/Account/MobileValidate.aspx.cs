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
public partial class Member_Manage_Account_MobileValidate : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("帐号管理", "手机验证");

        //保存事件
        Button1.Click+=new EventHandler(Button1_Click);

        if (IsPostBack) return;
        var ud = Session["UserData"] as UserData;
        var bl = new DS_Members_Br();
        Com.DianShi.Model.Member.DS_Members md = null ;
        try
        {
            md= bl.GetSingle(ud.Member.ID);
            ViewState["Mobile"] = md.Mobile;
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Page_Load",ex.Message);
            Common.MessageBox.Show(this,"获取数据出错",Common.MessageBox.InfoType.error,"history.back");
        }


        if (!string.IsNullOrEmpty(Request.QueryString["action"]))
        {
            string act = Request.QueryString["action"];
            switch (act)
            {
                case "vlmobile"://获取手机验证码
                    var vcbl = new DS_ValiCodeSend_Br();
                    if (vcbl.SendEnable(ud.Member.ID))
                    {
                        ud.ValiCode = Common.StringFormat.ValidateCode(6);
                        var ws = new WebService.SMS.Service1();
                        //ws.SendMessages(Common.Constant.WebConfig("SMSAccount"), Common.Constant.WebConfig("SMSPassword"), Request.QueryString["mobile"], "您的手机验证码是：" + ud.ValiCode + "(点石网)", "");
                    }
                    else {
                        Response.Write("false");
                        Response.End();
                    }

                    break;
                case "modify"://修改手机
                    
                    break;
                case "cancle"://取消验证
                    md.MobileValidate = false;
                    bl.Update(md);
                    Common.MessageBox.ResponseScript(this, "window.cancelValidate()");
                    break;
            }
        }//没有动作
        else {
            if (md.MobileValidate)//如果已验证则显示已验证界面
            {
                cmobile.Value = md.Mobile;
                Common.MessageBox.ResponseScript(this, "window.vlsucc();");
            }
        }
    }

    private void Button1_Click(object sender, EventArgs e) {
        try
        {
            string mobile = Request.Form["mobile"].Trim();
            string cem=cmobile.Value.Trim();
            string valiCode=Request.Form["valiCode"].Trim();
            if (string.IsNullOrEmpty(cem)) {
                Common.MessageBox.Show(this, "尚未获取验证码，请获取后再提交", Common.MessageBox.InfoType.warning,"history.back");
                return;
            }
            if (!mobile.Equals(cem))
            {
                Common.MessageBox.Show(this, "当前手机号码与提交验证的手机号码不一致，请重新发送验证码再确定", Common.MessageBox.InfoType.warning, "history.back");
                return;
            }
            var ud = Session["UserData"] as UserData;
            if (!valiCode.Equals(ud.ValiCode)) {
                Common.MessageBox.Show(this, "验证码输入不正确，请重输", Common.MessageBox.InfoType.warning, "history.back");
                return;
            }
            var bl = new DS_Members_Br();
            var md = bl.GetSingle(ud.Member.ID);
            md.Mobile=Request.Form["mobile"];
            md.MobileValidate = true;
            bl.Update(md);
            Common.MessageBox.ResponseScript(this, "window.vlsucc();");
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this, "保存出错", Common.MessageBox.InfoType.error, "history.back");
        }
    }

   

}
