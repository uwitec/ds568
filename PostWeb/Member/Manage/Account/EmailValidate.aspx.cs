﻿using System;
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
public partial class Member_Manage_Account_EmailValidate : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("帐号管理", "邮箱验证");
        //保存事件
        Button1.Click+=new EventHandler(Button1_Click);
        if (IsPostBack) return;
        var bl = new DS_Members_Br();
        if (!string.IsNullOrEmpty(Request.QueryString["action"]))
        {
            string act = Request.QueryString["action"];
            switch (act)
            {
                case "vlemail"://获取邮箱验证码
                    _userData.ValiCode = Common.StringFormat.ValidateCode(6);
                    var emun = new Common.EmailUitility();
                    emun.Title = "点石网邮箱验证！";
                    emun.Content = "您的邮箱验证码是：" + _userData.ValiCode;
                    emun.AddEmailAddress(Request.QueryString["email"]);
                    emun.FromAddress = "\"点石网会员中心\" " + emun.FromAddress;
                    emun.SendEmail();
                    break;
                case "modify"://修改邮箱
                    
                    break;
                case "cancle"://取消验证
                    _userData.Member.EmailValidate = false;
                    bl.Update(_userData.Member);
                    Common.MessageBox.ResponseScript(this, "window.cancelValidate()");
                    break;
            }
        }//没有动作
        else {
            if (_userData.Member.EmailValidate)//如果已验证则显示已验证界面
            {
                cemail.Value = _userData.Member.Email;
                Common.MessageBox.ResponseScript(this, "window.vlsucc();");
            }
        }
    }

    private void Button1_Click(object sender, EventArgs e) {
        try
        {
            string email=Request.Form["email"].Trim();
            string cem=cemail.Value.Trim();
            string valiCode=Request.Form["valiCode"].Trim();
            if (string.IsNullOrEmpty(cem)) {
                Common.MessageBox.Show(this, "尚未获取验证码，请获取后再提交");
                return;
            }
            if (!email.Equals(cem))
            {
                Common.MessageBox.Show(this, "当前邮箱地址与提交验证的邮箱地址不一致，请重新发送验证码再确定");
                return;
            }
            var ud = Session["UserData"] as UserData;
            if (!valiCode.Equals(ud.ValiCode)) {
                Common.MessageBox.Show(this, "验证码输入不正确，请重输");
                return;
            }
            var bl = new DS_Members_Br();
            var md = bl.GetSingle(ud.Member.ID);
            md.Email=Request.Form["email"];
            md.EmailValidate = true;
            bl.Update(md);
            Common.MessageBox.ResponseScript(this, "window.vlsucc();");
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this, "保存出错。");
        }
    }


}
