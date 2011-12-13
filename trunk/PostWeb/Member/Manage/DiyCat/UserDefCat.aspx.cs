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
public partial class Member_Manage_DiyCat_UserDefCat : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var ud = Session["UserData"] as UserData;
        var bl = new DS_DiyProCategory_Br();
        //处理ajax事件
        if (!string.IsNullOrEmpty(Request.Form["action"])) {
            string act = Request.Form["action"];
            switch (act) { 
                case "add":
                    try
                    {
                        var md = bl.CreateModel();
                        md.CategoryName = Request.Form["catname"];
                        md.MemberID = ud.Member.ID;
                        md.Px =0;
                        bl.Add(md);
                        bl.Sort(md.ID, true);
                    }
                    catch (System.Threading.ThreadAbortException ae) { }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("IX_DS_DiyProCategory"))
                        {
                            throw new Exception("已存在相同分类。");
                        }
                        else {
                            throw new Exception("添加分类出错。");
                        }
                    }
                    break;
                case "del":
                    try
                    {
                        bl.Delete(int.Parse(Request.Form["cid"]));
                    }
                    catch (System.Threading.ThreadAbortException ae) { }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("FK_DS_Products_DS_DiyProCategory"))
                        {
                            throw new Exception("存在与当前分类相关的产品，必须先删除该分类的产品才能删除此分类。");
                        }
                        else
                        {
                            throw new Exception("删除分类出错。");
                        }
                    }
                    break;
            }
        }
        if (IsPostBack) return;
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("供应管理", "产品自定义分类");

        Repeater1.DataSource = bl.Query("memberid=@0","px",ud.Member.ID);
        Repeater1.DataBind();
    }
}
