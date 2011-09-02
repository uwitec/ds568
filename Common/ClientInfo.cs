using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
namespace Common
{
    /// <summary>
    /// 处理客户端信息
    /// </summary>
    public class ClientInfo
    {
        /// <summary>
        /// 获取客户部IP
        /// </summary>
        /// <returns></returns>
        public static string GetClientIP()
        {
            string result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(result))
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }


            if (string.IsNullOrEmpty(result))
            {
                result = HttpContext.Current.Request.UserHostAddress;
            }
            return result;
        }

        public static void noCache(System.Web.UI.Page p)
        {//使页面不进行缓存

            p.Response.Expires = -1;
            p.Response.AddHeader("pragma", "no-cache");
            p.Response.AddHeader("cache-control", "no-store");
        }
    }
}
