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
using Com.DianShi.BusinessRules.Community;
public partial class Member_Manage_Message_MessageCenter : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            var bl = new DS_Message_Br();
            switch (act) { 
                case "pager":
                    bindData(Request.Form["pageIndex"],Request.Form["pageSize"], Request.Form["tid"]);
                    break;
                case "getdetail":
                    var md = bl.GetSingle(int.Parse(Request.QueryString["id"]));
                    md.IsView = true;
                    bl.Update(md);
                    Response.Write("<h2>"+md.Title+"</h2>"+"<br>"+md.Content);
                    Response.End();
                    break;
                case "del":
                    bl.Delete(Request.Form["ids"]);
                    Response.End();
                    break;
            }
            return;
        }

        if (IsPostBack) return;
        Repeater1.DataSource= Enum.GetValues(typeof(DS_Message_Br.MsgType));
        Repeater1.DataBind();
        ViewState["ps"] =10;
        bindData(null,ViewState["ps"].ToString(),Request.QueryString["tid"]);

    }

    private void bindData(string pageIndex, string pageSize, string tid)
    {
        var bl = new DS_Message_Br();
        int rc = 0;
        string sql = "memberid=" + _userData.Member.ID;
        if (!string.IsNullOrEmpty(tid))
        {
            sql += " and msgtype=" + tid;
        }
        int ps = int.Parse(pageSize);
        if (!string.IsNullOrEmpty(pageIndex))
        {
            int pindex = int.Parse(pageIndex);
            Repeater2.DataSource = bl.Query(sql, "createdate desc", (pindex - 1) * ps, ps, ref rc);
            Repeater2.DataBind();
        }
        else
        {
            rc = bl.Query(sql,"").Count();
            ViewState["pc"] = rc;
             
        }
    }
}
