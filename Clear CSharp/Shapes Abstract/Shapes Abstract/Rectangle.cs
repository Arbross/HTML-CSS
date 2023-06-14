using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Abstract
{
    class Rectangle : Shape
    {
        private uint height;
        private uint width;
        public uint Height
        {
            get => height;
            set => height = value > 0 ? value : height;
        }
        public uint Width
        {
            get => width;
            set => width = value > 0 ? value : width;
        }
        public override double Area => Height * Width;
        public override void Print()
        {
            Console.WriteLine($"Type : {GetType().Name}, Name : {Name}, Area : {Area}, Radius : {Radius}");
        }
    }
}
