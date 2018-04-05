using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    public class Velib : IVelib
    {
        private RequestSender sender = new RequestSender();

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
            String res = user.GetFromCache<string>(cityName + stationName);

            if (res == null)
            {
                res = sender.GetStationDetails(cityName, stationName, user);
            }

            watch.Stop();
            Monitoring.Instance.TotalResponseTime += watch.ElapsedMilliseconds;

            return res;
        }

        public void ChangeCacheSettingsSlide(int slideTime, string unit, string login)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            User user = UserAgenda.Instance.GetUser(login);

            user.ChangeSlidingCache(slideTime, unit);

            watch.Stop();
            Monitoring.Instance.TotalResponseTime += watch.ElapsedMilliseconds;
        }
    }
}

