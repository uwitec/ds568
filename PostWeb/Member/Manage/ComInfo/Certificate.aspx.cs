using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Member;
public partial class Member_Manage_ComInfo_Certificate : BasePage
{
    public string tempPath;
    public int rc = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string act = Request["action"];
        if (!string.IsNullOrEmpty(act))
        {
            var bl = new DS_Certificate_Br();
            switch (act)
            {
                case "pager":
                    int pageIndex = int.Parse(Request.Form["pageIndex"]), pageSize = int.Parse(Request.Form["pageSize"]);
                    Repeater2.DataSource = bl.Query("memberid=@0 and CtfType=@1", "id desc", (pageIndex - 1) * pageSize, pageSize, ref rc, _userData.Member.ID, int.Parse(Request["showType"]));
                    Repeater2.DataBind();
                    break;
            }
            return;
        }

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "公司证书");

        bindMenu();
    }

    private void bindMenu()
    {
        var vs = Enum.GetValues(typeof(DS_Certificate_Br.CtfType));
        Repeater1.DataSource = vs;
        Repeater1.DataBind();

        if (string.IsNullOrEmpty(Request["show_type"]) || vs.Cast<DS_Certificate_Br.CtfType>().Where(a => ((byte)a).ToString().Equals(Request["show_type"])).Count().Equals(0))
        {
            Response.Redirect("Certificate.aspx?show_type=" + (byte)DS_Certificate_Br.CtfType.税务登记证);
        }
       
    }
}
