using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSOAP
{
    class VelibCallback : Stations.IVelibCallback
    {
        public void SubscriptionRefreshed(string toPrint)
        {
            Console.WriteLine("Just received a new update !");

            Console.WriteLine("\n\n" + toPrint);
        }
    }
}
