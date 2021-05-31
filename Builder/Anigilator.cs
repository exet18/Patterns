using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Anigilator : IComputerBuilder
    {
        public Computer comp = new Computer();
        public Anigilator()
        {
            comp.Name = "Anigilator";
        }
        public void CreateOs()
        {
            comp.OS = Os.Windows;
            
        }

        public void CreateProcessor()
        {
            comp.Processor = Processor.Amd;
        }
    }
}
