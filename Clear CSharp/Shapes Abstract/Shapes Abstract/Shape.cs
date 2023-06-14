using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes_Abstract
{
    abstract class Shape
    {
        private double area;
        private string name;
        public virtual double Area
        {
            get => area;
        }
        public virtual string Name
        {
            get => name;
            set => name = value;
        }
        virtual public void Print()
        {
            Console.WriteLine($"Type : {GetType().Name}, Name : {Name}, Area : {Area}");
        }
    }
}
