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
public partial class Js_Map_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "setmap":
                    var mbbl = new DS_CompanyInfo_Br();
                    var member = mbbl.GetSingleByMemberID(int.Parse(Request.Form["memberID"]));
                    member.MapNid=Request.Form["mapNid"];
                    mbbl.Update(member);
                    break;
            }
        }
    }
}
