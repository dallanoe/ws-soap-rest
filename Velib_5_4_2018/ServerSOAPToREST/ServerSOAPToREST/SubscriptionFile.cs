using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace ServerSOAPToREST
{
    public class SubscriptionFile
    {
        private TimeSpan timeAccepted = TimeSpan.FromMinutes(3);

        public TimeSpan TimeAccepted
        {
            get { return timeAccepted; }
            set { timeAccepted = value; }
        }

        private Dictionary<string, Action<string>> subscriptions = new Dictionary<string, Action<string>>();

        public SubscriptionFile()
        {
        }

        internal void RemoveSubscription(string key)
        {
            if (subscriptions.Keys.Contains(key))
            {
                subscriptions.Remove(key);
            }
        }

        public void AddSubscription(string key)
        {
            if (subscriptions.Keys.Contains(key))
            {
                subscriptions[key] += OperationContext.Current.GetCallbackChannel<IVelibEvents>().SubscriptionRefreshed;
            }
            else
            {
                subscriptions.Add(key, delegate { });
                subscriptions[key] += OperationContext.Current.GetCallbackChannel<IVelibEvents>().SubscriptionRefreshed;
            }
        }

        internal void SendDetails(string key, string res, long lastUpdate)
        {
            if (subscriptions.Keys.Contains(key) && IsValidDelay(lastUpdate))
            {
                subscriptions[key](res);
            }
        }

        private bool IsValidDelay(long lastUpdate)
        {
            return TimeSpan.Compare(
                DateTime.UtcNow.Subtract(DateTime.SpecifyKind(new DateTime(1970, 1, 1), DateTimeKind.Utc).AddMilliseconds(lastUpdate)),
                this.timeAccepted) == -1;
        }
    }
}