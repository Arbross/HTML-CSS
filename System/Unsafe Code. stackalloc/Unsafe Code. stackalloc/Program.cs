using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unsafe_Code.@stackalloc
{
    class Program
    {
        public unsafe static void Arrays()
        {
            int ac = 0;
            int bc = 0;

            int* a = stackalloc int[1];
            int* b = null;
            int* c = null;

            for (int i = 0; ; i++)
            {
                try
                {
                    int* tmp = stackalloc int[i + 1];
                    for (int j = 0; j < i; j++)
                    {
                        tmp[j] = a[j];
                    }
                    a = tmp;
                    Console.Write($"Enter value {nameof(a)} : "); int y = int.Parse(Console.ReadLine());
                    a[i] = y;
                }
                catch (Exception)
                {
                    ac = i;
                    break;
                }
            }

            for (int i = 0; ; i++)
            {
                try
                {
                    int* tmp = stackalloc int[i + 1];
                    for (int j = 0; j < i; j++)
                    {
                        tmp[j] = b[j];
                    }
                    b = tmp;
                    Console.Write($"Enter value {nameof(b)} : "); int y = int.Parse(Console.ReadLine());
                    b[i] = y;
                }
                catch (Exception)
                {
                    bc = i;
                    break;
                }
            }

            int* o = stackalloc int[ac + bc];

            int k = 0;
            for (k = 0; k < ac; k++)
            {
                o[k] = a[k];
            }

            for (int i = 0; i < bc; i++)
            {
                o[k] = b[i];
                k++;
            }

            for (int i = 0; i < ac + bc; i++)
            {
                Console.WriteLine(o[i]);
            }
        }

        static void Main(string[] args)
        {
            Arrays();

            Console.ReadKey();
        }
    }
}
