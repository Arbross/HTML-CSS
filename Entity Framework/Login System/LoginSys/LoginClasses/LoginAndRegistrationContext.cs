using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LoginSys
{
    public class LoginAndRegistrationContext
    {
        public UserLoginDBEntities entities { get; private set; } = new UserLoginDBEntities();
        public User user { get; private set; } = new User();
        public bool IsLogin { get; private set; } = false;
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
        private bool Check(string login, string password)
        {
            if (login == null)
            {
                MessageBox.Show("Login is null!");
                return false;
            }
            else if (password == null)
            {
                MessageBox.Show("Password is null!");
                return false;
            }
            if (login == String.Empty)
            {
                MessageBox.Show("Login is empty!");
                return false;

            }
            else if (password == String.Empty)
            {
                MessageBox.Show("Password is empty!");
                return false;
            }
            return true;
        }
        public void Register(string login, string password, string address, string telephone)
        {
            if (Check(login, password) == false)
            {
                return;
            }

            foreach (User item in entities.Users)
            {
                if (item.Login == login)
                {
                    MessageBox.Show("Name already exists.");
                    return;
                }
            }
            entities.Users.Add(new User() { Login = login, Password = ComputeSha256Hash(password), Adress = address, Telephone = telephone });
            entities.SaveChanges();
        }
        public void Login(string login, string password)
        {
            if (IsLogin == false)
            {
                if (Check(login, password) == false)
                {
                    return;
                }

                foreach (User item in entities.Users)
                {
                    if (item.Login == login && item.Password == password)
                    {
                        IsLogin = true;
                        MessageBox.Show("Successful login!");
                        user = item;
                        return;
                    }
                }
                MessageBox.Show("It is no user like this.\nPlease check your login or password.");
            }
            else
            {
                MessageBox.Show("You have already logged in.");
            }
        }
        public void LogOut()
        {
            if (IsLogin == true)
            {
                IsLogin = false;
                MessageBox.Show("Successful log out!");
            }
            else
            {
                MessageBox.Show("You have already logged in.");
            }
        }
    }
}
