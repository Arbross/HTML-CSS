using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("course");
            course.Print(Currency.ccy.USD, Currency.base_ccy.UAH);
        }
    }
}
