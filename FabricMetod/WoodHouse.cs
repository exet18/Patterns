using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_metod
{
    class WoodHouse : IHouse
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house build");
        }
        public void UseMaterials()
        {
            Console.WriteLine("Use wood materials");
        }
    }
}
