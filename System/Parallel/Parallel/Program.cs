using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel
{
    class Program
    {
        static int Factorial(int x, ref int sum, ref int count)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            sum += result;
            return result;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[] { -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, };
            int sum = 0, count = 0;

            var factorials = numbers.AsParallel()
                                    .AsOrdered()
                                    .Where(n => n > 0)
                                    .Select(n => Factorial(n, ref sum, ref  count));

            foreach (var n in factorials)
            {
                Console.WriteLine(n);
                count += Convert.ToString(n).Length;
            }

            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Count : {count}");

            Console.ReadKey();
        }
    }
}
