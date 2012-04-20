using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Sys;
public partial class DSAdmin_Area_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_Area_Br();
        string act=Request["action"];
        switch (act) { 
            case "add":
                var md = bl.CreateModel();
                md.ParentID = int.Parse(Request.Form["parentid"]);
                md.AreaName=Request.Form["an"];
                md.Px = 0;
                bl.Add(md);
                bl.Sort(md.ID,true);
                break;
            case "edit":
                md = bl.GetSingle(int.Parse(Request.Form["id"]));
                md.AreaName = Request.Form["an"];
                bl.Update(md);
                break;
        }
    }
}
