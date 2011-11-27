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
        try
        {
            var bl = new DS_SysProductCategory_Br();
            var prtbl = new DS_Property_Br();
            var diybl = new DS_DiyProCategory_Br();
            var ud = Session["UserData"] as UserData;
            if (string.IsNullOrEmpty(Request["action"]))
            {
                var mst = this.Master as Member_Manage_MasterPage;
                mst.SetMenuTitle("供应管理", "发布供应信息");
                
                var list = bl.Query<temClass>("select id,categoryName,(select count(id) from DS_SysProductCategory where parentid=c.id) as sc from DS_SysProductCategory c where parentid=0 order by px");
                Repeater1.DataSource = list;
                Repeater1.DataBind();

                //自定义分类
                Repeater2.DataSource = diybl.Query("MemberID=@0","px",ud.Member.ID);
                Repeater2.DataBind();
            }
            else
            {//如果存在动作
                string act = Request["action"];
                switch (act)
                {
                    case "subcat"://获取子类目
                        var list = bl.Query<temClass>("select id,categoryName,(select count(id) from DS_SysProductCategory where parentid=c.id) as sc from DS_SysProductCategory c where parentid=" + Request.QueryString["pid"] + " order by px");
                        string str = "";
                        foreach (var item in list)
                        {
                            str += "<li cid=\"" + item.id + "\" class=\"" + (item.sc > 0 ? "hassub" : "") + "\">" + item.categoryName + "</li>";
                        }
                        Response.Write(str);
                        Response.End();
                        break;
                    case "property"://获取分类属性
                        Response.Write(prtbl.GetControlList(int.Parse(Request["cid"])));
                        Response.End();
                        break;
                    case "addcat":
                        var md = diybl.CreateModel();
                        md.CategoryName = Request.QueryString["catname"];
                        md.Px = 0;
                        md.MemberID = ud.Member.ID;
                        diybl.Add(md);
                        diybl.Sort(md.ID, true);
                        Response.Write("id=" + md.ID);
                        Response.End();
                        break;
                    case "add":
                        
                        Response.Write("发布成功。");
                        Response.End();
                        break;
                }
            }
        }catch(System.Threading.ThreadAbortException ex){

        }
        catch (Exception ex)
        {
            if (ex.Message.Contains("IX_DS_DiyProCategory"))
            {
                Response.Write("已存在相同名称的分类。");
            }
            else
                Response.Write("创建分类出错。");
            Response.End();
        }

    }

  
    class temClass {
        public int id { get; set; }
        public string categoryName { get; set; }
        public int sc { get; set; }
    }
}
