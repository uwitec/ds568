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
    public string ModleName { get; set; }
    /// <summary>
    /// 当前菜单名称
    /// </summary>
    public string MenuName { get; set; }
    
    /// <summary>
    /// 菜单列表
    /// </summary>
    public string Menu { 
        get {
            switch (ModleName)
            { 
                case "帐号管理":
                    ViewState["icon"] = "accountmanagement";
                    return "<li><a href=\"#\">修改联系信息</a></li>"+
                            "<li><a href=\"#\">手机验证</a></li>"+
                            "<li><a href=\"#\">邮箱验证</a></li>"+
                            "<li><a href=\"#\">修改密码</a></li>"+
                            "<li><a href=\"#\">密保问题管理</a></li>";
                    break;
                case "供应管理":
                    ViewState["icon"] = "offer";
                    return "<li><a  href=\"/Member/Manage/Offer/Post.aspx\">发布供应信息</a></li>" +
                            "<li><a href=\"#\">管理供应信息</a></li>" +
                            "<li><a href=\"#\">混批设置</a></li>" +
                            "<li><a href=\"#\">运费设置</a></li>" +
                            "<li><a href=\"#\">信息自定义分类</a></li>";
                    break;
            }
            return "";
        }
    }
}
