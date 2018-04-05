using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    [ServiceContract]
    public interface IAdmin
    {

        [OperationContract]
        string GetDetailsUser(string wantedUser);

        [OperationContract]
        string GetGeneralMonitoring();

    }
}
