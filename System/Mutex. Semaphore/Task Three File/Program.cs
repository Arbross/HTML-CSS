using System;
using System.IO;
using System.Threading;

namespace Task_Three_File
{
    class Program
    {
        public static void FirstMethod(object obj)
        {
            EventWaitHandle ev = obj as EventWaitHandle;
            Random random = new Random();

            string tmp = null;
            for (int i = 0; i < 10; i++)
            {
                tmp += $"{random.Next(1, 100)} {random.Next(1, 100)}|";
            }
            File.WriteAllText("file.txt", tmp);
            ev.Set();
        }

        public static void SecondMethod(object obj)
        {
            EventWaitHandle ev = obj as EventWaitHandle;

            ev.WaitOne();

            string tmp = File.ReadAllText("file.txt");
            int first = 0;
            int second = 0;

            string str = null;
            string result = null;
            foreach (char item in tmp)
            {
                if (item == '|')
                {
                    second = int.Parse(str);
                    str = null;
                    result += $"{first + second} ";
                    continue;
                }
                else if (item == ' ')
                {
                    first = Convert.ToInt32(str);
                    str = null;
                    continue;
                }
                str += item;
            }
            File.WriteAllText("file_two.txt", result);

            ev.Set();
        }

        public static void ThirdMethod(object obj)
        {
            EventWaitHandle ev = obj as EventWaitHandle;

            ev.WaitOne();

            string tmp = File.ReadAllText("file.txt");
            int first = 0;
            int second = 0;

            string str = null;
            string result = null;
            foreach (char item in tmp)
            {
                if (item == '|')
                {
                    second = int.Parse(str);
                    str = null;
                    result += $"{first * second} ";
                    continue;
                }
                else if (item == ' ')
                {
                    first = Convert.ToInt32(str);
                    str = null;
                    continue;
                }
                str += item;
            }
            File.WriteAllText("file_third.txt", result);

            ev.Set();
        }
        static void Main(string[] args)
        {
            ManualResetEvent events = new ManualResetEvent(false);

            ThreadPool.QueueUserWorkItem(FirstMethod, events);
            ThreadPool.QueueUserWorkItem(SecondMethod, events);
            ThreadPool.QueueUserWorkItem(ThirdMethod, events);

            Console.ReadKey();
        }
    }
}
