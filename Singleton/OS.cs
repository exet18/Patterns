using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odinak
{
    class OS
    {
        private string _name;
        private OS(string name) 
        {
            _name = name;
        }
        private static OS _instance;
        public static OS getInstance(string name)
        {
            return _instance ??= new OS(name);
        }
        public override string ToString()
        {
            return _name;
        }
    }
}
