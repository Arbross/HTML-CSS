using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;

namespace Selles.DB_01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // connection class to database
        private SqlConnection conn = null;
        // data adapter for disconnected mode
        private SqlDataAdapter da = null;
        // DataSet
        private DataSet set = null;
        public MainWindow()
        {
            InitializeComponent();

            // read connection string from config file
            string cs = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            // create sql connection class
            conn = new SqlConnection(cs);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // query for select data
                string sql = "SELECT name FROM sys.objects WHERE type in (N'U')";
                // create data adapter
                da = new SqlDataAdapter(sql, conn);
                // create command builder for auto generate insert, update and delete queries
                new SqlCommandBuilder(da);

                // create empty DataSet
                set = new DataSet();
                // execute select query on server and put data to DataSet
                da.Fill(set, "MyTable");

                // bind table to DataGrid
                dataGrid.ItemsSource = set.Tables["MyTable"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                // query for select data 
                string sql = $"SELECT * FROM {nameof(dataGrid.SelectedItem)}";
                // create data adapter
                da = new SqlDataAdapter(sql, conn);
                // create command builder for auto generate insert, update and delete queries
                new SqlCommandBuilder(da);

                // create empty DataSet
                set = new DataSet();
                // execute select query on server and put data to DataSet
                da.Fill(set, "MyTable");

                // bind table to DataGrid
                dataGrid.ItemsSource = set.Tables["MyTable"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
