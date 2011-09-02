using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;
namespace Com.Todex.OA.Common
{
    public class StringFormat
    {
        /// <summary> 
        /// 将查询字符串改变成查询记录数的开式，即返回Count
        /// </summary>
        /// <param name="QueryString"></param>
        /// <returns></returns>
        public static string QueryCount(string QueryString) {
            return Regex.Replace(Regex.Replace(QueryString, "order[\\s]+by.*", "", RegexOptions.IgnoreCase), "^select.*from", "select count(*) as ct from");
        }

        /// <summary>
        /// 从html中提取纯文本
        /// </summary>
        /// <param name="strHtml"></param>
        /// <returns></returns>
        public static string StripHT(string strHtml)  
        {
            Regex regex = new Regex("<.+?>", RegexOptions.IgnoreCase);
            string strOutput = regex.Replace(strHtml, "");//替换掉"<"和">"之间的内容
            strOutput = strOutput.Replace("<", "");
            strOutput = strOutput.Replace(">", "");
            strOutput = strOutput.Replace("&nbsp;", "").Replace("&rdquo;", "“").Replace("&ldquo;", "“").Trim();
            return strOutput;
        }

        /// <summary>   
        /// 传入URL返回网页的html代码   
        /// </summary>   
        /// <param name="Url">URL</param>   
        /// <returns></returns>   
        public static string getUrltoHtml(string Url)
        {
            string errorMsg = "";
            try
            {
                System.Net.WebRequest wReq = System.Net.WebRequest.Create(Url);
                // Get the response instance.   
                System.Net.WebResponse wResp = wReq.GetResponse();
                // Read an HTTP-specific property   
                //if (wResp.GetType() ==HttpWebResponse)   
                //{   
                //DateTime updated =((System.Net.HttpWebResponse)wResp).LastModified;   
                //}   
                // Get the response stream.   
                System.IO.Stream respStream = wResp.GetResponseStream();
                // Dim reader As StreamReader = New StreamReader(respStream)   
                System.IO.StreamReader reader = new System.IO.StreamReader(respStream, System.Text.Encoding.GetEncoding("UTF-8"));
                return reader.ReadToEnd();

            }
            catch (System.Exception ex)
            {
                errorMsg = ex.Message;
            }
            return "";
        }

        /// <summary>
        /// 将数字字符串转成中文大写
        /// </summary>
        /// <param name="str">数字字符串</param>
        /// <returns>转换后的结果或错误信息</returns>
        public string ConvertSum(string str)
        {
            if (!ispositvedecimal(str))
                return "输入的不是正数字！";
            if (double.Parse(str) > 999999999999.99)
                return "数字太大，无法换算，请输入一万亿元以下的金额";
            char[] ch = new char[1];
            ch[0] = '.'; //小数点 
            string[] splitstr = null; //定义按小数点分割后的字符串数组 
            splitstr = str.Split(ch[0]);//按小数点分割字符串 
            if (splitstr.Length == 1) //只有整数部分 
                return convertdata(str) + "圆整";
            else //有小数部分 
            {
                string rstr;
                rstr = convertdata(splitstr[0]) + "圆";//转换整数部分 
                rstr += convertxiaoshu(splitstr[1]);//转换小数部分 
                return rstr;
            }

        }
        /// 
        /// 判断是否是正数字字符串 
        /// 
        /// 判断字符串 
        /// 如果是数字，返回true，否则返回false 
        public bool ispositvedecimal(string str)
        {
            decimal d;
            try
            {
                d = decimal.Parse(str);

            }
            catch (Exception)
            {
                return false;
            }
            if (d > 0)
                return true;
            else
                return false;
        }
        /// 
        /// 转换数字（整数） 
        /// 
        /// 需要转换的整数数字字符串 
        /// 转换成中文大写后的字符串 
        public string convertdata(string str)
        {
            string tmpstr = "";
            string rstr = "";
            int strlen = str.Length;
            if (strlen <= 4)//数字长度小于四位 
            {
                rstr = convertdigit(str);

            }
            else
            {

                if (strlen <= 8)//数字长度大于四位，小于八位 
                {
                    tmpstr = str.Substring(strlen - 4, 4);//先截取最后四位数字 
                    rstr = convertdigit(tmpstr);//转换最后四位数字 
                    tmpstr = str.Substring(0, strlen - 4);//截取其余数字 
                    //将两次转换的数字加上萬后相连接 
                    rstr = string.Concat(convertdigit(tmpstr) + "萬", rstr);
                    rstr = rstr.Replace("零萬", "萬");
                    rstr = rstr.Replace("零零", "零");

                }
                else
                    if (strlen <= 12)//数字长度大于八位，小于十二位 
                    {
                        tmpstr = str.Substring(strlen - 4, 4);//先截取最后四位数字 
                        rstr = convertdigit(tmpstr);//转换最后四位数字 
                        tmpstr = str.Substring(strlen - 8, 4);//再截取四位数字 
                        rstr = string.Concat(convertdigit(tmpstr) + "萬", rstr);
                        tmpstr = str.Substring(0, strlen - 8);
                        rstr = string.Concat(convertdigit(tmpstr) + "億", rstr);
                        rstr = rstr.Replace("零億", "億");
                        rstr = rstr.Replace("零萬", "零");
                        rstr = rstr.Replace("零零", "零");
                        rstr = rstr.Replace("零零", "零");
                    }
            }
            strlen = rstr.Length;
            if (strlen >= 2)
            {
                switch (rstr.Substring(strlen - 2, 2))
                {
                    case "佰零": rstr = rstr.Substring(0, strlen - 2) + "佰"; break;
                    case "仟零": rstr = rstr.Substring(0, strlen - 2) + "仟"; break;
                    case "萬零": rstr = rstr.Substring(0, strlen - 2) + "萬"; break;
                    case "億零": rstr = rstr.Substring(0, strlen - 2) + "億"; break;

                }
            }

            return rstr;
        }
        /// 
        /// 转换数字（小数部分） 
        /// 
        /// 需要转换的小数部分数字字符串 
        /// 转换成中文大写后的字符串 
        public string convertxiaoshu(string str)
        {
            int strlen = str.Length;
            string rstr;
            if (strlen == 1)
            {
                rstr = convertchinese(str) + "角";
                return rstr;
            }
            else
            {
                string tmpstr = str.Substring(0, 1);
                rstr = convertchinese(tmpstr) + "角";
                tmpstr = str.Substring(1, 1);
                rstr += convertchinese(tmpstr) + "分";
                rstr = rstr.Replace("零分", "");
                rstr = rstr.Replace("零角", "");
                return rstr;
            }


        }

        /// 
        /// 转换数字 
        /// 
        /// 转换的字符串（四位以内） 
        /// 
        public string convertdigit(string str)
        {
            int strlen = str.Length;
            string rstr = "";
            switch (strlen)
            {
                case 1: rstr = convertchinese(str); break;
                case 2: rstr = convert2digit(str); break;
                case 3: rstr = convert3digit(str); break;
                case 4: rstr = convert4digit(str); break;
            }
            rstr = rstr.Replace("拾零", "拾");
            strlen = rstr.Length;

            return rstr;
        }


        /// 
        /// 转换四位数字 
        /// 
        public string convert4digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string str4 = str.Substring(3, 1);
            string rstring = "";
            rstring += convertchinese(str1) + "仟";
            rstring += convertchinese(str2) + "佰";
            rstring += convertchinese(str3) + "拾";
            rstring += convertchinese(str4);
            rstring = rstring.Replace("零仟", "零");
            rstring = rstring.Replace("零佰", "零");
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }
        /// 
        /// 转换三位数字 
        /// 
        public string convert3digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string str3 = str.Substring(2, 1);
            string rstring = "";
            rstring += convertchinese(str1) + "佰";
            rstring += convertchinese(str2) + "拾";
            rstring += convertchinese(str3);
            rstring = rstring.Replace("零佰", "零");
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }
        /// 
        /// 转换二位数字 
        /// 
        public string convert2digit(string str)
        {
            string str1 = str.Substring(0, 1);
            string str2 = str.Substring(1, 1);
            string rstring = "";
            rstring += convertchinese(str1) + "拾";
            rstring += convertchinese(str2);
            rstring = rstring.Replace("零拾", "零");
            rstring = rstring.Replace("零零", "零");
            return rstring;
        }
        /// 
        /// 将一位数字转换成中文大写数字 
        /// 
        public string convertchinese(string str)
        {
            //"零壹贰叁肆伍陆柒捌玖拾佰仟萬億圆整角分" 
            string cstr = "";
            switch (str)
            {
                case "0": cstr = "零"; break;
                case "1": cstr = "壹"; break;
                case "2": cstr = "贰"; break;
                case "3": cstr = "叁"; break;
                case "4": cstr = "肆"; break;
                case "5": cstr = "伍"; break;
                case "6": cstr = "陆"; break;
                case "7": cstr = "柒"; break;
                case "8": cstr = "捌"; break;
                case "9": cstr = "玖"; break;
            }
            return (cstr);
        }

        /// <summary>
        /// 过滤危险html
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public string wipescript(string html)
        {
            Regex regex1 = new Regex(@"<script[\s\s]+</script *>",RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@" href *= *[\s\s]*script *:", RegexOptions.IgnoreCase);
            Regex regex3 = new Regex(@" on[\s\s]*=", RegexOptions.IgnoreCase);
            Regex regex4 = new Regex(@"<iframe[\s\s]+</iframe *>", RegexOptions.IgnoreCase);
            Regex regex5 = new Regex(@"<frameset[\s\s]+</frameset *>", RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //过滤<script></script>标记 
            html = regex2.Replace(html, ""); //过滤href=javascript: (<a>) 属性 
            html = regex3.Replace(html, " _disibledevent="); //过滤其它控件的on...事件 
            html = regex4.Replace(html, ""); //过滤iframe 
            html = regex5.Replace(html, ""); //过滤frameset 
            return html;
        }

        /// <summary>
        /// 取代传入URL文件名及参数
        /// </summary>
        /// <param name="Url">Url</param>
        /// <param name="rpstr">取代字符串</param>
        /// <returns></returns>
        public static string ReplaceUrl(string Url,string rpstr) {
            return Url.ToLower().Replace(Url.Substring(Url.LastIndexOf("/") + 1).ToLower(),rpstr);
        }
        /// <summary>
        /// 取代传入URL文件名及参数
        /// </summary>
        /// <param name="Url">Url</param>
        /// <param name="rpstr">取代字符串</param>
        /// <param name="left">文件名之前的文件路径，当前文件路径与取代文件路径不在同一文件夹时使用</param>
        /// <returns></returns>
        public static string ReplaceUrl(string Url, string rpstr, string left)
        {
            return Url.ToLower().Replace(left.ToLower() + Url.Substring(Url.LastIndexOf("/") + 1).ToLower(), rpstr.ToLower());
        }
    }
}
