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
    class RequestSender
    {

        private static String apiKey = "eb852b9a4f7a7562a509eb22ee5220f43a46ad83";

        /**
         * Returns a list of stations from the JCDecaux's API from the wanted contract.
         * 
         **/
        public List<Station> GetStationsByCity(string cityName, User user)
        {
            List<Station> res = new List<Station>();

            try
            {
                res = new List<Station>();

                JArray json = JArray.Parse(SendRequestAndGetResponse(cityName));

                foreach (JObject obj in json)
                {
                    res.Add(JsonConvert.DeserializeObject<Station>(obj.ToString()));
                }
            }
            catch (Newtonsoft.Json.JsonReaderException e)
            {
                Console.WriteLine("Wrong input");
            }

            user.InsertToCache<List<Station>>(cityName, res);

            return res;
        }

        internal Station GetStationDetails(string cityName, string stationName, User user)
        {
            try
            {
                JArray json = JArray.Parse(SendRequestAndGetResponse(cityName));

                foreach (JObject obj in json)
                {
                    if (((String)obj.GetValue("name")).ToLower().Contains(stationName.ToLower()))
                    {
                        Station toReturn = JsonConvert.DeserializeObject<Station>(obj.ToString());
                        user.InsertToCache<Station>(cityName + stationName, toReturn);
                        return toReturn;
                    }
                }
            }
            catch (Newtonsoft.Json.JsonReaderException e)
            {
                Console.WriteLine("Wrong input");
            }
            
            return new NoStation();
        }

        /**
         * Returns the content of the response sent by JCDecaux's API after the wanted request.
         * 
         **/
        private String SendRequestAndGetResponse(String supp)
        {
            WebRequest request;

            request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" + supp + "&apiKey=" + apiKey);

            try
            {
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                String res = reader.ReadToEnd();

                // Clean up the streams and the response.
                reader.Close();
                response.Close();

                return res;
            }
            catch (WebException e)
            {
                return "";
            }

        }
    }
}
