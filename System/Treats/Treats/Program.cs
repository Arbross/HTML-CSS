using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Treats
{
    public class Args
    {
        public int First { get; set; }
        public int Second { get; set; }
    }
    class Program
    {
        static void Method()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void MethodTwo(object obj)
        {
            Args args = obj as Args;

            for (int i = args.First; i < args.Second; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Args arguments = new Args();

            Console.Write("Threads : "); string threads = Console.ReadLine();

            Console.Write("First number : "); 
            string first = Console.ReadLine();

            Console.Write("Second number : "); 
            string second = Console.ReadLine();

            arguments.First = Convert.ToInt32(first);
            arguments.Second = int.Parse(second);

            // ThreadStart threadStart = new ThreadStart(Method);
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(MethodTwo);
            List<Thread> thread = new List<Thread>();

            for (int i = 0; i < Convert.ToInt32(threads); i++)
            {
                Thread tmp = new Thread(threadStart);
                tmp.Start(arguments);
                thread.Add(tmp);
            }

            Console.ReadKey();
            Console.WriteLine("Main end!");
        }
    }
}
