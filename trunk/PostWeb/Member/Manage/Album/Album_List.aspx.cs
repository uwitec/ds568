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
using Com.DianShi.BusinessRules.Album;
public partial class Member_Manage_Album_Album_List : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_Album_Br();
        int rc = 0;
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "chgPage":
                    Repeater1.DataSource = bl.Query("memberid=@0", "createdate desc", (int.Parse(Request["pgind"])-1)*2, 2, ref rc, _userData.Member.ID);
                    Repeater1.DataBind();
                    break;
            }
            return;
        }

        if (IsPostBack) return;

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("图片管家", "相册管理");

        Repeater1.DataSource = bl.Query("memberid=@0","createdate desc",0,2,ref rc, _userData.Member.ID);
        Repeater1.DataBind();
        ViewState["pageCount"] = (rc%2).Equals(0)?rc/2:rc/2+1;
    }
}
