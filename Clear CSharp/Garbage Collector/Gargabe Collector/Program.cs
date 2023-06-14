using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gargabe_Collector
{
    class Demo
    {

        public readonly int Id = ++lastId;
        private static int lastId = 0;
        int[] arr;
        public static int DefaultSize = 10_000_000;
        public Demo()
        {
            arr = new int[DefaultSize];
            Console.WriteLine($"Block was created # {Id}");
        }
        ~Demo() // finalizer
        {
            Console.WriteLine($"~~~~~~~~~~~~~~~~~ Removed block '{typeof(Demo).Name}' with id # {Id}");
        }
    }
    class Program
    {
        static void Main()
        {
            int times = 10;
            Demo b = new Demo();
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine($"{GC.GetTotalMemory(false) / 1024}"); // for KB
                b = new Demo();
            }
            Demo a = new Demo();
            Console.WriteLine(GC.GetGeneration(a));
            GC.Collect(0);
            System.Threading.Thread.Sleep(2000);
            for (int i = 0; i < times; i++)
            {
                a = new Demo();
            }
        }
    }
}
