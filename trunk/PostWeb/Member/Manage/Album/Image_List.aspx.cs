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
using Com.DianShi.BusinessRules.Album;
public partial class Member_Manage_Album_Image_List : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_AlbumImg_Br();
        var albbl = new DS_Album_Br();
        int rc = 0;
        int pagesize = 16;
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "chgPage":
                    Repeater4.DataSource = bl.Query("AlbumID=@0", "", (int.Parse(Request["pgind"]) - 1) * pagesize, pagesize, ref rc, int.Parse(Request.QueryString["id"]));
                    Repeater4.DataBind();
                    break;
                case "setcovert":
                    var album = albbl.GetSingle(int.Parse(Request.Form["albumid"]));
                    album.FrontCover=Request.Form["src"];
                    albbl.Update(album);
                    Response.End();
                    break;
                case "del":
                    //try
                    //{
                        bl.Delete(Request.Form["id"].TrimEnd(','));
                        rc = bl.Query("AlbumID=@0", "", int.Parse(Request.Form["albumid"])).Count();
                        Response.Write((rc % pagesize).Equals(0) ? rc / pagesize : rc / pagesize + 1);
                        Response.End();
                    //}
                    //catch (System.Threading.ThreadAbortException ex)
                    //{

                    //}
                    //catch (Exception ex)
                    //{
                    //    if (ex.Message.Contains("FK_DS_AlbumImg_DS_Album"))
                    //    {
                    //        Response.Write("当前相册包含有图片，必须将图片删除或转移到其他相册后才能删除。");
                    //    }
                    //    else
                    //        Response.Write("删除图片出错。" + ex.Message);
                    //    Response.End();
                    //}
                    break;
               
            }
            return;
        }

        if (IsPostBack) return;

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("图片管家", "相册管理");

        //绑定访问权限
        Repeater2.DataSource = Enum.GetValues(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions));
        Repeater2.DataBind();

        //绑定当前相册属性
        var alb= albbl.Query("id=@0", "",int.Parse(Request.QueryString["id"]));
        Repeater3.DataSource =alb;
        Repeater3.DataBind();
        ViewState["albname"] = alb.Single().AlbumName;

        //绑定图片列表
        Repeater4.DataSource = bl.Query("AlbumID=@0", "", 0, pagesize, ref rc, int.Parse(Request.QueryString["id"]));
        Repeater4.DataBind();
        ViewState["pageCount"] = (rc % pagesize).Equals(0) ? rc / pagesize : rc / pagesize + 1;
        ViewState["rc"] = rc;
    }
}
