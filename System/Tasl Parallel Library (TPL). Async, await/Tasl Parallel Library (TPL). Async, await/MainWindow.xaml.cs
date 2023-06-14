using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace Tasl_Parallel_Library__TPL_.Async__await
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TPLModel model = new TPLModel();
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxFillAsync();
        }

        public async void ComboBoxFillAsync()
        {
            cbAuthors.ItemsSource = await model.Authors.ToListAsync();
        }

        public async void ListBoxFillAsync(int id)
        {  
            lbBooks.ItemsSource = await model.Books.Where(x => id == x.AuthorId).ToListAsync();      
        }

        private void cbAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxFillAsync(cbAuthors.SelectedIndex - 1);
        }

        private async void SearchFunc()
        {
            var tmp = await model.Books.Where(x => x.BookName.Contains(tbSearch.Text) == true).ToListAsync();

            string names = null;
            foreach (Book item in tmp)
            {
                names += item.BookName  + ", ";
            }
            MessageBox.Show($"{names}");
        }

        private void btnStartSearch_Click(object sender, RoutedEventArgs e)
        {
            if (tbSearch.Text.Length >= 3)
            {
                SearchFunc();
            }
            else
            {
                MessageBox.Show("It is too little count of symbols to search.");
            }
        }
    }
}
