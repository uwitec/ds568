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
using System.Web.Script.Serialization;
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
            var probl = new DS_Products_Br();
            var ud = _userData;
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

                //常用系统分类
                Repeater3.DataSource = probl.Query<int>("select syscatid from ds_products where memberid={0} group by syscatid",ud.Member.ID);
                Repeater3.DataBind();
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
                    case "add"://发布产品
                        var product = probl.CreateModel();
                        product.MemberID = ud.Member.ID;
                        product.SysCatID = int.Parse(Request.Form["sysCatID"]);
                        product.ShopCatID = int.Parse(Request.Form["shopCat"]);
                        product.Title = Request.Form["proTitle"];
                        product.Img1 = Request.Form["img00"];
                        product.Img2 = Request.Form["img01"];
                        product.Img3 = Request.Form["img02"];
                        product.Unit=Request.Form["unit"];
                        Type t = product.GetType();
                        for (int i = 1; i <=24; i++)
                        {
                            t.GetProperty("Property" + i).SetValue(product, Request.Form["property" + i], null);
                        }
                        product.Detail=Server.UrlDecode(Request.Form["detail"]);
                        product.PriceRang=Request.Form["priceRang"];
                        if(!string.IsNullOrEmpty(Request.Form["maxNumber"])){
                            product.MaxNumber =int.Parse(Request.Form["maxNumber"]);
                        }
                        product.LowPrice = double.Parse(Request.Form["lowPrice"]);
                        product.HeightPrice = double.Parse(Request.Form["heightPrice"]);
                        product.CreateDate = DateTime.Now;
                        product.ExpiredDate = DateTime.Now.AddDays(int.Parse(Request.Form["expiredDate"]));
                        product.State = (byte)DS_Products_Br.State.待审中;
                        probl.Add(product);
                        Response.Write(true);
                        Response.End();
                        break;
                    case "edit"://修改产品
                        product = probl.GetSingle(int.Parse(Request.Form["id"]));
                        product.SysCatID = int.Parse(Request.Form["sysCatID"]);
                        product.ShopCatID = int.Parse(Request.Form["shopCat"]);
                        product.Title = Request.Form["proTitle"];
                        product.Img1 = Request.Form["img00"];
                        product.Img2 = Request.Form["img01"];
                        product.Img3 = Request.Form["img02"];
                        product.Unit = Request.Form["unit"];
                        t = product.GetType();
                        for (int i = 1; i <= 24; i++)
                        {
                            t.GetProperty("Property" + i).SetValue(product, Request.Form["property" + i], null);
                        }
                        product.Detail = Server.UrlDecode(Request.Form["detail"]);
                        product.PriceRang = Request.Form["priceRang"];
                        if (!string.IsNullOrEmpty(Request.Form["maxNumber"]))
                        {
                            product.MaxNumber = int.Parse(Request.Form["maxNumber"]);
                        }
                        product.LowPrice = double.Parse(Request.Form["lowPrice"]);
                        product.HeightPrice = double.Parse(Request.Form["heightPrice"]);
                        product.CreateDate = DateTime.Now;
                        product.ExpiredDate = DateTime.Now.AddDays(int.Parse(Request.Form["expiredDate"]));
                        product.State = (byte)DS_Products_Br.State.待审中;
                        probl.Update(product);
                        Response.Write(true);
                        Response.End();
                        break;
                    case "json"://返回对象的json数据
                        var json = new JavaScriptSerializer();
                        var promd = probl.GetSingle(int.Parse(Request["ID"]));
                        string js = json.Serialize(promd);
                        Response.ContentType = "application/json";
                        Response.Write(js);
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
                Response.Write("出错了。"+ex.Message);
            Response.End();
        }

    }

  
    class temClass {
        public int id { get; set; }
        public string categoryName { get; set; }
        public int sc { get; set; }
    }
}
