using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Processes.Task_Manager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TypeUpdate update = new TypeUpdate();
        private List<Process> processes = Process.GetProcesses().ToList();
        private DispatcherTimer timer = null;
        private bool IsStopped = false;
        public MainWindow()
        {
            InitializeComponent();
            ComboBoxFill(update);
            DataGridFill(processes);
            TimerCreating(timer);
        }

        public void ComboBoxFill(TypeUpdate update)
        {
            TypeListUpdate.ItemsSource = this.update.updateList;
        }

        private void TimerCreating(DispatcherTimer timer)
        {
            this.timer = new DispatcherTimer();
            this.timer.Interval = new TimeSpan(0, 0, 1);
            this.timer.Tick += timer_Tick;
            this.timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            processes = Process.GetProcesses().ToList();
            DataGridFill(processes);
        }

        public void DataGridFill(List<Process> processes)
        {
            ContextTM.ItemsSource = this.processes;
        }

        private void TypeListUpdate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsStopped == true)
            {
                IsStopped = false;
                return;
            }

            if (timer.IsEnabled == false)
            {
                timer.Start();
            }

            timer.Interval = new TimeSpan(0, 0, int.Parse(TypeListUpdate.SelectedItem.ToString()));
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled == true)
            {
                timer.Stop();
                IsStopped = true;
                TypeListUpdate.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Timer already stopped.");
            }
        }

        private void btnKill_Click(object sender, RoutedEventArgs e)
        {
            if (ContextTM.SelectedItem != null)
            {
                (ContextTM.SelectedItem as Process).Kill();
                MessageBox.Show("Process successfully killed.");
            }
            else
            {
                MessageBox.Show("Please select process.");
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            if (ContextTM.SelectedItem != null)
            {
                Process current = ContextTM.SelectedItem as Process;

                MessageBox.Show($"----------- Current proccess info ------------\nPriority class: {current.PriorityClass}\nName: {current.ProcessName}\nId: {current.Id}\nMachineName: {current.MachineName}\nPrivateMemorySize (KB): {current.PrivateMemorySize64 / 1024}\nStartTime: {current.StartTime}\nTotalProcessorTime: {current.TotalProcessorTime}\nUserProcessorTime: {current.UserProcessorTime}");
            }
            else
            {
                MessageBox.Show("Please select process.");
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo
                {
                    FileName = GetPath.Text,
                    Arguments = "-n",
                    WindowStyle = ProcessWindowStyle.Maximized,
                };

                Process process = Process.Start(info);
                process.WaitForExit();
            }
            catch (Exception)
            {
                MessageBox.Show("Enter normal path.");
            }
        }
    }
}
