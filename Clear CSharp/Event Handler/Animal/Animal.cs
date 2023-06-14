using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    //class AnimalArgs : EventArgs
    //{
    //    public double OldPrice { get; set; }
    //}
    class Animal
    {
        private float energy { get; set; } = 100;
        private ushort HP { get; set; } = 10;
        public event EventHandler Feed;
        public ushort nHP
        {
            get => HP;
            set
            {
                if (value <= 10)
                {
                    HP = value;
                }
            }
        }
        public float Energy
        {
            get => energy;
            set
            {
                if (energy <= 100.0)
                {
                    energy = value;
                }
            }
        }
        public void Eat()
        {
            if (Energy <= 80.0)
            {
                Energy += 20;
            }
            else
            {
                Console.WriteLine("The animal is full of enegy!");
            }
        }
        public void Run()
        {
            if (nHP == 0)
            {
                Console.WriteLine("Is Dead.");
                return;
            }
            if (Energy <= 20)
            {
                nHP -= 1;
                Feed?.Invoke(this, new EventArgs());
            }
            Energy -= 5;
            Console.WriteLine($"Energy : {Energy}");
        }
    }

    class Human
    {
        public string Name { get; set; }
        private ushort cal { get; set; }
        public ushort Cal
        {
            get => cal;
            set => cal = value;
        }

        public void Handler(object obj, EventArgs e)
        {
            Animal animal = obj as Animal;
            if (animal != null)
            {
                animal.Eat();
                Console.WriteLine($"Human {Name} feed it for a {Cal} cal food,\n the energy of animal is {animal.Energy},\n the HP of animal is {animal.nHP}.\n");
            }
        }
    }
}
