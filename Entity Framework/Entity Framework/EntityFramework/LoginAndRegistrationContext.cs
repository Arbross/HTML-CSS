using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EntityFramework
{
    public class LoginAndRegistrationContext
    {
        private UserLoginDBEntities entities = new UserLoginDBEntities();
        private bool IsLogin = false;
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void Register(string login, string password, string address, string telephone)
        {
            entities.Users.Add(new User() { Login = login, Password = ComputeSha256Hash(password), Adress = address, Telephone = telephone });
        }
        public void Login(string login, string password)
        {
            foreach (User item in entities.Users)
            {
                if (item.Login == login && item.Password == password)
                {
                    IsLogin = true;
                    MainWindow.MyForm.Login.IsEnabled = false;
                    MainWindow.MyForm.Log_out.IsEnabled = true;
                    MessageBox.Show("GDFGDF");
                }
            }
        }
        public void LogOut()
        {
            IsLogin = false;
            MainWindow.MyForm.Login.IsEnabled = true;
            MainWindow.MyForm.Log_out.IsEnabled = false;
        }
    }
}
