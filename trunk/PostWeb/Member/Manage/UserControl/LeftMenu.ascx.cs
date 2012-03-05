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

public partial class Member_Manage_UserControl_LeftMenu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

        string mn = Menu;//此处的作用是执行一遍Get,使ViewState["icon"]等生效,以便前页面可以获取
    }
    /// <summary>
    /// 当前模块名称
    /// </summary>
    public string ModleName { get { return ViewState["ModleName"] == null ? "" : ViewState["ModleName"].ToString(); } set { ViewState["ModleName"] = value; } }
    /// <summary>
    /// 当前菜单名称
    /// </summary>
    public string MenuName { get { return ViewState["MenuName"] == null ? "" : ViewState["MenuName"].ToString(); } set { ViewState["MenuName"] = value; } }
    
    /// <summary>
    /// 菜单列表
    /// </summary>
    public string Menu { 
        get {
            switch (ModleName)
            { 
                case "帐号管理":
                    ViewState["icon"] = "accountmanagement";
                    return "<li><a href=\"Contact.aspx\">修改联系信息</a></li>"+
                            "<li><a href=\"MobileValidate.aspx\">手机验证</a></li>" +
                            "<li><a href=\"EmailValidate.aspx\">邮箱验证</a></li>" +
                            "<li><a href=\"Password.aspx\">修改密码</a></li>"+
                            "<li><a href=\"PwdProtect.aspx\">密保问题管理</a></li>";
                    break;
                case "公司资料":
                    ViewState["icon"] = "companyinfo";
                    return "<li><a href=\"BaseInfo.aspx\">基本资料</a></li>" +
                            "<li><a href=\"DetailInfo.aspx\">详细资料</a></li>" +
                            "<li><a href=\"Certificate.aspx\">公司证书</a></li>";
                    break;
                case "供应管理":
                    ViewState["icon"] = "offer";
                    return "<li><a  href=\"../Offer/Post.aspx\">发布供应信息</a></li>" +
                            "<li><a href=\"../Offer/List.aspx\">管理供应信息</a></li>" +
                            "<li><a href=\"#\">混批设置</a></li>" +
                            "<li><a href=\"#\">运费设置</a></li>" +
                            "<li><a href=\"../DiyCat/UserDefCat.aspx\">产品自定义分类</a></li>";
                    break;
                case "图片管家":
                    ViewState["icon"] = "imagemanager";
                    return "<li><a  href=\"image_upload.aspx\">上传图片</a></li>" +
                            "<li><a href=\"album_list.aspx\">相册管理</a></li>" +
                            "<li><a href=\"#\">设置水印</a></li>";
                    break;
                case "公司动态":
                    ViewState["icon"] = "news";
                    return "<li><a  href=\"add.aspx\">发布公司动态</a></li>" +
                            "<li><a href=\"news_list.aspx\">管理公司动态</a></li>";
                            
                    break;
            }
            return "";
        }
    }
}
