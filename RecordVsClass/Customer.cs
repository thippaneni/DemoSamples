﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordVsClass
{
    // Class Example
    public class Customer
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } // Mutable, reference-based equality
    }
}
