using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class GasMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Move on gas");
        }
    }
}
