using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerSOAPToREST
{
    public class NoStation : Station
    {
        public NoStation()
        {
            this.Last_update = 0;
        }

        public new string WriteDescription()
        {
            return "Station not found :(";
        }
    }
}
