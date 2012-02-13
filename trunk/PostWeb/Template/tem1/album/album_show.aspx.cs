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
public partial class Template_tem1_album_album_show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;
        var bl = new DS_AlbumImg_Br();
        Repeater1.DataSource = bl.Query("albumid=@0","px",int.Parse(Request.QueryString["album_id"]));
        Repeater1.DataBind();
    }
}
