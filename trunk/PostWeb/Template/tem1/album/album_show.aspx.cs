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
using Com.DianShi.BusinessRules.Member;
public partial class Template_tem1_album_album_show :ShopBasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        int album_id=int.Parse(Request.QueryString["album_id"]);
        int member_id = _vMember.ID;
        var bl = new DS_AlbumImg_Br();
        Repeater1.DataSource = bl.Query("albumid=@0","px",album_id);
        Repeater1.DataBind();
        var albbl = new DS_Album_Br();
        var album = albbl.GetSingle(album_id);
        ViewState["albumName"] = album.AlbumName.Length>6?album.AlbumName.Substring(0,6)+"..":album.AlbumName;
        Repeater2.DataSource = albbl.Query("memberid=@0 and PictureNum>0 and Permissions!=@1", "updatedate desc", member_id, (byte)DS_Album_Br.Permissions.不公开);
        Repeater2.DataBind();
    }
}
