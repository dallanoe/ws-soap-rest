using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    public class SubscriptionModule
    {

        public void NewSubscription(string key, string login)
        {
            UserAgenda.Instance.GetUser(login).File.AddSubscription(key);
        }

        public void RemoveSubscription(string key, string login)
        {
            UserAgenda.Instance.GetUser(login).File.RemoveSubscription(key);
        }

        public void SendDetails(string key, string res, long lastUpdate)
        {
            foreach(User user in UserAgenda.Instance.Users)
            {
                user.File.SendDetails(key, res, lastUpdate);
            }
        }
    }
}
