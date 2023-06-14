using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayWork._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 10, 5, 500, 456, 3324, 123, 123, 643 };

            System.Threading.Tasks.Task<List<int>> sameValue = System.Threading.Tasks.Task.Run(() => arr.Distinct().ToList());
            foreach (var item in sameValue.Result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            System.Threading.Tasks.Task sort = sameValue.ContinueWith((x) => x.Result.OrderBy(i => i));
            System.Threading.Tasks.Task binary = sort.ContinueWith((x) => Array.BinarySearch(arr, 0));

            

            Console.ReadKey();
        }
    }
}
