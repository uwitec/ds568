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
public partial class Member_Manage_Offer_Post :  BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new DS_SysProductCategory_Br();
        var prtbl = new DS_Property_Br();
        var prtvbl = new DS_PropertyValue_Br();
        if (string.IsNullOrEmpty(Request["action"]))
        {
            var mst = this.Master as Member_Manage_MasterPage;
            mst.SetMenuTitle("供应管理", "发布供应信息");
            var list = bl.Query<temClass>("select id,categoryName,(select count(id) from DS_SysProductCategory where parentid=c.id) as sc from DS_SysProductCategory c where parentid=0 order by px");
            Repeater1.DataSource = list;
            Repeater1.DataBind();
        }
        else {//如果存在动作
            string act = Request["action"];
            switch (act) { 
                case "subcat"://获取子类目
                    var list = bl.Query<temClass>("select id,categoryName,(select count(id) from DS_SysProductCategory where parentid=c.id) as sc from DS_SysProductCategory c where parentid="+Request.QueryString["pid"]+" order by px");
                    string str = "";
                    foreach (var item in list)
                    {
                        str += "<li cid=\""+item.id+"\" class=\""+(item.sc>0?"hassub":"")+"\">"+item.categoryName+"</li>";
                    }
                    Response.Write(str);
                    Response.End();
                    break;
                case "property"://获取分类属性
                    var prtlist=prtbl.Query("SysCatID="+Request["cid"],"px");
                    var sb = new System.Text.StringBuilder();
                    foreach (var item in prtlist.Where(a => a.Request == true).OrderBy(a => a.Px))
                    {
                        BuildPrt(item.ControlType,item,prtvbl,sb);
                    }
                    foreach (var item in prtlist.Where(a => a.Request == false).OrderBy(a=>a.Px))
                    {
                        BuildPrt(item.ControlType, item, prtvbl, sb);
                    }
                    Response.Write(sb.ToString());
                    Response.End();
                    break;
            }
        }

    }

    private void BuildPrt(byte controlType, Com.DianShi.Model.Product.DS_Property item, DS_PropertyValue_Br prtvbl,System.Text.StringBuilder sb)
    {
        switch (controlType)
        {
            case (byte)DS_Property_Br.ControlType.文本框:
                sb.Append("<div class=\"prtctn overflowAuto\">" +
                    "<div class=\"prtn floatL\">" + (item.Request ? "<span class='red'>*</span>" : "") + item.ProName + "：</div>" +
                    "<div class=\"floatL\">" +
                        "<input class=\"txtbox\" type=\"text\" />"+item.Unit+" </div>" +
                "</div>");
                break;
            case (byte)DS_Property_Br.ControlType.下拉框:
                sb.Append("<div class=\"prtctn overflowAuto\">" +
                    "<div class=\"prtn floatL\">" + (item.Request ? "<span class='red'>*</span>" : "") + item.ProName + "：</div>" +
                    "<div class=\"floatL\">" +
                        "<select>");
                var prtvlist = prtvbl.Query("PropertyID=@0", "px", item.ID);
                foreach (var vitem in prtvlist)
                {
                    sb.Append("<option value=\"" + vitem.PropertyValue + "\">" + vitem.PropertyValue + "</option>");
                }
                sb.Append("</select>" + item.Unit + " </div></div>");
                break;
        }
    }

    class temClass {
        public int id { get; set; }
        public string categoryName { get; set; }
        public int sc { get; set; }
    }
}
