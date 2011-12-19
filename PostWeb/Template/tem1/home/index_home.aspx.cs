using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using Com.DianShi.BusinessRules.Member;
using Com.DianShi.BusinessRules.Product;
public partial class index_home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var mbbl = new DS_CompanyInfo_Br();
        try
        {
            if (!string.IsNullOrEmpty(Request["action"]))
            {
                string act = Request["action"];
                switch (act)
                {
                    case "cominfo":
                        var member = mbbl.GetSingleByMemberID(int.Parse(Request.QueryString["memberid"]));
                        Response.Write(member.Profile+"^"+member.ComImg.Split('|')[0]);//返回公司简介及第一张企业图片
                        Response.End();
                        break;
                }
                return;
            }
        }
        catch (System.Threading.ThreadAbortException ex) { }

        if (IsPostBack) return;


        var pbl = new DS_Products_Br();
        //最新产品
        int rc = 0;
        var list = pbl.Query("memberid=@0", "createdate desc",0,8,ref rc, int.Parse(Request.QueryString["member_id"]));
        Repeater1.DataSource = list;
        Repeater1.DataBind();

        //精品推荐
        Repeater2.DataSource = list.Take(4);
        Repeater2.DataBind();
    }
}

