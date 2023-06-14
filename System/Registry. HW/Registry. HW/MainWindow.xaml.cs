using Microsoft.Win32;
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

namespace Registry.HW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Languages languages = new Languages();
        public static MainWindow main;
        public DispatcherTimer timer;

        public const string userRoot = @"HKEY_CURRENT_USER\Software\SettingsChanger";
        public const string subkeyOne = "Theme";
        public const string subkeyTwo = "FontValue";
        public const string subkeyThree = "Language";
        public MainWindow()
        {
            InitializeComponent();
            CreateNeedFiles();
            FillComboBoxes();

            main = this;
        }

        private void GetAndSetValues()
        {
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                using (RegistryKey myKey = hklm.OpenSubKey(@"Software\SettingsChanger"))
                {
                    string value = (string)myKey.GetValue(subkeyTwo);

                    if (value != null)
                    {
                        Win.FontSize = double.Parse(value);
                    }
                }
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                using (RegistryKey myKey = hklm.OpenSubKey(@"Software\SettingsChanger"))
                {
                    string value = (string)myKey.GetValue(subkeyThree);

                    if (value != null)
                    {
                        if (int.Parse(value) == 0)
                        {
                            languages.MoveToEn();
                        }
                        else
                        {
                            languages.MoveToUa();
                        }
                    }
                }
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32))
                using (RegistryKey myKey = hklm.OpenSubKey(@"Software\SettingsChanger"))
                {
                    string value = (string)myKey.GetValue(subkeyTwo);

                    if (value != null)
                    {
                        if (int.Parse(value) == 0)
                        {
                            Win.Background = Brushes.Black;
                        }
                        else if (int.Parse(value) == 1)
                        {
                            Win.Background = Brushes.WhiteSmoke;
                        }
                        else if (int.Parse(value) == 2)
                        {
                            Win.Background = Brushes.White;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void FillComboBoxes()
        {
            cbLightDarkStandard.ItemsSource = languages.themes.listEn;
        }

        private void CreateNeedFiles()
        {
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"HKEY_CURRENT_USER\Software\SettingsChanger");

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetAndSetValues();
        }

        private void cbLightDarkStandard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Themes.Dark == Convert.ToString(cbLightDarkStandard.SelectedIndex))
            {
                Win.Background = Brushes.Black;
                Microsoft.Win32.Registry.SetValue(userRoot + "\\" + subkeyOne, cbLightDarkStandard.SelectedItem.ToString(), 0);
            }
            else if (Themes.Light == Convert.ToString(cbLightDarkStandard.SelectedIndex))
            {
                Win.Background = Brushes.WhiteSmoke;
                Microsoft.Win32.Registry.SetValue(userRoot + "\\" + subkeyOne, cbLightDarkStandard.SelectedItem.ToString(), 1);
            }
            else if (Themes.Default == Convert.ToString(cbLightDarkStandard.SelectedIndex))
            {
                Win.Background = Brushes.White;
                Microsoft.Win32.Registry.SetValue(userRoot + "\\" + subkeyOne, cbLightDarkStandard.SelectedItem.ToString(), 2);
            }
        }

        private void btnFontSize_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Win.FontSize = Convert.ToInt32(tbFontSize.Text);
                Microsoft.Win32.Registry.SetValue(userRoot + "\\" + subkeyTwo, "FontSize", Win.FontSize);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter number type.");
                return;
            }
        }

        private void btnEn_Click(object sender, RoutedEventArgs e)
        {
            languages.MoveToEn();
            Microsoft.Win32.Registry.SetValue(userRoot + "\\" + subkeyThree, "Language", 0);
        }

        private void btnUa_Click(object sender, RoutedEventArgs e)
        {
            languages.MoveToUa();
            Microsoft.Win32.Registry.SetValue(userRoot + "\\" + subkeyThree, "Language", 1);
        }
    }
}
