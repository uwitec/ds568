using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Web;
using System.Configuration;

namespace Common
{
    public class WriteLog
    {
        public WriteLog()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        //写跟踪日志
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void SetTrackLog(string pageURL, string Msg)
        {
            StreamWriter sw = null;
            try
            {
              
                string ip=ClientInfo.GetClientIP();
                if (File.Exists(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["LogPathTrack"].ToString() + DateTime.Now.ToShortDateString() + ".txt")))
                {

                    sw = File.AppendText(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["LogPathTrack"].ToString() + DateTime.Now.ToShortDateString() + ".txt"));
                }
                else
                    sw = File.CreateText(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["LogPathTrack"].ToString() + DateTime.Now.ToShortDateString() + ".txt"));
                sw.WriteLine("IP：" + ip + "    操作时间：" + DateTime.Now.ToString() + "  页面地址：" + pageURL + " 操作信息：" + Msg);
                sw.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }

        //写出错日志
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void SetErrLog(string pageURL, string FunctionName, string ErrMsg)
        {
            StreamWriter sw = null;
            try
            {
                string ip = ClientInfo.GetClientIP();


                if (File.Exists(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["LogPathError"].ToString() + DateTime.Now.ToShortDateString() + ".txt")))
                {
                    sw = File.AppendText(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["LogPathError"].ToString() + DateTime.Now.ToShortDateString() + ".txt"));
                }
                else
                    sw = File.CreateText(HttpContext.Current.Server.MapPath(ConfigurationSettings.AppSettings["LogPathError"].ToString() + DateTime.Now.ToShortDateString() + ".txt"));
                sw.WriteLine("IP：" + ip + "    提交时间：" + DateTime.Now.ToString() + "  页面地址：" + pageURL + " 函数名称：" + FunctionName + " 出错信息：" + ErrMsg);
                sw.Close();
            }
            catch (Exception ex)
            {
                 //System.Web.HttpContext.Current.Response.Write("没有访问日志文件的权限！或日志文件只读!<BR>" + ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
    }
}
