using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task._Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Tasks.Task task = null;
            System.Threading.Tasks.Task task1 = null;
            System.Threading.Tasks.Task task2 = null;
            System.Threading.Tasks.Task task3 = null;

            for (; ;)
            {
                Console.Clear();
                task = new System.Threading.Tasks.Task(() => Console.WriteLine(DateTime.UtcNow));
                task1 = System.Threading.Tasks.Task.Factory.StartNew(() => Console.WriteLine(DateTime.UtcNow));
                task2 = System.Threading.Tasks.Task.Run(() => Console.WriteLine(DateTime.UtcNow));
                task3 = System.Threading.Tasks.Task.Run(() => Console.WriteLine(DateTime.UtcNow));
                Thread.Sleep(1000);
            }
            
            Console.ReadKey();
        }
    }
}
