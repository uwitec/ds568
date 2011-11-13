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
namespace Com.ItOnline.Web
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Click+=new EventHandler(Button1_Click);

            int albumID = 12;
            var bl = new DS_Album_Br();
            string album = bl.GetDirByID(albumID);
            var pbl = new DS_AlbumImg_Br();
            var md = pbl.CreateModel();
            md.AlbumID = albumID;
            md.ImgUrl = album;
            md.ImgName = "";
            md.ImgDescript = "";
            md.Px = 0;
            pbl.Add(md);
            md.ImgName = album + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + "_" + md.ID;
            pbl.Update(md);
        }
        private void Button1_Click(object sender, EventArgs e) {
            var emun = new Common.EmailUitility();
            emun.Title = "测试验证码";
            emun.Content = "123456";
            emun.AddEmailAddress("416351551@qq.com");
            emun.SendEmail();
        }
    }

}
