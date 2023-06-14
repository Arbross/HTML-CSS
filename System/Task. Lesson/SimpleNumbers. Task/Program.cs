using System;
using System.Threading;

namespace SimpleNumbers._Task
{
    class Program
    {
        public static int GenerateDefaultNumbers(int from = 1, int to = 100)
        {
            string result = null;
            int count = 0;
            for (int i = from; i < to; i++)
            {
                bool prime = true;
                for (int j = from; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    result += ' ' + i;
                    count++;
                    Thread.Sleep(10);
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            System.Threading.Tasks.Task<int> task = System.Threading.Tasks.Task.Run(() => GenerateDefaultNumbers(1, 100));
            Console.WriteLine($"{task.Result}");
            task.Wait();

            Console.ReadKey();
        }
    }
}
