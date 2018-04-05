using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace ServerSOAPToREST
{
    public sealed class UserAgenda
    {
        private HashSet<User> users;

        public HashSet<User> Users
        {
            get { return users; }
        }


        private static readonly UserAgenda instance = new UserAgenda();

        static UserAgenda()
        {

        }

        private UserAgenda()
        {
            users = new HashSet<User>();
        }

        /**
         * Implementation of an user agenda with a singleton pattern
         * 
         **/
        public static UserAgenda Instance
        {
            get
            {
                return instance;
            }
        }

        /**
         * Reset the number of requests every user have made during the last day (00h00 -> 23h59)
         * 
         **/
        public void ResetUsersDatas()
        {
            foreach (User tmp in users)
            {
                tmp.ResetDayRequest();
            }
        }

        /**
         * Return true if the user is already known by the server. False otherwise
         * 
         **/
        public bool IsKnownUser(string user)
        {
            foreach (User tmp in users)
            {
                if (tmp.getName() == user.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        /**
         * Return the wanted user thanks to his login. If the user is not known, insert a new one in the database then return it.
         * 
         **/
        public User GetUser(string user)
        {
            Monitoring.Instance.DayUsers.Add(user.ToLower());

            foreach(User tmp in users)
            {
                if (tmp.getName() == user.ToLower())
                {
                    return tmp;
                }
            }

            User res = new User(user.ToLower());

            users.Add(res);

            return res;
        }
    }
}
