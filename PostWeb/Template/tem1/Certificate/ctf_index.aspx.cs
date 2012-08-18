using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Member;
public partial class Template_tem1_Certificate_ctf_index : ShopBasePage
{
    public string ctfdir = "";
    DS_Certificate_Br bl = new DS_Certificate_Br();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        Repeater1.ItemDataBound+=new RepeaterItemEventHandler(Repeater1_ItemDataBound);
        ctfdir = Common.Constant.WebConfig("AlbumRootPath") + DS_Members_Br.GetMemberDir(_vMember.ID) + "/Certificate/";
        Repeater1.DataSource = Enum.GetValues(typeof(DS_Certificate_Br.CtfType));
        Repeater1.DataBind();
    }

    private void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e) {
        var rp = e.Item.FindControl("Repeater2") as Repeater;
        rp.DataSource = bl.Query("memberid=@0 and ctftype=@1","",_vMember.ID,(byte)e.Item.DataItem);
        rp.DataBind();
    }
}
