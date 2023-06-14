using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

namespace Show
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (string item in Directory.GetFiles(@"C:\Users\victor\source\repos\MakeScreen. CW\Server\bin\Debug\"))
            {
                if (item.Contains(".png") || item.Contains(".jpg"))
                {
                    lbImages.Items.Add(item);
                }
            }
        }

        private void lbImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Process.Start(lbImages.SelectedItem.ToString());
        }
    }
}
