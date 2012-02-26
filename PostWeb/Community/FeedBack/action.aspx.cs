using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Community;
public partial class Community_FeedBack_action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "sendmsg":
                    if (Session["CheckCode"] == null || Session["CheckCode"].ToString().ToLower() != Request.QueryString["valcode"].ToLower())
                    {
                        Response.Write("验证码输入错误");
                        return;
                    }
                    var bl = new DS_Message_Br();
                    var md = bl.CreateModel();
                    md.Title=Request.QueryString["title"];
                    md.Content = Request.QueryString["content"];
                    md.MemberID=int.Parse(Request.QueryString["member_id"]);
                    md.ClientEmail = Request.QueryString["emailUid"] + "@" + Request.QueryString["emailCom"];
                    md.ClientCompany = Request.QueryString["companyName"];
                    md.ClientPhone = Request.QueryString["phoneArea"] + "-" + Request.QueryString["phoneNumber"];
                    md.ClientMobile=Request.QueryString["mobile"];
                    md.IsView = false;
                    md.MsgType = (byte)DS_Message_Br.MsgType.留言互动;
                    md.CreateDate = DateTime.Now;
                    bl.Add(md);
                    break;
            }
        }
    }
}