using System;

namespace Animal
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal();

            Human ivan = new Human() { Name = "Ivan", Cal = 50 };
            animal.Feed += ivan.Handler;
            for (int i = 0; i < 30; i++)
            {
                animal.Run();
            }
        }
    }
}
