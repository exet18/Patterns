using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_metod
{
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {

        }
        public override IHouse Create()
        {
            return new WoodHouse();
        }
    }
}
