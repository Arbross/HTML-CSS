using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processes.Task_Manager
{
    public class TypeUpdate
    {
        public TypeUpdate()
        {
            updateList.Add(ONE);
            updateList.Add(TWO);
            updateList.Add(FIVE);
        }

        public const int ONE = 1;
        public const int TWO = 2;
        public const int FIVE = 5;

        public List<int> updateList { get; private set; } = new List<int>();
    }
}
