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
 
public partial class Upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        HttpPostedFile file = Request.Files["FileData"];
        string uploadpath = Server.MapPath(Request["folder"] + "\\");

        if (file != null)
        {
            if (!Directory.Exists(uploadpath))
            {
                Directory.CreateDirectory(uploadpath);
            }
            file.SaveAs(uploadpath + file.FileName);
            Response.Write("1");
        }
        else
        {
            Response.Write("0");
        }
    }
}
 