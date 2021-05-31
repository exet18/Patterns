using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabric_metod
{
    public abstract class Developer
    {
        protected string name;
        protected Developer(string Name)
        {
            name = Name;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public abstract IHouse Create();
    }
}
