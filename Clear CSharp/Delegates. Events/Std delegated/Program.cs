using System;

namespace Std_delegated
{
    delegate void MyDeleg<T>(T one, T two);
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        static void Concat(string a, string b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        static void Test()
        {
            Console.WriteLine("Test for Action");
        }
        static void Main()
        {
            MyDeleg<double> deleg = Add;
            deleg?.Invoke(2, 4);

            MyDeleg<string> deleg1 = Concat;
            deleg1?.Invoke("2", "4");

            MyDeleg<char> deleg2 = (char a, char b) => Console.WriteLine($"{a} and {b} toUpper : {Char.ToUpper(a)} and {Char.ToUpper(b)}");
            deleg2?.Invoke('a', 'j');

            Action action = Test;
            action?.Invoke(); // action();
            action += () => Console.WriteLine("Action with lambda");

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Action<int, string> action1 = (int number, string str) => Console.WriteLine($"{number} == {str.Length} : {number == str.Length}");
            action1(4, "Привіт!");
            Func<int, DateTime, string> func = (number, date) => $"New Date : {date.AddDays(number) : dd-MMM-yyyy}";
            string result = func(5, DateTime.Now);
            Console.WriteLine(result);

            Predicate<int> predicate = (number) => number % 2 == 0;
            int value = new Random().Next(100);
            Console.WriteLine($"\n{value} : is even {predicate(value)}");

            Comparison<Person> cmpAge = (Person p1, Person p2) => p1.Age.CompareTo(p2.Age);
            Person[] people = { new Person(), new Person{Name = "Dima", Age = 17}, new Person { Name = "Olena", Age = 16 }};
            Array.Sort(people);
            Console.WriteLine();
            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name}, {p.Age, -7}");
            }
        }
    }
}
