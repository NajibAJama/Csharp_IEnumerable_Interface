using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_IEnumerable_Interface
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public override string ToString()
        {
            return $"Make:{Make} Model:{Model} Year:{Year.Year.ToString()}";
        }
    }
}
