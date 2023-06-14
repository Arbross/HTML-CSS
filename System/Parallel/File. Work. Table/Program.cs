using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Work.Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter from : "); int from =  int.Parse(Console.ReadLine());
            Console.Write("Enter to : "); int to =  int.Parse(Console.ReadLine());

            Parallel.Invoke(() => 
            {
                string tmp = null;
                for (int i = from; i <= to; i++)
                {
                    for (int j = 1; j < 10; j++)
                    {
                        tmp += $"{i} * {j} = {i * j}\n";
                    }
                    tmp += "-----------\n";
                }
                System.IO.File.WriteAllText("file.txt", tmp);
            });
            Console.ReadKey();   
        }
    }
}
