using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace ServerSOAPToREST
{
    public sealed class Monitoring
    {
        private static readonly Monitoring instance = new Monitoring();

        private CacheItemRemovedCallback OnCacheRemove;

        private int nbRequests;

        public int NbRequests
        {
            get { return nbRequests; }
            set { nbRequests = value; }
        }

        private int nbJCDecauxDayRequests;

        public int NbJCDecauxDayRequests
        {
            get { return nbJCDecauxDayRequests; }
            set { nbJCDecauxDayRequests = value; }
        }

        private int nbDayRequests;

        public int NbDayRequests
        {
            get { return nbDayRequests; }
            set { nbDayRequests = value; }
        }

        private int nbJCDecauxRequests;

        public int NbJCDecauxRequests
        {
            get { return nbJCDecauxRequests; }
            set { nbJCDecauxRequests = value; }
        }

        private int nbCacheRequests;

        public int NbCacheRequests
        {
            get { return nbCacheRequests; }
            set { nbCacheRequests = value; }
        }

        private float totalResponseTime;

        public float TotalResponseTime
        {
            get { return totalResponseTime; }
            set { totalResponseTime = value; }
        }

        private HashSet<String> dayUsers;

        public HashSet<String> DayUsers
        {
            get { return dayUsers; }
        }

        static Monitoring()
        {

        }
        private Monitoring()
        {
            nbRequests = 0;
            nbJCDecauxRequests = 0;
            nbJCDecauxDayRequests = 0;
            nbDayRequests = 0;
            totalResponseTime = 0;
            nbCacheRequests = 0;
            dayUsers = new HashSet<string>();

            AddTask("Reset_Day", 24 * 60 * 60 - (DateTime.Now.Hour * 60 + DateTime.Now.Minute + DateTime.Now.Second), CacheItemRemoved);
        }

        /**
         * Implementation of an user agenda with a singleton pattern
         * 
         **/
        public static Monitoring Instance
        {
            get
            {
                return instance;
            }
        }

        /**
         * Will be called when the server startup. Every day at 00.00, the function (3rd arg) will be called.
         * 
         **/
        private void AddTask(string name, int seconds, Action<string, object, CacheItemRemovedReason> cacheItemRemoved)
        {
            OnCacheRemove = new CacheItemRemovedCallback(cacheItemRemoved);
            HttpRuntime.Cache.Insert(name, seconds, null,
                DateTime.Now.AddSeconds(seconds), Cache.NoSlidingExpiration,
                CacheItemPriority.NotRemovable, OnCacheRemove);
        }

        /**
         * Reset the number of requests every user have made during the last day (00h00 -> 23h59)
         * 
         **/
        public void CacheItemRemoved(string k, object v, CacheItemRemovedReason r)
        {
            UserAgenda.Instance.ResetUsersDatas();

            this.ResetDayDatas();

            AddTask(k, Convert.ToInt32(v), CacheItemRemoved);
        }

        /**
         * Reset multiple datas about the server during the last day (00h00 -> 23h59)
         * 
         **/
        private void ResetDayDatas()
        {
            nbJCDecauxDayRequests = 0;
            nbDayRequests = 0;
            dayUsers = new HashSet<string>();
        }

        /**
         * Will be called when an admin wants to check datas from the server.
         * 
         **/
        public string DisplayMonitoring()
        {
            return
                "\nNumber of requests : " + this.nbRequests + "\n" +
                "Number of requests today : " + this.nbDayRequests + "\n" +
                "Average response time : " + (this.totalResponseTime / this.nbRequests) + "ms" + "\n" +
                "Number of cache access : " + this.nbCacheRequests + "\n" +
                "Number of JCDecaux requests : " + this.nbJCDecauxRequests + "\n" +
                "Number of JCDecaux requests today : " + this.nbJCDecauxDayRequests + "\n" +
                "Number of user : " + this.dayUsers.Count + "\n" +
                "Number of user today : " + this.dayUsers.Count + "\n";
        }
    }
}
