using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Four
{
    public class MinMax
    {
        public int number { get; set; }
        public List<int> obj { get; set; } = new List<int>();
    }

    class Program
    {
        static void FindMax()
        {
            MinMax minMax = new MinMax();
            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                minMax.obj.Add(random.Next(1, 100000));
            }

            int max = minMax.obj[0];
            foreach (int item in minMax.obj)
            {
                if (max < item)
                {
                    minMax.number = max;
                }
            }
            Console.WriteLine("Max : " + max);


            File.WriteAllText("../../file.txt", Convert.ToString(minMax.number));
        }

        static void FindMin()
        {
            MinMax minMax = new MinMax();
            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                minMax.obj.Add(random.Next(1, 100000));
            }

            int min = minMax.obj[0];
            foreach (int item in minMax.obj)
            {
                if (min > item)
                {
                    minMax.number = min;
                }
            }
            Console.WriteLine("Min : " + min);

            File.WriteAllText("../../file1.txt", Convert.ToString(minMax.number));
        }

        static void FindAvg()
        {
            MinMax minMax = new MinMax();
            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                minMax.obj.Add(random.Next(1, 100000));
            }

            int avg = 0;
            foreach (int item in minMax.obj)
            {
                avg += item;
            }
            Console.WriteLine("Avg : " + avg / minMax.obj.Count);

            File.WriteAllText("../../file2.txt", Convert.ToString(avg / minMax.obj.Count));
        }

        static void Main(string[] args)
        {
            Thread thread_one = new Thread(FindAvg);
            Thread thread_two = new Thread(FindMax);
            Thread thread_three = new Thread(FindMin);

            thread_one.Start();
            thread_two.Start();
            thread_three.Start();
        }
    }
}
