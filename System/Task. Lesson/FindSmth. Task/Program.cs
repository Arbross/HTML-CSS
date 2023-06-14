using System;
using System.Linq;

namespace FindSmth._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 10, 50, 34, 64, 876, 234, 12, 1 };

            System.Threading.Tasks.Task min = System.Threading.Tasks.Task.Factory.StartNew(() => Console.WriteLine(arr.Min()));
            System.Threading.Tasks.Task max = System.Threading.Tasks.Task.Factory.StartNew(() => Console.WriteLine(arr.Max()));
            System.Threading.Tasks.Task avg = System.Threading.Tasks.Task.Factory.StartNew(() => Console.WriteLine(arr.Average()));
            System.Threading.Tasks.Task sum = System.Threading.Tasks.Task.Factory.StartNew(() => Console.WriteLine(arr.Sum()));

            Console.ReadKey();
        }
    }
}
