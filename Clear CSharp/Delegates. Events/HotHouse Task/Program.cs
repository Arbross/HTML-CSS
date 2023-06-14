using System;

namespace HotHouse_Task
{
    class Program
    {
        static void Main()
        {
            Hothouse hothouse = new Hothouse(8, 0, 30);
            Heater heater = new Heater();
            Cooler cooler = new Cooler();

            for (int i = 0; i < 5; i++)
            {
                // int value = new Random().Next(-2, 2);
                // hothouse.Temperature += value;
                Console.WriteLine(hothouse.tmp);
            }
        }
    }
}
