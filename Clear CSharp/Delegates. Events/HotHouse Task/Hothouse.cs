using System;
using System.Collections.Generic;
using System.Text;

namespace HotHouse_Task
{
    delegate void HotHouseDeleg(Hothouse house);
    class Hothouse
    {
        public float MnTemperature { get; set; }
        public float MxTemperature { get; set; }

        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        public event HotHouseDeleg Well;

        private float temperature;
        public float tmp
        {
            get
            {
                if (temperature <= MnTemperature)
                {
                    Cooler cooler = new Cooler();
                    cooler.Cold(this);
                    return 0;
                }
                else
                {
                    Heater heater = new Heater();
                    heater.Heat(this);
                    return 0;
                }
            }
        }
        public float Temperature
        {
            get => temperature;
            set
            {
                if (value > MxTemperature)
                {
                    temperature = value;
                    Console.WriteLine($"It is too hot, really! Now the temperature is {Temperature} degrees.");
                    TooHot?.Invoke(this);
                }
                else if (value < MnTemperature)
                {
                    temperature = value;
                    Console.WriteLine($"It is some freezly(cold)! Now the temperature is {Temperature} degrees.");
                    TooCold?.Invoke(this);
                }
                else
                {
                    temperature = value;
                    Console.WriteLine($"All right. The temperature is {temperature} degrees.");
                    Well?.Invoke(this);
                }
            }
        }
        public Hothouse(float min, float temperature, float max)
        {
            MxTemperature = max;
            MnTemperature = min;
            Temperature = temperature;
        }
    }
    class Heater
    {
        public void Heat(Hothouse hothouse)
        {
            Console.WriteLine($"Heated the temperature from {hothouse.Temperature} to {hothouse.Temperature += 5}");
            hothouse.Temperature += 5;
        }
    }
    class Cooler
    {
        public void Cold(Hothouse hothouse)
        {
            Console.WriteLine($"Cold the temperature from {hothouse.Temperature} to {hothouse.Temperature -= 5}");
            hothouse.Temperature -= 5;
        }
    }
}
