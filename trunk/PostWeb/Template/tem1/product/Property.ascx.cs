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

public partial class Template_tem1_product_Property : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (Product != null)
        {
            var bl = new DS_Property_Br();
            var list = bl.Query("SysCatID=@0", "px", Product.SysCatID);
            Type t = Product.GetType();
            int PryCount = 0;
            foreach (var item in list)
            {
                object obj =t.GetProperty("Property" + item.MapID).GetValue(Product,null);
                if (obj != null&&!string.IsNullOrEmpty(obj.ToString().Trim())) {
                    AddItem(item.ProName,obj.ToString()+item.Unit);//添加一项属性
                    PryCount++;
                }
            }
            if(PryCount%2>0)//如果有效属性个数为单数，则最后要多添加一个空属性
                AddItem("","");   

        }
    }

    public Com.DianShi.Model.Product.DS_Products Product { get; set; }

    private void AddItem(string prtName, string val) {
        var tr = new HtmlTableRow();
        var td=new HtmlTableCell();
        int rc=tbprt.Rows.Count;
        if (rc > 0)//如果存在行
        {
            if (tbprt.Rows[rc - 1].Cells.Count == 4)//如果最后行已满
            {
                
                tbprt.Rows.Add(tr);//直接添加一个新行
            }
            else
            {
                tr = tbprt.Rows[rc - 1];//将tr设为最后的行
            }
        }
        else {//如果还没有行
            tbprt.Rows.Add(tr);
        }
        td.InnerText = prtName;
        td.Attributes["class"] = "fieldHead";
        tr.Cells.Add(td);
        td = new HtmlTableCell();
        td.InnerText = val;
        tr.Cells.Add(td);
        
    }
}
