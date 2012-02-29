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
