using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mutex.Semaphore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow myWindow { get; set; }
        public Info info = new Info();
        public MainWindow()
        {
            InitializeComponent();
            myWindow = this;

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Info.GenerateRandomNumbers);
            }
        }
    }
}
