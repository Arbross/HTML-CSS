using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposable_
{
    class DBConnection : IDisposable
    {
        public string nameDb;
        private bool isOpen;
        private bool isDisposed = false;
        FileStream fs = new FileStream("", FileMode.OpenOrCreate);
        public DBConnection()
        {
            Console.WriteLine($"DbConnection ctor");
        }
        public void Open(string nameDb)
        {
            if (isOpen)
            {
                Console.WriteLine($"DB {nameDb} is opened now");
            }
            else
            {
                isOpen = true;
                this.nameDb = nameDb;
            }
        }
        public void Work()
        {
            Console.WriteLine("We got all records from table....");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"We are releasing managed resouce..");
                }

                isOpen = false;
                Console.WriteLine($"Dispose done. Is opened {isOpen}.");
                isDisposed = true;
            }
        }
        ~DBConnection()
        {
            Console.WriteLine($"Finalizer works.");
            Dispose(false);
        }
    }
    class Program
    {
        static void Main()
        {
            using (DBConnection db = new DBConnection())
            {
                db.Open("aa.");
                db.Work();
            }
        }
    }
}
