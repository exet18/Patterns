using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    class Computer
    {
        public string Name { get; set; }
        public Os OS { get; set; }
        public Processor Processor { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "\nOS: " + OS + "\nProcessor: " + Processor;
        }
    }
}
