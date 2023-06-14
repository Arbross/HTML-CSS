using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStation
{
    public class Station
    {
        public static int[] PeopleCount { get; set; }

        public static void SetPeopleCount()
        {
            PeopleCount = new int[Bus.Stations.Length];
        }

        public static void DrawStation(int count)
        {
            for (int i = 0; i < count - 1; i++)
            {
                Console.Write("|--------------------");
            }
            Console.Write("|");
            Console.WriteLine();
        }

        public static void GeneratePeopleStation()
        {
            Random random = new Random();
            PeopleCount[Bus.CurrentStationIndex] = random.Next(0, 100);
        }

        public void StationDrawInfo()
        {
            for (int i = 0; i < PeopleCount.Length; i++)
            {
                Console.WriteLine($"People on a {i} station {PeopleCount[i]}.");
            }
            Console.WriteLine();
        }
    }
}
