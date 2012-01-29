using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using Com.DianShi.BusinessRules.Album;
public partial class Upload : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
            HttpPostedFile file = Request.Files["FileData"];
            string uploadpath = Server.MapPath(Request["folder"] + "\\");
            
            if (file != null)
            {
                var ud = Session["UserData"] as UserData;
                int albumID = int.Parse(Request.QueryString["albumID"]);
                var bl = new DS_Album_Br();
                string album = bl.GetDirByID(ud.Member.ID,albumID);
                var pbl = new DS_AlbumImg_Br();
                var md = pbl.CreateModel();
                md.AlbumID = albumID;
                md.ImgUrl = album;
                md.ImgName = "";
                md.ImgTitle =file.FileName;
                md.ImgDescript = "";
                md.Px = 0;
                pbl.Add(md);
                md.ImgName = "A"+albumID+"_"+DateTime.Now.ToString("yyyyMMddhhmmss") + "_" + md.ID + file.FileName.Substring(file.FileName.LastIndexOf('.'));
                pbl.Update(md);
                uploadpath = Server.MapPath("~" + Common.Constant.WebConfig("AlbumRootPath") + album) + "\\";
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                file.SaveAs(uploadpath + md.ImgName);

                Response.Write(Common.Constant.WebConfig("AlbumRootPath")+md.ImgUrl+"/"+md.ImgName);

            }
            else
            {
                Response.Write("0");
            }
      
    }
}
 