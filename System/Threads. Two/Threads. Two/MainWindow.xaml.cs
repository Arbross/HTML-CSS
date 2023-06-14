using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace Threads.Two
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Thread thread_num = new Thread(GenerateNumbers);
        private Thread thread_let = new Thread(GenerateLetters);
        private Thread thread_sym = new Thread(GenerateSymbols);
        public MainWindow()
        {
            InitializeComponent();
            FillPriority(ref PriorityNumber);
            FillPriority(ref PriorityLetters);
            FillPriority(ref PrioritySymbols);
        }

        public void FillPriority(ref ComboBox comboBox)
        {
            Priority priority = new Priority();
            comboBox.ItemsSource = priority.priorities;
        }

        public static void GenerateNumbers(object obj)
        {
            var tmp = (ComboBox)obj;
            Random random = new Random();
            for (int i = 0; ; i++)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    tmp.Items.Add(random.Next(0, 100000));
                }));
                Thread.Sleep(250);
            }
        }

        public static void GenerateLetters(object obj)
        {
            var tmp = (ComboBox)obj;
            Random random = new Random();
            for (int i = 0; ; i++)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    tmp.Items.Add(Convert.ToChar(random.Next(65, 90)));
                }));
                Thread.Sleep(250);
            }
        }

        public static void GenerateSymbols(object obj)
        {
            var tmp = (ComboBox)obj;
            Random random = new Random();
            for (int i = 0; ; i++)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    tmp.Items.Add(Convert.ToChar(random.Next(33, 47)));
                }));
                Thread.Sleep(250);
            }
        }

        private void btnNumbersStart_Click(object sender, RoutedEventArgs e)
        {
            thread_num.Start(Numbers);
        }

        private void btnSymbolsStart_Click(object sender, RoutedEventArgs e)
        {
            thread_sym.Start(Symbols);
        }

        private void btnLettersStart_Click(object sender, RoutedEventArgs e)
        {
            thread_let.Start(Letters);
        }

        private void PriorityNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)PriorityNumber.SelectedItem == "Normal")
            {
                thread_num.Priority = ThreadPriority.Normal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Lowest")
            {
                thread_num.Priority = ThreadPriority.Lowest;
            }
            else if ((string)PriorityNumber.SelectedItem == "Below Normal")
            {
                thread_num.Priority = ThreadPriority.BelowNormal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Above Normal")
            {
                thread_num.Priority = ThreadPriority.AboveNormal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Highest")
            {
                thread_num.Priority = ThreadPriority.Highest;
            }
        }

        private void PriorityLetters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)PriorityNumber.SelectedItem == "Normal")
            {
                thread_let.Priority = ThreadPriority.Normal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Lowest")
            {
                thread_let.Priority = ThreadPriority.Lowest;
            }
            else if ((string)PriorityNumber.SelectedItem == "Below Normal")
            {
                thread_let.Priority = ThreadPriority.BelowNormal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Above Normal")
            {
                thread_let.Priority = ThreadPriority.AboveNormal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Highest")
            {
                thread_let.Priority = ThreadPriority.Highest;
            }
        }

        private void PrioritySymbols_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((string)PriorityNumber.SelectedItem == "Normal")
            {
                thread_sym.Priority = ThreadPriority.Normal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Lowest")
            {
                thread_sym.Priority = ThreadPriority.Lowest;
            }
            else if ((string)PriorityNumber.SelectedItem == "Below Normal")
            {
                thread_sym.Priority = ThreadPriority.BelowNormal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Above Normal")
            {
                thread_sym.Priority = ThreadPriority.AboveNormal;
            }
            else if ((string)PriorityNumber.SelectedItem == "Highest")
            {
                thread_sym.Priority = ThreadPriority.Highest;
            }
        }
    }
}
