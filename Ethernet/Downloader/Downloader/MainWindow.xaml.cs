using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Downloader
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string SavePath { get; set; } = null;
        private static bool isCanceled { get; set; } = false;
        private static bool isStopped { get; set; } = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    SavePath = dialog.SelectedPath;
                }
            }
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            if (SavePath == null || SavePath == string.Empty)
            {
                System.Windows.MessageBox.Show("Error save path.");
                return;
            }
            else
            {
                DownloadFileAsync(tbUrl.Text);
            }
        }

            WebClient client = new WebClient();
        private async void DownloadFileAsync(string address)
        {
            string fileName = Path.GetFileName(address);

            client.DownloadProgressChanged += Client_DownloadProgressChanged;

            await client.DownloadFileTaskAsync(address, $@"{SavePath}\{fileName}");
            lbOutput.Items.Add($"qwewqe");
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (isCanceled == true)
            {
                return;
            }

            if (isStopped == true)
            {
                
                return;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            isCanceled = true;
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            isStopped = true;
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            isStopped = false;
        }
    }
}
