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
using Com.DianShi.BusinessRules.Product;

public partial class DSAdmin_UserControl_ProCategory : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DropDownList1.SelectedIndexChanged+=new EventHandler(DropDownList1_SelectedIndexChanged);
        DropDownList2.SelectedIndexChanged += new EventHandler(DropDownList2_SelectedIndexChanged);
        if (IsPostBack) return;
        var bl = new DS_SysProductCategory_Br();
        DropDownList1.DataSource = bl.Query("parentid=0","px");
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, new ListItem("--一级类--", "0"));
        for (int i = 1; i <= ShowLevel; i++)
        {
            this.FindControl("DropDownList"+i).Visible=true;
        }

        //还原类别状态
        if (ViewState["CurrentCategoryID"]!=null && !ViewState["CurrentCategoryID"].ToString().Equals("0"))
        {
            int ccatid = (int)ViewState["CurrentCategoryID"];
            var md = bl.GetSingle(ccatid);
            if (!md.ParentID.Equals(0))
            {
                var md2 = bl.GetSingle(md.ParentID);
                if (md2.ParentID.Equals(0))
                {
                    var item = Dropdown_1.Items.FindByValue(md.ParentID.ToString());
                    Dropdown_1.SelectedItem.Selected = false;
                    item.Selected = true;
                    DropDownList1_SelectedIndexChanged(null, null);
                }
                else {
                    var item = Dropdown_1.Items.FindByValue(md2.ParentID.ToString());
                    Dropdown_1.SelectedItem.Selected = false;
                    item.Selected = true;
                    DropDownList1_SelectedIndexChanged(null, null);

                    item = Dropdown_2.Items.FindByValue(md.ParentID.ToString());
                    Dropdown_2.SelectedItem.Selected = false;
                    item.Selected = true;
                }
            }
        }
    }

    private void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var bl = new DS_SysProductCategory_Br();
        if (DropDownList1.SelectedValue.Equals("0"))
        {
            DropDownList2.Items.Clear();
        }
        else
        {
            DropDownList2.DataSource = bl.Query("parentid=" + DropDownList1.SelectedValue, "px");
            DropDownList2.DataBind();
        }

        DropDownList2.Items.Insert(0, new ListItem("--二级类--", "0"));
        DropDownList3.Items.Clear();
        DropDownList3.Items.Insert(0, new ListItem("--三级类--", "0"));
    }

    private void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        var bl = new DS_SysProductCategory_Br();
        if (DropDownList2.SelectedValue.Equals("0"))
        {
            DropDownList3.Items.Clear();
        }
        else
        {
            DropDownList3.DataSource = bl.Query("parentid=" + DropDownList2.SelectedValue, "px");
            DropDownList3.DataBind();
        }

        DropDownList3.Items.Insert(0, new ListItem("--三级类--", "0"));
    }

    public void BindEvent(EventHandler eh, int Level) {
        switch (Level) { 
            case 1:
                DropDownList1.SelectedIndexChanged += eh;
                break;
            case 2:
                DropDownList2.SelectedIndexChanged += eh;
                break;
            case 3:
                DropDownList3.SelectedIndexChanged += eh;
                DropDownList3.AutoPostBack = true;
                break;
        }
    }

    public int CategoryID_1 { get { return int.Parse(DropDownList1.SelectedValue); } }
    public int CategoryID_2 { get { return int.Parse(DropDownList2.SelectedValue); } }
    public int CategoryID_3 { get { return int.Parse(DropDownList3.SelectedValue); } }

    public int ShowLevel { get { return ViewState["slevel"] == null ? 3 : (int)ViewState["slevel"]; } set { ViewState["slevel"] = value; } }

    public DropDownList Dropdown_1 { get { return DropDownList1; } }
    public DropDownList Dropdown_2 { get { return DropDownList2; } }
    public DropDownList Dropdown_3 { get { return DropDownList3; } }

    public int CurrentCategoryID { 
        get {
            if (Dropdown_3.SelectedIndex > 0)
                return int.Parse(Dropdown_3.SelectedValue);
            else if (Dropdown_2.SelectedIndex > 0)
                return int.Parse(Dropdown_2.SelectedValue);
            else if (Dropdown_1.SelectedIndex > 0)
                return int.Parse(Dropdown_1.SelectedValue);
            else
                return 0;
        }
        set {
            ViewState["CurrentCategoryID"] = value;
        }
    }
}
