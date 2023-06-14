using Microsoft.Win32;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Threading;

namespace Files.Read.Count
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Numbers numbers = new Numbers();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDirectoryDialogFind_Click(object sender, RoutedEventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    SelectNeedFiles(dialog);
                    numbers.threads = new System.Threading.Thread[numbers.files.Count];

                    int i = 0;
                    foreach (string path in numbers.files)
                    {
                        numbers.threads[i] = new Thread(numbers.ReadAllInfo);
                        numbers.threads[i].Start(path);
                        ++i;
                    }

                    for (int j = 0; j < numbers.threads.Length; j++)
                    {
                        numbers.threads[j].Join();
                    }
                    ShowAllInfo();
                }
            }
        }

        private void SelectNeedFiles(FolderBrowserDialog dialog)
        {
            foreach (string item in Directory.GetFiles(dialog.SelectedPath).ToList())
            {
                if (item.Contains(".txt"))
                {
                    numbers.files.Add(item);
                }
            }
        }

        private void ShowAllInfo()
        {
            lblShowInfo.Content = $"Words : {Numbers.Words}\nLines : {Numbers.Lines}\nPunctuation : {Numbers.Punctuation}";
        }
    }
}
