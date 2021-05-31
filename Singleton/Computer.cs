using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odinak
{
    class Computer
    {
        private OS _OS;
        public void Launch(string name)
        {
            _OS = OS.getInstance(name);
            Console.WriteLine("Launch " + _OS.ToString());
        }
    }
}
