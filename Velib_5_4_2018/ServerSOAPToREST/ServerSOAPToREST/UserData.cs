using System;

namespace ServerSOAPToREST
{
    public class UserData
    {

        private int nbRequests;

        public int MaxAbsTime
        {
            get { return nbRequests; }
            set { nbRequests = value; }
        }

        private int dayRequest;

        public int DayRequest
        {
            get { return dayRequest; }
            set { dayRequest = value; }
        }

        private int nbCacheAccess;

        public int NbCacheAccess
        {
            get { return nbCacheAccess; }
            set { nbCacheAccess = value; }
        }

        private int nbCacheInsert;

        public int NbCacheInsert
        {
            get { return nbCacheInsert; }
            set { nbCacheInsert = value; }
        }

        private DateTime lastRequest;

        public DateTime LastRequest
        {
            get { return lastRequest; }
            set { lastRequest = value; }
        }

        public UserData()
        {
            this.nbCacheAccess = 0;
            this.nbRequests = 0;
            this.nbCacheAccess = 0;
            this.dayRequest = 0;
            this.lastRequest = DateTime.Now;
        }

        /**
         * Will be called when the associated user get a data in his cache
         * 
         **/
        public void GetRequest()
        {
            Monitoring.Instance.NbRequests++;
            Monitoring.Instance.NbDayRequests++;
            Monitoring.Instance.NbCacheRequests++;
            this.nbRequests++;
            this.dayRequest++;
            this.nbCacheAccess++;
            this.lastRequest = DateTime.Now;
        }

        /**
         * Will be called when the associated user insert a data in his cache
         * 
         **/
        public void Insert()
        {
            Monitoring.Instance.NbRequests++;
            Monitoring.Instance.NbDayRequests++;
            Monitoring.Instance.NbJCDecauxRequests++;
            Monitoring.Instance.NbJCDecauxDayRequests++;

            this.nbRequests++;
            this.dayRequest++;
            this.nbCacheInsert++;
            this.lastRequest = DateTime.Now;
        }

        /**
         * Will be called when the associated user change his cache settings
         * 
         **/
        public void ChangeSliding()
        {
            Monitoring.Instance.NbRequests++;
            Monitoring.Instance.NbDayRequests++;

            this.nbRequests++;
            this.dayRequest++;
        }

        /**
         * Will be called when an admin wants to check datas from the associated user
         * 
         **/
        public string DisplayMonitoring(int nbItemCache)
        {
            return
                "\nLast request : " + this.lastRequest.ToLongDateString() + " " + this.lastRequest.ToLongTimeString() + "\n" +
                "Number of requests : " + this.nbRequests + "\n" +
                "Number of items in the cache : " + nbItemCache + "\n" +
                "Number of requests today : " + this.dayRequest + "\n" +
                "Number of cache access : " + this.nbCacheAccess + "\n" +
                "Number of cache insert : " + this.nbCacheInsert + "\n";
        }
    }
}