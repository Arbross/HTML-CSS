using System;

namespace Checked._Unchecked
{
    class Program
    {
        static void Main()  
        {
            byte a = 250, b = 2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{a, 10} -------- {b, 10}");
                try
                {
                    checked
                    {
                        ++a;
                        unchecked
                        {
                            --b;
                        }
                    }
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"\t{ex.Message}");
                    a = 0;
                }
            }
            byte value = 250;
            byte res = checked((byte)(value + 10));
            Console.WriteLine(res);
        }
    }
}
