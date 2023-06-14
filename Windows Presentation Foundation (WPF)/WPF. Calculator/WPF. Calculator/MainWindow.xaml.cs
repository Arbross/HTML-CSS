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

namespace WPF._Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CalculatorController controller = new(null, null);
        public MainWindow()
        {
            InitializeComponent();
            lblShow.Content = "0";
        }
        private void LabelUpdate()
        {
            if (controller.ChangeState)
            {
                lblShow.Content = $"{controller.First}";
            }
            else
            {
                lblShow.Content = $"{controller.First}{controller.Symbol}{controller.Second}";
            }
            
        }
        private void Count(string number)
        { 
            if (controller.ChangeStatePoint)
            {
                if (controller.ChangeState)
                {
                    controller.First += number;
                    LabelUpdate();
                }
                else if (!controller.ChangeState)
                {
                    controller.Second += number;
                    LabelUpdate();
                }
            }
            else if (controller.ChangeState)
            {
                controller.First += number;
                LabelUpdate();
            }
            else if (!controller.ChangeState)
            {
                controller.Second += number;
                LabelUpdate();
            }
            if (controller.ChangeState)
            {
                if (controller.First[0] == '0')
                {
                    controller.First = controller.First.Remove(0, 1);
                    LabelUpdate();
                }
            }
            else if (!controller.ChangeState)
            {
                if (controller.Second[0] == '0')
                {
                    controller.First = controller.Second.Remove(0, 1);
                    LabelUpdate();
                }
            }
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            Count("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Count("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Count("3");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Count("4");
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Count("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Count("6");
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Count("7");
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Count("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Count("9");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Count("0");
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            controller.Symbol = '+';
            controller.ChangeState = false;
            controller.ChangeStatePoint = false;
            LabelUpdate();
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            controller.Symbol = '-';
            controller.ChangeState = false;
            controller.ChangeStatePoint = false;
            LabelUpdate();
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            controller.Symbol = '*';
            controller.ChangeState = false;
            controller.ChangeStatePoint = false;
            LabelUpdate();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            controller.Symbol = '/';
            lblShow.Content += "/";
            controller.ChangeState = false;
            controller.ChangeStatePoint = false;
            LabelUpdate();
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (controller.ChangeState)
            {
                controller.First = null;
                controller.ChangeStatePoint = false;
                lblShow.Content = "0";
            }
            else
            {
                controller.Second = null;
                controller.ChangeStatePoint = false;
                lblShow.Content = "0";
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            lblShow.Content = "0";
            controller.First = null;
            controller.Second = null;
            controller.ChangeStatePoint = false;
            controller.Symbol = default(char);
            controller.ChangeState = true;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (controller.ChangeState)
            {
                if (controller.First == String.Empty)
                {
                    lblShow.Content = '0';
                    return;
                }
                controller.First = controller.First.Remove(controller.First.Length - 1, 1);
                LabelUpdate();
                if (controller.First == String.Empty)
                {
                    lblShow.Content = '0';
                    return;
                }
            }
            else
            {
                if (controller.First == String.Empty)
                {
                    lblShow.Content = '0';
                    return;
                }
                controller.Second = controller.Second.Remove(controller.Second.Length - 1, 1);
                LabelUpdate();
                if (controller.First == String.Empty)
                {
                    lblShow.Content = '0';
                    return;
                }
            }
        }

        private void Equeal_Click(object sender, RoutedEventArgs e)
        {
            lblShowUp.Content = $"{lblShow.Content}";
            if (controller.Symbol == '+')
            {
                double number = Double.Parse(controller.First, System.Globalization.CultureInfo.InvariantCulture) + Double.Parse(controller.Second, System.Globalization.CultureInfo.InvariantCulture);
                controller.First = Convert.ToString(number);
                lblShow.Content = controller.First;
            }
            if (controller.Symbol == '-')
            {
                double number = Double.Parse(controller.First, System.Globalization.CultureInfo.InvariantCulture) - Double.Parse(controller.Second, System.Globalization.CultureInfo.InvariantCulture);
                controller.First = Convert.ToString(number);
                lblShow.Content = controller.First;
            }
            if (controller.Symbol == '*')
            {
                double number = Double.Parse(controller.First, System.Globalization.CultureInfo.InvariantCulture) * Double.Parse(controller.Second, System.Globalization.CultureInfo.InvariantCulture);
                controller.First = Convert.ToString(number);
                lblShow.Content = controller.First;
            }
            if (controller.Symbol == '/')
            {
                if (controller.First == "0")
                {
                    controller.First = null;
                    controller.Second = null;
                    lblShow.Content = $"Error, you can't to do this.";
                    controller.ChangeState = true;
                    return;
                }
                double number = Double.Parse(controller.First, System.Globalization.CultureInfo.InvariantCulture) / Double.Parse(controller.Second, System.Globalization.CultureInfo.InvariantCulture);
                controller.First = Convert.ToString(number);
                lblShow.Content = controller.First;
            }
            controller.Second = null;
            controller.Symbol = default(char);
            controller.ChangeState = true;
            controller.ChangeStatePoint = false;
            if (controller.First.Contains(','))
            {
                controller.First.Replace(',', '.');
            }
            lblShow.Content = $"{controller.First}";
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            if (controller.ChangeState)
            {
                if (!controller.ChangeStatePoint)
                {
                    controller.ChangeStatePoint = true;
                    controller.First += ".";
                    LabelUpdate();
                }
            }
            else
            {
                if (!controller.ChangeStatePoint)
                {
                    controller.ChangeStatePoint = true;
                    controller.Second += ".";
                    LabelUpdate();
                }
            }
        }
    }
}
