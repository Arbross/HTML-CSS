using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Read_Nums_and_Count_Factorial
{
    class Program
    {
        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Thread.Sleep(3000);
            Console.WriteLine($"Factorial {x} = {result}");
        }

        static void Main(string[] args)
        {
            string filename = "file.txt";
            List<int> list = File.ReadAllText(filename).Split('\n').Select(x => int.Parse(x)).ToList();

            Parallel.ForEach(list, Factorial);

            Console.ReadKey();
        }
    }
}
