using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads.Two
{
    public class Priority
    {
        public Priority()
        {
            priorities.Add(Lowest);
            priorities.Add(BelowNormal);
            priorities.Add(Normal);
            priorities.Add(AboveNormal);
            priorities.Add(Highest);
        }

        public List<string> priorities { get; private set; } = new List<string>();

        private string Lowest = "Lowest";
        private string BelowNormal = "Below Normal";
        private string Normal = "Normal";
        private string AboveNormal = "Above Normal";
        private string Highest = "Highest";
    }
}
