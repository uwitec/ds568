using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Template_tem1_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act = Request["action"];
        if (!string.IsNullOrEmpty(act))
        {
            switch (act)
            {
                case "chkLogin":
                    var ud = Session["UserData"] as UserData;
                    if (UserData.ChkObjNull(UserData.ObjType.会员信息))
                    {
                        Response.Write(ud.Member.UserID);
                    }
                    Response.End();
                    break;
            }
            return;
        }
    }
}
