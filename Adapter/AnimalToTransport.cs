using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AnimalToTransport : ITransport
    {
        Animal _camel;
        public AnimalToTransport(Animal camel)
        {
            _camel = camel;
        }
        public void Drive()
        {
            _camel.Move();
        }
    }
}
