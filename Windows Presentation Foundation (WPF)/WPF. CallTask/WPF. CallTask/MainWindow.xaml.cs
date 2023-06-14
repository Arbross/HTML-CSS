using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPF._CallTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            accept.IsEnabled = false;
            calendar.DisplayDateStart = DateTime.Now;
        }
        private int count = 1;
        public int Count
        {
            get => count;
            set {
                if (value != 13)
                {
                    count++;
                }
            }
        }
        public void CountPlus()
        {
            people.Content = $"{Count++}";
        }
        private void decline_Click(object sender, RoutedEventArgs e)
        {
            name.Clear();
            surname.Clear();
            info.Clear();
            count = 0;
            people.Content = $"{Count}";
            calendar.SelectedDate = DateTime.Now;
            number.IsChecked = false;
            rules.IsChecked = false;
        }

        private void people_Click(object sender, RoutedEventArgs e)
        {
            CountPlus();
        }

        private void accept_Click(object sender, RoutedEventArgs e)
        {
            if (rules.IsChecked == true)
            {
                MessageBox.Show("--------Result-------\n" +
                    $"Name : {name.Text}\n" +
                    $"Surname : {surname.Text}\n" +
                    $"Info : {info.Text}\n" +
                    $"People : {people.Content}\n" +
                    $"Type : {number.IsChecked}\n" +
                    $"Calendar : from {calendar.SelectedDates[0]} to {calendar.SelectedDates[calendar.SelectedDates.Count - 1]}\n");
            }
            else
            {
                MessageBox.Show("Rules isn't equeal true.");
            }
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (calendar.SelectedDates[0] > calendar.SelectedDates[calendar.SelectedDates.Count - 1])
            {
                MessageBox.Show("Can't plan on a yesterday days.");
            }
        }
        private void rules_Click(object sender, RoutedEventArgs e)
        {
            if (rules.IsChecked == true)
            {
                accept.IsEnabled = true;
            }
            else
            {
                accept.IsEnabled = false;
            }
        }
    }
}
