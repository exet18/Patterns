using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_metod
{
    class PanelHouse : IHouse
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house build");
        }
        public void UseMaterials()
        {
            Console.WriteLine("Use panel materials");
        }
    }
}
