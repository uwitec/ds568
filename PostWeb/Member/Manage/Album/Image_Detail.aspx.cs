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
using Com.DianShi.BusinessRules.Album;
public partial class Member_Manage_Album_Image_Detail : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_AlbumImg_Br();
        var albbl = new DS_Album_Br();
        
        if (IsPostBack) return;
        //处理ajax动作
        string act=Request.Form["action"];
        if (!string.IsNullOrEmpty(act)) {
            var json = new JavaScriptSerializer();
            switch (act) { 
                case "loadimgdata":
                    Response.Write(json.Serialize(bl.GetSingle(int.Parse(Request.Form["img_id"]))));
                    break;
                case "save":
                    var img= bl.GetSingle(int.Parse(Request.Form["img_id"]));
                    img.ImgTitle=Request.Form["title"].Trim();
                    img.ImgDescript=Request.Form["des"].Trim();
                    bl.Update(img);
                    break;
            }
            Response.End();
            return;
        }

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("图片管家", "相册管理");

        var md=bl.GetSingle(int.Parse(Request.QueryString["img_id"]));
        var album = albbl.GetSingle(md.AlbumID);
        ViewState["albname"] = album.AlbumName;
        ViewState["albid"] = album.ID;
        ViewState["imgtitle"] = md.ImgTitle;
        ViewState["imgurl"] ="/Resource/"+ md.ImgUrl + "/" + md.ImgName;

        //绑定图片
        Repeater1.DataSource = bl.Query("albumid=@0","px",md.AlbumID);
        Repeater1.DataBind();
    }
}
