using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Person
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public override string ToString()
        {
            return $"{Name}\t{Birth.ToShortDateString()}";
        }
    }
}
