using System;
using System.IO;

namespace FileStream_
{
    class Program
    {
        static void Main()
        {
            string fname = "number.dat";
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                fs.WriteByte(65); // 'A'
                byte[] arr = new byte[] { 66, 67, 68, 69, 90, 97, 1, 2, 3 };
                fs.Write(arr);
                fs.Write(arr, 0, arr.Length);
            }
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                byte[] result = new byte[fs.Length];
                fs.Position = 4;
                fs.WriteByte(90);
                fs.Position = 0;
                fs.Read(result);
                Console.WriteLine($"We read from file : {String.Join(" ", result)}");
                Console.Write("We read from file(2) : ");
                foreach (var item in result)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
