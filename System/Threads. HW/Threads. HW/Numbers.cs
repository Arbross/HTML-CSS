using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads.HW
{
    public class Numbers
    {
        public Numbers(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int First { get; set; } = 2;
        public int Second { get; set; }
    }
}
