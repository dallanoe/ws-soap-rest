using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    interface IVelibEvents
    {
        [OperationContract(IsOneWay = true)]
        void SubscriptionRefreshed(string toPrint);
    }
}
