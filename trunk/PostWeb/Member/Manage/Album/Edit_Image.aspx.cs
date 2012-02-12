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
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Com.DianShi.BusinessRules.Album;
public partial class Member_Manage_Album_Edit_Image :BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var bl = new DS_AlbumImg_Br();
        string act=Request["action"];
        if (!string.IsNullOrEmpty(act))
        {
            switch (act)
            {
                case "edit":
                    var json = new JavaScriptSerializer();
                    //Response.Write(Request.Form["imglist"]);
                    var imglist = json.Deserialize<List<img>>(Request.Form["imglist"]);
                    foreach (var item in imglist)
                    {
                        var md = bl.GetSingle(item.ID);
                        md.ImgTitle = Server.UrlDecode(item.Title);
                        md.ImgDescript = Server.UrlDecode(item.Descript);
                        bl.Update(md, item.FontConver);
                     
                        break;
                    }
                    break;
            }
            Response.End();
            return;
        }

        if (IsPostBack) return;

        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("图片管家", "上传图片");

        //绑定上传的图片
        int recordCount = 0;
        var list = bl.Query("AlbumID=@0", "id desc", 0, int.Parse(Request.QueryString["fc"]), ref recordCount, int.Parse(Request.QueryString["albumid"]));
        Repeater1.DataSource = list;
        Repeater1.DataBind();
      
    }
    class img {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Descript { get; set; }
        public bool FontConver { get; set; }
        public int AlbumID { get; set; }
    }
}
