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
        var bl = new DS_Album_Br();
        int rc = 0;
        int pagesize = 20;
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "chgPage":
                    Repeater1.DataSource = bl.Query("memberid=@0", "createdate desc", (int.Parse(Request["pgind"])-1)*20, 20, ref rc, _userData.Member.ID);
                    Repeater1.DataBind();
                    break;
                case "del":
                    try
                    {
                        bl.Delete(int.Parse(Request.Form["aid"]));
                        rc = bl.Query("memberid=@0", "", _userData.Member.ID).Count();
                        Response.Write((rc % 20).Equals(0) ? rc / 20 : rc / 20 + 1);
                        Response.End();
                    }
                    catch (System.Threading.ThreadAbortException ex)
                    {

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("FK_DS_AlbumImg_DS_Album"))
                        {
                            Response.Write("当前相册包含有图片，必须将图片删除或转移到其他相册后才能删除。");
                        }
                        else
                            Response.Write("删除相册出错。");
                        Response.End();
                    }
                    break;
                case "editAlbum":
                    try
                    {
                        var album=bl.GetSingle(int.Parse(Request.Form["id"]));
                        album.AlbumName = Request["albumName"].Trim();
                        album.Permissions = byte.Parse(Request.Form["pm"]);
                        album.Password = Request.Form["pwd"].Trim();
                        bl.Update(album);
                        Response.Write(1);
                        Response.End();
                    }
                    catch (System.Threading.ThreadAbortException ex){}
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("IX_DS_Album")) {
                            Response.Write("已存在相同名称的相册。");
                        }
                        else
                            Response.Write("修改相册出错。" );
                        Response.End();
                    }
                    break;
            }
            return;
        }

        if (IsPostBack) return;

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("图片管家", "相册管理");

        Repeater1.DataSource = bl.Query("memberid=@0","createdate desc",0,20,ref rc, _userData.Member.ID);
        Repeater1.DataBind();
        ViewState["pageCount"] = (rc%20).Equals(0)?rc/20:rc/20+1;
        ViewState["rc"] = rc;

        //绑定访问权限
        Repeater2.DataSource = Enum.GetValues(typeof(Com.DianShi.BusinessRules.Album.DS_Album_Br.Permissions));
        Repeater2.DataBind();

        //绑定当前相册属性
        var alb= bl.Query("id=@0", "",int.Parse(Request.QueryString["id"]));
        Repeater3.DataSource =alb;
        Repeater3.DataBind();
        ViewState["albname"] = alb.Single().AlbumName;
    }
}
