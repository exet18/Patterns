using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_metod
{
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {

        }

        public override IHouse Create()
        {
            return new PanelHouse();
        }
    }
}
