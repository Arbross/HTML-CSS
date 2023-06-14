using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.IO;

namespace DirectoryViewer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static void Method(ref System.Windows.Controls.Label lblShowInfo)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    foreach (string path in Directory.GetFiles(dialog.SelectedPath))
                    {
                        string tmp = Path.GetFileName(path);
                        string name = Path.ChangeExtension(tmp, null);
                        int count = 0;

                        foreach (string secondPath in Directory.GetFiles(dialog.SelectedPath))
                        {
                            string secondTmp = Path.GetFileName(secondPath);
                            string secondName = Path.ChangeExtension(secondTmp, null);

                            if (name == secondName && path != secondPath)
                            {
                                count++;
                            }
                        }

                        if (count != 0)
                        {
                            lblShowInfo.Content += $"\n{name} - {count}";
                        }
                    }

                    foreach (string dir in Directory.GetDirectories(dialog.SelectedPath))
                    {
                        foreach (string path in Directory.GetFiles(dir))
                        {
                            string tmp = Path.GetFileName(path);
                            string name = Path.ChangeExtension(tmp, null);
                            int count = 0;

                            foreach (string secondPath in Directory.GetFiles(dialog.SelectedPath))
                            {
                                string secondTmp = Path.GetFileName(secondPath);
                                string secondName = Path.ChangeExtension(secondTmp, null);

                                if (name == secondName && path != secondPath)
                                {
                                    count++;
                                }
                            }

                            if (count != 0)
                            {
                                lblShowInfo.Content += $"\n{name} - {count}";
                            }
                        }
                    }
                }
            }
        }

        private void btnDirectorySelect_Click(object sender, RoutedEventArgs e)
        {
            Task task = Task.Factory.StartNew(() => Method(ref lblShowInfo), CancellationToken.None, TaskCreationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
