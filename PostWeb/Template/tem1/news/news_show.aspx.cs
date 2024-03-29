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
using Com.DianShi.BusinessRules.News;
using Com.DianShi.BusinessRules.Member;
public partial class Template_tem1_news_news_show : ShopBasePage
{
    public int replyNum = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
            var bl = new DS_ComNews_Br();
            var ud=Session["UserData"] as UserData;
            if (UserData.ChkObjNull(UserData.ObjType.会员信息)&&ud.Member.ID == _vMember.ID){
                ViewState["isLogin"] ="1";
            }
            else
                ViewState["isLogin"] = "0";
            string act = Request["action"];
            if (!string.IsNullOrEmpty(act)) {
                switch (act) { 
                    case "chklogin":
                        Response.Write(UserData.ChkObjNull(UserData.ObjType.会员信息) ? "1" : "0");
                        Response.End();
                        break;
                    case "login":
                        var mbbl = new DS_Members_Br();
                        var mb = mbbl.CreateModel();
                        mb.UserID = Request.Form["uid"].Trim();
                        mb.Password = Request.Form["pwd"].Trim();
                        if (mbbl.Login(ref mb))
                        {
                            if (UserData.ChkObjNull(UserData.ObjType.会员信息)) {
                                ud.Member = mb;
                            }else
                                Session["UserData"] = new UserData { Member = mb };
                            Response.Write("1");
                        }
                        else
                        {
                            Response.Write("用户名或密码错误");
                        }
                        Response.End();
                        break;
                    case "comment":
                        var news = bl.CreateModel();
                        news.Title = "";
                        news.ParentID = int.Parse(Request.Form["parent_id"]);
                        news.Content=Request.Form["content"];
                        news.Hits = news.Px = news.Coment = 0;
                        news.MemberID = ud.Member.ID;
                        news.UpdateDate = news.CreateDate = DateTime.Now;
                        news.Ip = Request.UserHostAddress;
                        bl.Comment(news);
                        var reply = bl.QueryView("parentid=@0", "createdate desc", int.Parse(Request.Form["parent_id"]));
                        replyNum = reply.Count();
                        Repeater2.DataSource = reply;
                        Repeater2.DataBind();
                        break;
                    case "del":
                        ud = Session["UserData"] as UserData;
                        if (UserData.ChkObjNull(UserData.ObjType.会员信息))
                        {
                            bl.Delete(int.Parse(Request.Form["id"]));
                            Response.Write(1);
                        }
                        else {
                            Response.Write(0);
                        }
                        Response.End();
                        break;
                    case "del_all":
                        ud = Session["UserData"] as UserData;
                        if (UserData.ChkObjNull(UserData.ObjType.会员信息))
                        {
                            bl.Delete(Request.Form["ids"]);
                            Response.Write(1);
                        }
                        else
                        {
                            Response.Write(0);
                        }
                        Response.End();
                        break;
                }
                return;
            }

            if(IsPostBack) return;
            var list = bl.Query("id=@0","",int.Parse(Request.QueryString["news_id"]));
            var md = list.Single();
            md.Hits++;
            bl.Update(md);
            title = md.Title;
            Repeater1.DataSource = list;
            Repeater1.DataBind();

            var list2 = bl.QueryView("parentid=@0","createdate desc",md.ID);
            replyNum = list2.Count();
            Repeater2.DataSource = list2;
            Repeater2.DataBind();
 
        //}
        //catch {
        //    Response.End();
        //}
    }
}
