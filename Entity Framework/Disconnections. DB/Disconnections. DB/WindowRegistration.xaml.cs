using Disconnection._DB;
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
using System.Windows.Shapes;

namespace Disconnections.DB
{
    public partial class WindowRegistration : Window
    {
        private User user = new User("1", "1", "1", "1");
        public WindowRegistration()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user.Login = Login.Text;
            user.Password = User.ComputeMD5Hash(Password.Text);
            user.Address = Address.Text;
            user.Telephone = Telephone.Text;

            MainWindow.MyForm.users.Add(user);
        }
    }
}
