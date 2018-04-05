using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    public class Admin : IAdmin
    {

        /**
         * Returns multiple datas about a specific user thanks to his name.
         * 
         **/
        public string GetDetailsUser(string wantedUser)
        {
            if (UserAgenda.Instance.IsKnownUser(wantedUser))
            {
                return UserAgenda.Instance.GetUser(wantedUser).DisplayMonitoring();
            }

            return "User not found :(";
        }

        /**
         * Returns multiple datas about the web services in general.
         * 
         **/
        public string GetGeneralMonitoring()
        {
            return Monitoring.Instance.DisplayMonitoring();
        }
    }
}
