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

namespace Threads.HW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thread thread_one = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void GenerateDefaultNumbers(object obj)
        {
            Numbers numbers = obj as Numbers;

            if (numbers.Second == 0)
            {
                for (int i = numbers.First; ; i++)
                {
                    bool prime = true;
                    for (int j = numbers.First; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            lblOutput.Items.Add(" " + i);
                        }));
                        Thread.Sleep(10);
                    }
                }
            }
            else
            {
                for (int i = numbers.First; i < numbers.Second; i++)
                {
                    bool prime = true;
                    for (int j = numbers.First; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            lblOutput.Items.Add(" " + i);
                        }));
                        Thread.Sleep(10);
                    }
                }
            }
        }

        public static int Fib(int i)
        {
            if (i < 1) return 0;
            if (i == 1) return 1;

            return Fib(i - 1) + Fib(i - 2);
        }

        public void GenerateFibonachiNumbers(object obj)
        {
            Numbers numbers = obj as Numbers;

            if (numbers.Second == 0)
            {
                for (int i = numbers.First; ; i++)
                {
                    int fib = Fib(i);
                    if (fib > numbers.Second)
                    {
                        break;
                    }
                    
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        lblOutputTwo.Items.Add(" " + fib);
                    }));
                    Thread.Sleep(100);
                }
            }
            else
            {
                for (int i = numbers.First; ; i++)
                {
                    int fib = Fib(i);
                    if (fib > numbers.Second)
                    {
                        break;
                    }

                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        lblOutputTwo.Items.Add(" " + fib);
                    }));
                    Thread.Sleep(100);
                }
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            int first;
            if (!int.TryParse(inFirst.Text, out first))
            {
                first = 2;
            }
            else
            {
                first = int.Parse(inFirst.Text);

                if (int.Parse(inFirst.Text) < 2)
                {
                    first = 2;
                }

            }

            int second;
            if (!int.TryParse(inSecond.Text, out second))
            {
                second = 0;
            }
            else
            {
                second = int.Parse(inSecond.Text);

                if (int.Parse(inSecond.Text) < 2)
                {
                    second = 0;
                }
            }

            Numbers numbers = new Numbers(first, second);
            Thread thread = new Thread(GenerateDefaultNumbers);
            thread.IsBackground = true;
            thread.Start(numbers);
        }

        private void Enter_Click_Two(object sender, RoutedEventArgs e)
        {
            int second;
            if (!int.TryParse(inSecondTwo.Text, out second))
            {
                second = 0;
            }
            else
            {
                second = int.Parse(inSecondTwo.Text);

                if (int.Parse(inSecondTwo.Text) < 2)
                {
                    second = 0;
                }
            }

            Numbers numbers = new Numbers(1, second);
            thread_one = new Thread(GenerateFibonachiNumbers);
            thread_one.IsBackground = true;
            thread_one.Start(numbers);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (thread_one == null)
            {
                MessageBox.Show("Thread isn't alive now.");
                return;
            }

            if (thread_one.IsAlive)
            {
                thread_one.Abort();
            }
            else
            {
                MessageBox.Show("Thread isn't alive now.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (thread_one == null)
            {
                MessageBox.Show("Thread isn't alive now.");
                return;
            }

            if (thread_one.IsAlive)
            {
                thread_one.Suspend();
            }
            else
            {
                MessageBox.Show("Thread isn't alive now.");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (thread_one == null)
            {
                MessageBox.Show("Thread isn't alive now.");
                return;
            }

            if (thread_one.IsAlive)
            {
                thread_one.Resume();
            }
            else
            {
                MessageBox.Show("Thread isn't alive now.");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (thread_one == null)
            {
                MessageBox.Show("Thread isn't alive now.");
                return;
            }

            if (thread_one.IsAlive)
            {
                int second;
                if (!int.TryParse(inSecondTwo.Text, out second))
                {
                    second = 0;
                }
                else
                {
                    second = int.Parse(inSecondTwo.Text);

                    if (int.Parse(inSecondTwo.Text) < 2)
                    {
                        second = 0;
                    }
                }

                Numbers numbers = new Numbers(1, second);

                if (thread_one.IsAlive)
                {
                    thread_one.Resume();
                }
                
                thread_one.Abort();
                thread_one = new Thread(GenerateFibonachiNumbers);
                thread_one.IsBackground = true;
                thread_one.Start(numbers);
            }
            else
            {
                MessageBox.Show("Thread isn't alive now.");
            }
        }
    }
}
