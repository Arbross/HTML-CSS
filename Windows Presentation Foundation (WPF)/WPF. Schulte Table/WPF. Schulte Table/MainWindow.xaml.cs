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
using System.Windows.Threading;

namespace WPF._Schulte_Table
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Count count = new Count();
        private int counter;
        private string last_number;
        private void UnEnable()
        {
            one.IsEnabled = false;
            two.IsEnabled = false;
            three.IsEnabled = false;
            four.IsEnabled = false;
            five.IsEnabled = false;
            six.IsEnabled = false;
            seven.IsEnabled = false;
            eight.IsEnabled = false;
            nine.IsEnabled = false;
            ten.IsEnabled = false;
            eleven.IsEnabled = false;
            twelve.IsEnabled = false;
            thirdteen.IsEnabled = false;
            fourteen.IsEnabled = false;
            fiveteen.IsEnabled = false;
            sixteen.IsEnabled = false;
        }
        public MainWindow()
        {
            InitializeComponent();
            UnEnable();
        }
        private void CountClick(string content, Control control)
        {
            if (count.GetNumbers(last_number, content) == 0)
            {
                control.Background = Brushes.Green;
                last_number = content;
                counter++;
            }
            else
            {
                control.Background = Brushes.Red;
                last_number = null;
                MessageBox.Show($"You lose. {counter} points.");
                counter = 0;
                foreach (Button item in Nums.Children)
                {
                    item.Background = Brushes.Transparent;
                }
                UnEnable();
                Progress.Value = 0;
                Hard.IsEnabled = true;
                Start.IsEnabled = true;
                timer.Stop();
            }
        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(one.Content), one);
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(two.Content), two);
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(three.Content), three);
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(four.Content), four);
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(eight.Content), eight);
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(five.Content), five);
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(six.Content), six);
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(seven.Content), seven);
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(nine.Content), nine);
        }

        private void ten_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(ten.Content), ten);
        }

        private void eleven_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(eleven.Content), eleven);
        }

        private void twelve_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(twelve.Content), twelve);
        }

        private void thirdteen_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(thirdteen.Content), thirdteen);
        }

        private void fourteen_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(fourteen.Content), fourteen);
        }

        private void fiveteen_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(fiveteen.Content), fiveteen);
        }

        private void sixteen_Click(object sender, RoutedEventArgs e)
        {
            CountClick(Convert.ToString(sixteen.Content), sixteen);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            one.IsEnabled = true;
            two.IsEnabled = true;
            three.IsEnabled = true;
            four.IsEnabled = true;
            five.IsEnabled = true;
            six.IsEnabled = true;
            seven.IsEnabled = true;
            eight.IsEnabled = true;
            nine.IsEnabled = true;
            ten.IsEnabled = true;
            eleven.IsEnabled = true;
            twelve.IsEnabled = true;
            thirdteen.IsEnabled = true;
            fourteen.IsEnabled = true;
            fiveteen.IsEnabled = true;
            sixteen.IsEnabled = true;
            Hard.IsEnabled = false;
            Start.IsEnabled = false;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
            Progress.Maximum = (int)Hard.Value;
            if ((int)Hard.Value == 0)
            {
                timer.Stop();
                timer.Interval = TimeSpan.FromSeconds(0);
                UnEnable();
                Hard.IsEnabled = true;
                Start.IsEnabled = true;
                nCounter.Content = 0;
                MessageBox.Show("Times is equeal zero.");
            }

            int[] arr = Count.FillRand();
            int i = 0;
            foreach (Button item in Nums.Children)
            {
                item.Content = arr[i];
                ++i;
            }
        }
        private DispatcherTimer timer = new DispatcherTimer();
        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter == 16)
            {
                MessageBox.Show($"You won! {counter}/16 points");
                timer.Interval = TimeSpan.FromSeconds(1);
                last_number = null;
                foreach (Button item in Nums.Children)
                {
                    item.Background = Brushes.Transparent;
                }
                UnEnable();
                Progress.Value = 0;
                Hard.IsEnabled = true;
                Start.IsEnabled = true;
                counter = 0;
                timer.Stop();
            }
            if (timer.Interval == TimeSpan.FromSeconds((int)Hard.Value))
            {
                MessageBox.Show($"{counter}/16 points");
                timer.Interval = TimeSpan.FromSeconds(1);
                last_number = null;
                foreach (Button item in Nums.Children)
                {
                    item.Background = Brushes.Transparent;
                }
                UnEnable();
                counter = 0;
                Progress.Value = 0;
                Hard.IsEnabled = true;
                Start.IsEnabled = true;
                timer.Stop();
            }
            Time.Content = $"{timer.Interval} sec";
            timer.Interval += TimeSpan.FromSeconds(1);
            Progress.Value += 1;
        }

        private void Hard_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            nCounter.Content = (int)Hard.Value;
        }
    }
}
