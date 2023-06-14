using System;

namespace Boxing._Unboxing
{
    class Program
    {
        static void Main()
        {
            object[] arr = { 100, 12.5, "line", 'A', true, 34 };
            double sum = 0;

            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
                if (elem.GetType().Name == "Int32")
                {
                    sum += (int)elem;
                }
                else if (elem is double)
                {
                    sum += (double)elem;
                }
                switch (elem)
                {
                    case int i when i < 100:
                        sum += i;
                        break;
                    case double i:
                        sum += i;
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
