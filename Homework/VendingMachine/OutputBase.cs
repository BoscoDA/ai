﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class OutputBase
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
