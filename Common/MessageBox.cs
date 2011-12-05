using System;
using System.Text;
using System.Runtime.CompilerServices;
namespace Common
{
	/// <summary>
	/// ��ʾ��Ϣ��ʾ�Ի���
	/// �յù�
	/// 2010.12.1
	/// </summary>
	public class MessageBox
	{		
		private  MessageBox()
		{			
		}

		/// <summary>
		/// ��ʾ��Ϣ��ʾ�Ի���
		/// </summary>
		/// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
		/// <param name="msg">��ʾ��Ϣ</param>
		public static void  Show(System.Web.UI.Page page,string msg)
		{
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>alert('" + msg.ToString() + "');</script>");
		}

		/// <summary>
		/// �ؼ���� ��Ϣȷ����ʾ��
		/// </summary>
		/// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
		/// <param name="msg">��ʾ��Ϣ</param>
		public static void  ShowConfirm(System.Web.UI.WebControls.WebControl Control,string msg)
		{
			//Control.Attributes.Add("onClick","if (!window.confirm('"+msg+"')){return false;}");
			Control.Attributes.Add("onclick", "return confirm('" + msg + "');") ;
		}

		/// <summary>
		/// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
		/// </summary>
		/// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
		/// <param name="msg">��ʾ��Ϣ</param>
		/// <param name="url">��ת��Ŀ��URL</param>
		public static void ShowAndRedirect(System.Web.UI.Page page,string msg,string url)
		{			
            //Response.Write("<script>alert('�ʻ����ͨ��������ȥΪ��ҵ��ֵ��');window.location=\"" + pageurl + "\"</script>");
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>alert('" + msg + "');window.location=\"" + url + "\"</script>");


		}
        /// <summary>
        /// ��ʾ��Ϣ��ʾ�Ի��򣬲�����ҳ����ת
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="msg">��ʾ��Ϣ</param>
        /// <param name="url">��ת��Ŀ��URL</param>
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
		/// ����Զ���ű���Ϣ
		/// </summary>
		/// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
		/// <param name="script">����ű�</param>
		public static void ResponseScript(System.Web.UI.Page page,string script)
		{
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>" + script + "</script>");
             
		}

        /// <summary>
        /// ��ʾ�����easyUi
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="script">����ű�</param>
        /// <param name="script">��ʾ����</param>
        public static void Show(System.Web.UI.Page page, string msg,InfoType it)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>using('messager',function(){$.messager.alert('ϵͳ��ʾ','" + msg.Replace("'", "\"").Replace("\n", "").Replace("\r", "") + "��','" + it.ToString() + "')});</script>");

        }

        /// <summary>
        /// ��ʾ�����easyUi
        /// </summary>
        /// <param name="page">��ǰҳ��ָ�룬һ��Ϊthis</param>
        /// <param name="script">����ű�</param>
        /// <param name="script">��ʾ����</param>
        /// <param name="Fun">�ص�����</param>
        public static void Show(System.Web.UI.Page page, string msg, InfoType it,string Fun)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), UnionID().ToString(), "<script language='javascript' defer>using('messager',function(){$.messager.alert('ϵͳ��ʾ','" + msg.Replace("'", "\"").Replace("\n", "").Replace("\r", "") + "��','" + it.ToString() + "'," + Fun + ")});</script>");

        }

       
      
        public enum InfoType {
            error,
            info,
            question,
            warning
        }

        
        private static int _UnionID = 0;
        /// <summary>
        /// ����������1-1000��һ������
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
