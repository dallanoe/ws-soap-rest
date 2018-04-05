using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using System.Web.SessionState;

namespace ServerSOAPToREST
{
    class PersonalCache
    {
        private Dictionary<string, Object> webCache;
        
        private CacheItemRemovedCallback OnCacheRemove;
        
        private TimeSpan maxSlideTime = TimeSpan.FromSeconds(3);

        public TimeSpan MaxSlideTime
        {
            get { return maxSlideTime; }
            set { maxSlideTime = value; }
        }

        public PersonalCache()
        {
            this.webCache = new Dictionary<string, object>();
        }

        internal int Count()
        {
            return this.webCache.Count();
        }

        /**
         * Will be called a new user join the server and everytime he change the cache settings.
         * 
         **/
        private void AddTask(string name, int dummy, Action<string, object, CacheItemRemovedReason> cacheItemRemoved)
        {
            OnCacheRemove = new CacheItemRemovedCallback(cacheItemRemoved);
            HttpRuntime.Cache.Insert(name, dummy, null,
                Cache.NoAbsoluteExpiration, maxSlideTime,
                CacheItemPriority.NotRemovable, OnCacheRemove);
        }

        /**
         * Reset the cache item after the desired time.
         * 
         **/
        public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
        {
            webCache.Remove(k.Substring(0, k.IndexOf("&")));
        }

        /**
         * Method called when a request have been made and the user cache do not contain the data.
         * The server will make a request to JCDecaux and then will add it to the user cache.
         * 
         **/
        public void Insert<T>(string toInsert, T value, string userName)
        {
            AddTask(toInsert.ToLower() + "&" + userName, 0, CacheItemRemoved);

            webCache.Add(toInsert.ToLower(), value);
        }

        /**
         * Method called when a request have been made and the user cache contain the data.
         * The server will get the wanted response from the cache and send it to the user.
         * 
         **/
        public T Get<T>(string wanted)
        {
            if (webCache.ContainsKey(wanted.ToLower()))
            {
                return (T)webCache[wanted.ToLower()];
            }

            return default(T);
        }

        /**
         * Clear the user cache.
         * 
         **/
        public void ClearApplicationCache()
        {
            webCache.Clear();
        }
    }
}
