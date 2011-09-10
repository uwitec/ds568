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
public partial class Member_Login_login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton1.Click+=new EventHandler(LinkButton1_Click);
    }

    private void LinkButton1_Click(object sender, EventArgs e) {
        //try
        //{
            string uid=Request.Form["uid"] as string;
            string pwd=Request.Form["pwd"] as string;
            if (string.IsNullOrEmpty(uid)||string.IsNullOrEmpty(pwd)) { 
                Common.MessageBox.Show(this,"请输入会员登录名和密码",Common.MessageBox.InfoType.warning,"history.back");
                return;
            }
            var bl = new DS_Members_Br();
            var md = bl.CreateModel();
            md.UserID = uid;
            md.Password = pwd;
            if (bl.Login(ref md))
            {
                Session["UserData"] = new UserData { Member=md };
                Response.Redirect(Resources.Constant.ManagePage);
            }
            else {
                Common.MessageBox.Show(this,"用户名或密码错误",Common.MessageBox.InfoType.warning,"history.back");
            }
            
        //}
        //catch (Exception ex) {
        //    Common.MessageBox.Show(this, "抱歉，登录发生意外，可联系客服人员寻找帮助", Common.MessageBox.InfoType.error, "history.back");
        //}
    }
}
