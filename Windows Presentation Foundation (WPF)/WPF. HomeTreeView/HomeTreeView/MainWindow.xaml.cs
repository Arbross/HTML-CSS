using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HomeTreeView
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DiskName.ItemsSource = DriveInfo.GetDrives();
        }

        private void DirectoriesViewAdd(DirectoryInfo directoryInfo)
        {
            if (directoryInfo == null)
                return;

            DirectoriesView.Items.Clear();

            foreach (DirectoryInfo directory in directoryInfo.GetDirectories())
            {
                DirectoriesView.Items.Add(directory);
            }
        }

        private void FilesViewAdd(DirectoryInfo directoryInfo)
        {
            if (directoryInfo == null)
                return;

            FilesView.Items.Clear();

            foreach (FileInfo file in directoryInfo.GetFiles())
                FilesView.Items.Add(file);
        }

        private void DiskName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string path = DiskName.SelectedItem.ToString();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            DirectoriesViewAdd(directoryInfo);
            FilesViewAdd(directoryInfo);

            if (btnBack.Visibility == Visibility.Hidden)
                btnBack.Visibility = Visibility.Visible;
        }

        private void DirectoriesView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            DirectoryInfo directoryInfo = e.NewValue as DirectoryInfo;
            DirectoriesViewAdd(directoryInfo);
            FilesViewAdd(directoryInfo);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            string path = DiskName.SelectedValue.ToString();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            DirectoriesViewAdd(directoryInfo);
            FilesViewAdd(directoryInfo);
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Back)
            {
                btnBack_Click(null, null);
            }

            if (e.Key == System.Windows.Input.Key.Delete)
            {
                if (FilesView.SelectedItem != null)
                {
                    MessageBoxResult msg = System.Windows.MessageBox.Show("Do you want to delete it?", "Deleting", MessageBoxButton.YesNo);
                    
                    if (msg == MessageBoxResult.Yes)
                    {
                        FileInfo directoryInfo = (FileInfo)FilesView.SelectedItem;
                        File.Delete(directoryInfo.FullName);
                        FilesView.Items.Remove(directoryInfo);
                    }
                }

                if (DirectoriesView.SelectedItem != null)
                {
                    MessageBoxResult msg = System.Windows.MessageBox.Show("Do you want to delete it?", "Deleting", MessageBoxButton.YesNo);

                    if (msg == MessageBoxResult.Yes)
                    {
                        DirectoryInfo directoryInfo = (DirectoryInfo)FilesView.SelectedItem;
                        Directory.Delete(directoryInfo.FullName);
                        DirectoriesView.Items.Remove(directoryInfo);
                    }
                }
            }
        }
    }
}
