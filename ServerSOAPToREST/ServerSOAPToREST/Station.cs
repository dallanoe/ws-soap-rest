using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{

    [DataContract]
    public class Station
    {
        [DataMember]
        private int Number { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        private string Address { get; set; }
        [DataMember]
        private Point Position { get; set; }
        [DataMember]
        private bool Banking { get; set; }
        [DataMember]
        private bool Bonus { get; set; }
        [DataMember]
        private string Status { get; set; }
        [DataMember]
        private string Contract_name { get; set; }
        [DataMember]
        private int Bike_stands { get; set; }
        [DataMember]
        private int Available_bike_stands { get; set; }
        [DataMember]
        private int Available_bikes { get; set; }
        [DataMember]
        private string Last_update { get; set; }

        public string WriteDescription()
        {
            return "Name : " + Name + "\n"
                + "Address : " + Address + "\n"
                + "Position : " + "\n" + Position.ToString() + "\n"
                + "Banking : " + Banking + "\n"
                + "Bonus : " + Bonus + "\n"
                + "Status : " + Status + "\n"
                + "Contract name : " + Contract_name + "\n"
                + "Bike stands : " + Bike_stands + "\n"
                + "Available bike stands : " + Available_bike_stands + "\n"
                + "Available bikes : " + Available_bikes + "\n"
                + "Last update : " + Last_update;
        }
    }
}
