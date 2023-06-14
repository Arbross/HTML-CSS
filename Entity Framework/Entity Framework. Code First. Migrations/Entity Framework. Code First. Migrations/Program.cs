using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Code_First.Migrations
{
    public class Service
    {
        MusicModel ctx = new MusicModel();
        // Task 1
        public IEnumerable<Trecks> First(string name)
        {
            return ctx.Trecks.Where(x => x.Album.Name == name && x.Album.Trecks.Average(y => y.Listening) < x.Listening);
        }
        // Task 2
        public IEnumerable<Trecks> Second_One()
        {
            return ctx.Trecks.OrderByDescending(x => x.Rate).Take(3);
        }
        public IEnumerable<Albums> Second_Two()
        {
            return ctx.Albums.OrderByDescending(x => x.Rate).Take(3);
        }
        // Task 3
        public IEnumerable<Trecks> Third_One(string name)
        {
            return ctx.Trecks.Where(x => x.Name.Contains(name));
        }
        public IEnumerable<Trecks> Third_Two(string name)
        {
            return ctx.Trecks.Where(x => x.TreckText.Contains(name));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            foreach (var item in service.First("Kolo"))
            {
                Console.WriteLine("Task 1\n" + item.Name);
            }

            foreach (var item in service.Second_One())
            {
                Console.WriteLine("Task 2.1\n" + item.Name);
            }

            foreach (var item in service.Second_Two())
            {
                Console.WriteLine("Task 2.2\n" + item.Name);
            }

            foreach (var item in service.Third_One("va"))
            {
                Console.WriteLine("Task 3.1\n" + item.Name);
            }

            foreach (var item in service.Third_Two("df"))
            {
                Console.WriteLine("Task 3.2\n" + item.Name);
            }

        }
    }
}
