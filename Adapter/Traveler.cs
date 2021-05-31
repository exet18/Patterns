using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Traveler
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
