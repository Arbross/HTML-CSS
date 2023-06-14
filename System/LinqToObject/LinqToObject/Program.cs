using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demo_Linq_01();

            List<Worker> workers = new List<Worker>
            {
                new Worker() { Name = "Anton", Age = 21, Departament = "Service", Salary = 4000},
                new Worker() { Name = "Ivan", Age = 23, Departament = "Service", Salary = 4050},
                new Developer() { Name = "Vadim", Age = 32, Languages = new List<string>{ "C++", ".NET", "SQL" }, Salary = 40050},
                new Developer() { Name = "Kostia", Age = 52, Languages = new List<string>{ "Python", ".NET", "SQL", "Java" }, Salary = 50050},
                new DevOps() { Name = "Sergiy", Age = 36, TechStack = new List<string>{ "Bash", "Dockers", "SQL", "Python" }, Salary = 1},
                new DevOps() { Name = "Valeriy", Age = 64, TechStack = new List<string>{ "Bash", "Dockers", "SQL", "Python", "PostrgreSql" }, Salary = 2},
                new Accouter() { Name = "Anna", Age = 34, Salary = 1000},
                new QA() { Name = "Petro", Age = 28, Salary = 800, MethodTest = "Auto"}
            };

            // Demo_Linq_02(workers);

            // Task 1
            var getSortWorkers = from e in workers
                                 where e.Departament == "Service" || e.Departament == "IT"
                                 orderby e.Age ascending
                                 select e;
            foreach (var gsw in getSortWorkers)
            {
                Console.WriteLine(gsw);
            }
            var getAverageSalary = (from e in workers where e.Departament == "Service" || e.Departament == "IT" select e).Average(x => x.Salary);
            Console.WriteLine($"Average salary : {getAverageSalary}");

            // Task 2

            var smth = from e in workers
                       where e is DevOps && (e as DevOps).TechStack.Contains("PostrgreSql")
                       select new { Name = e.Name, Salary = e.Salary, Skills = (e as DevOps).TechStack};
            foreach (var dep in smth)
            {
                Console.WriteLine($"{dep.Name}, {dep.Salary} {String.Join(", ", dep.Skills)}");
            }

            // Task 3
            Console.WriteLine();
            var tmp = from e in workers
                      where e.Age < 30
                      orderby e.Name
                      select new { Name = e.Name, Salary = e.Salary };
            Console.WriteLine(String.Join(",", tmp));

            // Task 4

            var smth2 = from e in workers
                        orderby e.Age
                        group e by e.Age;
            foreach (var item in smth2)
            {
                Console.WriteLine($"---------------Age {item.Key} {item.Average(e => e.Salary)} {item.Count()}");
                Console.WriteLine(item.Key);
            }

            // Task 5

            var smth5 = (from e in workers
                              select e.Name).Distinct();
            foreach (var item in smth5)
            {
                Console.WriteLine(item);
            }

            // Task 6

            int[][] juggedArray = new int[2][]
            {
                new int[] { 1, 4, 7, 4 },
                new int[] { 6, 5, 2, 8 }
            };

            var smthX = (from e in juggedArray
                        from l in e
                        select l).Distinct();
            Console.WriteLine(String.Join(",", smthX));
        }

        private static void Demo_Linq_02(List<Worker> workers)
        {
            // 1 way

            var allPeople = from e in workers
                            orderby e.Salary descending
                            select e;
            foreach (var p in allPeople)
            {
                Console.WriteLine(p);
            }

            // max developers salary

            var maxSalary = (from e in workers where e is Developer select e).Max(x => x.Salary);
            Console.WriteLine($"Max developer salary : {maxSalary}");

            var namesTypes = from e in workers // result = IEnumareble<string>
                             orderby e.GetType().Name
                             select $"{e.Name,20} {e.GetType().Name,15}";
            foreach (var p in namesTypes)
            {
                Console.WriteLine(p);
            }

            // anonymous type

            var car = new { Brand = "Audi", Power = 3.4, Year = 2020 };
            Console.WriteLine($"{car.Brand} {car.Power} {car.Year}");
            Console.WriteLine(car);

            var devops = from e in workers
                         where e is DevOps
                         select new { NameDevops = e.Name, SalaryDevops = e.Salary, CountStackTech = (e as DevOps).TechStack.Count };
            foreach (var d in devops)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("\nGroup people by department : ");
            var resultGroup = from e in workers
                              orderby e.Departament
                              group e by e.Departament;
            foreach (var dep in resultGroup)
            {
                Console.WriteLine(dep.Key);
                foreach (var w in dep)
                {
                    Console.WriteLine(w);
                }
            }

            var resultLang = (from e in workers
                              where e is Developer
                              from l in (e as Developer).Languages
                              select l).Distinct();
            foreach (var l in resultLang)
            {
                Console.WriteLine(l);
            }
        }

        private static void Demo_Linq_01()
        {
            int[] arr = { 10, -2, 346, -55, 77, -88, -100, -300 };

            var negs = from e in arr
                       where e < 0 && e % 2 == 0
                       orderby -e
                       select e;
            foreach (var item in negs)
            {
                Console.WriteLine($"{item,4}");
            }
            Console.WriteLine();

            // 2
            Console.WriteLine();
            Console.WriteLine($"Min : {negs.Min()}");
            Console.WriteLine($"Max : {negs.Max()}");

            double avgPositive = (from e in arr
                                  where e > 0
                                  select e).Average();
            Console.WriteLine($"Avg : {avgPositive}");
            string[] products = { "apple", "orange", "juice", "tomato", "meat" };
            var words = products.Where(p => p.ToLower().Contains('a')).OrderBy/*Descending*/(p => p);
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
