using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasad
{
    class Programmer
    {
        public void CreateApplication(VisualStudioFasade fasade)
        {
            fasade.Start();
            fasade.Stop();
        }
    }
}
