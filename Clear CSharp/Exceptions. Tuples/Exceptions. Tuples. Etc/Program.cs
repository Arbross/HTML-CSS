using System;

namespace Exceptions._Tuples._Etc
{
    class Program
    {
        static void Main()
        {
            Tuple<int, string> t = new Tuple<int, string>(100, "Olena");
            Console.WriteLine($"{t.Item1}, {t.Item2}");
            var tuple = t.ToValueTuple();
            tuple.Item1 = 200;
            Console.WriteLine($"{tuple.Item1}, {tuple.Item2}");
            (int id, string name) = tuple;
            Console.WriteLine($"{id}, {name}");
            var t2 = (Name: "Anton", Phone: "34534534543534");
            t2.Name = "Anoton A.";
            Console.WriteLine(t2.Name, t2.Phone);
            Console.WriteLine(t2.Name);
            // int @base = 100;
            var t3 = t2.ToTuple();
        }
    }
}
