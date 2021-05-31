﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    interface IComputerBuilder
    {
        void CreateProcessor();
        void CreateOs();
    }
}
