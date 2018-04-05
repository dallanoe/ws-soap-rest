using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    public class User
    {
        private PersonalCache personalCache;

        private string name;

        private UserData userData;

        public User(string name)
        {
            this.name = name;
            this.userData = new UserData();
            this.personalCache = new PersonalCache();
        }

        /**
         * Method called to display multiples datas about the user.
         * 
         **/
        public string DisplayMonitoring()
        {
            return this.userData.DisplayMonitoring(this.personalCache.Count());
        }

        /**
         * Method called when a request have been made and the user cache do not contain the data.
         * The server will make a request to JCDecaux and then will add it to the user cache.
         * Also add metrics.
         * 
         **/
        public void InsertToCache<T>(string toInsert, T value)
        {
            this.userData.Insert();

            personalCache.Insert(toInsert, value, this.name);
        }

        /**
         * Method called when a request have been made and the user cache contain the data.
         * The server will get the wanted response from the cache and send it to the user.
         * Also add metrics.
         * 
         **/
        public T GetFromCache<T>(string wanted)
        {
            T res = personalCache.Get<T>(wanted);

            if (res != null)
            {
                this.userData.GetRequest();
            }
            
            return res;
        }

        /**
         * Method called when a the user wants to change the settings of his personal cache.
         * Also add metrics.
         * 
         **/
        public void ChangeSlidingCache(int time, string wanted)
        {
            this.userData.ChangeSliding();

            switch (wanted)
            {
                case "s":
                    this.personalCache.MaxSlideTime = TimeSpan.FromSeconds(time);
                    break;
                case "m":
                    this.personalCache.MaxSlideTime = TimeSpan.FromMinutes(time);
                    break;
                case "h":
                    this.personalCache.MaxSlideTime = TimeSpan.FromHours(time);
                    break;
                default:
                    break;
            }
        }

        /**
         * User name getter
         * 
         **/
        public string getName()
        {
            return this.name;
        }

        /**
         * Method called at 00h00 each day, resetting the number of request the user made this day.
         * 
         **/
        public void ResetDayRequest()
        {
            this.userData.DayRequest = 0;
        }
    }
}
