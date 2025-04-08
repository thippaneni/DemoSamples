using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordVsClass
{
    // Record Example
    public record Person(string Name, int Age); // Immutable, value-based equality
}
