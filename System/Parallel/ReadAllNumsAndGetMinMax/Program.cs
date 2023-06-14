using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllNumsAndGetMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "file.txt";
            List<int> list = File.ReadAllText(filename).Split('\n').Select(x => int.Parse(x)).ToList();

            int max = list.AsParallel()
                          .AsOrdered()
                          .Max();

            Console.WriteLine($"Max : {max}");

            int min = list.AsParallel()
                          .AsOrdered()
                          .Min();

            Console.WriteLine($"Min : {min}");

            int sum = list.AsParallel()
                          .AsOrdered()
                          .Sum();

            Console.WriteLine($"Sum : {sum}");

            Console.ReadKey();
        }
    }
}
