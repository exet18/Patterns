using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Orders : Decorator
    {
        List<string> customers = new List<string>();
        public void clientsOutput()
        {
            foreach(var x in customers)
            {
                Console.WriteLine("Customer: " + x);
            }
        }
        public Orders(Goods goods) : base(goods) { }
        public void clientOrder(string client)
        {
            customers.Add(client);
        }
        public override void Output()
        {
            clientsOutput();
            base.Output();
           
        }
    }
}
