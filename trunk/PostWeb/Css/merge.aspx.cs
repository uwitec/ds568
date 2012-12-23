using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using Yahoo.Yui.Compressor;
public partial class Css_merge : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        Compress(HttpContext.Current);
        
    }

    private const string CacheKeyFormat = "_CacheKey_{0}_";

    private const bool IsCompress = true; //需要压缩
    public void Compress(HttpContext context)
    {
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;

        string cachekey = string.Empty;

        string type = request.Url.Query.Substring(request.Url.Query.LastIndexOf(".")+1);
        if (!string.IsNullOrEmpty(type) && (type == "css" || type == "js"))
        {
            if (type == "js")
            {
                response.ContentType = "text/javascript";

            }
            else if (type == "css")
            {
                response.ContentType = "text/css";
            }

            var paths = request.QueryString[0].Split(',');
            cachekey = string.Format(CacheKeyFormat, paths[paths.Length-1].Split('-')[0]+"_"+type);
            CompressCacheItem cacheItem = HttpRuntime.Cache[cachekey] as CompressCacheItem;
            if (cacheItem == null)
            {
                string content = string.Empty;
                //string[] files = Directory.GetFiles(path, "*." + type);
                StringBuilder sb = new StringBuilder();
               
                foreach (var item in paths)
                {
                    string filename = context.Server.MapPath(item.Contains("."+type)?item:item+"."+type);
                    if (File.Exists(filename))
                    {
                        string readstr = File.ReadAllText(filename, Encoding.UTF8);
                        sb.Append(readstr);
                    }
                }

                content = sb.ToString();

                // 开始压缩文件
                if (IsCompress)
                {
                    if (type.Equals("js"))
                    {
                        content = new JavaScriptCompressor().Compress(content);
                    }
                    else if (type.Equals("css"))
                    {
                        content = new CssCompressor().Compress(content);
                    }
                }

                //输入到客户端还可以进行Gzip压缩 ,这里就省略了

                cacheItem = new CompressCacheItem() { Type = type, Content = content, Expires = DateTime.Now.AddMinutes(30) };
                HttpRuntime.Cache.Insert(cachekey, cacheItem, null, cacheItem.Expires, TimeSpan.Zero);
            }

            string ifModifiedSince = request.Headers["If-Modified-Since"];
            if (!string.IsNullOrEmpty(ifModifiedSince)&&TimeSpan.FromTicks(cacheItem.Expires.Ticks - DateTime.Parse(ifModifiedSince).Ticks).Seconds < 0)
            {
                response.StatusCode = (int)System.Net.HttpStatusCode.NotModified;
                response.StatusDescription = "Not Modified";
            }
            else
            {
                response.Write(cacheItem.Content);
                SetClientCaching(response, cacheItem.Expires);
            }
        }

    }

    private void SetClientCaching(HttpResponse response, DateTime expires)
    {
        response.Cache.SetETag(DateTime.Now.Ticks.ToString());
        response.Cache.SetLastModified(DateTime.Now);

        //public 以指定响应能由客户端和共享（代理）缓存进行缓存。    
        response.Cache.SetCacheability(HttpCacheability.Public);

        //是允许文档在被视为陈旧之前存在的最长绝对时间。 
        response.Cache.SetMaxAge(TimeSpan.FromTicks(expires.Ticks));

        response.Cache.SetSlidingExpiration(true);
    }
    private class CompressCacheItem
    {
        /// <summary>
        /// 类型 js 或 css 
        /// </summary>
        public string Type { get; set; } // js css  
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { set; get; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime Expires { set; get; }
    }
}