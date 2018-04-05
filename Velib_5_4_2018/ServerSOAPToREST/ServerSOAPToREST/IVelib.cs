using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    [ServiceContract(CallbackContract = typeof(IVelibEvents))]
    public interface IVelib
    {
        [OperationContract]
        List<Station> GetStationsByCity(string cityName, string login);

        [OperationContract]
        string GetStationDetails(string cityName, string stationName, string login);

        [OperationContract]
        void ChangeCacheSettingsSlide(int slideTime, string unit, string login);

        [OperationContract]
        void SubscribeDetails(string cityName, string stationName, string login);

        [OperationContract]
        void UnsubscribeDetails(string cityName, string stationName, string login);

        [OperationContract]
        void ChangeSubscribeSettings(int slideTime, string unit, string login);

    }
}