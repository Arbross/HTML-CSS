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

namespace EntityFramework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginAndRegistrationContext dataContext = new LoginAndRegistrationContext();
        public static MainWindow MyForm { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            Rent.IsEnabled = false;
            Log_out.IsEnabled = false;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }
    }
}
