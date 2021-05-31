using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Roadster : IComputerBuilder
    {
        public Computer comp = new Computer();
        
        public Roadster()
        {
            comp.Name = "Roadster";
        }
        public void CreateOs()
        {
            comp.OS = Os.Linux;
        }

        public void CreateProcessor()
        {
            comp.Processor = Processor.Intel;
        }
    }
}
