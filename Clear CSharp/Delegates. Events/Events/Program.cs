using System;

namespace Events
{
    class Program
    {
        static void Main()
        {
            Customer ann = new Customer { Name = "Ann" };
            Customer ivan = new Customer { Name = "Ivan" };

            Magazine magazine = new Magazine()
            { Title = "Forbes" };
            magazine.NewPostAddedEvent += ann.Handler;
            magazine.NewPostAddedEvent += ivan.Handler;

            magazine.AddPosts("I. Mask has become the richest man around the globe.");

            // magazine.NewPostAddedEvent = null; // ann.Handler;
            // magazine.NewPostAddedEvent -= ann.Handler;

            Console.WriteLine();
            magazine.NewPostAddedEvent += Worker.Handler;
            magazine.AddPosts(".NET 6 will be released in November 2021");
            // Console.WriteLine(magazine.ToString());
        }
    }
}
