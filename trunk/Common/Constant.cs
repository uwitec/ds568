using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Constant
    {
        public enum ChkType:byte { 
            待审中,
            审核未过,
            审核通过
        }

        public static string GetCt(byte b)
        {
            string rs = Enum.GetName(typeof(ChkType), b);
            switch (b) { 
                case 0:
                    rs = rs + "..";
                    break;
                case 1:
                    rs = "<span style='color:#AC213D'>" + rs + "</span>";
                    break;
                case 2:
                    rs = "<span style='color:green'>" + rs + "</span>";
                    break;
            }
            return rs;
        }


        public enum PayWay { 
            现金,
            支票,
            转帐
        }

        /// <summary>
        /// 获取配置文件AppSeting的值
        /// </summary>
        /// <param name="conName">键名称</param>
        /// <returns></returns>
        public static  string WebConfig(string conName) {
            return System.Configuration.ConfigurationManager.AppSettings[conName];
        }

        public static System.Web.HttpContext HttpContext { get { return System.Web.HttpContext; } }
     
    }
}
