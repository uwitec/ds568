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
public partial class Member_Manage_Account_PwdProtect : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("帐号管理", "密保问题管理");

        //保存事件
        Button1.Click+=new EventHandler(Button1_Click);

        if (IsPostBack) return;
        var ud = Session["UserData"] as UserData;
        var bl = new DS_SafeQuestion_Br();
        Com.DianShi.Model.Member.DS_SafeQuestion md = null;
        bool exists =bl.Exists(ud.Member.ID);
        if (exists)
        {
            md = bl.GetSingleByMemberID(ud.Member.ID);
            ViewState["question"] = md.Question1;
            ViewState["answer"] = md.Answer1;
        }

        //处理动作
        if (!string.IsNullOrEmpty(Request.QueryString["action"]))
        {
            string act = Request.QueryString["action"];
            switch (act)
            {
                case "modify":
                    
                    break;
            }
        }
        else {//没有任何动作时
            if (exists)
            {
                Common.MessageBox.ResponseScript(this, "window.vlsucc()");
            }
        }
    }

    private void Button1_Click(object sender, EventArgs e) {
        try
        {
            string passsafe_question = Request.Form["passsafe_question"].Trim();
            string otherQuestion = Request.Form["otherQuestion"].Trim();
            string answer = Request.Form["answer"].Trim();
            string answer2 = Request.Form["answer2"].Trim();
            if (string.IsNullOrEmpty(passsafe_question)) {
                Common.MessageBox.Show(this, "请选择密保问题", Common.MessageBox.InfoType.warning, "history.back");
                return;
            }
            else if (passsafe_question.Equals("7")) {
                if (string.IsNullOrEmpty(otherQuestion))
                {
                    Common.MessageBox.Show(this, "请输入其他密保问题", Common.MessageBox.InfoType.warning, "history.back");
                    return;
                }
                else
                    passsafe_question = otherQuestion;
            }
            if (string.IsNullOrEmpty(answer)) {
                Common.MessageBox.Show(this, "请输入问题答案", Common.MessageBox.InfoType.warning, "history.back");
                return;
            }
            if (string.IsNullOrEmpty(answer2))
            {
                Common.MessageBox.Show(this, "请输入确认问题答案", Common.MessageBox.InfoType.warning, "history.back");
                return;
            }

            var ud = Session["UserData"] as UserData;
            var bl = new DS_SafeQuestion_Br();
            var md = bl.CreateModel();
            md.MemberID = ud.Member.ID;
            md.Question1 = passsafe_question;
            md.Answer1 = answer;
            bl.InsertOrUpdate(md);

            Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info, "history.back");
            
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this, "保存出错", Common.MessageBox.InfoType.error, "history.back");
        }
    }
}
