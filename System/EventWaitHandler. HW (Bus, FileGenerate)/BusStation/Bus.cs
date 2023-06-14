using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusStation
{
    public class Bus
    {
        public Bus(int stationCount)
        {
            Stations = new Station[stationCount];
            CurrentStation = Stations[0];
            CurrentStationIndex = -1;
            People = 0;
        }

        public static bool IsMoveUp { get; set; } = true;
        public static Station[] Stations { get; set; }
        public static Station CurrentStation { get; set; }
        public static int CurrentStationIndex { get; private set; }

        public static readonly string Name = "175";
        public static readonly int MaxSeats = 60;

        public static int People { get; private set; }

        public static void Next(object obj)
        {
            EventWaitHandle ev = obj as EventWaitHandle;
            Random random = new Random();

            if (IsMoveUp == true)
            {
                CurrentStationIndex++;
            }
            else
            {
                CurrentStationIndex--;
            }

            Station.GeneratePeopleStation();

            if (People != 0)
            {
                int peopleOut = random.Next(0, People);
                People -= peopleOut;
            }
            
            CurrentStation = Stations[CurrentStationIndex];

            BusDraw(CurrentStationIndex);
            Station.DrawStation(Stations.Length);

            for (int i = 0; i < Station.PeopleCount[CurrentStationIndex]; i++)
            {
                if (People < MaxSeats)
                {
                    People++;
                }
            }

            if (CurrentStationIndex == Station.PeopleCount.Length - 1)
            {
                IsMoveUp = false;
            }

            if (CurrentStationIndex == 0)
            {
                IsMoveUp = true;
            }
            ev.Set();
        }

        public static void BusDraw(int moveCount = 0)
        {
            string moveOne = "                    ";
            string result = null;

            for (int i = 0; i < moveCount; i++)
            {
                result += moveOne;
            }
            Console.WriteLine($"{result}{Name}");
        }

        public void BusDrawInfo()
        {
            Console.WriteLine($"Current station index : {CurrentStationIndex}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Max seats : {MaxSeats}");
            Console.WriteLine($"Current count of people : {People}");
            Console.WriteLine();
        }
    }
}
