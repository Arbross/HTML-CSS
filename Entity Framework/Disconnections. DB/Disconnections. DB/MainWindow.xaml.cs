using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using Disconnections.DB;
using System.Security.Cryptography;
using System.Text;

namespace Disconnection._DB
{
    public class User
    {
        private string login;
        private string password;
        private string address;
        private string telephone;
        public User(string login, string password, string address, string telephone)
        {
            Login = login;
            Password = password;
            Address = address;
            Telephone = telephone;
        }
        public string Login 
        {
            get => login;
            set => login = value;
        }
        public string Password
        {
            get => password;
            set => password = value; 
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public string Telephone
        {
            get => telephone;
            set
            {
                telephone = value;
                //if (value.Length != 10)
                //{
                //    throw new Exception("Password length is too big.");
                //}
                //else
                //{
                //    telephone = '+' + value;
                //}
            }
        }
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
        public static string ComputeMD5Hash(string s)
        {
            // conver to byte array
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //create encrypt obj
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();

            // calc hash-encrypt from bytes
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            // make string from hash
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
    }
    public partial class MainWindow : Window
    {
        private DbProviderFactory fact = null;
        private DbConnection conn = null;
        private DbDataAdapter da = null;
        private DataSet set = null;
        public static MainWindow MyForm { get; private set; } = new MainWindow();
        public List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            // EncryptConnSettings("connectionString");
            MyForm = this;

            string cs = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            fact = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["connStr"].ProviderName);

            conn = fact.CreateConnection();
            conn.ConnectionString = cs;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM UsersDB";

                da = fact.CreateDataAdapter();
                da.SelectCommand = conn.CreateCommand();
                da.SelectCommand.CommandText = sql;

                var builder = fact.CreateCommandBuilder();
                builder.DataAdapter = da;

                set = new DataSet();

                da.Fill(set);

                listBox.ItemsSource = set.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void EncryptConnSettings(string section)
        {
            Configuration objConfig = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetEntryAssembly().Location); //GetAppPath() + "config_encryptions.exe");
            ConnectionStringsSection conSringSection = (ConnectionStringsSection)objConfig.GetSection(section);
            if (!conSringSection.SectionInformation.IsProtected)
            {
                conSringSection.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
                conSringSection.SectionInformation.ForceSave = true;
                objConfig.Save(ConfigurationSaveMode.Modified);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (users != null)
                {
                    foreach (User item in users)
                    {
                        string sql = $"insert into UsersDB (Login, Password, Adress, Telephone, IsAdmin) values ('{item.Login}', '{item.Password}', '{item.Address}', '{item.Telephone}', 0)";

                        da = fact.CreateDataAdapter();
                        da.SelectCommand = conn.CreateCommand();
                        da.SelectCommand.CommandText = sql;

                        var builder = fact.CreateCommandBuilder();
                        builder.DataAdapter = da;

                        set = new DataSet();

                        da.Fill(set);

                        listBox.ItemsSource = set.Tables[0].DefaultView;

                        da.Update(set);
                    }
                }
                else
                {
                    da.Update(set);
                }
                users = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WindowRegistration wr = new WindowRegistration();
            wr.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            set.Tables.RemoveAt(listBox.SelectedIndex);
            Button_Click_1(null, null);
            Button_Click(null, null);
        }
    }
}
