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
public partial class Member_Manage_Account_Password : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("帐号管理", "修改密码");

        //保存事件
        Button1.Click+=new EventHandler(Button1_Click);

        if (IsPostBack) return;
    }

    private void Button1_Click(object sender, EventArgs e) {
        try
        {
            var ud = Session["UserData"] as UserData;
            var bl = new DS_Members_Br();
            string msg = "";
            if (bl.ChangePwd(ud.Member.ID, Request.Form["pwd"], Request.Form["npwd"], ref msg))
            {
                ud.Member= bl.GetSingle(ud.Member.ID);
                Common.MessageBox.Show(this, "保存成功", Common.MessageBox.InfoType.info);
            }
            else
                Common.MessageBox.Show(this, msg, Common.MessageBox.InfoType.info);
        }
        catch (Exception ex) {
            Common.WriteLog.SetErrLog(Request.Url.ToString(), "Button1_Click", ex.Message);
            Common.MessageBox.Show(this, "保存出错", Common.MessageBox.InfoType.error, "history.back");
        }
    }
}
