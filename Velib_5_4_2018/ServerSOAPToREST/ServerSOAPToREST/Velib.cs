using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    public class Velib : IVelib
    {
        private RequestSender sender = new RequestSender();

        private SubscriptionModule module = new SubscriptionModule();
        
        public void SubscribeDetails(string cityName, string stationName, string login)
        {
            this.module.NewSubscription(cityName.ToLower() +  stationName.ToLower(), login);
        }

        public void UnsubscribeDetails(string cityName, string stationName, string login)
        {
            this.module.RemoveSubscription(cityName.ToLower() + stationName.ToLower(), login);
        }

        public List<Station> GetStationsByCity(string cityName, string login)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            User user = UserAgenda.Instance.GetUser(login);
            List<Station> res = user.GetFromCache<List<Station>>(cityName);

            if (res == null)
            {
                res = sender.GetStationsByCity(cityName, user);
            }
            
            watch.Stop();
            Monitoring.Instance.TotalResponseTime += watch.ElapsedMilliseconds;

            return res;
        }

        public string GetStationDetails(string cityName, string stationName, string login)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            User user = UserAgenda.Instance.GetUser(login);
            Station res = user.GetFromCache<Station>(cityName + stationName);

            if (res == null)
            {
                res = sender.GetStationDetails(cityName, stationName, user);
            }

            watch.Stop();
            Monitoring.Instance.TotalResponseTime += watch.ElapsedMilliseconds;

            this.module.SendDetails(cityName.ToLower() + stationName.ToLower(), res.WriteDescription(), res.Last_update);

            return res.WriteDescription();
        }

        public void ChangeCacheSettingsSlide(int slideTime, string unit, string login)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            User user = UserAgenda.Instance.GetUser(login);

            user.ChangeSlidingCache(slideTime, unit);

            watch.Stop();
            Monitoring.Instance.TotalResponseTime += watch.ElapsedMilliseconds;
        }

        public void ChangeSubscribeSettings(int slideTime, string unit, string login)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            User user = UserAgenda.Instance.GetUser(login);

            user.ChangeSubscriptionTime(slideTime, unit);

            watch.Stop();
            Monitoring.Instance.TotalResponseTime += watch.ElapsedMilliseconds;
        }
    }
}

