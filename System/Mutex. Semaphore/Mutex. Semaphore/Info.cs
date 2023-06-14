using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Mutex.Semaphore
{
    public class Info
    {
        public static System.Threading.Semaphore s = new System.Threading.Semaphore(3, 10);
        public static void GenerateRandomNumbers(object obj)
        {
            s.WaitOne();
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    MainWindow.myWindow.ShowInfo.Items.Add($"{random.Next(1, 1000)}, Index : ");
                }));
            }
            s.Release();
        }
    }
}
