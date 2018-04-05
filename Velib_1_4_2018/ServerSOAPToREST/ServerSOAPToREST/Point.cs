using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    [DataContract]
    class Point
    {
        [DataMember]
        private float lat { get; set; }
        [DataMember]
        private float lng { get; set; }

        public override string ToString()
        {
            return "    Latitude : " + lat + "\n"
                + "    Longitude : " + lng;
        }
    }
}
