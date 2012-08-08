using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Caching;
using System.Web;
namespace SDG.Cache
{
    public class CacheUtility
    {
        public static void Insert(string cacheKey, object value, CacheDependency cacheDependency)
        {
            HttpRuntime.Cache.Insert(cacheKey, value, cacheDependency, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(10.0));
        }

        /// <summary>
        /// 插入缓存
        /// </summary>
        /// <param name="cacheKey">缓存键名称</param>
        /// <param name="value">缓存对像</param>
        /// <param name="cacheDependency">缓存依赖项</param>
        /// <param name="cacheMinutes">缓存时间，以分钟为单位</param>
        /// <param name="IsAbsolute">是否使用绝对过期</param>
        public static void Insert(string cacheKey, object value, CacheDependency cacheDependency, double cacheMinutes, bool IsAbsolute)
        {
            if (IsAbsolute)
            {
                HttpRuntime.Cache.Insert(cacheKey, value, cacheDependency, DateTime.Now.AddMinutes(cacheMinutes), TimeSpan.Zero);
            }
            else {
                HttpRuntime.Cache.Insert(cacheKey, value, cacheDependency, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(cacheMinutes));
            }
        }

        public static object Get(string cacheKey)
        {
            return  HttpRuntime.Cache.Get(cacheKey);
        }

        public static void Remove(string cacheKey)
        {
            HttpRuntime.Cache.Remove(cacheKey);
        }

      
    }
}
