using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Transaction;
public partial class Order_Action : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string act=Request["action"];
        switch(act){
            case "add_num":
                var bl = new DS_Cart();
                bl.Add();
                break;
        }
    }
}
