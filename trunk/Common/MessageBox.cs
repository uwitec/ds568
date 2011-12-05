using System;
using System.Text;
using System.Runtime.CompilerServices;
namespace Common
{
	/// <summary>
	/// 显示消息提示对话框。
	/// 苏得冠
	/// 2010.12.1
	/// </summary>
	public class MessageBox
	{		
		private  MessageBox()
		{			
		}

		/// <summary>
		/// 显示消息提示对话框
		/// </summary>
		/// <param name="page">当前页面指针，一般为this</param>
		/// <param name="msg">提示信息</param>
		public static void  Show(System.Web.UI.Page page,string msg)
		{
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>alert('" + msg.ToString() + "');</script>");
		}

		/// <summary>
		/// 控件点击 消息确认提示框
		/// </summary>
		/// <param name="page">当前页面指针，一般为this</param>
		/// <param name="msg">提示信息</param>
		public static void  ShowConfirm(System.Web.UI.WebControls.WebControl Control,string msg)
		{
			//Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");
			Control.Attributes.Add("onclick", "return confirm('" + msg + "');") ;
		}

		/// <summary>
		/// 显示消息提示对话框，并进行页面跳转
		/// </summary>
		/// <param name="page">当前页面指针，一般为this</param>
		/// <param name="msg">提示信息</param>
		/// <param name="url">跳转的目标URL</param>
		public static void ShowAndRedirect(System.Web.UI.Page page,string msg,string url)
		{			
            //Response.Write("<script>alert('帐户审核通过！现在去为企业充值。');window.location=\"" + pageurl + "\"</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>alert('" + msg + "');window.location=\"" + url + "\"</script>");


		}
        /// <summary>
        /// 显示消息提示对话框，并进行页面跳转
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="msg">提示信息</param>
        /// <param name="url">跳转的目标URL</param>
        public static void ShowAndRedirects(System.Web.UI.Page page, string msg, string url)
        {
            StringBuilder Builder = new StringBuilder();
            Builder.Append("<script language='javascript' defer>");
            Builder.AppendFormat("alert('{0}');", msg);
            Builder.AppendFormat("top.location.href='{0}'", url);
            Builder.Append("</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), Builder.ToString());

        }

		/// <summary>
		/// 输出自定义脚本信息
		/// </summary>
		/// <param name="page">当前页面指针，一般为this</param>
		/// <param name="script">输出脚本</param>
		public static void ResponseScript(System.Web.UI.Page page,string script)
		{
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>" + script + "</script>");
             
		}

        /// <summary>
        /// 提示框，针对easyUi
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="script">输出脚本</param>
        /// <param name="script">提示类型</param>
        public static void Show(System.Web.UI.Page page, string msg,InfoType it)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>using('messager',function(){$.messager.alert('系统提示','" + msg.Replace("'", "\"").Replace("\n", "").Replace("\r", "") + "。','" + it.ToString() + "')});</script>");

        }

        /// <summary>
        /// 提示框，针对easyUi
        /// </summary>
        /// <param name="page">当前页面指针，一般为this</param>
        /// <param name="script">输出脚本</param>
        /// <param name="script">提示类型</param>
        /// <param name="Fun">回调函数</param>
        public static void Show(System.Web.UI.Page page, string msg, InfoType it,string Fun)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>using('messager',function(){$.messager.alert('系统提示','" + msg.Replace("'", "\"").Replace("\n", "").Replace("\r", "") + "。','" + it.ToString() + "'," + Fun + ")});</script>");

        }

       
      
        public enum InfoType {
            error,
            info,
            question,
            warning
        }

        
        private static int _UnionID = 0;
        /// <summary>
        /// 返回连续的1-1000的一个数字
        /// </summary>
        [MethodImpl(MethodImplOptions.Synchronized)]
        private static int UnionID()
        {
            if (_UnionID > 999)
                _UnionID = 1;
            else
                _UnionID++;
            return _UnionID;
            
        }
	}
}
