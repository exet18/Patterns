using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Decorator : Goods
    {
        private Goods _goods;
        public Decorator(Goods goods)
        {
            _goods = goods;
        }
        public override void Output()
        {
            _goods.Output();
        }
    }
}
