using System;
using System.Threading;

namespace BusStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = null;
            ManualResetEvent manual = new ManualResetEvent(false);

            Console.Write("Station count : "); int stationCount = int.Parse(Console.ReadLine());
            bus = new Bus(stationCount);

            for (int i = 0; i < stationCount; i++)
            {
                Bus.Stations[i] = new Station();
            }
            Station.SetPeopleCount();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Next");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        {
                            Console.Clear();
                            ThreadPool.QueueUserWorkItem(Bus.Next, manual);
                            manual.WaitOne();
                            bus.BusDrawInfo();
                            Bus.CurrentStation.StationDrawInfo();
                        } break;
                    default:
                        break;
                }
            }
        }
    }
}
