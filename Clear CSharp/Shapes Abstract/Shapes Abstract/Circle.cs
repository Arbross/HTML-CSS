using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Abstract
{
    class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set => radius = value > 0 ? radius : value;
        }
        public override double Area => Math.PI * Radius * Radius;
        public override void Print()
        {
            Console.WriteLine($"Type : {GetType().Name}, Name : {Name}, Area : {Area}, Radius : {Radius}");
        }
    }
}
