using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Com.DianShi.BusinessRules.Member;
using System.IO;
public partial class Member_Manage_ComInfo_CtfPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var od = Session["UserData"] as UserData;
        if (od == null || od.Member == null)
        {
            Response.Write(Common.JSONHelper.ObjectToJSON(new { succ = false,lgout=true, msg = "抱歉，操作超时，需重新登录。" }));
            Response.End();
            return;
        }

        //ajax事件
        string act = Request["action"];
        if (!string.IsNullOrEmpty(act)) {
            switch (act) { 
                case "upload":
                    var mbbl = new DS_Members_Br();
                    string tempPath = "/Resource/" + mbbl.GetMemberDir(od.Member.ID) + "/Certificate/";
                    HttpPostedFile file = Request.Files[0];
                    string ext = Path.GetExtension(file.FileName).ToLower();
                    if (ext != ".jpg" && ext != ".gif")
                    {
                        Common.JSONHelper.ObjectToJSON(new { succ = false, msg = "请您上传jpg、gif、png图片" });
                    }
                    else if (file.ContentLength > 1024 * 1024)
                    {
                        Common.JSONHelper.ObjectToJSON(new { succ = false, msg = "请您上传1M(1024KB)内的图片" });
                    }
                    else
                    {
                        string newName = Guid.NewGuid().ToString();
                        string img = tempPath + newName + ext;
                        string filePath = Server.MapPath(img);
                        tempPath = Server.MapPath(tempPath);
                        if (!Directory.Exists(tempPath))
                        {
                            Directory.CreateDirectory(tempPath);
                        }
                        file.SaveAs(filePath);//保存图
                        Common.JSONHelper.ObjectToJSON(new { succ = true, fileName = newName + ext });
                    }
                    break;
            }
            Response.End();
            return;
        }


        //设置左边菜单
        var mst = this.Master as Member_Manage_MasterPage;
        mst.SetMenuTitle("公司资料", "公司证书");

        var vs = Enum.GetValues(typeof(DS_Certificate_Br.CtfType));
        Repeater1.DataSource = vs;
        Repeater1.DataBind();
    }
}
